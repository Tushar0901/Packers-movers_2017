﻿using System;
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
public partial class User_Order_track : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    string user;



    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../Home.aspx");
        }
        else
        {
            cn.Open();
            cmd.CommandText = "select oid,oname,ocategory,shiftfrom,fcity,fstate,shiftto,tcity,tstate,totalcost from akhatro where username='" + Session["username"] + "'";
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();

            da.SelectCommand = cmd;
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

    }
}