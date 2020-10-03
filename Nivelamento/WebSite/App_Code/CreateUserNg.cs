using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Techshift.DataAccessLayer;

/// <summary>
/// Summary description for CreateUserNg
/// </summary>
public class CreateUserNg
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
                              String _escolaEstIngles, int? _anoEstIngles, String _estagioEstIngles, String _motivo, String _userid)
    {
        String msg, sql;
        #region SQL
        sql = "insert into tb_Usuario (UserId, Nome, DataNascimento, Escolaridade, FoneFixo, FoneCelular, EstudouIngles, EscolaEstudouIngles, AnoEstudouIngles, "+
						              "EstagioEstudouIngles, Motivo) "+
               "values (@userid, @nome, CONVERT(date, @dataNascimento, 103), @escolaridade, @foneFixo, @foneCel, @estudouIngles, @escolaEstIngles, @anoEstIngles, " +
                        "@estagioEstIngles, @motivo)";
        #endregion
        int retorno = DBProvider.Instance(sql, out msg, DbParametro.Parametro("@userid", _userid, DbType.String),
                                                        DbParametro.Parametro("@nome", _nome, DbType.String),
                                                        DbParametro.Parametro("@dataNascimento", _dataNascimento, DbType.String),
                                                        DbParametro.Parametro("@escolaridade", _escolaridade, DbType.Int32),
                                                        DbParametro.Parametro("@foneFixo", _foneFixo, DbType.String),
                                                        DbParametro.Parametro("@foneCel", _foneCel, DbType.String),
                                                        DbParametro.Parametro("@estudouIngles", _estIngles, DbType.String),
                                                        DbParametro.Parametro("@escolaEstIngles", _escolaEstIngles, DbType.String),
                                                        DbParametro.Parametro("@anoEstIngles", _anoEstIngles, DbType.Int32),
                                                        DbParametro.Parametro("@estagioEstIngles", _estagioEstIngles, DbType.String),
                                                        DbParametro.Parametro("@motivo", _motivo, DbType.String));
        return retorno;
    }
}