using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;
using System.IO;

namespace testsendmail
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent(); 

            try
            {
                // Lấy nội dung XML từ Resource
                string xmlContent = Properties.Resources.Account;

                if (!string.IsNullOrWhiteSpace(xmlContent)) // Kiểm tra dữ liệu không rỗng
                {
                    // Chuyển XML từ chuỗi thành XDocument
                    XDocument xml = XDocument.Parse(xmlContent);

                    // Truy xuất dữ liệu
                    txtMailSender.Text = xml.Root.Element("email")?.Value ?? "Không có email";
                    txtAppPassword.Text = xml.Root.Element("password")?.Value ?? "Không có mật khẩu";
                }
                else
                {
                    MessageBox.Show("File XML rỗng hoặc không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc XML: " + ex.Message);
            }
            loadlistmail();
        }

        private void loadlistmail()
        {
            string fileContent = Properties.Resources.ListMail; 

            if (!string.IsNullOrWhiteSpace(fileContent)) 
            {
                using (StringReader reader = new StringReader(fileContent)) 
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                      
                        listMail.Items.Add(line); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Không đọc được nội dung file.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
           {
               Credentials = new NetworkCredential("vietnamboardinghouse@gmail.com", "ziau vrck nvyt viem"),
               EnableSsl = true
           };

           
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("vietnamboardinghouse@gmail.com"),
                Subject = "Subject of the email",
                Body = "Body of the email",
                IsBodyHtml = true
            };
            mailMessage.To.Add("klemin3005@gmail.com");

            client.Send(mailMessage);
      

        }

        private void SendMail_Load(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listMail.Items.Count > 0)
            {
                foreach (var item in listMail.Items)
                {
                    try
                    {
                        string __emailhost = txtMailSender.Text;
                        string __apppassword = txtAppPassword.Text;
                        string __mailrecep = item.ToString();
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.Credentials = new NetworkCredential(__emailhost, __apppassword);
                        smtp.EnableSsl = true;

                        MailMessage mail = new MailMessage
                        {
                            From = new MailAddress(__emailhost),
                            Subject = rBSubject.Text,
                            Body = rBContent.Text,
                            IsBodyHtml = false
                        };
                        mail.To.Add(__mailrecep);

                        smtp.Send(mail);
                        
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                MessageBox.Show("Gửi thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string __emailhost = txtMailSender.Text;
                    string __apppassword = txtAppPassword.Text;
                    string __mailrecep = txtMailrecep.Text;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential(__emailhost, __apppassword);
                    smtp.EnableSsl = true;

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(__emailhost),
                        Subject = rBSubject.Text,
                        Body = rBContent.Text,
                        IsBodyHtml = false
                    };
                    mail.To.Add(__mailrecep);

                    smtp.Send(mail);
                    MessageBox.Show("Gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }
    }
}
