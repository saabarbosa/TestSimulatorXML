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


public partial class Private_Administrator_EditUser : System.Web.UI.Page
{
    public string CurrentUser;
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["CurrentUser"] = Convert.ToString(Request["UserName"]);
        CurrentUser = Convert.ToString(Request["UserName"]);
        if (!IsPostBack)
        {
            PopulateCheckboxes();
            txtLogin.Text = CurrentUser;
            txtLogin.Enabled = false;
            MembershipUser mu = (MembershipUser)Membership.GetUser(CurrentUser, false);
            if (mu == null)
            {
                return; // Review: scenarios where this happens.
            }
            ActiveUser.Checked = mu.IsApproved;
            txtEmail.Text = mu.Email;            
        }
    }
    private void PopulateCheckboxes()
    {
        CheckBoxRepeater.DataSource = Roles.GetAllRoles();
        CheckBoxRepeater.DataBind();
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        UpdateUser(sender, e);
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListUsers.aspx");
    }
    private void UpdateRoleMembership(string u)
    {
        if (String.IsNullOrEmpty(u))
        {
            return;
        }
        foreach (RepeaterItem i in CheckBoxRepeater.Items)
        {
            CheckBox c = (CheckBox)i.FindControl("checkbox1");
            UpdateRoleMembership(u, c);
        }
        PopulateCheckboxes();
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
    public void UpdateUser(object sender, EventArgs e)
    {
        if (!Page.IsValid)
        {
            return;
        }
        string userIDText = txtLogin.Text;
        string emailText = txtEmail.Text;        
        try
        {
            MembershipUser mu = (MembershipUser)Membership.GetUser(CurrentUser, false);            
            mu.Email = txtEmail.Text;
            mu.IsApproved = ActiveUser.Checked;
            
            Membership.UpdateUser((MembershipUser)mu);            
            UpdateRoleMembership(userIDText);
            btnCancelar_Click(sender, e);
        }
        catch (Exception ex)
        {
            return ;
        }        
    }
}
