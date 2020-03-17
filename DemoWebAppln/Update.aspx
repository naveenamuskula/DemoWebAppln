<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="DemoWebAppln.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td>Employee number</td>
        <td>
            <asp:TextBox ID="txtempno" runat="server" ClientIDMode="Static" AutoPostBack="True" OnTextChanged="txtempno_TextChanged"></asp:TextBox>

        </td>
    </tr>
    <tr>
        <td>Employee name</td>
        <td>
            <asp:TextBox ID="txtename" runat="server" ClientIDMode="Static"></asp:TextBox>

        </td>
    </tr>
    <tr>
    <td>Job</td>
     <td>
         <asp:TextBox ID="txtjob" runat="server" ClientIDMode="Static"></asp:TextBox></td>

    </tr>
    <tr>
        <td>MGR</td>
        <td>
            <asp:TextBox ID="txtmgr" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Hiredate</td>
        <td>
            <asp:TextBox ID="txthiredate" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>
    <tr>
        <td>sal</td>
        <td>
            <asp:TextBox ID="txtsal" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Commission</td>
        <td>
            <asp:TextBox ID="txtcomm" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Deptno</td>
        <td>
            <asp:TextBox ID="txtdeptno" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>
    <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server" ForeColor="#FF3300"></asp:Label>
            </td>
     </tr>
    <tr>  
            <td>
                <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click"/>
            </td>   
        </tr> 
        <tr>
            <td>
                <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click"/>
            </td>
        </tr>
</table>

</asp:Content>
