<%@ Page Title="" Language="C#" MasterPageFile="~/Private/Supervisor/MasterSupervisor.master" AutoEventWireup="true" CodeFile="AddNotes.aspx.cs" Inherits="Private_Supervisor_AddNotes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    <div style="height:24px;padding:5px; border:solid 1px #F9F9F9; font-size:15px; font-weight:bold">
        Anotações</div>

   <div style="height:30px;padding:5px; border:solid 1px #F9F9F9; background-color:#F9F9F9">
    Obs: Adicione comentários sobre esta prova.
   </div>
    &nbsp;
    <asp:DropDownList ID="ddlStatus" runat="server">
        <asp:ListItem Value="A">Agendado</asp:ListItem>
        <asp:ListItem Value="M">Matriculado</asp:ListItem>
        <asp:ListItem Value="N">Não Matriculado</asp:ListItem>
    </asp:DropDownList>
    <br />
  
   &nbsp;&nbsp;
<br />
<asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
    <div style="padding:6px; width:600px">
        <asp:Label ID="LblObs" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Observacao") %>'></asp:Label><br />
        <asp:Label ID="LblNomeFuncionario" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "NomeFuncionario") %>'></asp:Label>&nbsp;[
        <asp:Label ID="LblDataLog" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "DataLog") %>'></asp:Label>]
    </div>
    </ItemTemplate>
    <SeparatorTemplate>
        <hr />
    </SeparatorTemplate>
</asp:Repeater>
    
   <br />
   &nbsp;
   <asp:TextBox ID="txtObs" runat="server" Height="200px" 
         TextMode="MultiLine" 
        Width="600px"></asp:TextBox>
        <br />
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Ok" Width="80px" 
        onclick="Button1_Click" />&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Cancelar" 
        CausesValidation="False" onclick="Button2_Click" Width="80px" />

</asp:Content>

