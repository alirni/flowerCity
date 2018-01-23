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
  public partial class profile : System.Web.UI.Page
  {

    protected void Button1_Click(object sender, EventArgs e)
    {
      if(Request.Cookies["loginAdmin"] != null)
      {
        Response.Cookies["loginAdmin"].Expires = DateTime.Now.AddDays(-1);
      }
      if (Request.Cookies["loginUser"] != null)
      {
        Response.Cookies["loginUser"].Expires = DateTime.Now.AddDays(-1);
      }
      Response.Redirect("login.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
      DB profiledb = new DB();
      string queryStr = string.Format("SELECT * FROM users WHERE username = '{0}'", Request.Cookies["loginUser"].Value);
      SqlDataReader userRow = profiledb.searchInDb(queryStr);
      if (userRow.HasRows)
      {
        userRow.Read();
        Labelname.Text = userRow["name"].ToString() + " " + userRow["family"].ToString();
        labeladdres.Text = userRow["name"].ToString() + " " + userRow["family"].ToString();
      }

      string queryStr2 = "SELECT * FROM address WHERE iduser = 1";
      SqlDataReader userRow2 = profiledb.searchInDb(queryStr2);
      if (userRow2.HasRows)
      {
        userRow2.Read();
        labeladdres.Text = userRow2["state"].ToString() + ", " + userRow2["city"].ToString() + ", " + userRow2["address"].ToString();
      }
    }
  }
}