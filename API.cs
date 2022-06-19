using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Text.Json;
using System.Net.Http;
using System.IO;

namespace Starbuy_Desktop {
    internal class API {

        private static String heroku_host = "https://tcc-web-api.herokuapp.com";
        private static String railways_host = "https://starbuy.up.railway.app";
        private static String host = heroku_host;

        // Vai verificar se a host da Heroku ta de boa. Se ela, por algum motivo,
        // tiver caido, vai usar a host do Railways (uma outra plataforma que eu
        // também hospedei a nossa API que serve de backup).
        public static void checkHostIntegrity() {
            var req = (HttpWebRequest)WebRequest.Create(heroku_host);
            appendHeaders("GET", req);
            var httpResponse = (HttpWebResponse)req.GetResponse();
            if(httpResponse.StatusCode == HttpStatusCode.ServiceUnavailable) {
                host = railways_host;
            }
        }

        // Já que toda request vai ter o header ContentType e um método, eu
        // criei essa função só pra ter que escrever menos coisa.
        private static void appendHeaders(String method, HttpWebRequest request) {
            request.ContentType = "application/json";
            request.Method = method;
        }

        public static Usuario login(String username, String password) {
            var req = (HttpWebRequest)WebRequest.Create(host + "/login");
            appendHeaders("POST", req);

            using (var streamWriter = new StreamWriter(req.GetRequestStream())) {
                streamWriter.Write("{\"username\":\"" + username + "\"," +
                              "\"password\":\"" + password + "\"}");
            }

            var httpResponse = (HttpWebResponse)req.GetResponse();

            if(httpResponse.StatusCode == HttpStatusCode.Unauthorized) {
                throw new AuthException("Verifique suas credenciais.");
            }

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) {
                var result = streamReader.ReadToEnd();

                try {
                    LoginResponse response = JsonSerializer.Deserialize<LoginResponse>(result);
                    Session.setSession(new Session(response.user, response.jwt));
                    return response.user;
                } catch (Exception ex) {
                    return null;
                }
            }
        }
    }
}
