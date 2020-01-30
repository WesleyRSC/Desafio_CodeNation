using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia_Julio_Cesar
{
    class Client
    {
        public int numero_casas;
        public string token;
        public string cifrado;
        public string decifrado;
        public string resumo_criptografico;


        public Client(int numero_casas, string token,string cifrado,string decifrado,string resumo)
        {
            this.numero_casas = numero_casas;
            this.token = token;
            this.cifrado = cifrado;
            this.decifrado = decifrado;
            resumo_criptografico = resumo;
        }
    }
}
