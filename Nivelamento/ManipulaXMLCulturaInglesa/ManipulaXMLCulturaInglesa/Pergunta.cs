using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace ManipulaXMLCulturaInglesa
{
    public class Pergunta
    {
        private String dsPergunta;
        private String pathPicture;
        public String DsPergunta
        {
            get { return dsPergunta; }
            set { dsPergunta = value; }
        }
        public String PathPicture
        {
            get { return pathPicture; }
            set { pathPicture = value; }
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
        public Pergunta(String _dsPergunta, String _pathPicture)
        {
            this.dsPergunta = _dsPergunta;
            this.pathPicture = _pathPicture;
            this.Respostas = new ArrayList();
        }


        public ArrayList ListaResposta()
        {
            return this.Respostas;
        }
    }
}