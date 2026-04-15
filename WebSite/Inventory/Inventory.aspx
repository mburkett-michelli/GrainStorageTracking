<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Inventory.aspx.cs" Inherits="Inventory_Inventory" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
 
    <div class="row text-center">
 
         <div class="col-md-12" >
          <h2 >Current Inventory</h2>
          <p><asp:LinkButton ID="LinkButton2"  class="btn btn-primary btn-lg "  runat="server" PostBackUrl="~/Inventory/Inventory.aspx">Update</asp:LinkButton></p>
          <p><asp:Label ID="lblTime" runat="server" Text=""></asp:Label></p>
        </div>
    </div>
    <div class="row text-center">
         <div class="col-md-12 row text-center" >
  

        <asp:GridView style="width: 274px;" class="row text-center" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="sqlInventory" ShowHeader="False">
            <Columns>
                <asp:TemplateField HeaderText="" SortExpression="Percent_Full" ItemStyle-VerticalAlign="Bottom">
                    <ItemTemplate  >
                        <div style="z-index: 0 ; position: relative  ; width: 274px; height: 395px">
                            <img alt="Bin" src="../Image/Bin.png" style=" width: 274px; height: 395px" />
                            <div style="z-index: -1; position: absolute; top: <%# Eval("GraphTop") %>; width: 274px; height:<%# Eval("GraphHeight") %>; background-color: #00FF00">
                            </div>
                            
                             <div class="row text-center"  style="position: absolute; top: 100px; width: 274px;" >
                                 
                                     <div><strong><%# Eval("Bin_Description") %></strong></div>
                                     <div>CAPACITY (bu)</div>
                                     <div><strong><%# Eval("Capacity","{0:N0}") %></strong></div>
                                     <div>CURRENT (bu)</div>
                                     <div><strong><%# Eval("Current_Bushels", "{0:N0}") %></strong></div>
                                     <div>Percent Full</div>
                                     <div><strong><%# Eval("Percent_Full" , "{0:N0}%") %></strong></div>

                                     
                                 
                            </div>

                        </div> 
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        
        <asp:SqlDataSource ID="sqlInventory" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT Bin_Description, Recieving_Net, Capacity, Starting_Bushels, Shipping_Net, Current_Weight, Variety, Bushel_Wt, Current_Bushels, Percent_Full, STR(CONVERT (int, Percent_Full * .01 * 295)) + 'px' AS GraphHeight, STR(95 + (295 - CONVERT (int, Percent_Full * .01 * 295))) + 'px' AS GraphTop FROM vw_Inventory Order By Bin_Description"></asp:SqlDataSource>


             


             </div>
        

    </div>
    
</asp:Content>

