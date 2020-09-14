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

public partial class Admin_catagory : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        
            if(! IsPostBack)
            {
               cn.Open();
               fillgrid();
            }
           
    }
    public void fillgrid()
    {
        cn.Close();
        cn.Open();
        cmd.CommandText = "select * from catagory";
        cmd.Connection = cn;
        cmd.ExecuteNonQuery();

        da.SelectCommand = cmd;
        da.Fill(ds);

        grvCategory.DataSource = ds;
        grvCategory.DataBind();
       
    }
    protected void DeleteCat(object sender, EventArgs e)
    {
        try
        {
            cn.Close();
            cn.Open();
            LinkButton lnkDelete = (LinkButton)sender;
            cmd.CommandText = "delete from catagory where cat_id = " + int.Parse(lnkDelete.CommandArgument) + "";
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            fillgrid();
        }
        catch (Exception ex)
        {
            Response.Write("<script language='javascript'>alert('" + ex.Message.ToString() + "');</script>");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cn.Close();
        cn.Open();
        cmd.CommandText = "insert into catagory values('" + TextBox1.Text + "')";
        cmd.Connection = cn;
        cmd.ExecuteNonQuery();
        fillgrid();



        Response.Write("<script language=javascript>alert('Category Updated.....');</script>");

        TextBox1.Text = "";

    }


    protected void grvCategory_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        try
        {
            grvCategory.EditIndex = -1;
            fillgrid();

        }
        catch (Exception ex)
        {
            Response.Write("<script language='javascript'>alert('" + ex.Message.ToString() + "');</script>");
        }
    }
    protected void grvCategory_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            grvCategory.EditIndex = e.NewEditIndex;
            fillgrid();

        }
        catch (Exception ex)
        {
            Response.Write("<script language='javascript'>alert('" + ex.Message.ToString() + "');</script>");
        }
    }
    protected void grvCategory_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            int id = int.Parse(((Label)grvCategory.Rows[e.RowIndex].FindControl("lblcid")).Text);
            string nm = ((TextBox)grvCategory.Rows[e.RowIndex].FindControl("txtcname")).Text;
            cn.Close();
            cn.Open();
            cmd.CommandText = "update catagory set catagory = '" + nm + "' where cat_id = " + id + "";
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            grvCategory.EditIndex = -1;
            fillgrid();
        }
        catch (Exception ex)
        {
            Response.Write("<script language='javascript'>alert('" + ex.Message.ToString() + "');</script>");
        }
    }
  


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("catagory.aspx");
    }
}