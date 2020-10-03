using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ManipulaXMLCulturaInglesa;
using System.Data;
using System.Drawing;
using System.Web.Security;
using System.Collections;

public partial class Private_User_Test : System.Web.UI.Page
{
    private DataTable dtPerguntas = null;
    private DataTable dtRespostas = null;
    private int qtdPerguntas;
    private int nivel; //Obter atraves do grau de instrução do usuario

    protected void Page_Load(object sender, EventArgs e)
    {
        MembershipUser user = Membership.GetUser();
        DataTable dtUserid = UsuarioAD.DtObterUsuario(user.ProviderUserKey.ToString());
        lblNome.Text = dtUserid.Rows[0]["Nome"].ToString();
        nivel = Convert.ToInt16( dtUserid.Rows[0]["Escolaridade"]);
        CriarWizard();
        
    }

    /// <summary>
    /// 
    /// </summary>
    private void CriarWizard()
    {
        //DataTable dtRespostas = null;
        //DataTable dtPerguntas = null;
        Wizard wz = new Wizard();
        WizardStepBase step = new WizardStep();
        DataView dvRespostas;

        if (nivel == 0) //Junior
            LerXML.LerXMLPergResp(Server.MapPath("../../xmls/NIVELAMENTO JUNIOR.test"), false, out dtPerguntas, out dtRespostas);
        else if (nivel == 1) //Adolescente
            LerXML.LerXMLPergResp(Server.MapPath("../../xmls/NIVELAMENTO ADOLESCENTE.test"), false, out dtPerguntas, out dtRespostas);
        else //Adulto
            LerXML.LerXMLPergResp(Server.MapPath("../../xmls/NIVELAMENTO ADULTO.test"), false, out dtPerguntas, out dtRespostas);

        Int16 nrPergunta = 1;
        qtdPerguntas = dtPerguntas.Rows.Count;
        lblNrQuestoesExame.Text = "Questão de 1 a " + qtdPerguntas.ToString();

        //Perguntas do Exame lidas do XML
        foreach (DataRow drPerguntas in dtPerguntas.Rows)
        {

            Pergunta pergunta = new Pergunta(drPerguntas["Perguntas"].ToString(), drPerguntas["Pictures"].ToString());
 
            //Respostas da Perguntas do Exame
            dvRespostas = new DataView(dtRespostas);
            dvRespostas.RowFilter = "NumeroPergunta = " + nrPergunta;
            foreach (DataRowView drvRespostas in dvRespostas)
            {
                pergunta.AddResposta(drvRespostas["Respostas"].ToString(), Convert.ToBoolean(drvRespostas["Gabarito"]));
            }

            //Cria cada um dos Steps com a Pergunta e suas respectivas respostas
            CriaWizardStep(nrPergunta, qtdPerguntas, pergunta, out step);

            wz.WizardSteps.Add(step);

            nrPergunta++;
        }

        WizardStep fstep = new WizardStep() { ID = "final" };
        Label lblFinish = new Label();
        lblFinish.ID = "lblFinish";
        fstep.StepType = WizardStepType.Finish;
        fstep.Controls.Add(lblFinish);
        wz.WizardSteps.Add(fstep);

        //Configurações do Wizard
        wz.ActiveStepIndex = 0;
        wz.ID = "Wizard1";
        wz.EnableViewState = true;
        wz.Height = Unit.Pixel(315);
        wz.Width = Unit.Pixel(670);
        wz.BackColor = Color.Silver;
        wz.BorderColor = ColorTranslator.FromHtml("#999999");
        wz.BorderStyle = BorderStyle.Solid;
        wz.BorderWidth = new Unit("1px");
        wz.Font.Name = "Verdana";
        wz.SideBarStyle.CssClass = "sideBar";
        wz.StepStyle.CssClass = "stepStyle";
        wz.HeaderStyle.CssClass = "headerStyle";
        wz.HeaderText = "Exame de Nivelamento";

        wz.StartNextButtonText = "Próximo >>";
        wz.FinishCompleteButtonText = "Encerrar Exame";
        wz.FinishPreviousButtonText = "<< Anterior";
        wz.StepNextButtonText = "Próximo >>";
        wz.StepPreviousButtonText = "<< Anterior";

        wz.NextButtonClick += new WizardNavigationEventHandler(Wizard1_NextButtonClick);
        wz.PreviousButtonClick += new WizardNavigationEventHandler(Wizard1_PreviousButtonClick);
        wz.FinishButtonClick += new WizardNavigationEventHandler(Wizard1_FinishButtonClick);
        
        this.pnlExame.Controls.Add(wz);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_nrPergunta"></param>
    /// <param name="_qtdPerguntas"></param>
    /// <param name="_pergunta"></param>
    /// <param name="_step"></param>
    private void CriaWizardStep(Int16 _nrPergunta, int _qtdPerguntas, Pergunta _pergunta, out WizardStepBase _step)
    {
        WizardStep step = new WizardStep() { ID = "step" + _nrPergunta };

        if (_nrPergunta == 1)
            step.StepType = WizardStepType.Start;
        //else if ((_nrPergunta == qtdPerguntas))
        //{
        //    Label lblFinish = new Label();
        //    lblFinish.ID = "lblFinish";
        //    step.StepType = WizardStepType.Finish;
        //    step.Controls.Add(lblFinish);
        //}
        else
            step.StepType = WizardStepType.Step;

        Label lblPergunta = new Label();
        lblPergunta.ID = "lblPergunta" + _nrPergunta;
        lblPergunta.CssClass = "tituloPergunta";
        if (!_pergunta.PathPicture.Equals(String.Empty))
            lblPergunta.Text = _nrPergunta + ".  " + _pergunta.DsPergunta + "<br><img src=\"../../" + _pergunta.PathPicture + "\" border=\"0\" alt=\"" + _pergunta.PathPicture + "\" />";
        else
            lblPergunta.Text = _nrPergunta + ".  " + _pergunta.DsPergunta;

        step.Controls.Add(lblPergunta);
        
        //RadioButtonList com as Respostas
        RadioButtonList rblRespostas = new RadioButtonList() { ID = "rblRespostas" + _nrPergunta };
        foreach (ManipulaXMLCulturaInglesa.Resposta r in _pergunta.ListaResposta())
        {
            rblRespostas.Items.Add(new ListItem(r.DsResposta));
        }

        step.Controls.Add(rblRespostas);

        _step = step;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
    {
        lblNrQuestoesExame.Text = "Questão de " + (e.CurrentStepIndex + 2).ToString() + " a " + qtdPerguntas.ToString();

        Wizard wz = (Wizard)sender;

        //if (wz.WizardSteps[e.CurrentStepIndex].StepType == WizardStepType.Finish)
        if (e.CurrentStepIndex == wz.WizardSteps.Count - 2)
        {
            lblNrQuestoesExame.Text = "";
            Label lblFinish = wz.WizardSteps[e.CurrentStepIndex].FindControl("lblFinish") as Label;
            string str_lblFinish =  RetornaQuestoesNaoRespondidas(wz);
            if (str_lblFinish.Equals(""))
            {
 
                lblFinish.Text = "FIM. <br>Seu resultado será analisado pela área correspondente. Em breve nosso retorno.";
                string fileRespXML = GerarXMLResp.GerarXML(RetornaPerguntas(), lblNome.Text, "Resultado", "00:00:01", "00:00:01", "00:00:01", "00:00:01", "descricao");
                
                Resposta resp = new Resposta();
                resp.Cod_Resposta = 1;
                resp.Userid = Membership.GetUser().ProviderUserKey.ToString();
                resp.XMLResposta = fileRespXML;
                resp.DataResposta = DateTime.Now.Date;
                resp.Status = 'A'; // A-Agendado
                resp.Cod_Exame = 1; //Obter automaticamente da prova
                RespostaAD.Inserir(resp);
            }
            else
                lblFinish.Text = str_lblFinish;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void Wizard1_FinishButtonClick(object sender, EventArgs e)
    {
        string encerrar = "ok";
        string x;

        Wizard wz = (Wizard)sender;

        for (int i = 1; i < wz.WizardSteps.Count; i++)
        {
            RadioButtonList rbl = wz.Controls[0].FindControl("rblRespostas" + i) as RadioButtonList;
            if (rbl.SelectedIndex != -1)
                x = rbl.SelectedItem.Text;
            else
                x = "erro";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void Wizard1_PreviousButtonClick(object sender, WizardNavigationEventArgs e)
    {
        lblNrQuestoesExame.Text = "Questão de " + (e.CurrentStepIndex).ToString() + " a " + qtdPerguntas.ToString();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_wz"></param>
    /// <returns></returns>
    protected string RetornaQuestoesNaoRespondidas(Wizard _wz)
    {
        string questoes = "";
        for (int i = 1; i < _wz.WizardSteps.Count; i++)
        {
            RadioButtonList rbl = _wz.Controls[0].FindControl("rblRespostas" + i) as RadioButtonList;

            if (rbl.SelectedIndex == -1)
                questoes += "Questão " + i + "<br />";
        }

        return questoes;
    }

    protected ArrayList RetornaPerguntas()
    {
        ArrayList questoes = new ArrayList();
        foreach (DataRow drPerguntas in dtPerguntas.Rows)
        {
            Pergunta pergunta = new Pergunta(drPerguntas["Perguntas"].ToString());
            questoes.Add(pergunta);
        }
        return questoes;
    }
}