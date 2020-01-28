using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia_Julio_Cesar
{
    class Client
    {
        private string numeroDeCasas;
        private string token;
        private string cifrado;
        private string decifrado;
        private string resumoCriptografico;
        private int numero;
        public string NumeroDeCasas
        {
            get
            {
                Numero = Convert.ToInt32(numeroDeCasas.Substring(numeroDeCasas.IndexOf(':')+1));
                return numeroDeCasas;
            }

            set
            {
                numeroDeCasas = value;
            }
        }

        public string Token
        {
            get
            {
                return token;
            }

            set
            {
                token = value;
            }
        }

        public string Cifrado
        {
            get
            {
                return cifrado;
            }

            set
            {
                cifrado = value;
            }
        }

        public string Decifrado
        {
            get
            {
                return decifrado;
            }

            set
            {
                decifrado = value;
            }
        }

        public string ResumoCriptografico
        {
            get
            {
                return resumoCriptografico;
            }

            set
            {
                resumoCriptografico = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public Client(string casas, string token,string cifrado,string decifrado,string resumo)
        {
            NumeroDeCasas = casas;
            Token = token;
            Cifrado = cifrado;
            Decifrado = decifrado;
            ResumoCriptografico = resumo;
        }
    }
}
