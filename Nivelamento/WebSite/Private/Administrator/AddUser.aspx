<%@ Page Language="C#" MasterPageFile="~/Private/Administrator/MasterAdmin.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="Private_Administrator_AddUser" Title="" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:24px;padding:5px; border:solid 1px #F9F9F9; font-size:15px; font-weight:bold">
        Usuários</div>

   <div style="height:30px;padding:5px; border:solid 1px #F9F9F9; background-color:#F9F9F9">
    Obs: Ao criar um novo usuário associe a uma regra.
   </div>
    <br />

    <table>
        <tr>
            <td>
                <table cellspacing="0" cellpadding="5" class="lrbBorders">                    
                    <tr >
                        <td>
                            <asp:CreateUserWizard ID="createUser" runat="server" 
                                oncreateduser="CreatedUser">
                                <WizardSteps>
                                    <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                                    </asp:CreateUserWizardStep>
                                    <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                                    </asp:CompleteWizardStep>
                                </WizardSteps>
                            </asp:CreateUserWizard>
                        </td>
                    </tr>
                </table>
            </td>
            <td height="100%">
                <table  borderwidth="1px" cellpadding="0" cellspacing="0" height="100%" width="100%">                    
                    <tr valign="top" height="100%">
                        <td  class="userDetailsWithFontSize" height="100%">
                            <asp:panel runat="server" id="panel1" scrollbars="auto" valign="top">
                                <br/>
                                <asp:repeater runat="server" id="checkBoxRepeater">
                                    <itemtemplate>
                                        <asp:checkbox runat="server" id="checkBox1" text='<%# Container.DataItem.ToString()%>' />
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
</asp:Content>

