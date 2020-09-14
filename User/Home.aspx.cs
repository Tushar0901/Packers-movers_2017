using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;

public partial class User_Home : System.Web.UI.Page
{

    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    string User, first_name, last_name, contact_no, gender;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../Home.aspx");

        }
        else
        {
           User = (Session["username"].ToString());
           cn.Open();
            

            cmd.CommandText = "select * from Registration where email='"+ User +"' ";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();

            while( dr.Read())
            {

              first_name = dr[1].ToString();
              last_name = dr[2].ToString();
              gender = dr[3].ToString();
              contact_no= dr[9].ToString();


        }
           dr.Close();

            Label1.Text = first_name;
            Label2.Text = last_name;
            Label3.Text = gender;
            Label4.Text = contact_no;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("update_profile.aspx");
    }
}