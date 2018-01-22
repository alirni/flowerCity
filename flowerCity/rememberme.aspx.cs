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
  public partial class rememberme : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      DB rememberDb = new DB();
      string queryStr = "SELECT * FROM rememberdate WHERE iduser= 1";
      rememberDb.loadDataGrid(queryStr, GridView1);
    }

    protected void add_Click(object sender, EventArgs e)
    {
      string myYear = year.Text;
      string myMonth = month.Text;
      string myDay = day.Text;
      string myMsg = message.Text;

      DB rememberDb = new DB();
      string queryStr = string.Format("INSERT INTO rememberdate (year, month, day, textmessage, iduser,) VALUES ( {0}, {1}, {2}, {3}, 1 )", myYear, myMonth, myDay, myMsg);
      rememberDb.execQuery(queryStr);
    }
  }
}