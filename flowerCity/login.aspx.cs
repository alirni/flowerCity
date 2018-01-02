using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace flowerCity
{
  public partial class login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Request.Cookies["loginAdmin"] != null)
      {
        Response.Redirect("homeAdmin.aspx");
      }

      if (Request.Cookies["loginUser"] != null)
      {
        Response.Redirect("home.aspx");
      }
    }

    protected void loginBtn_Click(object sender, EventArgs e)
    {
      if (userName.Text == "" || passwrod.Text== "")
      {
        error.Text = "لطفا ابتدا فیلد ها را پر کنید";
      }
      else
      {
        DB db1 = new DB();
        string user = userName.Text;
        string pass = passwrod.Text;
        string queryStr = "SELECT * FROM users WHERE username = '"+ user + "' and password = '" + pass + "'";
        SqlDataReader userRow = db1.searchInDb(queryStr);
        if(userRow.HasRows)
        {
          userRow.Read();
          if(Convert.ToBoolean(userRow["access"].ToString())==true) {
            HttpCookie loginAdmin = new HttpCookie("loginAdmin");
            loginAdmin.Value = user;
            loginAdmin.Expires = DateTime.Now.AddDays(2);
            Response.Cookies.Add(loginAdmin);
            Response.Redirect("homeAdmin.aspx");
          }
          else if(Convert.ToBoolean(userRow["access"].ToString()) == false)
          {
            HttpCookie loginUser = new HttpCookie("loginUser");
            loginUser.Value = user;
            loginUser.Expires = DateTime.Now.AddHours(2);
            Response.Cookies.Add(loginUser);
            Response.Redirect("home.aspx");
          }
        }
        else
        {
          error.Text = "نام کاربری یا رمز عبور اشتباه است";
        }
      }
    }
  }
}