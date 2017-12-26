<%@ Page Title="" Language="C#" MasterPageFile="~/main-master-page.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="flowerCity.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link href="login.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <table class="login-container">
    <tr>
      <td class="label">نام کاربری:</td>
    </tr>
    <tr>
      <td>
        <asp:TextBox CssClass="input" ID="userName" runat="server"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="label">کلمه عبور:</td>
    </tr>
    <tr>
      <td>
        <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td>
        <asp:Button CssClass="button" ID="Button1" runat="server" Text="Button" />
      </td>
    </tr>
  </table>
</asp:Content>
