<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageMap ID="ImageMap1" runat="server" Height="1000px" 
            HotSpotMode="PostBack" ImageUrl="~/Img/back.jpg" Width="1000px">
            <asp:CircleHotSpot Radius="150" X="250" Y="269" />
            <asp:RectangleHotSpot Bottom="382" Left="900" Right="612" Top="109" />
            <asp:PolygonHotSpot Coordinates="486,420,775,602,691,930,352,951,226,637" />
        </asp:ImageMap>
    
    </div>
    </form>
</body>
</html>
