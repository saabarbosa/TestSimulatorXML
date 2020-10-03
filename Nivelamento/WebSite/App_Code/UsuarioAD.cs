using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class UsuarioAD
{
	public UsuarioAD()
	{

	}

    public static DataTable DtObterUsuario(string userId)
    {
        Banco banco = new Banco();
        SqlConnection con = banco.Conexao();
        string procedure = "dbo.obterUsuario";
        SqlCommand command = new SqlCommand(procedure, con);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@USERID", userId);
        DataTable dt = new DataTable();
        try
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            da.Fill(dt);
            return dt;
        }
        catch (SqlException err)
        {
            throw new ApplicationException(err.Message);
        }
        finally
        {
            con.Close();
        }
    }
}