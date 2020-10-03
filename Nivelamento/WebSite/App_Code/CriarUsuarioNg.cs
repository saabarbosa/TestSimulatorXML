using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Techshift.DataAccessLayer;
using System.Collections;
using System.Data.Common;

/// <summary>
/// Summary description for CreateUserNg
/// </summary>
public class CriarUsuarioNg
{
    /// <summary>
    /// Inserir Usuário na tabela tb_Usuario
    /// </summary>
    /// <param name="_nome"></param>
    /// <param name="_dataNascimento"></param>
    /// <param name="_escolaridade"></param>
    /// <param name="_foneFixo"></param>
    /// <param name="_foneCel"></param>
    /// <param name="_estIngles"></param>
    /// <param name="_escolaEstIngles"></param>
    /// <param name="_anoEstIngles"></param>
    /// <param name="_estagioEstIngles"></param>
    /// <param name="_motivo"></param>
    /// <param name="_userid">ID do usuário inserido na tabela do membership</param>
    /// <returns>"-1" indica erro</returns>
    public static int InserirUsuario(String _nome, String _dataNascimento, int _escolaridade, String _foneFixo, String _foneCel, char _estIngles,
                                     String _escolaEstIngles, int? _anoEstIngles, String _estagioEstIngles, String _motivo,
                                     String _role, String _applicationName, String _userName, String _password, String _passSalt, String _email,
                                     String _question, String _answer)
    {
        String msg;
        
        Hashtable retorno = DBProvider.InstanceProcedureOutData("inserirUsuario", out msg,
                                                                DbParametro.Parametro("@nome", _nome, DbType.String),
                                                                DbParametro.Parametro("@dataNascimento", _dataNascimento, DbType.String),
                                                                DbParametro.Parametro("@escolaridade", _escolaridade, DbType.Int32),
                                                                DbParametro.Parametro("@foneFixo", _foneFixo, DbType.String),
                                                                DbParametro.Parametro("@foneCel", _foneCel, DbType.String),
                                                                DbParametro.Parametro("@estudouIngles", _estIngles, DbType.String),
                                                                DbParametro.Parametro("@escolaEstIngles", _escolaEstIngles, DbType.String),
                                                                DbParametro.Parametro("@anoEstIngles", _anoEstIngles, DbType.Int32),
                                                                DbParametro.Parametro("@estagioEstIngles", _estagioEstIngles, DbType.String),
                                                                DbParametro.Parametro("@motivo", _motivo, DbType.String),
                                                                DbParametro.Parametro("@role", _role, DbType.String),
                                                                DbParametro.Parametro("@ApplicationName", _applicationName, DbType.String),
                                                                DbParametro.Parametro("@UserName", _userName, DbType.String),
                                                                DbParametro.Parametro("@Password", _password, DbType.String),
                                                                DbParametro.Parametro("@PasswordSalt", _passSalt, DbType.String),
                                                                DbParametro.Parametro("@Email", _email, DbType.String),
                                                                DbParametro.Parametro("@PasswordQuestion", _question, DbType.String),
                                                                DbParametro.Parametro("@PasswordAnswer", _answer, DbType.String),
                                                                DbParametro.Parametro("@UserId", DBNull.Value, DbType.Int32, ParameterDirection.InputOutput));
        return Convert.ToInt32(retorno["@UserId"]);
    }
}