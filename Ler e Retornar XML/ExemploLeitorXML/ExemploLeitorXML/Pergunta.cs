using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace ExemploLeitorXML
{
    public class Pergunta
    {
        private String dsPergunta;
        public String DsPergunta
        {
            get { return dsPergunta; }
            set { dsPergunta = value; }
        }
        private ArrayList Respostas;
        public void AddResposta(String _resposta, bool _valor)
        {
            Resposta resp = new Resposta();
            resp.DsResposta = _resposta;
            resp.Valor = _valor;
            this.Respostas.Add(resp);
        }
        public Pergunta(String _dsPergunta)
        {
            this.dsPergunta = _dsPergunta;
            this.Respostas = new ArrayList();
        }
        public ArrayList ListaResposta()
        {
            return this.Respostas;
        }
    }
}