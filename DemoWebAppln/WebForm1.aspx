<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoWebAppln.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="Javascript" type="text/javascript">
    function Validate()
        {
        var eno = document.getElementById("txtempno").value;
        var ename = document.getElementById("txtename").value;
        var job = document.getElementById("txtjob").value;
        var mgr = document.getElementById("txtmgr").value;
        var hiredate = document.getElementById("txthiredate").value;
        var sal = document.getElementById("txtsal").value;
        var comm = document.getElementById("txtcomm").value;
        var deptno = document.getElementById("txtdeptno").value;
        if (eno.length != 0 && ename.length != 0 && job.length != 0 && mgr.length != 0 && hiredate.length != 0 && sal.length != 0 && comm.length != 0 && deptno.length != 0)
            return true;
        else
        {
            alert("enter all details");
            return false;
        }
        }

    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 535px">
                <tr>
                    <td>Employee No</td>
                    <td>
                        <asp:TextBox ID="txtempno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Employee Name</td>
                    <td>
                        <asp:TextBox ID="txtename" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Job</td>
                    <td>
                        <asp:TextBox ID="txtjob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Manager Id</td>
                    <td>
                        <asp:TextBox ID="txtmgr" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Hiredate</td>
                    <td>
                        <asp:TextBox ID="txthiredate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Sal</td>
                    <td>
                        <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Commission</td>
                    <td>
                        <asp:TextBox ID="txtcomm" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Deptno</td>
                    <td style="margin-left: 40px">
                        <asp:TextBox ID="txtdeptno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="margin-left: 40px">
                        <asp:Button ID="btnsubmit" runat="server" Text="Button" OnClientClick="return Validate();" OnClick="btnsubmit_Click" />
                    </td>
                    <td style="margin-left: 40px">&nbsp;</td>
                </tr>
            </table>
           
        </div>
    </form>
</body>
</html>
