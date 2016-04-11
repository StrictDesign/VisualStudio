<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="StrictDesign.Web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>StrictDesign Consulting AB</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        ReadFile
        <br />
        <asp:Button ID="btnReadFile" runat="server" Text="Read File" OnClick="btnReadFile_Click" />
        <br /><br />
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
        <hr />    
        <asp:Button ID="btnCheckNetwork" runat="server" Text="Check Network" OnClick="btnCheckNetwork_Click" />
        <hr />
        <asp:Button ID="btnSendMail" runat="server" Text="Send Mail" OnClick="btnSendMail_Click" />
        <br /><br />
        <asp:Label ID="lblSendMail" runat="server" Text=""></asp:Label>
        <hr />

    </div>
    </form>
</body>
</html>
