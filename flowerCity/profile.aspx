<%@ Page Title="" Language="C#" MasterPageFile="~/main-master-page.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="flowerCity.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="profilecontainer">
    <div class="avatar"></div>
    <div class="nameuser">  
      <asp:Label class="spacename" id="Label1" runat="server" Text="مهدی غلامی"></asp:Label>
      <asp:Button ID="Button1" runat="server" Text="خروج" OnClick="Button1_Click" />
    </div>
    
    <div class="border"></div>
    <div class="infouser">
      <div class="address">
        <span> آدرس:</span> 
        <asp:Label CssClass="info" runat="server" Text="آدرس را وارد کنید"></asp:Label>
      </div>
    </div>

    <div class="linkfactor">
        <asp:HyperLink ID="HyperLink1" runat="server" href="#">فاکتور</asp:HyperLink><br/>
        <asp:HyperLink ID="HyperLink2" runat="server" href="#">یادآوری</asp:HyperLink>
    </div>
  </div>      
</asp:Content>
