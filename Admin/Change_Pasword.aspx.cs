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

public partial class Admin_Change_Pasword : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    string admin, pass;
    SqlDataReader dr;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../Home.aspx");
        }
        else
        {
            admin = (Session["username"].ToString());
            cn.Open();
            }
        }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cn.Close();
        cn.Open();
        cmd.CommandText = "select * from Login where email='" + admin + "' ";
        cmd.Connection = cn;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            pass = dr[2].ToString();
        }
        dr.Close();

        //Response.Write(pass);
        if (pass == TextBox1.Text)
        {
            cmd.CommandText = "update Login set password ='" + TextBox2.Text + "' where email='"+ admin +"' ";
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('password has been changed');</script>");
        }
        else
        {
           Response.Write("<script language='javascript'>alert('Enter Right Current Password');</script>");
        
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Change_Pasword.aspx");
    }
}
