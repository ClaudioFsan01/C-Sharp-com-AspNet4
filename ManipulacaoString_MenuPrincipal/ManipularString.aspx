<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManipularString.aspx.cs" Inherits="ManipulacaoString_MenuPrincipal.ManipularString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>
&nbsp;
        <br />
    </p>
    <form id="form1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Manipulando Strings"></asp:Label>
        
        <div>

            <br />
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 50px" Width="249px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="Button1Maiusculo" runat="server" OnClick="Button1_Click" Text="Maiusculo" Width="72px" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Minusculo" Width="85px" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" style="margin-left: 0px" Text="Substring" Width="80px" />
&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Indexof" Width="88px" />
&nbsp;
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="StartsWhith" Width="67px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="EndsWhith" Width="73px" />
&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="PadLeft" Width="71px" />
&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="PadRight" Width="76px" />
&nbsp;
            <asp:Button ID="Button9" runat="server" Height="25px" OnClick="Button9_Click" Text="Trim" Width="67px" />
&nbsp;
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="TrimStart" Width="74px" />
&nbsp;&nbsp;<asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="TrimEnd" Width="75px" />
            <br />
&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;
            <asp:Button ID="Button12Split" runat="server" OnClick="Button12Split_Click" Text="Split" Width="66px" />
&nbsp;
            <asp:Button ID="Button12Join" runat="server" OnClick="Button12Join_Click" Text="Join" Width="57px" />
&nbsp;&nbsp;
            <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="String c/ Param" Width="99px" />
&nbsp;&nbsp;
            <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="String c/ numeros" Width="132px" />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2Resultado" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
