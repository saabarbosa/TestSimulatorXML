using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class Private_Administrator_DelUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string usuario = Convert.ToString(Request["UserName"]);
            CarregaUsuario(usuario);
        }
    }
    protected void CarregaUsuario(string usuario)
    {
        lblNome.Text = usuario;
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListUsers.aspx");
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        string usuario = Convert.ToString(Request["UserName"]);
        //Apaga a Usuario como tambem UsersInRoles
        Membership.DeleteUser(usuario);
        btnCancelar.Visible = false;
        btnExcluir.Visible = false;
        lblConfirmacao.Visible = false;

        lblSucesso.Visible = true;
        btnVoltar.Visible = true;
    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListUsers.aspx");
    }
}
