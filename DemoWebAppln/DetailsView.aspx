<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="DetailsView.aspx.cs" Inherits="DemoWebAppln.DetailsView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView runat="server" ID="GridView" AllowPaging="True" OnPageIndexChanging="GridView_PageIndexChanging" PageSize="2"></asp:GridView>
    <asp:DetailsView runat="server" Height="50px" Width="125px" ID="DetView" AllowPaging="True" OnPageIndexChanging="DetView_PageIndexChanging"></asp:DetailsView>
    <asp:FormView runat="server" ID="FView" AllowPaging="True" OnPageIndexChanging="FView_PageIndexChanging">
        <ItemTemplate>
            <table class="auto-style2">
                <tr>
                    <td>OrderId</td>
                    <td>OrderDesc</td>
                    <td>Total Cost</td>
                    <td class="auto-style3">Discount Amt</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("orderid") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("orderdesc") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("totalprice") %>'></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Disamt") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
    </asp:Content>
