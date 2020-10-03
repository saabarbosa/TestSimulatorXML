<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="~/Style.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .style1
        {
            text-align: center;
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

    <table style="width: 500px" align="center" bgcolor="#ffffff">
        <tr>

            <td style="width: 50%; vertical-align:text-top; padding:10px; text-align:right">
      
  
    
        <asp:Login ID="Login1" runat="server"  
        PasswordRecoveryText="Esqueceu sua senha? Clique aqui." 
        CreateUserText="Você ainda não possui conta? Clique aqui." 
        CreateUserUrl="~/CreateUser.aspx" 
        DestinationPageUrl="" 
        FailureAction="RedirectToLoginPage" 
        FailureText="Sua tentativa de login não foi aceita. Por favor, tente novamente." 
        LoginButtonText="Entrar" 
        MembershipProvider="AspNetSqlMembershipProviderCulturaInglesa" 
        onloggedin="Login1_LoggedIn" 
        PasswordLabelText="Senha:" PasswordRecoveryUrl="~/PasswordRecovery.aspx" 
        PasswordRequiredErrorMessage="Senha é requerido." TitleText="Autenticação" 
        UserNameLabelText="Usuário:" 
        UserNameRequiredErrorMessage="Usuário é requerido.">
          <LayoutTemplate>
              <table cellpadding="2" cellspacing="0">
                  <tr>
                      <td>

                          <table cellpadding="0" width="250px" height="180px" >
                              <tr>
                                  <td align="right" width="70px">
                                      <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuário:</asp:Label>
                                  </td>
                                  <td style="width:180px">
                                      <asp:TextBox ID="UserName" runat="server" Height="20px" Width="150px"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                          ControlToValidate="UserName" ErrorMessage="Usuário requerido." 
                                          ToolTip="Usuário requerido." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                  </td>
                              </tr>
                              <tr><td></td></tr>
                              <tr>
                                  <td align="right" width="90px">
                                      <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Senha:</asp:Label>
                                  </td>
                                  <td>
                                      <asp:TextBox ID="Password" runat="server" Height="20px" TextMode="Password" Width="150px"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                          ControlToValidate="Password" ErrorMessage="Senha requerida." 
                                          ToolTip="Senha requerida." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                  </td>
                              </tr>
                              <tr>
                                  <td colspan="2">
                                      <asp:CheckBox ID="RememberMe" runat="server" Text="Lembrar-me neste computador." />
                                  </td>
                              </tr>
                              <tr>
                                  <td align="center" colspan="2" style="color:Red;">
                                      <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right" colspan="2">
                                      <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Entrar" 
                                          ValidationGroup="Login1" Width="65px" />
                                  </td>
                              </tr>
                              <tr>
                                  <td colspan="2">
                                      <asp:HyperLink ID="CreateUserLink" runat="server" 
                                          NavigateUrl="~/CriarUsuario.aspx">Você ainda não possui conta? Clique aqui.</asp:HyperLink>
                                      <br />
                                      <asp:HyperLink ID="PasswordRecoveryLink" runat="server" 
                                          NavigateUrl="~/PasswordRecovery.aspx">Esqueceu sua senha? Clique aqui.</asp:HyperLink>
                                  </td>
                              </tr>
                          </table>


                      </td>
                  </tr>
              </table>
          </LayoutTemplate>
    </asp:Login>
      
  
    
            </td>
            <td style="width: 50%; vertical-align:top; padding:10px; " class="style1">
                <br />
                <br />
                <br />
                <br />
                LOGOMARCA DO 
                <br />
                SISTEMA DE NIVELAMENTO<br />
                
            </td>
        </tr>
    </table>


     
    </form>
</body>
</html>
