<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="EFex1.aspx.cs" Inherits="DemoWebAppln.EFex1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <script src="Scripts/EmpdetailsValidations.js"></script> 
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
                <asp:Button ID="btnsubmit" runat="server" Text="Insert with EF" OnClick="btnsubmit_Click" OnClientClick="return Validate();"/>
            </td>
            
        </tr> 
         <tr>
            <td>
                <asp:Button ID="btninsert" runat="server" Text="insert with sp" OnClick="btninsert_Click" OnClientClick="return Validate();" />
            </td>
        </tr>
</table>





</asp:Content>
