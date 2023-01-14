using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text;
public partial class contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            string mail = TextBox2.Text;
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(mail);
            mailMessage.To.Add("idreamitsolution18@gmail.com.com");
            mailMessage.Subject = TextBox3.Text;
            mailMessage.Body = "<b> Name : </b>" + TextBox1.Text + "<br/>"
 + "<b>Email: : </b>" + TextBox2.Text + "<br/>"
                   + "<b>Courses: </b>" + TextBox3.Text + "<br/>"
                     + "<b>Phone: </b>" + TextBox4.Text + "<br/>"
                      + "<b>Message: </b>" + TextBox5.Text + "<br/>";

            mailMessage.IsBodyHtml = true;


            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new
                System.Net.NetworkCredential("idreamitsolution18@gmail.com", "jayram123");
            smtpClient.Send(mailMessage);

            Label1.ForeColor = System.Drawing.Color.Blue;
            Label1.Text = "Thank you for contacting us";

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";


        }
        catch (Exception ex)
        {
            Console.WriteLine("{0} Exception caught.", ex);
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }
}