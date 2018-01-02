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
  public class DB
  {
    private string conStr;

    public DB()
    {
      conStr = @"Data Source=.;Initial Catalog=flowerCityDb;Integrated Security=True";
    }

    public void loadDataGrid(string queryStr, GridView My_gridname)
    {
      SqlConnection My_con_load = new SqlConnection(conStr);
      My_con_load.Open();
      SqlDataAdapter MY_sda = new SqlDataAdapter(queryStr, My_con_load);
      DataSet My_ds = new DataSet();
      MY_sda.Fill(My_ds);
      My_gridname.DataSource = My_ds;
      My_gridname.DataBind();
      My_con_load.Close();
    }

    public int execQuery(string queryStr)
    {
      SqlConnection My_con_exe = new SqlConnection(conStr);
      My_con_exe.Open();
      SqlCommand My_scm = new SqlCommand(queryStr, My_con_exe);
      int My_result_exe = My_scm.ExecuteNonQuery();
      My_con_exe.Close();
      return My_result_exe;
    }

    public int My_execqueryscalar(string queryStr)
    {
      SqlConnection My_con_exe = new SqlConnection(conStr);
      My_con_exe.Open();
      SqlCommand My_scm = new SqlCommand(queryStr, My_con_exe);
      int My_result_exe = Convert.ToInt32(My_scm.ExecuteScalar());
      My_con_exe.Close();
      return My_result_exe;
    }

    public SqlDataReader searchInDb(string queryStr)
    {
      SqlConnection My_con_dreader = new SqlConnection(conStr);
      My_con_dreader.Open();
      SqlCommand My_scm = new SqlCommand(queryStr, My_con_dreader);
      SqlDataReader My_sdr = My_scm.ExecuteReader();
      return My_sdr;
    }

    public void My_loaddatalist(string queryStr, DataList My_dlistname)
    {
      SqlConnection My_con_load = new SqlConnection(conStr);
      My_con_load.Open();
      SqlCommand My_scmd = new SqlCommand(queryStr, My_con_load);
      My_dlistname.DataSource = My_scmd.ExecuteReader();
      My_dlistname.DataBind();
      My_con_load.Close();
    }

    public void loadFormView(string queryStr, FormView My_frmvw)
    {
      SqlConnection My_con_load = new SqlConnection(conStr);
      My_con_load.Open();
      SqlCommand My_scmd = new SqlCommand(queryStr, My_con_load);
      My_frmvw.DataSource = My_scmd.ExecuteReader();
      My_frmvw.DataBind();
      My_con_load.Close();
    }
  }
}