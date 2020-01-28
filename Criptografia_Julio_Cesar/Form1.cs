﻿using System;
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
using Newtonsoft.Json;

namespace Criptografia_Julio_Cesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnDescriptografar.Enabled = false;
        }
        Client baseDados;
        string json = "";

        private void btnReceberDados_Click(object sender, EventArgs e)
        {
            json = "";
            ReceberAPI();
            btnDescriptografar.Enabled = true;
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
            baseDados = JsonConvert.DeserializeObject<Client>(objeto.ToString());
            Exibir();
        }

        public void Descriptografar()
        {
            string frase = "";
            //a=97
            //z=122
            foreach (char letra in baseDados.Cifrado)
            {
                //letra está considerando o caracter em ASCII para a comparação com inteiro
                if (letra >= 97 && letra <= 122)
                {
                    int aux = letra - baseDados.Numero_Casas;
                    if (aux < 97)
                    {
                        frase += Convert.ToChar(122 + (aux - 96));
                    }
                    else
                        frase += Convert.ToChar(aux);
                }
                else
                {
                    frase += Convert.ToChar(letra);
                }
            }

            btnDescriptografar.Enabled = false;
            txtDados.Clear();
            txtDados.Text = frase;
            baseDados.Decifrado = frase;
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            json = "";
            Descriptografar();
        }

        private void btnVerJson_Click(object sender, EventArgs e)
        {
            try
            {
                CriarJson();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Exibir();
        }

        public void CriarJson()
        {
            json = "";
            json = JsonConvert.SerializeObject(baseDados);
        }

        public void Exibir()
        {
            txtDados.Text = "Numero_Casas - " + baseDados.Numero_Casas + Environment.NewLine + Environment.NewLine +
            "Cifrado - " + baseDados.Cifrado + Environment.NewLine + Environment.NewLine +
            "Decifrado - " + baseDados.Decifrado + Environment.NewLine + Environment.NewLine +
            "Token - " + baseDados.Token + Environment.NewLine + Environment.NewLine +
            "Resumo Criptografico - " + baseDados.ResumoCriptografico;

            if (json!="")
            {
                txtDados.Text+= Environment.NewLine +
            Environment.NewLine + "JSON - " + json;
            }
        }
    }
}
