<%@ Page Title="" Language="C#" MasterPageFile="~/Private/Supervisor/MasterSupervisor.master" AutoEventWireup="true" CodeFile="ListAnswers.aspx.cs" Inherits="Private_Supervisor_ListAnswers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:24px;padding:5px; border:solid 1px #F9F9F9; font-size:15px; font-weight:bold">
        <span>Respostas</span>
        <span  style="padding-left:20px;text-align:right">    
        <asp:DropDownList ID="DdlExame" runat="server" DataTextField="Nome" 
            DataValueField="CodExame" AutoPostBack="True" 
            onselectedindexchanged="DdlExame_SelectedIndexChanged" />

        </span>
    </div>

    <div style="height:30px;padding:5px; border:solid 1px #F9F9F9; background-color:#F9F9F9">
    Pesquisar por:
    
        <asp:DropDownList ID="ddlCriterio" runat="server">
            <asp:ListItem>Nome</asp:ListItem>
            <asp:ListItem>Status</asp:ListItem>
            <asp:ListItem>Intervalo de Datas</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="txtArgumento" runat="server"></asp:TextBox>
<asp:ImageButton ID="imgBtnBusca" runat="server" 
            ImageUrl="~/Images/btn_search-blue.png" ImageAlign=AbsMiddle />
    
    </div>
    <br />
    
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
            
            <asp:templateField runat="server" HeaderStyle-Width="20px" >
                <itemTemplate>
                    <asp:linkButton runat="server" id="linkButton1" text="<img src='../../Images/page_white_put.png' border='0'>" commandArgument='<%# "?CodResposta=" + DataBinder.Eval(Container.DataItem, "CodResposta") + "&UserId=" + DataBinder.Eval(Container.DataItem, "UserId") %>' commandName="Download" onCommand='LinkButtonClick'/>
                </itemTemplate>                        
            </asp:templateField>            

             <asp:templateField runat="server" HeaderStyle-Width="20px" >
                <itemTemplate>
                    <asp:linkButton runat="server" id="linkButton2" text="<img src='../../Images/page_edit.png' border='0'>" commandArgument='<%# "?CodResposta=" + DataBinder.Eval(Container.DataItem, "CodResposta") + "&UserId=" + DataBinder.Eval(Container.DataItem, "UserId") %>' commandName="AddNotes" onCommand='LinkButtonClick'/>
                </itemTemplate>                        
            </asp:templateField> 

            <asp:BoundField DataField="Nome"  HeaderText="Nome">
                <HeaderStyle HorizontalAlign="Left"  />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>      
 
            <asp:BoundField DataField="Status"  HeaderText="Status">
                <HeaderStyle HorizontalAlign="Left"  />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>      
           
            <asp:TemplateField HeaderStyle-Width="60px">
                <ItemTemplate>
                    <asp:Label ID="Lbl_pendenciaChefe" runat="server" Text="" />
                </ItemTemplate>
                <HeaderStyle Width="60px" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>                           
            
            <asp:BoundField DataField="DataResposta"  HeaderText="Data de Resposta" HeaderStyle-Width="160px">
                <HeaderStyle HorizontalAlign="Left"  />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>                                            
            
                                                  
            </Columns>
    </asp:GridView>    
 


</asp:Content>

