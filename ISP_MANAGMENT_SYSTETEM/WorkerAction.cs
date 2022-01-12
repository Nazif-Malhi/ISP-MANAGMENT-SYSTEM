using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class WorkerAction : Form
    {
        FireBaseAction fireBaseAction = new FireBaseAction();
        private string nameKey = "";
        private bool switchonn = false;
        private int pay = 1;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public WorkerAction(string nameKey)
        {
            InitializeComponent();
            this.nameKey = nameKey;
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
        private void WorkerAction_Load(object sender, EventArgs e)
        {
            try
            {
                workersDetailsData workers = fireBaseAction.workerDetails(nameKey).ResultAs<workersDetailsData>();
                workerID.Text = workers.worker_ID;
                workerName.Text = workers.worker_Name;
                workerMobile.Text = workers.worker_Mobile;
                workerAdress.Text = workers.worker_Adress;
                workerPay.Text = workers.worker_pay;
                commison.Text = workers.worker_Comission;
                workerArea.Text = workers.worker_Area;
                populateList1(fireBaseAction.areaDetails());
            }
            catch (SerializationException)
            {

                MessageBox.Show("Internet Connection is Down");
            }
           
        }
        void populateList1(Dictionary<string, areaDetailsData> record)
        {
            foreach (var item in record)
            {
                workerArea.Items.Add(item.Value.area_Name);
            }
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {
            if (workerName.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input Worker Name", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (nameKey != workerName.Text)
                {
                    fireBaseAction.deleteData("F4-Fiber/WorkersDetails/" + nameKey);
                }
                if (switchonn)
                {
                    pay = 0;
                    workerPay.Text = "0";
                    commison.Text = "0";
                }
                await fireBaseAction.insertDataInWorkerAsync(workerID.Text, workerName.Text, workerMobile.Text, workerAdress.Text, workerPay.Text, commison.Text, pay, workerArea.Text, true);

                this.Close();
            }
        }

        private void crossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (workerName.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input Worker Name", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fireBaseAction.deleteData("F4-Fiber/WorkersDetails/" + nameKey);
                this.Close();
            }
        }

        private void switchBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (!switchonn)
            {
                switchBtn.BackgroundImage = Properties.Resources.switchon;
                switchonn = true;
            }
            else
            {
                switchBtn.BackgroundImage = Properties.Resources.switchof;
                switchonn = false;
            }
        }
    }
}
