using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class AreaAction : Form
    {
        FireBaseAction fireBaseAction = new FireBaseAction();
        private string nameKey = "";
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        public AreaAction(string nameKey)
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
        private void AreaAction_Load(object sender, EventArgs e)
        {
            try
            {
                populateWorkerList(fireBaseAction.workerDetails());
                areaDetailsData areaDetails = fireBaseAction.AreaDetails(nameKey).ResultAs<areaDetailsData>();
                areaName.Text = areaDetails.area_Name;
                workerName.Text = areaDetails.worker_Name;
                secondWorkerName.Text = areaDetails.secondWorker_Name;
                thirdWorkerName.Text = areaDetails.thirdWorker_Name;
            }
              catch (SerializationException)
            {

                MessageBox.Show("Internet Connection is Down");
            }
        }
        private void populateWorkerList(Dictionary<string, workersDetailsData> record)
        {
            if (record != null) {
                foreach (var item in record)
                {
                    workerName.Items.Add(item.Value.worker_Name);
                    secondWorkerName.Items.Add(item.Value.worker_Name);
                    thirdWorkerName.Items.Add(item.Value.worker_Name);
                }
            }
           
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {
            if (areaName.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input Area Name", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (nameKey != areaName.Text)
                {
                    fireBaseAction.deleteData("F4-Fiber/Area/" + areaName.Text);
                }
                await fireBaseAction.insertDataInAreaAsync(
                    areaName.Text,
                    workerName.Text,
                    secondWorkerName.Text,
                    thirdWorkerName.Text,
                    true);
                this.Close();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (areaName.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input Area Name", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fireBaseAction.deleteData("F4-Fiber/Area/" + areaName.Text);
                this.Close();
            }
        }

        private void cnclBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crssBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
