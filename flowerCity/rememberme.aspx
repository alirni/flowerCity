<%@ Page Title="" Language="C#" MasterPageFile="~/main-master-page.Master" AutoEventWireup="true" CodeBehind="rememberme.aspx.cs" Inherits="flowerCity.rememberme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="elan">
    <asp:Label ID="elan" runat="server" Text="Label"></asp:Label>
  </div>
  <div class="elan grideview">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
  </div>
  <div class="elan">
    <asp:Label ID="Labelyear" runat="server" Text="سال:"></asp:Label>
    <asp:TextBox ID="year" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Labelmonth" runat="server" Text="ماه:"></asp:Label>
    <asp:TextBox ID="month" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Labelday" runat="server" Text="روز:"></asp:Label>
    <asp:TextBox ID="day" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LabeltextMessage" runat="server" Text="پیام:"></asp:Label>
    <asp:TextBox ID="message" runat="server" Columns="50" Rows="5" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Button CssClass="button" ID="add" runat="server" Text="اضافه کردن" OnClick="add_Click" />
  </div>
</asp:Content>
