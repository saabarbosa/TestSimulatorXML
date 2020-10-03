using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

class Banco
{
    private static string strConexao = null;

    public Banco()
    {
        try
        {
            strConexao = ChaveStringConexao();
            //string nomeStringConexao = ChaveStringConexao();
            //ConnectionStringSettings configStringConexao = ConfigurationManager.ConnectionStrings[nomeStringConexao];
            //strConexao = configStringConexao.ConnectionString;

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }

    private string ChaveStringConexao()
    {
        return ConfigurationManager.AppSettings["connectionString"];
    }

    public SqlConnection Conexao()
    {
        SqlConnection conn = new SqlConnection(strConexao);
        try
        {
            conn.Open();
        }
        catch (SqlException err)
        {
            throw new Exception(err.Message);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return conn;

    }



}
