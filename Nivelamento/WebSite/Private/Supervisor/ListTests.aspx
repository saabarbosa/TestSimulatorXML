<%@ Page Title="" Language="C#" MasterPageFile="~/Private/Supervisor/MasterSupervisor.master" AutoEventWireup="true" CodeFile="ListTests.aspx.cs" Inherits="Private_Supervisor_ListTests" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:24px;padding:5px; border:solid 1px #F9F9F9; font-size:15px; font-weight:bold">
        Exames</div>
    <table cellpadding="0" cellspacing="0" width="100%" border="0">
    <tr>
    <td style="width:200px; padding:5px">
    <asp:Button ID="btnNovo" runat="server" AccessKey="N" CssClass="Buttons" 
            Text="Importar" Width="70px" />
    </td>
     <td style="padding:5px; text-align:right">
&nbsp;</td>
    </tr>
    </table>

    
    <asp:GridView ID="GridView1" runat="server" Width="100%"
        EmptyDataText="<div style='padding:10px 10px 10px 10px; color: red'>Não há registro.</div>" AllowPaging="True" 
        onpageindexchanging="GridView1_PageIndexChanging" PageSize="20" 
        onrowcommand="GridView1_RowCommand" onrowediting="GridView1_RowEditing" 
        GridLines="None" AutoGenerateColumns="False"
        onrowdatabound="GridView1_RowDataBound">
         <PagerStyle HorizontalAlign="Center" />
         <HeaderStyle CssClass="HeaderGrid" HorizontalAlign="Left" />
         <RowStyle CssClass="RowGrid" />
          <AlternatingRowStyle CssClass="AlternatingRowGrid" />
         <Columns>
            
  
            <asp:BoundField DataField="Nome"  HeaderText="Nome">
                <HeaderStyle HorizontalAlign="Left"  />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>      
            
            <asp:BoundField DataField="XMLExamePath"  HeaderText="Path">
                <HeaderStyle HorizontalAlign="Left"  />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>   
                                                              
            </Columns>
    </asp:GridView>    
 


</asp:Content>

