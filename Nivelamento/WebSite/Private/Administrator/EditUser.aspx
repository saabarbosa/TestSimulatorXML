<%@ Page Language="C#" MasterPageFile="~/Private/Administrator/MasterAdmin.master" AutoEventWireup="true" CodeFile="EditUser.aspx.cs" Inherits="Private_Administrator_EditUser" Title="" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:24px;padding:5px; border:solid 1px #F9F9F9; font-size:15px; font-weight:bold">
        Usuário</div>

   <div style="height:30px;padding:5px; border:solid 1px #F9F9F9; background-color:#F9F9F9">
        Obs: Sem comentários.
   </div>
    <br />

    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td>
                <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
                    <tr>
                        <td style="width: 98px">
                            Login</td>
                        <td>
                            <asp:TextBox ID="txtLogin" runat="server" Width="200px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 98px">
                            E-mail</td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox></td>
                    </tr>
                    <tr>                        
                        <td colspan="2">
                            <asp:checkbox runat="server" id="ActiveUser" text="Ativo" checked="true"/>
                        </td>
                    </tr>
                </table>                
            </td>
            <td height="100%">
                <table  borderwidth="1px" cellpadding="0" cellspacing="0" height="100%" width="100%">                    
                    <tr valign="top" height="100%">
                        <td height="100%">
                            <asp:panel runat="server" id="panel1" scrollbars="auto" valign="top">
                                <br/>
                                <asp:repeater runat="server" id="CheckBoxRepeater">
                                    <itemtemplate>
                                        <asp:checkbox runat="server" id="checkBox1" text='<%# Container.DataItem.ToString()%>' checked='<%# (bool)Roles.IsUserInRole((string) CurrentUser, (string) Container.DataItem.ToString())%>'/>
                                        <br/>
                                    </itemtemplate>
                                </asp:repeater>
                            </asp:panel>
                        </td>
                    </tr>
                </table>    
            </td>
        </tr>
    </table>        
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td style="width: 98px; height: 26px">
            </td>
            <td style="height: 26px">
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                    onclick="btnCancelar_Click" AccessKey="C" CssClass="Buttons" />
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar alterações" 
                    onclick="btnSalvar_Click" AccessKey="N" CssClass="Buttons" />
            </td>
        </tr>
    </table>

</asp:Content>

