<%@ Page Language="C#" AutoEventWireup="true" CodeFile="G2415_Index.aspx.cs" Inherits="G2415_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="Img/Capture.PNG" /> </br>
        Markus Mikkola, G2415 </br>
        <asp:HyperLink ID="hlPisteet" runat="server" Text="Pisteet" NavigateUrl="~/G2415_Pisteet.aspx"></asp:HyperLink>
        <asp:HyperLink ID="Tehtava2" runat="server" Text="Pisteet" NavigateUrl="~/G2415_T2.aspx"></asp:HyperLink>
        <asp:HyperLink ID="Tehtava3" runat="server" Text="Pisteet" NavigateUrl="~/G2415_T3.aspx"></asp:HyperLink>
        <asp:HyperLink ID="Tehtava4" runat="server" Text="Pisteet" NavigateUrl="~/G2415_T4.aspx"></asp:HyperLink>
    </div>
    </form>
</body>
</html>
