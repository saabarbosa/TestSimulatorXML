using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for ExameAD
/// </summary>
public class ExameAD
{
	public ExameAD()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static DataTable DtObterExames()
    {
        Banco banco = new Banco();
        SqlConnection con = banco.Conexao();
        SqlCommand command = new SqlCommand();
        command.Connection = con;
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT * FROM tb_Exame";
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