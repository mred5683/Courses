<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionVApplicationState.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter your name: "></asp:Label>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter your email: "></asp:Label>
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
        <asp:Button ID="Retrieve" runat="server" OnClick="Retrieve_Click" Text="Retrieve" />
        <br />
        <asp:Label ID="NameAndEmail" runat="server"></asp:Label>
        <br />
        <asp:Label ID="RetrievedNameAndEmail" runat="server"></asp:Label>

    </div>
    </form>
</body>
</html>
