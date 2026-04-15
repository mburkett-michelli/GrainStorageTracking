<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <center>


    <div class="row text-center navbar-inverse">
        <div class="col-md-12 text-center" >
            <img src="Image\Eckhart%20Farms%20Logo.png" />
        </div>
    </div>


  <div class="text-center" >

       <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
      
    </div>
  <div class="row text-center">
        

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
