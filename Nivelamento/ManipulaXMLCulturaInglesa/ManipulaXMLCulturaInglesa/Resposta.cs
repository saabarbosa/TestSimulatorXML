using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManipulaXMLCulturaInglesa
{
    public class Resposta
    {
        private String dsResposta;
        private bool valor;
        public String DsResposta
        {
            get { return dsResposta; }
            set { dsResposta = value; }
        }
        public bool Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}