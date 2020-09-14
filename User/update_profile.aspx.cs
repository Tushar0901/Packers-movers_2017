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

public partial class User_update_profile : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    string user, fname, lname, gender, contact_no;


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
        cn.Close();
        cn.Open();
        cmd.CommandText = "update Registration set  first_name='" + TextBox1.Text+ "', last_name='" + TextBox2.Text + "',gender='" + RadioButtonList1.SelectedValue + "' ,contact_no= '"+TextBox3.Text+"' where email='" + user + "'";
        cmd.Connection = cn;
        cmd.ExecuteNonQuery();
        Response.Write("<script language='javascript'>alert('Update Successfully');</script>");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("update_profile.aspx");
    }
}