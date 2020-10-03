<%@ Page Title="" Language="C#" MasterPageFile="~/Private/User/MasterTest.master" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Private_User_Welcome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
    .aviso{
	    font: icon;
 	    padding:10px; 
	    background-color:#FFFFFF; 
	    border:solid 1px #FFCC00; 
    }

    .aviso #cultura{
        font-size: 15px;
	    font-weight:bold;
    }
    .aviso #nivelamento{
        font-size: 18px;
	    font-weight:bold;
    }

    </style>
    <br /><br />
<table width="500px" align="center" border="0" class="aviso">
<tr>
<td>
          <strong>
          <img  src="../../Images/notes.gif" align="absmiddle" hspace="5px" />INSTRU&Ccedil;&Otilde;ES</strong><br />
          <br />
        Bem-vindo, 
          <asp:Label ID="lblNome" runat="server" Font-Bold="True"></asp:Label>
          <br />
        <br />
        Antes de começar a prova leia atentatemente as seguintes orientações:</p>
        <ul>
          <li>Se o cliente exceder o limite de 20 minutos para prova infantil ou 30 minutos para 
              a prova adulta o sistema encerra a prova automaticamente</li>
          <li>Caso erre 5 questões consecutivas o sistema encerra a prova automaticamente</li>
          <li>O resultado da prova 
            será enviado para o 
            departamento de supervisão de nossa escola.
          </li>
        </ul>
        <table width="100%" border="0">
        <tr>
        <td style="width:200px">
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Li e estou ciente. " 
                AutoPostBack="True" oncheckedchanged="CheckBox1_CheckedChanged" />
        </td>
        <td>
            <asp:Button ID="btnIniciar" runat="server" Text="Iniciar" Width="80px" 
                Enabled="False" onclick="btnIniciar_Click" />
        </td>
        </tr>
        </table>
</td>
</tr>
 

</table>
</asp:Content>

