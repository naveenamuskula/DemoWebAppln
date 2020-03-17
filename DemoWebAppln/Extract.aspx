<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Extract.aspx.cs" Inherits="DemoWebAppln.Extract" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Enter the Deptno:<asp:DropDownList ID="ddldeptno" runat="server" OnSelectedIndexChanged="ddldeptno_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True">
        <asp:ListItem Value="-1">Select</asp:ListItem>
        </asp:DropDownList>
        <asp:Button runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:GridView ID="gvdata" runat="server"></asp:GridView>

        

    </h2>
</asp:Content>