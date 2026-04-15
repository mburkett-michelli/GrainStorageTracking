<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="User_Logins.aspx.cs" Inherits="AdminPages_User_Logins" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class= "row text-center">
        <h3>Current Inventory</h3>

    </div>
    <div class="row"> 
       <div class="col-md-4">
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table" DataKeyNames="UserName" DataSourceID="sqlLoginNames">
               <Columns>
                   <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                   <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" />
                   <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
               </Columns>
           </asp:GridView>
        </div>
    </div>






               
           
                <asp:SqlDataSource ID="sqlLoginNames" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" DeleteCommand="DELETE FROM [AspNetUsers] WHERE [Id] = @Id" InsertCommand="INSERT INTO [AspNetUsers] ([Id], [UserName]) VALUES (@Id, @UserName)" SelectCommand="SELECT [Id], [UserName] FROM [AspNetUsers] ORDER BY [UserName]" UpdateCommand="UPDATE [AspNetUsers] SET [UserName] = @UserName WHERE [Id] = @Id">
                    <DeleteParameters>
                        <asp:Parameter Name="Id" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Id" Type="String" />
                        <asp:Parameter Name="UserName" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="UserName" Type="String" />
                        <asp:Parameter Name="Id" Type="String" />
                    </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

