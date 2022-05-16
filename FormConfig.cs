using System;
using System.Net; 
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace Starbuy_Desktop
{
    
public partial class FormConfig : Form
    {
        
        public FormConfig(String user)
        {
            InitializeComponent();
            var requisicaoWeb = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + user);
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWebDemo";
            using (var resposta = requisicaoWeb.GetResponse())
            {
                string fileName = "WeatherForecast.json";
                string jsonString = File.ReadAllText(fileName);
                Usuario classUsername = JsonSerializer.Deserialize<Usuario>(jsonString)!;
                labelConfigCantoNome.Text = classUsername.name;
                labelConfigNome.Text = classUsername.name;
            }
        }

    }
}
