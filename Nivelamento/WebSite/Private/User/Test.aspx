<%@ Page Title="" Language="C#" MasterPageFile="~/Private/User/MasterTest.master" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Private_User_Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link href="../../Estilos/estilos.css" rel="stylesheet" type="text/css" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="width: 650px; height: 400px; margin:0px auto;">

        <div style="background-color: Silver; height: 40px; width: 650px; padding:10px">
            <div style="width: 60%; float: left; color: White;">
                <div>
                    <asp:Label ID="lblNome" runat="server"></asp:Label>
                </div>
               
            </div>
            <div style="width: 40%; text-align: right; float: left;">
                <div style="font-size:18px">Tempo Restante:</div>
                <div style="font-size:15px"><asp:Label ID="lblNrQuestoesExame" runat="server" Font-Bold="true"></asp:Label></div>
            </div>
        </div>
        <div>
            <asp:Panel ID="pnlExame" runat="server">
            </asp:Panel>
        </div>

    </div>

</asp:Content>

