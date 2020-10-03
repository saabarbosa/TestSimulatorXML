using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Private_Supervisor_ListTests : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //GridView1.DataSource = IncluirDadosGridExame(20);
        GridView1.DataSource = ExameAD.DtObterExames();
        GridView1.DataBind();
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

    protected DataTable IncluirDadosGridExame(int count)
    {
        DataTable mDataTable = new DataTable();
        DataColumn mDataColumn;

        mDataColumn = new DataColumn();
        mDataColumn.DataType = Type.GetType("System.String");
        mDataColumn.ColumnName = "Nome";
        mDataTable.Columns.Add(mDataColumn);

          DataRow linha;
        for (int i = 0; i <= count; i++)
        {
            linha = mDataTable.NewRow();
            linha["Nome"] = "Exame " + i.ToString();
            mDataTable.Rows.Add(linha);

        }
        return mDataTable;

    }

}