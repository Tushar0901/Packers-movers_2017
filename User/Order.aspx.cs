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

public partial class User_Order : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    MailMessage msg = new MailMessage();
    string x, y,pass,user,first_name;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../home.aspx");

        }
        else
        {
            cn.Open();
            user = Session["username"].ToString();


             cmd.CommandText = "select * from Registration where email='"+ user +"' ";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();

            while( dr.Read())
            {

              first_name = dr[1].ToString();
             


        }
           dr.Close();

            Label1.Text = first_name;
           
        }
    
        
    
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {

        cn.Close();
        cn.Open();
        x = DropDownList4.SelectedValue;
        y = DropDownList2.SelectedValue;
       



        // Ahmedabad //

        if (y=="Ahmedabad" && x=="Ahmedabad")
        {
            TextBox3.Text = "500";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a+b+c+d+f).ToString();



        }
            
        else if (y=="Ahmedabad" && x=="Mehsana")
        {
            TextBox3.Text = "1500";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y=="Ahmedabad" && x=="Rajkot")
        {
            TextBox3.Text = "5000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y=="Ahmedabad" && x=="Bhavnagar")
        {
            TextBox3.Text = "8000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();

        }
        else  if (y=="Ahmedabad" && x=="Himmatnagar")
        {
            TextBox3.Text = "1200";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }




       //Mehsan To //

        else if (y == "Mehsana" && x== "Ahmedabad")
        {
            TextBox3.Text = "1520";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Mehsana" && x == "Mehsana")
        {
            TextBox3.Text = "500";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
          else if (y=="Mehsana" && x=="Rajkot")
        {
            TextBox3.Text = "8500";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y=="Mehsana" && x=="Bhavnagar")
        {
            TextBox3.Text = "8000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Mehsana" && x == "Himmatnagar")
        {
            TextBox3.Text = "1300";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
     


        //Rajkot to //

        else if (y == "Rajkot" && x == "Ahmedabad")
        {
            TextBox3.Text = "2000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Rajkot" && x == "Mehsana")
        {
            TextBox3.Text = "1200";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();

        }
        else if (y == "Rajkot" && x == "Rajkot")
        {
            TextBox3.Text = "1500";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Rajkot" && x == "Bhavnagar")
        {
            TextBox3.Text = "1600";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Rajkot" && x == "Himmatnagar")
        {
            TextBox3.Text = "6000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }




        // Bhavnagar to //

        else if (y == "Bhavnagar" && x == "Ahmedabad")
        {
            TextBox3.Text = "3000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Bhavnagar" && x == "Mehsana")
        {
            TextBox3.Text = "5000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Bhavnagar" && x == "Rajkot")
        {
            TextBox3.Text = "2000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Bhavnagar" && x == "Bhavnagar")
        {
            TextBox3.Text = "800";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Bhavnagar" && x == "Himmatnagar")
        {
            TextBox3.Text = "7000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }



        // Himmatnagar to //


        else if (y == "Himmatnagar" && x == "Ahmedabad")
        {
            TextBox3.Text = "2500";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Himmatnagar" && x == "Mehsana")
        {
            TextBox3.Text = "2000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Himmatnagar" && x == "Rajkot")
        {
            TextBox3.Text = "7500";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Himmatnagar" && x == "Bhavnagar")
        {
            TextBox3.Text = "6000";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }
        else if (y == "Himmatnagar" && x == "Himmatnagar")
        {
            TextBox3.Text = "600";
            TextBox4.Text = "200";
            TextBox5.Text = "100";
            TextBox6.Text = "200";
            TextBox7.Text = "12";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }


        if (DropDownList4.SelectedValue == "Ahmedabad")
        {
            DropDownList5.SelectedValue = "Gujarta";
        }


        if (DropDownList4.SelectedValue == "Mehsana")
        {
            DropDownList5.SelectedValue = "Gujarat";
        }


        if (DropDownList4.SelectedValue == "Rajkot")
        {
            DropDownList5.SelectedValue = "Gujarat";
        }


        if (DropDownList4.SelectedValue == "Bhavnagar")
        {
            DropDownList5.SelectedValue = "Gujarat";
        }


        if (DropDownList4.SelectedValue == "Himmatnagar")
        {
            DropDownList5.SelectedValue = "Gujarat";
        }

        // Maharastra//


        else if (y == "Ahmedabad" && x == "Pune")
        {
            TextBox3.Text = "36000";
            TextBox4.Text = "2000";
            TextBox5.Text = "1000";
            TextBox6.Text = "2200";
            TextBox7.Text = "1500";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Ahmedabad" && x == "Mumbai")
        {
            TextBox3.Text = "16000";
            TextBox4.Text = "2000";
            TextBox5.Text = "10000";
            TextBox6.Text = "2000";
            TextBox7.Text = "1800";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }



        else if (y == "Rajkot" && x == "Pune")
        {
            TextBox3.Text = "16000";
            TextBox4.Text = "2200";
            TextBox5.Text = "1000";
            TextBox6.Text = "2000";
            TextBox7.Text = "1200";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Rajkot" && x == "Mumbai")
        {
            TextBox3.Text = "26000";
            TextBox4.Text = "2000";
            TextBox5.Text = "1000";
            TextBox6.Text = "2000";
            TextBox7.Text = "1200";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }


        else if (y == "Rajkot" && x == "Pune")
        {
            TextBox3.Text = "14000";
            TextBox4.Text = "2000";
            TextBox5.Text = "1000";
            TextBox6.Text = "2000";
            TextBox7.Text = "1200";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }


        else if (y == "Bhavnagar" && x == "Mumbai")
        {
            TextBox3.Text = "26000";
            TextBox4.Text = "2000";
            TextBox5.Text = "1000";
            TextBox6.Text = "2000";
            TextBox7.Text = "1200";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Bhavnagar" && x == "Pune")
        {
            TextBox3.Text = "15000";
            TextBox4.Text = "1200";
            TextBox5.Text = "1100";
            TextBox6.Text = "2000";
            TextBox7.Text = "1200";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Mehsana" && x == "Pune")
        {
            TextBox3.Text = "17000";
            TextBox4.Text = "2000";
            TextBox5.Text = "1200";
            TextBox6.Text = "2000";
            TextBox7.Text = "1200";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Mehsana" && x == "Mumbai")
        {
            TextBox3.Text = "20000";
            TextBox4.Text = "2000";
            TextBox5.Text = "1000";
            TextBox6.Text = "2000";
            TextBox7.Text = "1200";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Himmatnagar" && x == "Pune")
        {
            TextBox3.Text = "18000";
            TextBox4.Text = "2000";
            TextBox5.Text = "1000";
            TextBox6.Text = "200";
            TextBox7.Text = "1200";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }

        else if (y == "Himmatnagar" && x == "Mumbai")
        {
            TextBox3.Text = "1600";
            TextBox4.Text = "2000";
            TextBox5.Text = "1000";
            TextBox6.Text = "200";
            TextBox7.Text = "1200";

            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            int c = int.Parse(TextBox5.Text);
            int d = int.Parse(TextBox6.Text);
            int f = int.Parse(TextBox7.Text);

            TextBox8.Text = (a + b + c + d + f).ToString();
        }













        if (DropDownList4.SelectedValue == "Mumbai")
        {
            DropDownList5.SelectedValue = "Maharastra";
        }


        if (DropDownList4.SelectedValue == "Pune")
        {
            DropDownList5.SelectedValue = "Maharastra";
        }


        //Maharastra//


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        x = DropDownList4.SelectedValue;
        y = DropDownList2.SelectedValue;


        cmd.CommandText = " insert into akhatro values('" + TextBox9.Text + "','" + TextBox10.Text + "','" + DropDownList1.SelectedItem + "','" + TextBox1.Text + "','" + DropDownList2.SelectedValue + "','" + DropDownList6.SelectedValue + "','" + TextBox2.Text + "','" + DropDownList4.SelectedValue + "','" + DropDownList5.SelectedValue + "','" + TextBox8.Text + "','" + Session["username"] + "' )";
        cmd.Connection = cn;
        cmd.ExecuteNonQuery();


        cmd = new SqlCommand();

        
            cmd.CommandText = "select * from akhatro where username='" + Session["username"] + "'";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                pass = dr[3].ToString();


            }
            //  with city msg for trace parcel // 

            // AHMEDABAD//
            if (y == "Ahmedabad" && x == "Ahmedabad")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Your Parcel reminder:<br>
                            <br>
                            <b>Your parcel:  " + pass + @"</b><br><br>
                            we tranport your Goods in 2 days.
                            And <b>Total Amount  is :" + TextBox8.Text + @"</b>
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


            else if (y == "Ahmedabad" && x == "Mehsana")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 3 days
                            And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            else if (y == "Ahmedabad" && x == "Rajkot")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 4 days
                               And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Ahmedabad" && x == "Bhavnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 4 days
                                And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Ahmedabad" && x == "Himmatnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                               And <b>Total Amount is :" + TextBox8.Text + @"</b>
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
                // AHMEDABAD STOP //

                               
                // MEHSANA  START//


            else if (y == "Mehsana" && x == "Ahmedabad")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                               And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            else if (y == "Mehsana" && x == "Mehsana")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 1 days
                                And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Mehsana" && x == "Rajkot")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 3 days
                                And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Mehsana" && x == "Bhavnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 4 days
                                And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Mehsana" && x == "Himmatnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                                And <b>Total Amount is :" + TextBox8.Text + @"</b>
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
                // MEHSANA STOP //

                               // RAJKOT START //

            else if (y == "Rajkot" && x == "Ahmedabad")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                                And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            else if (y == "Rajkot" && x == "Mehsana")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 3 days
                                And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Rajkot" && x == "Rajkot")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 1 days
                                And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Rajkot" && x == "Bhavnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                                 And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Rajkot" && x == "Himmatnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 3 days
                                And <b>Total Amount is :" + TextBox8.Text + @"</b>
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
            // RAJKOT STOP //
               

            // BHAVNAGAR START //



            else if (y == "Bhavnagar" && x == "Ahmedabad")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            else if (y == "Bhavnagar" && x == "Mehsana")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 3 days
                           And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Bhavnagar" && x == "Rajkot")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                            And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Bhavnagar" && x == "Bhavnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 1 days
                            And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Bhavnagar" && x == "Himmatnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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
            
            // BHAVNAGAR STOP //
        

            // HIMMATNAGAR START //




            else if (y == "Himmatnagar" && x == "Ahmedabad")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            else if (y == "Himmatnagar" && x == "Mehsana")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 2 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Himmatnagar" && x == "Rajkot")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 3 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Himmatnagar" && x == "Bhavnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 3 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Himmatnagar" && x == "Himmatnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 1 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            // HIMMATNAGAR STOP //



                 // MUMBAI START //





            else if (y == "Mumbai" && x == "Ahmedabad")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 7 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            else if (y == "Mumbai" && x == "Mehsana")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 7 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Mumbai" && x == "Rajkot")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 8 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Mumbai" && x == "Bhavnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 6 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Mumbai" && x == "Himmatnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 5 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Mumbai" && x == "Mumbai")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 3 days
                            And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


                // MUMBAI STOP //


            // PUNE START //




            else if (y == "Pune" && x == "Ahmedabad")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 8 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            else if (y == "Pune" && x == "Mehsana")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 7 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Pune" && x == "Rajkot")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 6 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Pune" && x == "Bhavnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 6 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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

            else if (y == "Pune" && x == "Himmatnagar")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 6 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            else if (y == "Pune" && x == "Pune")
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587);
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("bhavsar.tushard@yahoo.com");
                Msg.To.Add(user);
                Msg.Body = @"<html> 
                            <head>
                            </head>
                           <body>
                            Dear User,<br><br><br>
                           
                            You requested the following Parcel reminder:<br>
                            <br>
                            <b>Your Parcel:  " + pass + @"</b><br><br>
                            we transport your Goods in 3 days
                             And <b>Total Amount is :" + TextBox8.Text + @"</b>
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


            // PUNE STOP //


            // ALL email massage Stop //

            Response.Write("<script language=javascript>alert('Order Confirm Successfully');</script>");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
        
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedValue == "Ahmedabad")
        {
            DropDownList6.SelectedValue = "Gujarta";
        }


        if (DropDownList2.SelectedValue == "Mehsana")
        {
            DropDownList6.SelectedValue = "Gujarat";
        }


        if (DropDownList2.SelectedValue == "Rajkot")
        {
            DropDownList6.SelectedValue = "Gujarat";
        }


        if (DropDownList2.SelectedValue == "Bhavnagar")
        {
            DropDownList6.SelectedValue = "Gujarat";
        }


        if (DropDownList2.SelectedValue == "Himmatnagar")
        {
            DropDownList6.SelectedValue = "Gujarat";
        }


        //Maharastra//

        if (DropDownList2.SelectedValue == "Mumbai")
        {
            DropDownList6.SelectedValue = "Maharastra";
        }


        if (DropDownList2.SelectedValue == "Pune")
        {
            DropDownList6.SelectedValue = "Maharastra";
        }

        //Maharastra//
      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Order.aspx");
    }
}