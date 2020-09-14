using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

public partial class Forgot_Password : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    string pass;
    MailMessage msg = new MailMessage();


    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         cmd.CommandText = "select * from Login where email='" + TextBox1.Text + "'";
        cmd.Connection = cn;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            pass = dr[2].ToString();


        }
        SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
        MailMessage Msg = new MailMessage();
        Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
        Msg.To.Add(TextBox1.Text);
        Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following password reminder:<br>
                            Please login with this password<br>
                            <b>Password:  " + pass + @"</b><br><br>
                            Use this link to login again
                            <br><br>
                            
                            
                            Thanks for using and supporting our website. 

                            </body>
                           </html>";
        Msg.IsBodyHtml = true;
        smtp.UseDefaultCredentials = false;
        smtp.Credentials = new System.Net.NetworkCredential("bhavsar.tushard@yahoo.com", "tushar1995");
        smtp.Send(Msg);
        Response.Write("<script language='javascript'>alert('Message has been sent successfully');</script>");
   
    
    }
}