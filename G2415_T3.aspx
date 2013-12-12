<%@ Page Language="C#" AutoEventWireup="true" CodeFile="G2415_T3.aspx.cs" Inherits="G2415_T3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="Img/funnypicture.jpg" />
        <h1>PuolipilkunViilaajat</h1>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" FailureText="Username ans password did not match!"></asp:Login>
    </div>
    </form>
</body>
</html>
