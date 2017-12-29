using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace flowerCity
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

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
  }
}