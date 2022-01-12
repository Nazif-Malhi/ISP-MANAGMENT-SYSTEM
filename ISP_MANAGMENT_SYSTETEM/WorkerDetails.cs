using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class WorkerDetails : Form
    {
       
        FireBaseAction fireBaseAction = new FireBaseAction();
        MainCodeSeperationClass mainCodeSeperationClass = new MainCodeSeperationClass();
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private DataGridView dataGridView;
        public WorkerDetails(DataGridView dataGridView)
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
        private void WorkerDetails_Load(object sender, EventArgs e)
        {
            populateList(fireBaseAction.areaDetails());
        }
        void populateList(Dictionary<string, areaDetailsData> record)
        {
            if (record == null) return;
            foreach (var item in record)
            {
                workerArea.Items.Add(item.Value.area_Name);
            }
        }
        private async void submitBtn_Click(object sender, EventArgs e)
        {
            if (workerName.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input Worker Name", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await fireBaseAction.insertDataInWorkerAsync(workerID.Text, workerName.Text, workerMobile.Text, workerAddress.Text, workerPay.Text, comissionOfWorker.Text, 1, workerArea.Text, false);
                mainCodeSeperationClass.refreshDataGridsView(2, dataGridView);
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
