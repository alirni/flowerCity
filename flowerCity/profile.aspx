<%@ Page Title="" Language="C#" MasterPageFile="~/main-master-page.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="flowerCity.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="profilecontainer">
      <div class="avatar"></div>
      <div class="nameuser">  
        <asp:Label id="Label1" runat="server" Text="مهدی غلامی"></asp:Label>
      </div>
      <div class="logout">  
        <asp:Button ID="Button1" runat="server" Text="خروج" />
      </div>
      <div class="border"></div>
      <div class="infouser">
       آدرس: <asp:Label runat="server" Text="آدرس را وارد کنید"></asp:Label> 
      </div>
      <div class="linkfactor">
          <asp:HyperLink ID="HyperLink1" runat="server">فاکتور</asp:HyperLink><br/>
          <asp:HyperLink ID="HyperLink2" runat="server">یادآوری</asp:HyperLink>
      </div>
  </div>      
</asp:Content>
