using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia_Julio_Cesar
{
    class Client
    {
        private int numero_Casas;
        private string token;
        private string cifrado;
        private string decifrado;
        private string resumoCriptografico;
        public int Numero_Casas
        {
            get
            {
                return numero_Casas;
            }

            set
            {
                numero_Casas = value;
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

        public Client(int numero_casas, string token,string cifrado,string decifrado,string resumo)
        {
            Numero_Casas = numero_casas;
            Token = token;
            Cifrado = cifrado;
            Decifrado = decifrado;
            ResumoCriptografico = resumo;
        }
    }
}
