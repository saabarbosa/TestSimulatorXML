using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Private_Supervisor_ListAnswers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DdlExame.DataSource = ExameAD.DtObterExames();
            DdlExame.DataBind();
            DdlExame.Items.Insert(0, new ListItem("Todos", "0"));

            GridView1.DataSource = RespostaAD.DtObterRespUsuarios(DdlExame.SelectedValue);
            GridView1.DataBind();
        }
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
        if (e.CommandName.Equals("Download"))
        {
            Response.Redirect("Download.aspx" + (string)e.CommandArgument);
        }
        if (e.CommandName.Equals("AddNotes"))
        {
            Response.Redirect("AddNotes.aspx" + (string)e.CommandArgument);
        }
    }


 
    protected void DdlExame_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView1.DataSource = RespostaAD.DtObterRespUsuarios(DdlExame.SelectedValue);
        GridView1.DataBind();
    }
}