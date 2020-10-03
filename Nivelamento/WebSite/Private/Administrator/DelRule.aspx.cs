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


public partial class Private_Administrator_DelRule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string regra = Convert.ToString(Request["RoleName"]);
            CarregaRegra(regra);
        }
    }
    protected void CarregaRegra(string regra)
    {
        lblNome.Text = regra;
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListRules.aspx");
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        string regra = Convert.ToString(Request["RoleName"]);
        //Apaga a Role como tambem UsersInRoles
        Roles.DeleteRole(regra,false);
        btnCancelar.Visible = false;
        btnExcluir.Visible = false;
        lblConfirmacao.Visible = false;

        lblSucesso.Visible = true;
        btnVoltar.Visible = true;
    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListRules.aspx");
    }
}
