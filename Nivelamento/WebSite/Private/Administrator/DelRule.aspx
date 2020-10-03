<%@ Page Language="C#" MasterPageFile="~/Private/Administrator/MasterAdmin.master" AutoEventWireup="true" CodeFile="DelRule.aspx.cs" Inherits="Private_Administrator_DelRule" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:24px;padding:5px; border:solid 1px #F9F9F9; font-size:15px; font-weight:bold">
        Regras</div>

   <div style="height:30px;padding:5px; border:solid 1px #F9F9F9; background-color:#F9F9F9">
    Atenção: Ao excluir uma regra os usuários que estiverem fazendo parte da mesma serão automaticamente excluídos.
   </div>
    <br />
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td>
                <asp:Label ID="lblConfirmacao" runat="server" 
                    Text="Tem certeza que deseja excluir a Regra abaixo?"></asp:Label></td>
        </tr>
    </table>
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td>
                <asp:Label ID="lblNome" runat="server" Font-Bold="True"></asp:Label></td>
        </tr>
    </table>
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td>
                <br />
                &nbsp;<asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click"
                    Text="Cancelar" Width="90px" AccessKey="C" CssClass="Buttons" />
                &nbsp;<asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click"
                    Text="Confirmar" Width="90px" AccessKey="N" CssClass="Buttons" /><br />
                &nbsp;<asp:Label ID="lblSucesso" runat="server" ForeColor="Green" Text="Regra excluída com sucesso."
                    Visible="False"></asp:Label><br />
                &nbsp;<asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click"
                    Text="Voltar" Visible="False" Width="90px" AccessKey="V" CssClass="Buttons" /></td>
        </tr>
    </table>

</asp:Content>

