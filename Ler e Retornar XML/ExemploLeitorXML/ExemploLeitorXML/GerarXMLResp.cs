using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Xml;

namespace ExemploLeitorXML
{
    public class GerarXMLResp
    {
        /// <summary>
        /// Gerar XML
        /// </summary>
        /// <param name="_questionario">ArrayList com o questionário</param>
        /// <returns></returns>
        public static String GerarXML(ArrayList _questionario, String _nome, String _titulo, String _maxHour,
                                    String _maxMin, String _startTime, String _finishTime, String _descricao)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xmlNoDec = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDoc.AppendChild(xmlNoDec);

            XmlNode folhaResp = xmlDoc.CreateElement("answersheet");
            folhaResp.Attributes.Append(CriarAtributo("FullName", _nome.ToUpper(), xmlDoc));
            folhaResp.Attributes.Append(CriarAtributo("Title", _titulo, xmlDoc));
            folhaResp.Attributes.Append(CriarAtributo("Description", _descricao, xmlDoc));
            folhaResp.Attributes.Append(CriarAtributo("Copyright", "Cultura Inglesa Sergipe",xmlDoc));
            folhaResp.Attributes.Append(CriarAtributo("MaxHour", _maxHour, xmlDoc));
            folhaResp.Attributes.Append(CriarAtributo("MaxMin", _maxMin, xmlDoc));
            folhaResp.Attributes.Append(CriarAtributo("StartTime", _startTime, xmlDoc));
            folhaResp.Attributes.Append(CriarAtributo("FinishTime", _finishTime, xmlDoc));
            xmlDoc.AppendChild(folhaResp);

            String dspergunta;
            foreach (Pergunta perg in _questionario)
            {
                dspergunta = perg.DsPergunta;
                XmlNode xmlQuestao = xmlDoc.CreateElement("Question");
                xmlQuestao.Attributes.Append(CriarAtributo("Text", dspergunta, xmlDoc));

                foreach (Resposta resp in perg.ListaResposta())
                {
                    String correct = Convert.ToString(resp.Valor);;
                    XmlNode xmlResposta = xmlDoc.CreateElement("Answer");
                    xmlResposta.Attributes.Append(CriarAtributo("Correct", correct, xmlDoc));
                    xmlQuestao.AppendChild(xmlResposta);
                }

                folhaResp.AppendChild(xmlQuestao);
            }

            return xmlDoc.OuterXml;
        }

        /// <summary>
        /// Criar atributo
        /// </summary>
        /// <param name="_nome">Nome</param>
        /// <param name="_valor">Valor</param>
        /// <param name="_xmlDoc">Documento XML</param>
        /// <returns></returns>
        private static XmlAttribute CriarAtributo(String _nome, String _valor, XmlDocument _xmlDoc)
        {
            XmlAttribute xmlAtt = _xmlDoc.CreateAttribute(_nome);
            xmlAtt.Value = _valor;
            return xmlAtt;
        }
    }
}