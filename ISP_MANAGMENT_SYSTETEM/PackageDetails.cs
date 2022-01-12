using System;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class PackageDetails : Form
    {
        
        FireBaseAction fireBaseAction = new FireBaseAction();
        MainCodeSeperationClass mainCodeSeperationClass = new MainCodeSeperationClass();
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private DataGridView dataGridView;
        public PackageDetails(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
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
        private void cancelCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void submitBtn_Click(object sender, EventArgs e)
        {
            if (packageName.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input package Name", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await fireBaseAction.insertDataInPackageAsync(packageID.Text, packageName.Text, priceToClient.Text, actualPrice.Text, false);
              //  mainCodeSeperationClass.refreshDataGridsView(4, dataGridView);
            }
        }

        private void PackageDetails_Load(object sender, EventArgs e)
        {
            packageName.Items.Add("Cable");
        }
    }
}
