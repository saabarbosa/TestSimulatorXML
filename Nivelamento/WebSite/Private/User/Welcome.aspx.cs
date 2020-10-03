using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

public partial class Private_User_Welcome : System.Web.UI.Page
{

    private MembershipUser user = Membership.GetUser();
  
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtUserid = UsuarioAD.DtObterUsuario(user.ProviderUserKey.ToString());
        lblNome.Text = dtUserid.Rows[0]["Nome"].ToString();
 
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
            btnIniciar.Enabled = true;
        else
            btnIniciar.Enabled = false;
    }

    protected void btnIniciar_Click(object sender, EventArgs e)
    {
          Response.Redirect("Test.aspx");
    }
}