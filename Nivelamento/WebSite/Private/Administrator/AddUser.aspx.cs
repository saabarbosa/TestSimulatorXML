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

public partial class Private_Administrator_AddUser : System.Web.UI.Page
{    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateCheckboxes();
        }
    }

    public void CreatedUser(object sender, EventArgs e)
    {        
        UpdateRoleMembership(createUser.UserName);
    }
    private void UpdateRoleMembership(string u)
    {
        if (String.IsNullOrEmpty(u))
        {
            return;
        }
        foreach (RepeaterItem i in checkBoxRepeater.Items)
        {
            CheckBox c = (CheckBox)i.FindControl("checkbox1");
            UpdateRoleMembership(u, c);
        }
    }

    private void UpdateRoleMembership(string u, CheckBox box)
    {        
        string role = box.Text;        

        if (box.Checked && !(bool)Roles.IsUserInRole(u, role))
        {
            Roles.AddUsersToRoles(new string[] { u }, new string[] { role });            
        }
        else if (!box.Checked && (bool)Roles.IsUserInRole(u, role))
        {
            Roles.RemoveUsersFromRoles(new string[] { u }, new string[] { role });            
        }
    }

    private void PopulateCheckboxes()
    {
        checkBoxRepeater.DataSource = Roles.GetAllRoles();
        checkBoxRepeater.DataBind();        
    }
    
}
