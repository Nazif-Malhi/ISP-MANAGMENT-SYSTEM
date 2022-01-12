using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class ConnectionAction : Form
    {
        FireBaseAction fireBaseAction = new FireBaseAction();
        CalculationMoney calculationMoney = new CalculationMoney();
        private bool switchonn = false,textChangeSwitch=false;
        private string nameKey = "";
        private int pay = 1;
        ArrayList packageName = new ArrayList();
        ArrayList packagePrice = new ArrayList();
        private string prevInternetPackage, prevCablePackage;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        int prev,total;

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
        public ConnectionAction(string nameKey)
        {
            this.nameKey = nameKey;
            InitializeComponent();
            internetDiscountComboBox.Items.Add("1/3");
            internetDiscountComboBox.Items.Add("1/2");
            internetDiscountComboBox.Items.Add("2/3");
            cableDiscountComboBox.Items.Add("1/3");
            cableDiscountComboBox.Items.Add("1/2");
            cableDiscountComboBox.Items.Add("2/3");
        }
        private void ConnectionAction_Load(object sender, EventArgs e)
        {
            try
            {
                userDetailsData user = fireBaseAction.userDetails(nameKey).ResultAs<userDetailsData>();
                customerID.Text = user.customer_Id;
                nameOfClient.Text = user.nameOF_Client;
                packageComboBox.Text = user.packageOf_Client;
               
                cablePackage.Text = user.cablePackageof_Client;
               
                mobileNumber.Text = user.mobileOf_Client;
                AdressOfClient.Text = user.addressof_Client;
                AreaComboBox.Text = user.areaOf_Client;
                previousDebt.Text = user.getDebt.ToString();
                prev = Convert.ToInt32(user.getDebt);
                populateList(fireBaseAction.packagesDetails());
                populateList1(fireBaseAction.areaDetails());


                prevCablePackage = user.cablePackageof_Client;
                prevInternetPackage = user.packageOf_Client;
               
            }
            catch (SerializationException)
            {

                MessageBox.Show("Internet Connection is Down");
            }
           
           
        }
        void populateList1(Dictionary<string, areaDetailsData> record)
        {
            if (record == null) return;
            foreach (var item in record)
            {
                AreaComboBox.Items.Add(item.Value.area_Name);
            }
        }
        void populateList(Dictionary<string, packageDetailsData> record)
        {
            if (record == null) return;
            cablePackage.Items.Add(" Previous package ");
            packageComboBox.Items.Add(" Previous package ");
            foreach (var item in record)
            {
                string toLower = item.ToString().ToLower();
                if (toLower.Contains("cable"))
                {
                    cablePackage.Items.Add(item.Value.package_Name);
                }
                else
                {
                    packageComboBox.Items.Add(item.Value.package_Name);
                }
                packageName.Add(item.Value.package_Name);
                if (item.Value.priceTo_Client != "")
                {
                    packagePrice.Add(Convert.ToInt32(item.Value.priceTo_Client));
                }
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            fireBaseAction.deleteData("F4-Fiber/Users/" + nameOfClient.Text);
            this.Close();
        }
        private async void editBtn_Click(object sender, EventArgs e)
        {
            if (nameOfClient.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input Name of Client", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                if (nameKey != nameOfClient.Text)
                {
                    fireBaseAction.deleteData("F4-Fiber/Users/" + nameKey);
                }
                if (switchonn)
                {
                    pay = 0;
                }
                total = Convert.ToInt32(previousDebt.Text);
                if (packageComboBox.Text.Equals(" Previous package ")) {
                    packageComboBox.Text = prevInternetPackage;
                    textChangeSwitch = true;
                  
                }
                if (cablePackage.Text.Equals(" Previous package ")) {
                    cablePackage.Text = prevCablePackage;
                    textChangeSwitch = true;
                  
                }
                await fireBaseAction.insertDataInUserAsync(
                    customerID.Text,
                    nameOfClient.Text,
                    mobileNumber.Text,
                    AdressOfClient.Text,
                    packageComboBox.Text,
                    cablePackage.Text,
                    AreaComboBox.Text,
                    pay,
                    total,
                    true
                    );
                this.Close();
            }
            
        }
        private void crossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!switchonn)
            {
                pictureBox1.BackgroundImage = Properties.Resources.switchon;
                switchonn = true;
            }
            else
            {
                pictureBox1.BackgroundImage = Properties.Resources.switchof;
                switchonn = false;
            }
        }

      
        private void internetDiscountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!textChangeSwitch) callCalculator();

        }

        private void cableDiscountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!textChangeSwitch) callCalculator();
        }

        private void cablePackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!textChangeSwitch) callCalculator();
        }

        private void extraCharges_TextChanged(object sender, EventArgs e)
        {
            if (!textChangeSwitch) callCalculator();
        }

        private void packageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!textChangeSwitch) callCalculator();
        }

        private void internetDiscountComboBox_TextChanged(object sender, EventArgs e)
        {
            if (!textChangeSwitch) callCalculator();
        }

        private void callCalculator() {
            if (textChangeSwitch) return;
            if (internetDiscountComboBox.Text.Equals(" Previous package ") || cableDiscountComboBox.Text.Equals(" Previous package "))
            {
                previousDebt.Text = prev.ToString();
            }
            else
            {
                previousDebt.Text = calculationMoney.getAmountInActionInternet(packageComboBox.Text, cablePackage.Text, cableDiscountComboBox, internetDiscountComboBox, extraCharges, packageName, packagePrice, pay, prev).ToString();
            }
        }
    }
}

