 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class workerMode : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private Form switchacc,user;
        
        public workerMode(Form switchacc,Form user)
        {
            InitializeComponent();
            this.switchacc = switchacc;
            this.user = user;
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

        private void switchAcount_MouseEnter(object sender, EventArgs e)
        {
            switchAcount.BackgroundImage = Properties.Resources.hoverSwitchAccountBtn;
        }

        private void switchAcount_MouseLeave(object sender, EventArgs e)
        {
            switchAcount.BackgroundImage = Properties.Resources.switchAccountBtn;
        }

        private void switchAcount_Click(object sender, EventArgs e)
        {
            this.Close();
            user.Close();
            switchacc.Show();
        }

        private void crssBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
