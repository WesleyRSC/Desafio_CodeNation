using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia_Julio_Cesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Client baseDados;

        private void btnReceberDados_Click(object sender, EventArgs e)
        {
            ReceberAPI();

        }

        public void ReceberAPI()
        {
            //https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token=6eb77403e8fac5ad7c4e54b97c8fbaa456efc0e1
            var requisicaoWeb = WebRequest.CreateHttp("https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token=6eb77403e8fac5ad7c4e54b97c8fbaa456efc0e1");
            requisicaoWeb.Method = "GET";
            using (var resposta = requisicaoWeb.GetResponse())
            {
                var recebeDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(recebeDados);
                object objeto = reader.ReadToEnd();
                Console.WriteLine(objeto.ToString());
                reader.Close();
                resposta.Close();
                SepararCampos(objeto);
            }
        }
        public void SepararCampos(object objeto)
        {

            string[] dados = objeto.ToString().Split(',');
            baseDados = new Client(dados[0],dados[1],dados[2],dados[3],dados[4]);
            txtDados.Text = baseDados.NumeroDeCasas + Environment.NewLine +
                baseDados.Token + Environment.NewLine +
                baseDados.Cifrado + Environment.NewLine +
                baseDados.Decifrado + Environment.NewLine +
                baseDados.ResumoCriptografico + Environment.NewLine;
        }

        public void Descriptografar()
        {

        }
    }
}
