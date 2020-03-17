<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Validators.aspx.cs" Inherits="DemoWebAppln.Validators" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Empno</td>
            <td>
                <asp:TextBox ID="txtempno" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Cannot be Blank" ControlToValidate="txtempno" Font-Bold="True" ForeColor="#FF3300" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>Ename</td>
            <td>
                <asp:TextBox ID="txtename" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Cannot Be Blank" ControlToValidate="txtename" Font-Bold="True" ForeColor="#FF3300" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Confirm Password
            </td>
            <td>
                <asp:TextBox ID="txtconfirmpwd" runat="server" TextMode="Password"></asp:TextBox></td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password does not match" ControlToValidate="txtconfirmpwd" ControlToCompare="txtpwd" Font-Bold="True" ForeColor="#FF3300" Display="None"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td>
                salary
            </td>
            <td>
                <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="salary b/w 5000 to 20000" Type="Double" ControlToValidate="txtsal" MaximumValue="20000" MinimumValue="5000" Font-Bold="True" ForeColor="#FF3300" Display="None"></asp:RangeValidator>
            </td> 
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="salary should be b/w 5000 to 20000" Display="None" ControlToValidate="txtsal"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>Pancard</td>
            <td>
                <asp:TextBox ID="txtpancard" runat="server"></asp:TextBox></td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Pancard" ControlToValidate="txtpancard" ForeColor="Red" ValidationExpression="^[A-Z]{5}[0-9]{4}[A-Z]$" Display="None"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td>Date of Birth</td>
            <td>
                <asp:TextBox ID="txtdob" runat="server" TextMode="Date"></asp:TextBox></td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Age must be b/w  21 to 50" ControlToValidate="txtdob" Display="None" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </td>    
        </tr> 
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" ForeColor="Red" />
</asp:Content>
