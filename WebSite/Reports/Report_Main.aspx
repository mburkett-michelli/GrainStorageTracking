<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Report_Main.aspx.cs" Inherits="Reports_Report_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td style="font-weight: bold">
                        <asp:Label ID="LabelStart" runat="server" Text="Start Date"></asp:Label>
                    </td>
                    <td style="font-weight: bold">
                        <asp:Label ID="LabelEnd" runat="server" Text="End Date"></asp:Label>
                    </td>
                    <td style="font-weight: bold"></td>
                    <td style="font-weight: bold"></td>
                    <td style="font-weight: bold"></td>
                    <td style="font-weight: bold"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Calendar ID="CalendarFrom" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" SelectedDate="<%# DateTime.Today %>" Width="330px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                            <DayStyle BackColor="#CCCCCC" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                            <TodayDayStyle BackColor="#999999" ForeColor="White" />
                        </asp:Calendar>
                    </td>
                    <td>
                        <asp:Calendar ID="CalendarTo" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" SelectedDate="<%# DateTime.Today %>" Width="330px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                            <DayStyle BackColor="#CCCCCC" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                            <TodayDayStyle BackColor="#999999" ForeColor="White" />
                        </asp:Calendar>
                    </td>
                    <td>
                        <table style="vertical-align: top">
                            <tr style="vertical-align: top">
                                <td>CUSTOMERS</td>
                                <td>
                                    <asp:DropDownList ID="CustomerLIst0" runat="server" DataSourceID="Customer0" DataTextField="text" DataValueField="value" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:SqlDataSource ID="Customer0" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT 'All Customers' AS text, NULL AS value UNION SELECT DISTINCT Customer AS text, Customer AS value FROM Customers ORDER BY value"></asp:SqlDataSource>

                                </td>
                            </tr>
                            <tr style="vertical-align: top">
                                <td>BINS</td>
                                <td>
                                    <asp:DropDownList ID="BinList0" runat="server" DataSourceID="Bin0" DataTextField="text" DataValueField="value" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:SqlDataSource ID="Bin0" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT 'All Bins' AS text, NULL AS value UNION SELECT DISTINCT Bin AS text, Bin AS value FROM Bins ORDER BY value"></asp:SqlDataSource>

                                </td>
                            </tr>
                            <tr style="vertical-align: top">
                                <td>VARIETIES</td>
                                <td>
                                    <asp:DropDownList ID="VarietyList" runat="server" DataSourceID="Varieties" DataTextField="text" DataValueField="value" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:SqlDataSource ID="Varieties" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT 'All Varieties' AS text, NULL AS value UNION SELECT DISTINCT Variety AS text, Variety AS value FROM Varieties ORDER BY value"></asp:SqlDataSource>

                                </td>
                            </tr>
                        </table>
                    </td>
                    <td></td>
                    <td>&nbsp;</td>
                    <td></td>
                </tr>
            </table>
        
            <p>
                
                <style type="text/css">
                    
                    #MainContent_ShippingView tbody tr th {
                        text-align: center;
                       }
                    
                </style>

                <asp:GridView ID="ShippingView" runat="server" AllowPaging="True"
                    AllowSorting="True" AutoGenerateColumns="False" CellPadding="6"
                    DataSourceID="Shipping" PageSize="100" ForeColor="#333333" Font-Size="Small">

                    <AlternatingRowStyle BackColor="White" />

                    <Columns>
                        <asp:BoundField DataField="Ticket" HeaderText="Ticket" SortExpression="Ticket" ApplyFormatInEditMode="False">
                            <ControlStyle Font-Underline="True" />
                            <HeaderStyle Font-Underline="False" Wrap="False" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID">
                            <HeaderStyle Wrap="False" />
                            <ItemStyle Wrap="False" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Time_In" HeaderText="Time In" SortExpression="Time_In" HeaderStyle-HorizontalAlign="Center">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle Wrap="False" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Time_Out" HeaderText="Time_Out" SortExpression="Time_Out">
                            <ItemStyle Wrap="False" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Truck_ID" HeaderText="Truck" ReadOnly="True" SortExpression="Truck_ID" />
                        <asp:BoundField DataField="Driver" HeaderText="Driver" ReadOnly="True" SortExpression="Driver" />
                        <asp:BoundField DataField="Variety" HeaderText="Variety" SortExpression="Variety" />
                        <asp:BoundField DataField="Load_Type" HeaderText="Load_Type" SortExpression="Load_Type" />
                        <asp:BoundField DataField="Customer" HeaderText="Customer" SortExpression="Customer">
                            <ItemStyle Wrap="False" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Gross" HeaderText="Gross" ReadOnly="True" SortExpression="Gross" />
                        <asp:BoundField DataField="Tare" HeaderText="Tare" ReadOnly="True" SortExpression="Tare" />
                        <asp:BoundField DataField="Net" HeaderText="Net" ReadOnly="True" SortExpression="Net" />
                        <asp:BoundField DataField="Bin" HeaderText="Bin" ReadOnly="True" SortExpression="Bin">
                            <ControlStyle Width="300px" />
                            <ItemStyle Wrap="False" />
                        </asp:BoundField>
                        <asp:CheckBoxField DataField="Driver_On" HeaderText="Driver_On" SortExpression="Driver_On">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:CheckBoxField>
                        <asp:BoundField DataField="WeighMaster" HeaderText="WeighMaster" ReadOnly="True" SortExpression="WeighMaster" />
                        <asp:BoundField DataField="Comments" HeaderText="Comments" ReadOnly="True" SortExpression="Comments" />
                    </Columns>

                    <EditRowStyle BackColor="#2461BF" />

                    <EmptyDataTemplate>
                        No Records Matching Filter
                    </EmptyDataTemplate>

                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Top" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />

                </asp:GridView>
                <asp:SqlDataSource ID="Shipping" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT Ticket, Time_In, Driver, WeighMaster, Truck_ID, Load_Type, Comments, In_Weight, Out_Weight, Net, Gross, Tare, Time_Out, Inbound_Picture, Outbound_Picture, Driver_On, Bin, ID, Customer, Variety FROM vwTicket_Information WHERE (Customer = ISNULL(@Customer, Customer)) AND (Bin = ISNULL(@Bin, Bin)) AND (Variety = ISNULL(@Variety, Variety)) AND (Time_Out IS NOT NULL) AND (DATEDIFF(day, ISNULL(@Start_Date, GETDATE()), Time_Out) &gt;= 0) AND (DATEDIFF(day, Time_Out, ISNULL(@End_Date, GETDATE())) &gt;= 0) ORDER BY Time_Out" CancelSelectOnNullParameter="False">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="CustomerLIst0" Name="Customer" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="BinList0" Name="Bin" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="VarietyList" Name="Variety" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="CalendarFrom" Name="Start_Date" PropertyName="SelectedDate" />
                        <asp:ControlParameter ControlID="CalendarTo" Name="End_Date" PropertyName="SelectedDate" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

