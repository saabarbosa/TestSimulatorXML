using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Login : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_LoggedIn(object sender, EventArgs e)
    {
        string[] roles = Roles.GetRolesForUser(Login1.UserName);
        if (roles[0].Equals("administrador")) 
            Login1.DestinationPageUrl = "~/Private/Administrator/ListUsers.aspx";
        else if (roles[0].Equals("supervisor"))
            Login1.DestinationPageUrl = "~/Private/Supervisor/ListAnswers.aspx";
        else
            Login1.DestinationPageUrl = "~/Private/User/Welcome.aspx";
    }

}
