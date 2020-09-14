using System;
using System.Collections;
using System.Web.Configuration;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Admin_Feedback : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    string user, pass;
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../Home.aspx");
        }
        else
        {
            user = (Session["username"].ToString());
            cn.Open();
        }
        
        cmd.CommandText = "select * from Feedback";
        cmd.Connection = cn;
        cmd.ExecuteNonQuery();

        da.SelectCommand = cmd;
        da.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}