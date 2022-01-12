using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class userDetails : Form
    {
        FireBaseAction fireBaseAction = new FireBaseAction();
        CalculationMoney calculationMoney = new CalculationMoney();
        MainCodeSeperationClass mainCodeSeperationClass = new MainCodeSeperationClass();
        private DataGridView dataGridView;
        ArrayList packageName = new ArrayList();
        ArrayList packagePrice = new ArrayList();
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        public userDetails(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            internetDiscount.Items.Add("1/3");
            internetDiscount.Items.Add("1/2");
            internetDiscount.Items.Add("2/3");
            cableDiscount.Items.Add("1/3");
            cableDiscount.Items.Add("1/2");
            cableDiscount.Items.Add("2/3");

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
        private void userDetails_Load(object sender, EventArgs e)
        {
            populateList(fireBaseAction.packagesDetails());
            populateList1(fireBaseAction.areaDetails());
        }

        void populateList1(Dictionary<string, areaDetailsData> record)
        {
            if (record == null) return;
            foreach (var item in record)
            {
                areaOfClient.Items.Add(item.Value.area_Name);
            }
        }
        void populateList(Dictionary<string, packageDetailsData> record)
        {
            if (record == null) return;
            foreach (var item in record)
            {
                string toLower = item.ToString().ToLower();
                if (toLower.Contains("cable"))
                {
                    cablePackageOfClient.Items.Add(item.Value.package_Name);
                }
                else
                {
                    packageOfClient.Items.Add(item.Value.package_Name);
                }
                    packageName.Add(item.Value.package_Name);
                if (item.Value.priceTo_Client == "")
                {
                    packagePrice.Add(0);
                }
                else {
                    packagePrice.Add(Convert.ToInt32(item.Value.priceTo_Client));
                }
            }
            
        }
        private async void submitBtm_Click(object sender, EventArgs e)
        {
            if (nameOFClient.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input Name of Client", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                await fireBaseAction.insertDataInUserAsync(
                customerId.Text,
                nameOFClient.Text,
                mobileOfClient.Text,
                addressofClient.Text,
                packageOfClient.Text,
                cablePackageOfClient.Text,
                areaOfClient.Text,
                1,
                calculationMoney.getAmountOfClient(packageOfClient.Text, cablePackageOfClient.Text, cableDiscount, internetDiscount, extraCharges, packageName, packagePrice, 1),
                false
                );
                mainCodeSeperationClass.refreshDataGridsView(1, dataGridView);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
