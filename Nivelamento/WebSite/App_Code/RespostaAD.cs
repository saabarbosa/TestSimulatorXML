using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for RespostaAD
/// </summary>
public class RespostaAD
{
	public RespostaAD()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void Inserir(Resposta resp)
    {
        Banco banco = new Banco();
        SqlConnection con = banco.Conexao();
        string procedure = "dbo.inserirResposta";
        SqlCommand command = new SqlCommand(procedure, con);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.AddWithValue("@CodResposta", resp.Cod_Resposta);
        command.Parameters.AddWithValue("@UserId", resp.Userid);
        command.Parameters.AddWithValue("@XMLResposta", resp.XMLResposta);
        command.Parameters.AddWithValue("@DataResposta", resp.DataResposta);
        command.Parameters.AddWithValue("@Status", resp.Status);
        command.Parameters.AddWithValue("@CodExame", resp.Cod_Exame);

        try
        {
            command.ExecuteNonQuery();
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


    public static DataTable DtObterRespUsuarios(string cod)
    {
        Banco banco = new Banco();
        SqlConnection con = banco.Conexao();
        SqlCommand command = new SqlCommand();
        command.Connection = con;
        command.CommandType = CommandType.Text;
        string select = "SELECT r.*, u.* FROM tb_Resposta r INNER JOIN tb_Usuario u ON r.UserId = u.UserId  order by r.DataResposta desc";
        if (!cod.Equals("0"))
            select = "SELECT r.*, u.* FROM tb_Resposta r INNER JOIN tb_Usuario u ON r.UserId = u.UserId where r.CodExame = " + cod + " order by r.DataResposta desc";

        command.CommandText = select;
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

    public static DataTable DtObterRespUsuario(int codResposta, string userId)
    {
        Banco banco = new Banco();
        SqlConnection con = banco.Conexao();
        SqlCommand command = new SqlCommand();
        command.Connection = con;
        command.CommandType = CommandType.Text;

        command.CommandText = "SELECT r.*, u.* FROM tb_Resposta r INNER JOIN tb_Usuario u ON r.UserId = u.UserId WHERE r.CodResposta = " + codResposta + " AND r.UserId = '" + userId + "'";

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