using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using System.Xml;

namespace ExemploLeitorXML
{
    public class LerXML
    {
        /// <summary>
        /// Ler XML de perguntas e respostas
        /// </summary>
        /// <param name="_caminho">Caminho do arquivo que contém o XML a ser lido</param>
        /// <param name="_junior">Variável que indica se o XML a ser lido é júnior. Caso sim será retornado o caminho das imagens</param>
        /// <param name="_dtPerguntas">DataTable com todas as perguntas</param>
        /// <param name="_dtRespostas">DataTable com todas as respostas. Caso seja júnior terá a coluna CaminhoFigura</param>
        public static void LerXMLPergResp(String _caminho, Boolean _junior, out DataTable _dtPerguntas, out DataTable _dtRespostas)
        {
            int NumPergunta = 0;

            #region Tabelas de perguntas e respostas
            //Tabelas de perguntas e respostas
            _dtPerguntas = new DataTable();
            _dtPerguntas.Columns.Add("Perguntas");
            _dtRespostas = new DataTable();
            _dtRespostas.Columns.Add("Respostas");
            _dtRespostas.Columns.Add("NumeroPergunta");
            _dtRespostas.Columns.Add("Gabarito");
            #endregion

            #region Carregar arquivo texto no StreamReader
            StreamReader sr;
            if (!_caminho.Equals(String.Empty))
            {
                sr = new StreamReader(_caminho);
            }
            else
            {
                throw new Exception("Caminha do arquivo inválido");
            }
            #endregion

            #region Carregar documento XML
            XmlTextReader reader = new XmlTextReader(sr);
            reader.XmlResolver = null;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);
            XmlNode nos = xmlDoc.DocumentElement;
            #endregion

            if (!_junior)
            {
                #region XML Adulto Adolescente
                foreach (XmlNode no1 in nos.ChildNodes)
                {
                    switch (no1.Name)
                    {
                        case "Question":
                            _dtPerguntas.Rows.Add(no1.Attributes["Value"].Value);
                            NumPergunta++;
                            break;
                    }
                    foreach (XmlNode no2 in no1.ChildNodes)
                    {
                        switch (no2.Name)
                        {
                            case "Answer":
                                _dtRespostas.Rows.Add(no2.Attributes["Text"].Value, NumPergunta, no2.Attributes["Correct"].Value);
                                break;
                        }
                    }
                }
                #endregion
            }
            else
            {
                #region XML Junior
                _dtRespostas.Columns.Add("CaminhoFigura");
                foreach (XmlNode no1 in nos.ChildNodes)
                {
                    switch (no1.Name)
                    {
                        case "Question":
                            _dtPerguntas.Rows.Add(no1.Attributes["Value"].Value);
                            NumPergunta++;
                            break;
                    }
                    foreach (XmlNode no2 in no1.ChildNodes)
                    {
                        switch (no2.Name)
                        {
                            case "Answer":
                                String resp = no2.Attributes["Text"].Value;
                                String correta = no2.Attributes["Correct"].Value;
                                String caminhaFig = no2.Attributes["Picture"].Value;
                                _dtRespostas.Rows.Add(resp, NumPergunta, correta, caminhaFig);
                                break;

                        }
                    }
                }
                #endregion
            }
        }
    }
}