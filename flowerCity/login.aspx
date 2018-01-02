<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="flowerCity.login" %>
<!DOCTYPE html>
<html dir="rtl">
<head runat="server">
  <title>flowerCity login</title>
  <link href="components/1grid/1grids.css" rel="stylesheet" />
  <link href="App_Themes/main/main.css" rel="stylesheet" />
</head>
<body>
  <form id="form1" runat="server">
    <div class="container">
      <div class="login-container box w5">
        <div class="login box w12">
          <div class="label">نام کاربری:</div>
          <div>
            <asp:TextBox CssClass="input" ID="userName" runat="server"></asp:TextBox>
          </div>
          <div class="label">کلمه عبور:</div>
          <div>
            <asp:TextBox CssClass="input" ID="passwrod" runat="server"></asp:TextBox>
          </div>
          <div>
            <asp:Button CssClass="button" ID="loginBtn" runat="server" Text="ورود" OnClick="loginBtn_Click" />
          </div>
          <div>
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
          </div>
        </div>
      </div>
    </div>
  </form>
</body>
</html>
