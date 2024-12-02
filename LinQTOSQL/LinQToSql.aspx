<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinQToSql.aspx.cs" Inherits="LinQTOSQL.LinQToSql" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Btninsert" runat="server" Text="Insert" OnClick="Btninsert_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
            <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
        </div>
        <div>
            <asp:GridView ID="GVUser" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
