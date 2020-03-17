<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="DeleteEmp.aspx.cs" Inherits="DemoWebAppln.DeleteEmp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="border-spacing:30px">
          <tr>
              <td> ENTER EMPNO TO DELETE</td>
              <td>
                  <asp:TextBox ID="txtempno" runat="server" ClientIDMode="Static" ></asp:TextBox></td>
          </tr>
          <tr>
              <td>
                  <asp:Button ID="Button1" runat="server" Text="DELETE" OnClick="Button1_Click" OnClientClick="return dvalidate();"  /></td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="label" runat="server" Text=""></asp:Label></td>
          </tr>
          </table>
</asp:Content>
