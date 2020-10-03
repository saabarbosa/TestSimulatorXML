using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;


public partial class Private_Supervisor_Download : System.Web.UI.Page
{

    private string CodResposta;
    private string UserId;
    private string fileXML;

    protected void Page_Load(object sender, EventArgs e)
    {
        CodResposta = Request.Params["CodResposta"];
        UserId = Request.Params["UserId"];
        DataTable dtResposta = RespostaAD.DtObterRespUsuario(Convert.ToInt32(CodResposta), UserId);
        fileXML = dtResposta.Rows[0]["XMLResposta"].ToString();
        txtXmlResposta.Text = fileXML;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListAnswers.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        Download( "Resp_" + UserId + ".xml");
    }

    public void Download(string fName)
    {
        MemoryStream ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(fileXML));
        Response.Charset = "iso-8859-1";
        Response.ContentType = "application/octet-stream";
        Response.AddHeader("Content-Disposition", "attachment; filename = \"" + fName + "\"");

        //FileInfo fInfo = new FileInfo(fName);
        //HttpContext.Current.Response.Clear();
        //HttpContext.Current.Response.ContentType = "application/octet-stream";
        //HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename = \"" + fInfo.Name + "\"");
        //HttpContext.Current.Response.AddHeader("Content-Length", ms.Length.ToString());
        //HttpContext.Current.Response.Flush();
        //fInfo = null;
        ms.WriteTo(Context.Response.OutputStream);
        ms.Close();

        Response.Flush();
        Response.Clear();
        Response.End();


    }
}