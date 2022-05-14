<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <style> body { background-image: url('Jp9x.gif'); } </style>
    <form id="form1" runat="server">
        <h1 style="text-align:center;font-family:'Comic Sans MS';">uwu-ify</h1>
        <i><h4 style="text-align:center;font-family:'Comic Sans MS';">(´• ω •`)</h4></i>
        <i><h3 style="text-align:center;font-family:'Comic Sans MS';">pls dont take me seriously</h3></i>
        <div>
            <div>
                <h5 style="text-align:center;font-family:'Comic Sans MS';">enter your message to uwu</h5>
                <p style="text-align:center;font-family:'Comic Sans MS';">
                    <asp:TextBox ID="TextBox1" runat="server" style="text-align:center;font-family:'Comic Sans MS';" Width="850px">hello world</asp:TextBox>
                </p>
                <p style="text-align:center;font-family:'Comic Sans MS';">
                    <asp:Button ID="Button1" runat="server" style="text-align:center;font-family:'Comic Sans MS';" Text="uwu me" OnClick="Button1_Click" />
                </p>
                <p style="text-align:center;font-family:'Comic Sans MS';">
                    &nbsp;</p>
                <h5 style="text-align:center;font-family:'Comic Sans MS';">your uwu'd message</h5>
                <p style="text-align:center;font-family:'Comic Sans MS';">
                    <asp:TextBox ID="TextBox2" runat="server" style="text-align:center;font-family:'Comic Sans MS';" Width="850px"></asp:TextBox>
                </p>
                <br />
            </div>
        </div>
    </form>
</body>
</html>
