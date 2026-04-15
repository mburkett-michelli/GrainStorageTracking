<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="LoginHome.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <center>


            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick"></asp:Timer>
    <div class="row text-center navbar-inverse">
        <div class="col-md-12 text-center" >
            <img src="Eckhart%20Farms%20Logo.png" />
        </div>
    </div>


  <div class="text-center" >

       <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
      
    </div>
  <div class="row text-center">
        <div class="col-md-5">
            <p>
                <asp:Image ID="ImageIn" runat="server" AlternateText="No Image " ImageUrl="~/Image/Inbound.jpg" OnPreRender="ImageIn_PreRender" />
            </p>
        </div>
        <div class="col-md-2" >
          <p><asp:LinkButton ID="LinkButton1"  class="btn btn-primary btn-lg "  runat="server" OnClick="LinkButton1_Click">Update Picture</asp:LinkButton></p>
            <p><asp:LinkButton ID="LinkButton2"  class="btn btn-primary btn-lg "  runat="server" PostBackUrl="~/Inventory/Inventory.aspx">View Inventory</asp:LinkButton></p>
            <p><asp:LinkButton ID="LinkButton3"  class="btn btn-primary btn-lg "  runat="server" PostBackUrl="~/Reports/Report_Main.aspx">View Reports</asp:LinkButton></p>
        </div>
        <div class="col-md-5">
            <p>
                <asp:Image ID="ImageOut" runat="server" AlternateText="No Image " ImageUrl="~/Image/Outbound.jpg" OnPreRender="ImageOut_PreRender" />
            </p>
        </div>

    </div>
    <div class="row">
            <a href="http://www.accuweather.com/en/us/osgood-id/83402/current-weather/2226932" class="aw-widget-legal">
    </div>
        <!--
        By accessing and/or using this code snippet, you agree to AccuWeather’s terms and conditions (in English) which can be found at http://www.accuweather.com/en/free-weather-widgets/terms and AccuWeather’s Privacy Statement (in English) which can be found at http://www.accuweather.com/en/privacy.
        -->
        </a><div id="awtd1457826580640" class="aw-widget-36hour text-center"  data-locationkey="2226932" data-unit="f" data-language="en-us" data-useip="false" data-uid="awtd1457826580640" data-editlocation="false"></div><script type="text/javascript" src="http://oap.accuweather.com/launch.js"></script>
</center>
        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
