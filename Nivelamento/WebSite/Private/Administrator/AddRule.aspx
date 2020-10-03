<%@ Page Language="C#" MasterPageFile="~/Private/Administrator/MasterAdmin.master" AutoEventWireup="true" CodeFile="AddRule.aspx.cs" Inherits="Private_Administrator_AddRule" Title="" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:24px;padding:5px; border:solid 1px #F9F9F9; font-size:15px; font-weight:bold">
        Regras</div>

   <div style="height:30px;padding:5px; border:solid 1px #F9F9F9; background-color:#F9F9F9">
    Obs: Somente crie novas regras se realmente houver necessidade.
   </div>
    <br />


    <div>

    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Regra</td>
                <td>
                    <asp:TextBox ID="txtRegra" runat="server" Width="300px"></asp:TextBox></td>
            </tr>
        </table>
    
    </div>
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td style="width: 98px">
            </td>
            <td>
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                    onclick="btnCancelar_Click" AccessKey="C" CssClass="Buttons" />&nbsp;
                <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click"
                    Text="Salvar alterações" AccessKey="N" CssClass="Buttons" />
            </td>
        </tr>
    </table>
</asp:Content>

