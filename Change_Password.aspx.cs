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

public partial class Admin_forgotepassword : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    string user, pass;
    SqlDataReader dr;


    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["username"] == null)
        {
            Response.Redirect("../home.aspx");

        }
        else
        {
            user = Session["username"].ToString();
            cn.Open();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            cmd.CommandText = "select password from Login where email='" + user + "' and usertype = 'Admin'";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pass = dr[0].ToString();
            }
            dr.Close();


            if (TextBox1.Text == pass)
            {
                cmd.CommandText = "update Login set password='" + TextBox2.Text + "' where email='" + user + "'";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                Response.Write("<script language='javascript'>alert('Password Changed');</script>");
            }
            else
            {
                Response.Write("Enter right current password");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script language='javascript'>alert('" + ex.Message.ToString() + "');</script>");
        }
    }
}
