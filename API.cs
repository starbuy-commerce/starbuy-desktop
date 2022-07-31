using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Text.Json;
using System.Net.Http;
using System.IO;

namespace Starbuy_Desktop
{
    internal class API
    {

        private static String heroku_host = "https://starbuy-api.herokuapp.com";
        private static String railways_host = "https://starbuy.up.railway.app";
        private static String host = heroku_host;

        // Vai verificar se a host da Heroku ta de boa. Se ela, por algum motivo,
        // tiver caido, vai usar a host do Railways (uma outra plataforma que eu
        // também hospedei a nossa API que serve de backup).
        public static void checkHostIntegrity()
        {
            var req = (HttpWebRequest)WebRequest.Create(heroku_host);
            appendHeaders("GET", req);
            var httpResponse = (HttpWebResponse)req.GetResponse();
            if (httpResponse.StatusCode == HttpStatusCode.ServiceUnavailable)
            {
                host = railways_host;
            }
        }

        // Já que toda request vai ter o header ContentType e um método, eu
        // criei essa função só pra ter que escrever menos coisa.
        private static void appendHeaders(String method, HttpWebRequest request)
        {
            request.ContentType = "application/json";
            request.Method = method;
        }

        public static Usuario login(String username, String password)
        {
            var req = (HttpWebRequest)WebRequest.Create(host + "/login");
            appendHeaders("POST", req);

            using (var streamWriter = new StreamWriter(req.GetRequestStream()))
            {
                streamWriter.Write("{\"username\":\"" + username + "\"," +
                              "\"password\":\"" + password + "\"}");
            }

            try
            {
                 var httpResponse = (HttpWebResponse)req.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    try
                    {
                        LoginResponse response = JsonSerializer.Deserialize<LoginResponse>(result);
                        Session.setSession(new Session(response.user, response.jwt));
                        return response.user;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return null;
                    }
                }
            }
            catch (WebException e)
            {

                var errorResponse = (HttpWebResponse)e.Response;
                if(errorResponse.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new AuthException("Verifique sua senha!");
                }
                if (errorResponse.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new AuthException("Verifique suas credenciais.");
                }
                return null;
            } 
        }
        public static UsuarioComProdutoRequest getProducts(String username)
        {
            var req = (HttpWebRequest)WebRequest.Create(host + "/user/" + username + "?includeItems=true");
            appendHeaders("GET", req);

            try
            {
                var httpResponse = (HttpWebResponse)req.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    try
                    {
                        UsuarioComProdutoRequest resposta = JsonSerializer.Deserialize<UsuarioComProdutoRequest>(result);
                        MessageBox.Show(resposta.items.Length.ToString());
                        ItemsResponse.setItemsResponse(new ItemsResponse(resposta.user, resposta.rating, resposta.items));
                        return resposta;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        return null;
                    }
                }
            }
            catch(Exception teste)
            {
                MessageBox.Show(teste.ToString());
                return null;
            }
        }

        public static Address[] getAddress (String jwt)
        {
            var req = (HttpWebRequest)WebRequest.Create(host + "/user/address");
            appendHeaders("GET", req);
            req.Headers.Add("Authorization", "Bearer " + jwt);

            try
            {
                var httpsResponse = (HttpWebResponse)req.GetResponse();
                using (var streamReader = new StreamReader(httpsResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    try
                    {
                        Address[] enderecos = JsonSerializer.Deserialize<Address[]>(result);
                        //*MessageBox.Show(enderecos.addresses.Length.ToString());
                        MessageBox.Show(enderecos[0].cep.ToString());
                        MultiplosEnderecosResponse.setMultiplosEnderecosResponse(new MultiplosEnderecosResponse(enderecos));
                        return enderecos;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
    }
}
