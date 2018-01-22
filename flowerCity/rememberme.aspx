<%@ Page Title="" Language="C#" MasterPageFile="~/main-master-page.Master" AutoEventWireup="true" CodeBehind="rememberme.aspx.cs" Inherits="flowerCity.rememberme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="elan">
    <asp:Label ID="elan" runat="server" Text="Label"></asp:Label>
  </div>
  <div class="grideview">
    <asp:GridView ID="rememberGridView" runat="server"></asp:GridView>
  </div>
  <div>
    <asp:Button CssClass="button" ID="add" runat="server" Text="اضافه کردن" />
  </div>
</asp:Content>
