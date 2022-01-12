using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
   
    public partial class SettingsForm : Form
    {
        FireBaseAction fireBaseAction = new FireBaseAction();
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private string tempEmailIdStoreForEmailChange = "";
        public SettingsForm()
        {
            InitializeComponent();
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

        private  void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                settingsDetailsData settingsDetails = fireBaseAction.settingsDetails(1).ResultAs<settingsDetailsData>();
                emailID.Text = settingsDetails.email_ID;
                password.Text = settingsDetails.pasword;
                tempEmailIdStoreForEmailChange = settingsDetails.email_ID;
            }
            catch (SerializationException)
            {

                MessageBox.Show("Internet Connection is Down");
            }
          
        }

        private  void pictureBox2_Click(object sender, EventArgs e)
        {
            if (emailID.Text == "")
            {
                errorProvider1.SetError(emailID, "Please provide fill");
                return;
            }
            else if (password.Text == "") {
                errorProvider1.SetError(password, "Please provide fill");
                return;
            }
            else
            {
                errorProvider1.Clear();
                fireBaseAction.insertDataInSettingsAsync(emailID.Text, password.Text, false);
                this.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailID_Leave(object sender, EventArgs e)
        {
            checkError();
        }

        private void emailID_TabIndexChanged(object sender, EventArgs e)
        {
            checkError();
        }
        private void checkError() {
            string pattren = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";
            if (Regex.IsMatch(emailID.Text, pattren))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(emailID, "Please provide valid email");
                return;
            }
        }

        private void emailID_TextChanged(object sender, EventArgs e)
        {
            if (emailID.Text == "")
            {
                errorProvider1.SetError(emailID, "Please provide fill");
                return;
            }
            checkError();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                errorProvider1.SetError(password, "Please provide fill");
                return;
            }
        }
    }
}
