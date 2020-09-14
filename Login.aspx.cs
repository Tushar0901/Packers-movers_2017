using System;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
  
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    Boolean b = false;
    string usertype;


    protected void Page_Load(object sender, EventArgs e)
    {
        {
            cn.Open();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        cn.Close();
        cn.Open();
        cmd.CommandText = "select * from Login where email='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' ";
        cmd.Connection = cn;
        dr = cmd.ExecuteReader();


        while (dr.Read())
        {
            usertype = dr[3].ToString();

        }
        if (usertype == "User")
        {
            Session["username"] = TextBox1.Text;
            Response.Redirect("~/User/Home.aspx");
        }
        else if (usertype == "Admin")
        {
            Session["username"] = TextBox1.Text;
            Response.Redirect("~/Admin/Admin_User_Reg.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");

        }

       
       
    }
   
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Forgot_Password.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}