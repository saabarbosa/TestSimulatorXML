using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public partial class Private_Administrator_AddRule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {             
     
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListRules.aspx");
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        if (!txtRegra.Text.Equals(string.Empty))
        {
            Roles.CreateRole(txtRegra.Text);
            Response.Redirect("ListRules.aspx");
        }
    }
}
