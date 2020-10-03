using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Data;
using System.Collections;

namespace ExemploLeitorXML
{

    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtPerguntas, dtRespostas;
            LerXML.LerXMLPergResp(@"c:\teste\Nivelamento Infantil.test", true, out dtPerguntas, out dtRespostas);
            gvwPerguntas.DataSource = dtPerguntas;
            gvwPerguntas.DataBind();
            gvwRespostas.DataSource = dtRespostas;
            gvwRespostas.DataBind();

            //Arraylist com as perguntas
            ArrayList alQuestionario = new ArrayList();
            //Criando a primeira pergunta
            Pergunta pergunta = new Pergunta("Primeira Pergunta");
            pergunta.AddResposta("Primeira escolha", true);
            pergunta.AddResposta("Segunda escolha", false);
            pergunta.AddResposta("Terceira escolha", false);
            pergunta.AddResposta("Quarta escolha", false);
            alQuestionario.Add(pergunta);

            pergunta = new Pergunta("Segunda Pergunta");
            pergunta.AddResposta("Primeira escolha", false);
            pergunta.AddResposta("Segunda escolha", false);
            pergunta.AddResposta("Terceira escolha", true);
            pergunta.AddResposta("Quarta escolha", false);
            alQuestionario.Add(pergunta);

            //Retorna XML de respostas do aluno
            String a = GerarXMLResp.GerarXML(alQuestionario, "Edjostenes Lima Poderoso", "Nivelamento Adolescente", "0",
                                             "30", "15:14:42", "15:20:55", "");
        }
    }
}
