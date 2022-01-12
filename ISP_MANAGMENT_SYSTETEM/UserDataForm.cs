using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    public partial class UserDataForm : Form
    {
        FireBase fireBase = new FireBase();
        MainCodeSeperationClass MainCodeSeperationClass;
        //Double Buffering Removing Flickering
        private bool user, worker, area, package, report;
        private int remainder;
        private bool mode;
        private Form switchAccount;
        private Func<ChartPoint, string> func = chartpoint => string.Format("{0}({1:p})", chartpoint.Y, chartpoint.Participation);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        public UserDataForm(bool mode,Form switchAccount) 
        {
            InitializeComponent();
            ResizeRedraw = true;
            this.mode = mode;
            this.switchAccount = switchAccount;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            MainCodeSeperationClass = new MainCodeSeperationClass(usersDataGridView, areaDataGridView1, workerDataGridView, packagesDataGridView,printPreviewDialog1,printDocument1,mode);
            workerDataGridView.Hide();
            areaDataGridView1.Hide();
            pieChart1.Hide();
            flowLayoutPanel1.Hide();
            packagesDataGridView.Hide();
            comboBox1.Items.Add("Not-Paid");
            comboBox1.Items.Add("Paid");
          
            if (!mode)
            {
                MainCodeSeperationClass.mainFormLoad_DataGrid(usersDataGridView);
                MainCodeSeperationClass.refreshDataGrids(1);
            }
            else
            {
                MainCodeSeperationClass.mainFormLoad_DataGrid(usersDataGridView);
                MainCodeSeperationClass.mainFormLoad_DataGrid(workerDataGridView);
                MainCodeSeperationClass.mainFormLoad_DataGrid(packagesDataGridView);
                MainCodeSeperationClass.mainFormLoad_DataGrid(areaDataGridView1);

                MainCodeSeperationClass.refreshDataGrids(1);
                MainCodeSeperationClass.refreshDataGrids(2);
                MainCodeSeperationClass.refreshDataGrids(3);
                MainCodeSeperationClass.refreshDataGrids(4);
            }
          
        }

        private void crossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.Refresh();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
            this.BackgroundImage = Properties.Resources.userSelected;
            this.Refresh();
            
        }
        private void packageBtn_Click(object sender, EventArgs e)
        {
            if (restrictedForm()) return;
            this.BackgroundImage = Properties.Resources.packagesSelected;
            user = true;
            package = false;
            report = true;
            area = true;
            worker = true;
            usersDataGridView.Hide();
            workerDataGridView.Hide();
            areaDataGridView1.Hide();
            packagesDataGridView.Show();
            comboBox1.Hide();
            pieChart1.Hide();
            flowLayoutPanel1.Hide();
           

        }
        private void reportBtn_Click(object sender, EventArgs e)
        {
            if (restrictedForm()) return;
            this.BackgroundImage = Properties.Resources.reportSelected;
            user = true;
            package = true;
            report = false;
            area = true;
            worker = true;
            usersDataGridView.Hide();
            workerDataGridView.Hide();
            areaDataGridView1.Hide();
            packagesDataGridView.Hide();
            comboBox1.Hide();
            flowLayoutPanel1.Show();
            pieChart1.Show();

            SeriesCollection series = new SeriesCollection();
            if (MainCodeSeperationClass.getPackagesName.Length >= 0)
            {
                for (int i = 0; i < MainCodeSeperationClass.getPackagesName.Length; i++)
                {
                    series.Add(new PieSeries() { Title = MainCodeSeperationClass.getPackagesName[i], Values = new ChartValues<int> { MainCodeSeperationClass.getNumberofCount[i] }, DataLabels = true, LabelPoint = func });
                    pieChart1.Series = series;
                }
            }
        }
        private void workerBtn_Click(object sender, EventArgs e)
        {
            if (restrictedForm()) return;
            this.BackgroundImage = Properties.Resources.workerSelected;
            user = true;
            package = true;
            report = true;
            area = true;
            worker = false;
            usersDataGridView.Hide();
            workerDataGridView.Show();
            areaDataGridView1.Hide();
            packagesDataGridView.Hide();
            comboBox1.Hide();
            pieChart1.Hide();
            flowLayoutPanel1.Hide();
        }
        private void areaBtn_Click(object sender, EventArgs e)
        {
            if (restrictedForm()) return;
            this.BackgroundImage = Properties.Resources.areaSelected;
            user = true;
            package = true;
            report = true;
            area = false;
            worker = true;
            usersDataGridView.Hide();
            workerDataGridView.Hide();
            areaDataGridView1.Show();
            packagesDataGridView.Hide();
            comboBox1.Hide();
            pieChart1.Hide();
            flowLayoutPanel1.Hide();

        }
        private void userBtn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.userSelected;
            user = false;
            package = true;
            report = true;
            area = true;
            worker = true;
            usersDataGridView.Show();
            workerDataGridView.Hide();
            areaDataGridView1.Hide();
            packagesDataGridView.Hide();
            comboBox1.Show();
            pieChart1.Hide();
            flowLayoutPanel1.Hide();
        }

      




        /// <summary>
        /// User Data Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void userDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MainCodeSeperationClass.userDataGridView_CellMouseClick(sender, e, usersDataGridView);
        }

        private void userDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            MainCodeSeperationClass.userDataGridView_CellMouseEnter(sender, e, usersDataGridView);
        }

        private void areaDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MainCodeSeperationClass.areaDataGridView1_CellMouseClick(sender, e, areaDataGridView1);
        }

        private void areaDataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            MainCodeSeperationClass.areaDataGridView1_CellMouseEnter(sender, e, areaDataGridView1);
        }

        private void areaDataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            MainCodeSeperationClass.areaDataGridView1_CellMouseLeave(sender, e, areaDataGridView1);
        }
        /// <summary>
        /// packages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void packagesDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            MainCodeSeperationClass.packagesDataGridView_CellMouseEnter(sender, e, packagesDataGridView);
        }

        private void packagesDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        { 
           MainCodeSeperationClass.packagesDataGridView_CellMouseLeave(sender, e, packagesDataGridView);
        }

        private void packagesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MainCodeSeperationClass.packagesDataGridView_CellMouseClick(sender, e, packagesDataGridView);
        }

        private void userDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            MainCodeSeperationClass.userDataGridView_CellMouseLeave(sender, e, usersDataGridView);
        }





        private void mainMenueBarBtn_Click(object sender, EventArgs e)
        {
            mainMenueBarBtn.SendToBack();
            panel1.Hide();
            panel1.Size = new System.Drawing.Size(188, 641);
            panel1.Refresh();
            panel1.Show();
            
        }

        private void menueBarBtn_Click(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(0, 0);
            mainMenueBarBtn.BringToFront();
            panel1.Hide();
           
        }

        private void settingBtn_MouseEnter(object sender, EventArgs e)
        {
            settingBtn.BackgroundImage = Properties.Resources.menueBarSettingBtn;
        }

        private void settingBtn_MouseLeave(object sender, EventArgs e)
        {
            settingBtn.BackgroundImage = null;
        }

        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            logoutBtn.BackgroundImage = Properties.Resources.menueBarLogoutBtn;
        }

        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            logoutBtn.BackgroundImage = null;
        }

        private void switchAcountBtn_MouseEnter(object sender, EventArgs e)
        {
            switchAcountBtn.BackgroundImage = Properties.Resources.menuebarSwithcBtn;
        }

        private void switchAcountBtn_MouseLeave(object sender, EventArgs e)
        {
            switchAcountBtn.BackgroundImage = null;
        }

        private void showReportBtn_MouseEnter(object sender, EventArgs e)
        {
            showReportBtn.BackgroundImage = Properties.Resources.menuebarShowReportBtn;
        }

        private void showReportBtn_MouseLeave(object sender, EventArgs e)
        {
            showReportBtn.BackgroundImage = null;
        }

        private void addAreaBtn_MouseEnter(object sender, EventArgs e)
        {
            addAreaBtn.BackgroundImage = Properties.Resources.menuebarAddAreaBtn;
        }

        private void addAreaBtn_MouseLeave(object sender, EventArgs e)
        {
            addAreaBtn.BackgroundImage = null;
        }

        private void addPackageBtn_MouseEnter(object sender, EventArgs e)
        {
            addPackageBtn.BackgroundImage = Properties.Resources.menuebarAddPackages;
        }

        private void addPackageBtn_MouseLeave(object sender, EventArgs e)
        {
            addPackageBtn.BackgroundImage = null;
        }

        private void addWorkerBtn_MouseEnter(object sender, EventArgs e)
        {
            addWorkerBtn.BackgroundImage = Properties.Resources.menuebarAddWorkersBtn;
        }

        private void addWorkerBtn_MouseLeave(object sender, EventArgs e)
        {
            addWorkerBtn.BackgroundImage = null;
        }

        private void addUsrBtn_MouseEnter(object sender, EventArgs e)
        {
            addUsrBtn.BackgroundImage = Properties.Resources.meneubarAdduserBtn;
        }

        private void addUsrBtn_MouseLeave(object sender, EventArgs e)
        {
            addUsrBtn.BackgroundImage = null;
        }

        private void addUsrBtn_Click(object sender, EventArgs e)
        {
            userDetails userDetails = new userDetails(usersDataGridView);
            userDetails.ShowDialog();
          
        }

        private void addWorkerBtn_Click(object sender, EventArgs e)
        {
            if (restrictedForm()) return;
            WorkerDetails worker = new WorkerDetails(workerDataGridView);
            worker.ShowDialog();
        }

        private void addPackageBtn_Click(object sender, EventArgs e)
        {
            if (restrictedForm()) return;
            PackageDetails packageDetails = new PackageDetails(packagesDataGridView);
            packageDetails.ShowDialog();
            MainCodeSeperationClass.addPackageBtn_Click(sender, e);
        }

        private void addAreaBtn_Click(object sender, EventArgs e)
        {
            if (restrictedForm()) return;
            areaDetails area = new areaDetails(areaDataGridView1);
            area.ShowDialog();
            MainCodeSeperationClass.addAreaBtn_Click(sender, e);
        }

        private void showReportBtn_Click(object sender, EventArgs e)
        {
            if (restrictedForm()) return;
          
            usersDataGridView.Hide();
            workerDataGridView.Hide();
            areaDataGridView1.Hide();
            packagesDataGridView.Hide();
            comboBox1.Hide();
            pieChart1.Show();
            flowLayoutPanel1.Show();
            panel1.BringToFront();
        }

        private void switchAcountBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            switchAccount.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            if (restrictedForm()) return;
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            MainCodeSeperationClass.printDocument1_PrintPage(sender, e);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.userSelected__Search;
            MainCodeSeperationClass.searchResult(comboBox1.Text);
            this.BackgroundImage = Properties.Resources.userSelected;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.userSelected__Search;
            MainCodeSeperationClass.searchResult(comboBox1.Text);
            this.BackgroundImage = Properties.Resources.userSelected;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainCodeSeperationClass.searchResult(comboBox1.Text);
        }

        /// <summary>
        /// Worker Data Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void workerDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           MainCodeSeperationClass.workerDataGridView_CellMouseClick(sender, e, workerDataGridView);
        }

        private void workerDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            MainCodeSeperationClass.workerDataGridView_CellMouseEnter(sender, e, workerDataGridView);
        }

        private void workerDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
             MainCodeSeperationClass.workerDataGridView_CellMouseLeave(sender, e, workerDataGridView);
        }

        private bool restrictedForm() {
            if (!mode)
            {
                workerMode workerMode = new workerMode(switchAccount,this);
                workerMode.ShowDialog();
                return true;
            }
            else return false;
        }
    }
}
