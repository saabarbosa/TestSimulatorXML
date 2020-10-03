using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

public partial class Private_Supervisor_AddNotes : System.Web.UI.Page
{

    private string CodResposta;

    private string UserId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CodResposta = Request.Params["CodResposta"];
        UserId = Request.Params["UserId"];

        // Obtem status
        DataTable dtResposta = RespostaAD.DtObterRespUsuario(Convert.ToInt32(CodResposta), UserId);
        string status = dtResposta.Rows[0]["Status"].ToString();
        ListItem lItemStatus = ddlStatus.Items.FindByValue(status);
        lItemStatus.Selected = true;

        // Repeat
        DataTable dtObservacoes = AtendimentoAD.DtObterAtendimento(Convert.ToInt32(CodResposta), UserId);
        Repeater1.DataSource = dtObservacoes;
        Repeater1.DataBind();


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListAnswers.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Atendimento atend = new Atendimento();
        atend.Cod_Resposta = Convert.ToInt32(CodResposta);
        atend.Userid = UserId;
        atend.Observacao = txtObs.Text;
        atend.DataLog = DateTime.Now.Date;
        //DataTable dtUsuario = UsuarioAD.DtObterUsuario(UserId);
        //atend.NomeFuncionario = dtUsuario.Rows[0]["Nome"].ToString();
        atend.NomeFuncionario = Membership.GetUser().UserName;
        try
        {
            AtendimentoAD.Inserir(atend);
        }
        catch (Exception ex)
        {

        }
        Response.Redirect("ListAnswers.aspx");

    }
}