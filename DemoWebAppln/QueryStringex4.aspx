<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringex4.aspx.cs" Inherits="DemoWebAppln.QueryStringex4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="javascript" type="text/javascript">
        function Fun1()
        {
           
            window.open("QueryStringex5.aspx?A=10&B=20");
        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button"  OnClientClick="Fun1();"/>
        </div>
    </form>
</body>
</html>
