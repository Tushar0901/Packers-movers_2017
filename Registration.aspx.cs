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

public partial class Registration : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        cn.Close();
        cn.Open();
        cmd.CommandText = "insert into Registration values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + RadioButtonList1.SelectedValue + "' ,'" + TextBox3.Text + "', '" + DropDownList1.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + TextBox4.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')";
        cmd.Connection = cn;
        cmd.ExecuteNonQuery();


        cmd.CommandText = "insert into Login values('" + TextBox4.Text + "','" + TextBox6.Text + "','User')";
        cmd.Connection = cn;
        cmd.ExecuteNonQuery();


        Response.Write("<script language=javascript>alert('Registration Successfully');</script>");

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registration.aspx");
    }
  
}