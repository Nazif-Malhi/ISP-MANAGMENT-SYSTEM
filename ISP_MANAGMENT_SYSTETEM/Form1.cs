using System;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class SplashScreen : Form
    {
        FireBaseAction fireBaseAction = new FireBaseAction();
        private string email, password = "";
        private bool worker, admin;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        public SplashScreen()
        {
            InitializeComponent();
            admin = true;
            worker = false;
            workerProccedBtn.Hide();
            pasword.PasswordChar = '*';
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);

                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }

            base.WndProc(ref m);
        }


        private void adminBtn_Click(object sender, EventArgs e)
        {
            if (worker) {
                this.BackgroundImage = Properties.Resources.adminSelected;
                admin = true;
                worker = false;
                pasword.Show();
                proceedBtn.Show();
                ForgetPasword.Show();
                workerProccedBtn.Hide();
            }
        
        }
        private void workerBtn_Click(object sender, EventArgs e)
        {
            if (admin) {
                this.BackgroundImage = Properties.Resources.workerSelectedsplashScreen;
                worker = true;
                admin = false;
                pasword.Hide();
                proceedBtn.Hide();
                ForgetPasword.Hide();
                workerProccedBtn.Show();
            }
       
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            if (!callingSettingsFromDataBase()) return;
            if (pasword.Text != password)
            {
                MessageBox.Show("Password is incorrect", "Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                UserDataForm userData = new UserDataForm(true, this);
                pasword.Text = "";
                userData.Show();
                this.Hide();
            }
           
        }

        private void proceedBtn_MouseEnter(object sender, EventArgs e)
        {
            proceedBtn.BackgroundImage = Properties.Resources.proceedHoverBtn;
        }

        private void proceedBtn_MouseLeave(object sender, EventArgs e)
        {
            proceedBtn.BackgroundImage = null;
        }

        private void ForgetPasword_MouseEnter(object sender, EventArgs e)
        {
            ForgetPasword.BackgroundImage = Properties.Resources.hoverForgertPasword;
        }

        private void ForgetPasword_MouseLeave(object sender, EventArgs e)
        {
            ForgetPasword.BackgroundImage = null;
        }

        private  void ForgetPasword_MouseDown(object sender, MouseEventArgs e)
        {
            ForgetPasword.BackgroundImage = Properties.Resources.selectedForgertPasword;
            string to, from, passwordOfSender, mail;
            to = email;
            from = ("***");
            Random rnd = new Random();
            int temp_Password = rnd.Next(0000, 9999);
            fireBaseAction.insertDataInSettingsAsync(email, temp_Password.ToString(),true);
            mail = "Please insert this 4 digit password to access the account \n" +
                "                           " + "“"+temp_Password+ "”";
            passwordOfSender = "***";
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = mail;
            mailMessage.Subject = "Recovery of Password";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, passwordOfSender);
            try
            {
                
                smtpClient.Send(mailMessage);
                MessageBox.Show("Temproray Password Send Successfully to "+to, "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail is Not send to \n"+to+"\nDue to following Exception\n"+ex.Message,"Recovery Password mail is Not send !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void workerProccedBtn_Click(object sender, EventArgs e)
        {
            UserDataForm userData = new UserDataForm(false,this);
            pasword.Text = "";
            userData.Show();
            this.Hide();
        }

        private void workerProccedBtn_MouseEnter(object sender, EventArgs e)
        {
            workerProccedBtn.BackgroundImage = Properties.Resources.proceedHoverBtn;
        }

        private void workerProccedBtn_MouseLeave(object sender, EventArgs e)
        {
           workerProccedBtn.BackgroundImage = null;
        }

     

        private void cnclBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool callingSettingsFromDataBase() {
            try
            {
                settingsDetailsData settingsDetails = fireBaseAction.settingsDetails(1).ResultAs<settingsDetailsData>();
                email = settingsDetails.email_ID;
                password = settingsDetails.pasword;
                return true;
            }
            catch (SerializationException)
            {

                MessageBox.Show("Internet Connection is Down");
                return false;
            }
           
        }
    }
}
