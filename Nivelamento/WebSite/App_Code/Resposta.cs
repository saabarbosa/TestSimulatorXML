using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Resposta
/// </summary>
public class Resposta
{

    private int _cod_Resposta;
    private string _userId;
    private string _xMLResposta;
    private DateTime _dataResposta;
    private char _status;
    private int _cod_Exame;

	public Resposta()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public Resposta(int cod_resposta, string userid, string xmlResposta , 
        DateTime dataResposta, char status , int cod_exame) 
    {
        this._cod_Resposta = cod_resposta;
        this._userId = userid;
        this._xMLResposta = xmlResposta;
        this._dataResposta = dataResposta;
        this._status = status;
        this._cod_Exame = cod_exame;

    }

    public int Cod_Resposta
    {
        get { return _cod_Resposta; }
        set { _cod_Resposta = value; }
    }

    public string Userid
    {
        get { return _userId; }
        set { _userId = value; }
    }


    public string XMLResposta
    {
        get { return _xMLResposta; }
        set { _xMLResposta = value; }
    }

    public DateTime DataResposta
    {
        get { return _dataResposta; }
        set { _dataResposta = value; }
    }

    public char Status
    {
        get { return _status; }
        set { _status = value; }
    }

    public int Cod_Exame
    {
        get { return _cod_Exame; }
        set { _cod_Exame = value; }
    }

}