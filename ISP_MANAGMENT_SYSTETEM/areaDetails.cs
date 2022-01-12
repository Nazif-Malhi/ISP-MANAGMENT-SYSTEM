using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class areaDetails : Form
    {
        FireBaseAction FireBaseAction = new FireBaseAction();
        MainCodeSeperationClass mainCodeSeperationClass = new MainCodeSeperationClass();
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private DataGridView dataGridView;
        public areaDetails(DataGridView dataGridView)
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
        private void areaDetails_Load(object sender, EventArgs e)
        {
            populateWorkerList(FireBaseAction.workerDetails());
        }

        private void populateWorkerList(Dictionary<string, workersDetailsData> record)
        {
            if (record == null) return;
            foreach (var item in record)
            {
                workerName.Items.Add(item.Value.worker_Name);
                secondWorkerName.Items.Add(item.Value.worker_Name);
                thirdWorkerName.Items.Add(item.Value.worker_Name);
            }
        }

        private async void submitBtn_ClickAsync(object sender, EventArgs e)
        {
            if (areaName.Text == "")
            {
                MessageBox.Show("Master Feild is empty please input Area Name", "Fill Master Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await FireBaseAction.insertDataInAreaAsync(
                areaName.Text,
                workerName.Text,
                secondWorkerName.Text,
                thirdWorkerName.Text,
                false
                );
             //   mainCodeSeperationClass.refreshDataGridsView(3, dataGridView);
               
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crossCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
