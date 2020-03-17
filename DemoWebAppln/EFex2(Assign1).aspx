<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="EFex2(Assign1).aspx.cs" Inherits="DemoWebAppln.EFex2_Assign1_" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
    <tr>
        <td>
        <asp:RadioButton ID="rdbjoiningdate" runat="server" GroupName="G1" OnCheckedChanged="rdbjoiningdate_CheckedChanged" Text="Joining Date" AutoPostBack="True" />
        </td>
        <td>
            <asp:TextBox ID="txtstart" runat="server" TextMode="Date"></asp:TextBox>
            and
            <asp:TextBox ID="txtend" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:RadioButton ID="rdbdeptno" runat="server" GroupName="G1" Text="Deptno" AutoPostBack="True" OnCheckedChanged="rdbdeptno_CheckedChanged" />
        </td>
        <td>
            <asp:DropDownList ID="ddldeptno" runat="server" AppendDataBoundItems="True">
                <asp:ListItem Value="-1">Select</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Extract" OnClick="Button1_Click" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
            <asp:GridView ID="gvdata" runat="server"></asp:GridView>
        </table>
</asp:Content>
