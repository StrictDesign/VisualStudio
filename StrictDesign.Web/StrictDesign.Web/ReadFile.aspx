<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadFile.aspx.cs" Inherits="StrictDesign.Web.ReadFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        ReadFile
        <br />
        <asp:Button ID="btnReadFile" runat="server" Text="Read File" OnClick="btnReadFile_Click" />
        <br /><br />
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
