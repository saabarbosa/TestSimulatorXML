<%@ Page Title="" ValidateRequest="false" Language="C#" MasterPageFile="~/Private/Supervisor/MasterSupervisor.master" AutoEventWireup="true" CodeFile="Download.aspx.cs" Inherits="Private_Supervisor_Download" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div style="height:24px;padding:5px; border:solid 1px #F9F9F9; font-size:15px; font-weight:bold">
        Download da Prova</div>

   <div style="height:30px;padding:5px; border:solid 1px #F9F9F9; background-color:#F9F9F9">
    Obs: Para baixar o arquivo gerado clique no botão abaixo Download.
   </div>
    <br />
      
    <asp:TextBox ID="txtXmlResposta" runat="server" Height="400px" 
         ReadOnly="True" TextMode="MultiLine" 
        Width="600px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Download" Width="80px" 
        onclick="Button1_Click" />&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Cancelar" 
        CausesValidation="False" onclick="Button2_Click" Width="80px" />
</asp:Content>

