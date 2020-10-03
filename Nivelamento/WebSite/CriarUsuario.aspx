<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CriarUsuario.aspx.cs" Inherits="CriarUsuario" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="~/Style.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .style1
        {
            text-align: left;
            font-weight: bold;
        }
        .style2
        {
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td><img src="Images/logo.png" alt="logo" width="286" height="100" /></td>
  </tr>
</table>
<br />
    <div>
        <asp:ToolkitScriptManager ID="Scriptmanager1" runat="server"></asp:ToolkitScriptManager>
        <table  width="600px" align="center" bgcolor="#ffffff">
            <tr>
                <td colspan="2" class="style1">
                    Efetuar Cadastro</td>
            </tr>

            <%--Dados do usuário--%>

            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="lblNome" runat="server">Nome:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" Width="350px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NomeRequired" runat="server" 
                        ControlToValidate="txtNome" ErrorMessage="Nome é requerido." 
                        ToolTip="Nome é requerido." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="lblDataNascimento" runat="server">Data Nascimento:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="DataNascimentoRequired" runat="server" 
                        ControlToValidate="txtDataNascimento" ErrorMessage="Data Nascimento é requerido." 
                        ToolTip="Data Nascimento é requerido." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                    <asp:CalendarExtender TargetControlID="txtDataNascimento"
                            ID="ceDtNascimento" runat="server" DaysModeTitleFormat="dd/MM/yyyy" 
                            TodaysDateFormat="dd/MM/yyyy"></asp:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="lblEscolaridade" runat="server">Escolaridade:</asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEscolaridade" runat="server">
                        <asp:ListItem Value="1">Fundamental</asp:ListItem>
                        <asp:ListItem Value="2">Médio</asp:ListItem>
                        <asp:ListItem Value="3">Superior</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="EscolaridadeRequired" runat="server" 
                        ControlToValidate="ddlEscolaridade" ErrorMessage="Escolaridade é requerida." 
                        ToolTip="Escolaridade é requerida." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="lblFoneFixo" runat="server">Telefone Fixo:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFoneFixo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="FoneFixoRequired" runat="server" 
                        ControlToValidate="txtFoneFixo" ErrorMessage="Telefone fixo é requerido." 
                        ToolTip="Telefone fixo é requerido." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="lblFoneCel" runat="server">Celular:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFoneCel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="lblEstudouIngles" runat="server">Estudou Inglês:</asp:Label>
                </td>
                <td>
                    <asp:CheckBox runat="server" ID="chkEstudouIngles" AutoPostBack="True" 
                        oncheckedchanged="chkEstudouIngles_CheckedChanged" />
                </td>
            </tr>
             <asp:Panel ID="Panel1" runat="server" Width="100%" Visible="false">
                   
            <tr>
                <td align="right" class="style2">
                    &nbsp;</td>
                <td>
                    
                    <asp:Label ID="lblEscolaEstIng" runat="server">Escola onde estudou:</asp:Label>
                    <br />
                    <asp:TextBox ID="txtEscolaEstIng" runat="server" Width="250px"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblAno" runat="server">Ano que estudou:</asp:Label>
                    <br />
                    <asp:TextBox ID="txtAno" runat="server" Width="50px"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblEstagioEstIngles" runat="server">Estágio que estudou:</asp:Label>
                    <br />
                    <asp:TextBox ID="txtEstagioEstIngles" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            </asp:Panel>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="lblMotivo" runat="server">Motivo:</asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMotivo" runat="server">
                        <asp:ListItem Value="Vestibular">Vestibular</asp:ListItem>
                        <asp:ListItem Value="Concurso">Concurso</asp:ListItem>
                        <asp:ListItem Value="Mestrado">Mestrado</asp:ListItem>
                        <asp:ListItem Value="Negocios">Negócios</asp:ListItem>
                        <asp:ListItem Value="SegundaLingua">Segunda Língua</asp:ListItem>
                        <asp:ListItem Value="ExameCambridge">Exame Cambridge</asp:ListItem>
                        <asp:ListItem>Outros</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2" colspan="2">
                    <hr size="1" width="100%" noshade=noshade /></td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="UserNameLabel" runat="server">Login:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                        ControlToValidate="UserName" ErrorMessage="User Name is required." 
                        ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="PasswordLabel" runat="server">Senha:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                        ControlToValidate="Password" ErrorMessage="Informe uma senha." 
                        ToolTip="Informe uma senha." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="ConfirmPasswordLabel" runat="server">Confirme a senha:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" 
                        ControlToValidate="ConfirmPassword" 
                        ErrorMessage="É preciso confirma a senha." 
                        ToolTip="É preciso confirma a senha." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Email" runat="server" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailRequired" runat="server" 
                        ControlToValidate="Email" ErrorMessage="Informe um Email." 
                        ToolTip="Informe um Email." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- Dados do Login -->
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="QuestionLabel" runat="server">Pergunta de Segurança:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Question" runat="server" Width="350px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" 
                        ControlToValidate="Question" ErrorMessage="Informe uma pergunta de segurança." 
                        ToolTip="Informe uma pergunta de segurança." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="AnswerLabel" runat="server">Resposta:</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Answer" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" 
                        ControlToValidate="Answer" ErrorMessage="Informe a resposta." 
                        ToolTip="Informe a resposta." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Button runat="server" ID="btnSalvar" Text="Salvar" 
                        ValidationGroup="CreateUserWizard1" onclick="btnSalvar_Click" />
                </td>
                <td align="left">
                    &nbsp;<asp:Button runat="server" ID="btnCancelar" Text="Cancelar" 
                        CausesValidation="False" onclick="btnCancelar_Click" 
                        />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:CompareValidator ID="PasswordCompare" runat="server" 
                        ControlToCompare="Password" ControlToValidate="ConfirmPassword" 
                        Display="Dynamic" 
                        ErrorMessage="A senha e confirmação da senha devem ser compatíveis." 
                        ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2" style="color:Red;">
                    <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                    <br />
            <asp:Label ID="lblMsg" runat="server" style="text-align: center"></asp:Label>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </div>
    </form>
</body>
</html>
