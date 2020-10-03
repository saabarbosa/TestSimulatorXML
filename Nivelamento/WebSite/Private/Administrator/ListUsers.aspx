<%@ Page Language="C#" MasterPageFile="~/Private/Administrator/MasterAdmin.master" AutoEventWireup="true" CodeFile="ListUsers.aspx.cs" Inherits="Private_Administrator_ListUsers" Title="" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:24px;padding:5px; border:solid 1px #F9F9F9; font-size:15px; font-weight:bold">
        Usuários</div>

   <div style="height:30px;padding:5px; border:solid 1px #F9F9F9; background-color:#F9F9F9">
    Pesquisar por:
    
        <asp:DropDownList ID="ddlCriterio" runat="server">
            <asp:ListItem>Nome</asp:ListItem>
            <asp:ListItem>Login</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="txtArgumento" runat="server"></asp:TextBox>
<asp:ImageButton ID="imgBtnBusca" runat="server" 
            ImageUrl="~/Images/btn_search-blue.png" ImageAlign=AbsMiddle />
    
    </div>
    <br />

    <table cellpadding="0" cellspacing="0" width="100%" border="0">
    <tr>
    <td style="width:200px; padding:5px">
    <asp:Button ID="btnNovo" runat="server" AccessKey="N" CssClass="Buttons" 
            Text="Novo" Width="70px" onclick="btnNovo_Click" />
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
            
  
         <asp:templateField runat="server" headerText="Usuário" >
            <itemTemplate>
                <%# Container.DataItem %>                            
            </itemTemplate>                        
        </asp:templateField> 
        <asp:templateField runat="server" headerText="Editar" >
            <itemTemplate>
                <asp:linkButton runat="server" id="linkButton2" text="Editar" commandArgument='<%#Container.DataItem%>' commandName="EditUser" onCommand='LinkButton2Click'/>
            </itemTemplate>                        
        </asp:templateField>   
        <asp:templateField runat="server" headerText="Excluir" >
            <itemTemplate>
                <asp:linkButton runat="server" id="linkButton1" text="Excluir" commandArgument='<%#Container.DataItem%>' commandName="DelUser" onCommand='LinkButtonClick'/>
            </itemTemplate>                        
        </asp:templateField>                                           
          
                                                  
            </Columns>
    </asp:GridView>    
 
 </asp:Content>

