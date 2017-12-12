<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rEGISTRAION'.aspx.cs" Inherits="TimePass.rEGISTRAION_" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Dname"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
     <asp:Label ID="Label2" runat="server" Text="Location"></asp:Label>
     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
  <asp:Button runat="server" OnClick="insert" text="submit" />    </div>

        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

        <asp:gridview ID="Gridview1" runat="server"></asp:gridview>
    </form>
</body>

</html>
