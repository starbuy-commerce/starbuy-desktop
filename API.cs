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
using System.Globalization;

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
                var httpResponse = (HttpWebResponse)req.GetResponse(); // Lança WebException

                using var streamReader = new StreamReader(httpResponse.GetResponseStream());
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
            catch (WebException e)
            {
                var errorResponse = (HttpWebResponse)e.Response;

                switch (errorResponse.StatusCode)
                {
                    case HttpStatusCode.Unauthorized:
                        throw new AuthException("Verifique sua senha!");

                    case HttpStatusCode.NotFound:
                        throw new AuthException("Usuário não encontrado:  Verifique suas credenciais.");

                    case HttpStatusCode.BadGateway:
                        throw new AuthException("Bad Gateway");

                    // case HttpStatusCode.

                    default:
                        throw new AuthException("Resposta não tratada" + errorResponse.StatusDescription);
                }
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
                        if (resposta.items != null)
                        {
                            MessageBox.Show(resposta.items.Length.ToString());
                            ItemsResponse.setItemsResponse(new ItemsResponse(resposta.user, resposta.rating, resposta.items));
                            return resposta;
                        }
                        else
                        {
                            MessageBox.Show("teste!");
                            ItemsResponse.setItemsResponse(new ItemsResponse(null, 0, null));
                            return null;
                        }
                    }
                    catch (NullReferenceException e)
                    {
                        MessageBox.Show(e.ToString());
                        return null;
                    }
                }
            }
            catch (Exception teste)
            {
                MessageBox.Show(teste.ToString());
                return null;
            }
        }

        public static List<Address> getAddress(String jwt)
        {
            var req = (HttpWebRequest)WebRequest.Create(host + "/user/address");
            appendHeaders("GET", req);
            req.Headers.Add("Authorization", "Bearer " + jwt);
            try
            {
                var httpsResponse = (HttpWebResponse)req.GetResponse();
                using (var streamReader = new StreamReader(httpsResponse.GetResponseStream()))
                {
                    if (streamReader != null)
                    {
                        var result = streamReader.ReadToEnd();
                        try
                        {
                            List<Address> enderecos = JsonSerializer.Deserialize<List<Address>>(result);
                            if (enderecos != null)
                            {
                                MultiplosEnderecosResponse.setMultiplosEnderecosResponse(new MultiplosEnderecosResponse(enderecos));
                                return enderecos;
                            }
                            else
                            {
                                MultiplosEnderecosResponse.setMultiplosEnderecosResponse(null);
                                return null;
                            }
                        }
                        catch (System.NullReferenceException e)
                        {
                            MessageBox.Show("Não existe endereço! " + e.ToString());
                            return null;
                        }
                    }
                    else
                    {
                        MultiplosEnderecosResponse.setMultiplosEnderecosResponse(null);
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

        public static void cadastrar(RequestCadastro reqCad)
        {
            var req = (HttpWebRequest)WebRequest.Create(host + "/register");
            appendHeaders("POST", req);
            using (var streamWriter = new StreamWriter(req.GetRequestStream()))
            {
                streamWriter.Write("{\"username\":\"" + reqCad.username + "\"," +
                                "\"name\":\" " + reqCad.name + "\"," +
                                "\"email\":\" " + reqCad.email + "\"," +
                                "\"city\":\" " + reqCad.city + "\"," +
                                "\"birthdate\":\" " + reqCad.birthdate + "\"," +
                                "\"seller\":\"" + "true" + "\"," +
                                "\"profile_picture\":\""  + "\"," +
                               "\"password\":\"" + reqCad.password + "\"}");
            }
            try
            {
                var httpResponse = (HttpWebResponse)req.GetResponse(); // Lança WebException
                using var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();
                try
                {//change after
                    ResponseCadastroProduto response = JsonSerializer.Deserialize<ResponseCadastroProduto>(result);
                    ResponseCadastroProduto.setResponseCadastroProduto(response);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            catch (WebException cadastroException) {
                MessageBox.Show(cadastroException.Message.ToString());
            }
        }
        public static void cadastrarNovoProduto(String jwt, Item item,  String image)
        {
            var req = (HttpWebRequest)WebRequest.Create("https://starbuy.up.railway.app/item");
            appendHeaders("POST", req);
            var autorizacao = "Bearer " + jwt;
            req.ContentType = "application/json; charset=UTF-8";
            req.Headers.Add("Authorization", autorizacao);

            using (var streamWriter = new StreamWriter(req.GetRequestStream()))
            {
                string sla = "{\"item\":{" +
                                        "\"identifier\":\" " + "\"," +
                                        "\"title\": \"" + item.title + "\"," +
                                        "\"seller\": \"" + "\"," +
                                        "\"price\": " + item.price + "," +
                                        "\"stock\": " + item.stock + "," +
                                        "\"category\": " + item.category + "," +
                                        "\"description\": \"" + item.description + "\"}," +
                                   "\"assets\": [\"" + "data:image/jpeg;base64," + image + "\"]}";
                MessageBox.Show(sla);
                System.Windows.Forms.Clipboard.SetText(sla);
                streamWriter.Write("{\"item\":{" +
                                        "\"identifier\":\" " + "\"," +
                                        "\"title\": \"" + item.title + "\"," +
                                        "\"seller\": \"" + "\"," +
                                        "\"price\": " + item.price + "," +
                                        "\"stock\": " + item.stock + "," +
                                        "\"category\": " + item.category + "," +
                                        "\"description\": \"" + item.description + "\"}," +
                                   "\"assets\": [\"" + "data:image/jpeg;base64," + image + "\"]}");
            }
            try
            {
                    var httpResponse = (HttpWebResponse)req.GetResponse(); // Lança WebException
                    using var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    var result = streamReader.ReadToEnd();
                    try
                    {
                        ResponseCadastroProduto response = JsonSerializer.Deserialize<ResponseCadastroProduto>(result);
                        ResponseCadastroProduto.setResponseCadastroProduto(response);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                catch (WebException cadastroException)
                {
                    MessageBox.Show(cadastroException.Message.ToString());
                }
        }

        public static void getPedidos(String jwt)
        {
            var req = (HttpWebRequest)WebRequest.Create(host + "/received_orders");
            appendHeaders("GET", req);
            req.Headers.Add("Authorization", "Bearer " + jwt);
            try
            {
                var httpResponse = (HttpWebResponse)req.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    try
                    {
                        List<Order> resposta = JsonSerializer.Deserialize<List<Order>>(result);
                        if (resposta != null)
                        {
                            OrdersResponse.setOrdersResponse(new OrdersResponse(resposta));
                        }
                        else
                        {
                            OrdersResponse.setOrdersResponse(new OrdersResponse(null));
                        }
                    }
                    catch (NullReferenceException e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            catch (Exception teste)
            {
                MessageBox.Show(teste.ToString());
            }
        }

        public static void adicionarEndereco(String jwt, Endereco endereco)
        {
            var req = (HttpWebRequest)WebRequest.Create(host + "/user/address");
            appendHeaders("POST", req);
            req.Headers.Add("Authorization", "Bearer " + jwt);
            using (var streamWriter = new StreamWriter(req.GetRequestStream()))
            {
                streamWriter.Write("{\"name\":\" "+ endereco.name + "\"," +
                                     "\"cep\": \"" + endereco.cep + "\"," +
                                     "\"number\": \"" + endereco.number + "\"," +
                                     "\"complement\": " + endereco.complement + "," +
                                        "}");
            }
            try
            {
                var httpResponse = (HttpWebResponse)req.GetResponse(); 
                using var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();
                try
                {
                    EnderecoResponse resposta = JsonSerializer.Deserialize<EnderecoResponse>(result);
                    MessageBox.Show(resposta.message);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            catch (WebException cadastroException)
            {
                MessageBox.Show(cadastroException.Message.ToString());
            }
        }
    }
}
