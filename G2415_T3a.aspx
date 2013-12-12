<%@ Page Language="C#" AutoEventWireup="true" CodeFile="G2415_T3a.aspx.cs" Inherits="G2415_T3a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tunnit" runat="server" AutoGenerateColumns="true"></asp:GridView>

        Käyttäjänimi: <asp:TextBox ID="txtboxKayttaja" runat="server"></asp:TextBox>
        Päiväys: <asp:TextBox ID="txtboxDate" runat="server" ></asp:TextBox> <br />

        Tunnit: <asp:TextBox ID="txtboxTunnit" runat="server"></asp:TextBox>
        Minuutit: <asp:TextBox ID="txtbotMinuutit" runat="server"></asp:TextBox>
        <asp:Button runat="server" ID="btnKirjaa" Text="Kirjaa merkinta" OnClick="btnLisaa"/>

    </div>
    </form>
</body>
</html>
