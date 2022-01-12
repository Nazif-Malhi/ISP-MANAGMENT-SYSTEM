using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class PackagesAction : Form
    {
        FireBaseAction fireBaseAction = new FireBaseAction();
        private string nameKey = "";
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        FireBase fireBase = new FireBase();

        public PackagesAction(string nameKey)
        {
            this.nameKey = nameKey;
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
        private void PackagesAction_Load(object sender, EventArgs e)
        {
            try
            {
                packageName.Items.Add("Cable");
                packageDetailsData packageDetails = fireBaseAction.packageDetails(nameKey).ResultAs<packageDetailsData>();
                packageID.Text = packageDetails.package_ID;
                packageName.Text = packageDetails.package_Name;
                actualPrice.Text = packageDetails.actual_Price;
                priceToClient.Text = packageDetails.priceTo_Client;
            }
            catch (SerializationException)
            {

                MessageBox.Show("Internet Connection is Down");
            }
        
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (packageName.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input package Name", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fireBaseAction.deleteData("F4-Fiber/Packages/" + nameKey);
                this.Close();
            }
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {
            if (packageName.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input package Name", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (nameKey != packageName.Text)
                {
                    fireBaseAction.deleteData("F4-Fiber/Packages/" + nameKey);
                }
                await fireBaseAction.insertDataInPackageAsync(packageID.Text, packageName.Text, priceToClient.Text, actualPrice.Text, true);

                this.Close();
            }
        }

        private void cnclBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
