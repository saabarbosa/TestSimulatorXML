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


public partial class Private_Administrator_ListRules : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            listaRegras();
        }
    }
    protected void listaRegras()
    {
        string[] arr = Roles.GetAllRoles();
        GridView1.DataSource = arr;
        int currentPage = GridView1.PageIndex;
        int count = arr.Length;
        int pageSize = GridView1.PageSize;
        if (count > 0 && currentPage == count / pageSize && count % pageSize == 0)
        {
            GridView1.PageIndex -= 1;
        }
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
        if (e.CommandName.Equals("DelRule"))
        {                        
            Response.Redirect("DelRule.aspx?RoleName=" + (string)e.CommandArgument);
        }        
    }

    protected void btnNovo_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddRule.aspx");
    }
}
