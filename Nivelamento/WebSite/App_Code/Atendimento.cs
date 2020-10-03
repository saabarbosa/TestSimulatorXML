using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Atendimento
/// </summary>
public class Atendimento
{
    private int _cod_Atendimento;
    private int _cod_Resposta;
    private string _userId;
    private string _observacao;
    private DateTime _dataLog;
    private string _nomeFuncionario;

	public Atendimento()
	{

	}

    public Atendimento(int cod_Atendimento, int cod_Resposta, string userId, 
                        string observacao, DateTime dataLog, string nomeFuncionario)
    {
        this._cod_Atendimento = cod_Atendimento;
        this._cod_Resposta = cod_Resposta;
        this._userId = userId;
        this._observacao = observacao;
        this._dataLog = dataLog;
        this._nomeFuncionario = nomeFuncionario;
    }

    public int Cod_Atendimento
    {
        get { return _cod_Atendimento; }
        set { _cod_Atendimento = value; }
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

    public string Observacao
    {
        get { return _observacao; }
        set { _observacao = value; }
    }

    public DateTime DataLog
    {
        get { return _dataLog; }
        set { _dataLog = value; }
    }

    public string NomeFuncionario
    {
        get { return _nomeFuncionario; }
        set { _nomeFuncionario = value; }
    }
}