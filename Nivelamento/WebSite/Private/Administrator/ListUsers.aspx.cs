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


public partial class Private_Administrator_ListUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            listaUsuarios();
        }
    }
    protected void listaUsuarios()
    {

        GridView1.DataSource = Membership.GetAllUsers();
        GridView1.DataBind();
        GridView1.Visible = (GridView1.Rows.Count > 0);
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }

 
    public void LinkButtonClick(object sender, CommandEventArgs e)
    {
        if (e.CommandName.Equals("DelUser"))
        {
            Response.Redirect("DelUser.aspx?UserName=" + (string)e.CommandArgument);
        }
    }
    public void LinkButton2Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName.Equals("EditUser"))
        {
            Response.Redirect("EditUser.aspx?UserName=" + (string)e.CommandArgument);
        }
    }
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddUser.aspx");
    }
}
