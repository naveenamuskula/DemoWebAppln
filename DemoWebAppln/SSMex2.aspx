<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="SSMex2.aspx.cs" Inherits="DemoWebAppln.SSMex2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td>Employee number</td>
        <td>
            <asp:TextBox ID="txtempno" runat="server" ClientIDMode="Static"></asp:TextBox>

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
                <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" OnClientClick="return Validate();"/>
            </td>
            
        </tr> 
        
</table>

</asp:Content>
