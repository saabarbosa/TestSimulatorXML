using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AtendimentoAD
/// </summary>
public class AtendimentoAD
{
	public AtendimentoAD()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void Inserir(Atendimento atend)
    {
        Banco banco = new Banco();
        SqlConnection con = banco.Conexao();
        string procedure = "dbo.inserirObservacao";
        SqlCommand command = new SqlCommand(procedure, con);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.AddWithValue("@CodAtendimento", atend.Cod_Atendimento);
        command.Parameters.AddWithValue("@CodResposta", atend.Cod_Resposta);
        command.Parameters.AddWithValue("@UserId", atend.Userid);
        command.Parameters.AddWithValue("@Observacao", atend.Observacao);
        command.Parameters.AddWithValue("@DataLog", atend.DataLog);
        command.Parameters.AddWithValue("@NomeFuncionario", atend.NomeFuncionario);

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


    public static DataTable DtObterAtendimento(int codResposta, string userId)
    {
        Banco banco = new Banco();
        SqlConnection con = banco.Conexao();
        SqlCommand command = new SqlCommand();
        command.Connection = con;
        command.CommandType = CommandType.Text;

        command.CommandText = "SELECT * FROM tb_Atendimento WHERE CodResposta = " + codResposta + " AND UserId = '" + userId + "'";

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