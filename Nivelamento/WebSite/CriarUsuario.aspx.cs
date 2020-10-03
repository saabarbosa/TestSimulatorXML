using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;
using System.Drawing;
using System.Threading;

public partial class CriarUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Visible = false;
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        String salt = GenerateSalt();
        String password = EncodePassword(Password.Text, salt);
        String answer = EncodePassword(Answer.Text, salt);
        int? ano = null;
        if (!txtAno.Text.Equals(String.Empty))
        {
            ano = Convert.ToInt32(txtAno.Text);
        }

        // problema no padrão da data
        //DateTime dtNascimento = Convert.ToDateTime(txtDataNascimento.Text);
        //@"usuario"

        int retorno = CriarUsuarioNg.InserirUsuario(txtNome.Text,
                                                    "1973-06-06",
                                                    Convert.ToInt32(ddlEscolaridade.SelectedValue),
                                                    txtFoneFixo.Text,
                                                    txtFoneCel.Text,
                                                    chkEstudouIngles.Checked ? '1' : '0',
                                                    txtEscolaEstIng.Text,
                                                    ano,
                                                    txtEstagioEstIngles.Text,
                                                    ddlMotivo.SelectedValue,
                                                    @"usuario",
                                                    Membership.ApplicationName,
                                                    UserName.Text,
                                                    password,
                                                    salt,
                                                    Email.Text,
                                                    Question.Text,
                                                    answer);


        LimparCampos(txtAno, txtNome, txtFoneFixo, txtFoneCel, txtEstagioEstIngles, txtEscolaEstIng, txtDataNascimento,
                     Answer, Password, Question, Email);
        if (retorno == 0)
        {
            //Response.Redirect("Login.aspx");
            Mensagem(Color.Red, true, "Usuário cadastrado com sucesso.");
        }
        else
        {
            Mensagem(Color.Red, true, "Problema no cadastro");
        }
    }

    private void LimparCampos(params TextBox[] listaTb)
    {
        foreach (TextBox tb in listaTb)
        {
            tb.Text = String.Empty;
        }
    }

    private void Mensagem(Color cor, bool visivel, String msg)
    {
        if (visivel)
        {
            lblMsg.Text = msg;
            lblMsg.ForeColor = cor;
        }
        lblMsg.Visible = visivel;
    }

    /*
     * Geração de salt e criptogria
     */
    private string GenerateSalt()
    {
        var buf = new byte[16];
        (new RNGCryptoServiceProvider()).GetBytes(buf);
        return Convert.ToBase64String(buf);
    }

    private string EncodePassword(string pass, string salt)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(pass);
        byte[] src = Convert.FromBase64String(salt);
        byte[] dst = new byte[src.Length + bytes.Length];
        byte[] inArray = null;

        System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
        System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

        HashAlgorithm algorithm = HashAlgorithm.Create(Membership.HashAlgorithmType);
        inArray = algorithm.ComputeHash(dst);

        return Convert.ToBase64String(inArray);
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void chkEstudouIngles_CheckedChanged(object sender, EventArgs e)
    {
        if (chkEstudouIngles.Checked)
            Panel1.Visible = true;
        else
            Panel1.Visible = false;
    }
}