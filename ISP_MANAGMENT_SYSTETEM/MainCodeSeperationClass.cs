using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    class MainCodeSeperationClass
    {
        FireBaseAction fireBaseAction = new FireBaseAction();
        private ArrayList storeNumberOfAreas = new ArrayList();
        private ArrayList storeNumberOfPackages = new ArrayList();
        private ArrayList countTotalNumberOfAreas = new ArrayList();
        private ArrayList countTotalNumberOfPackages = new ArrayList();
        private DataGridView userDataGridView, areaDataGridView, workerDataGridView, packageDataGridView;
        private PrintPreviewDialog printPreviewDialog;
        private PrintDocument printDocument;
        private string customerID, customerName, internetPackages, internetPackagePrice, cablePackagePrice,  totalAmount;
        private bool mode;
        public string[] getPackagesName;
        public int[] getNumberofCount;
        public MainCodeSeperationClass() {
        }
        public MainCodeSeperationClass(DataGridView userDataGridView, DataGridView areaDataGridView, DataGridView workerDataGridView, DataGridView packageDataGridView,PrintPreviewDialog printPreviewDialog,PrintDocument printDocument,bool mode) {

            this.userDataGridView = userDataGridView;
            this.areaDataGridView = areaDataGridView;
            this.workerDataGridView = workerDataGridView;
            this.packageDataGridView = packageDataGridView;
            this.printPreviewDialog = printPreviewDialog;
            this.printDocument = printDocument;
            this.mode = mode;
        }


        /// <summary>
        /// Data grid UI 
        /// </summary>
        /// <param name="DataGridView"></param>
        public void mainFormLoad_DataGrid(DataGridView DataGridView)
        {
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            DataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DataGridView.BackgroundColor = Color.White;
            DataGridView.EnableHeadersVisualStyles = false;
            DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
     


        /// <summary>
        /// Showing details in Data grid 
        /// </summary>
        /// <param name="record"></param>
        /// <param name="usersDataGridView"></param>
        private void showDetailsOfUsersInDataGrid(Dictionary<string, userDetailsData> record, DataGridView usersDataGridView)
        {
           
                int i = 0;
                if (record == null) return;
                foreach (var item in record)
                {
                    if (item.Value.recevie_Payment == 1)
                    {
                        usersDataGridView.Rows.Add(i, item.Value.nameOF_Client, item.Value.mobileOf_Client, item.Value.addressof_Client, item.Value.areaOf_Client, Properties.Resources.activeBtn, "RS" + "  " + item.Value.getDebt, item.Value.packageOf_Client, Properties.Resources.notreceived);

                    }
                    else
                    {
                        usersDataGridView.Rows.Add(i, item.Value.nameOF_Client, item.Value.mobileOf_Client, item.Value.addressof_Client, item.Value.areaOf_Client, Properties.Resources.activeBtn, "RS" + "  " + item.Value.getDebt, item.Value.packageOf_Client, Properties.Resources.recieved);

                    }
                    i++;
                }
           
                foreach (var item in record)
                {
                     
                    storeNumberOfAreas.Add(item.Value.areaOf_Client);
                    storeNumberOfPackages.Add(item.Value.packageOf_Client);
                    storeNumberOfPackages.Add(item.Value.cablePackageof_Client);
                }
        
        }
        private void showDetailsOfWorkersInDataGrid(Dictionary<string, workersDetailsData> record, DataGridView workersDataGridView)
        {
            int i = 0;
            if (record == null) return;
            foreach (var item in record)
            {
                if (item.Value.recevie_Payment == 1)
                {
                    workersDataGridView.Rows.Add(i, item.Value.worker_Name, item.Value.worker_Mobile, item.Value.worker_Adress, item.Value.worker_Area, Properties.Resources.activeBtn, "RS" + "  " + item.Value.worker_pay, item.Value.worker_Comission, Properties.Resources.notpay);
                }
                else
                {
                    workersDataGridView.Rows.Add(i, item.Value.worker_Name, item.Value.worker_Mobile, item.Value.worker_Adress, item.Value.worker_Area, Properties.Resources.activeBtn, "RS" + "  " + item.Value.worker_pay, item.Value.worker_Comission, Properties.Resources.paid);
                }
                i++;
            }
        }
        private void showDetailsOfAreaInDataGrid(Dictionary<string, areaDetailsData> record, DataGridView AreaDataGridView)
        {
            if (record == null) return;
            string[] tempArray = new string[storeNumberOfAreas.Count];
            for (int i = 0; i < storeNumberOfAreas.Count; i++)
            {
                tempArray[i] = storeNumberOfAreas[i].ToString();;
            }
            string[] q = tempArray.Distinct().ToArray();
            int count = 0;
            for (int i = 0; i < q.Length; i++)
            {
                for (int j = 0; j < tempArray.Length; j++)
                {
                    if (q[i] == tempArray[j])
                    {
                        count++;
                    }
                    
                }
                countTotalNumberOfAreas.Add(count);
               // MessageBox.Show(q[i] + " "+count);
                
                count = 0;

            }
            int w = 0;
            foreach (var item in record)
            {
               
                for ( int i = 0; i < q.Length; i++)
                {
                    if (item.Value.area_Name == q[i])
                    {
                        AreaDataGridView.Rows.Add(w, item.Value.area_Name, item.Value.worker_Name, item.Value.secondWorker_Name, item.Value.thirdWorker_Name, countTotalNumberOfAreas[i]);
                    }
                    
                }
                if (!q.Contains(item.Value.area_Name))
                {
                    AreaDataGridView.Rows.Add(w, item.Value.area_Name, item.Value.worker_Name, item.Value.secondWorker_Name, item.Value.thirdWorker_Name, 0);
                }
                w++;
            }
        }
        private void showDetailsOfPackagesInDataGrid(Dictionary<string, packageDetailsData> record, DataGridView packagesDataGridView)
        {
            if (record == null) return;
            string[] tempArray = new string[storeNumberOfPackages.Count];
            for (int i = 0; i < storeNumberOfPackages.Count; i++)
            {
                tempArray[i] = storeNumberOfPackages[i].ToString();
            }
            string[] q = tempArray.Distinct().ToArray();
            getPackagesName = new string[q.Length];
            getNumberofCount = new int[q.Length];
            int count = 0;
            for (int i = 0; i < q.Length; i++)
            {
                getPackagesName[i] = q[i];
                for (int j = 0; j < tempArray.Length; j++)
                {
                    if (q[i] == tempArray[j])
                    {
                        count++;
                    }
                }
                countTotalNumberOfPackages.Add(count);
                getNumberofCount[i] = count;
                count = 0;
            }
            int p = 1;
            foreach (var item in record)
            {
            
                for (int i = 0; i < q.Length; i++)
                {
                    if (item.Value.package_Name == q[i])
                    {
                        packageDataGridView.Rows.Add(p, item.Value.package_Name, item.Value.actual_Price, item.Value.priceTo_Client, countTotalNumberOfPackages[i]);
                    }
                   
                }
               
                if (!q.Contains(item.Value.package_Name)) {
                    packageDataGridView.Rows.Add(p, item.Value.package_Name, item.Value.actual_Price, item.Value.priceTo_Client, 0);
                }
                p++;
            }
        }



        /// <summary>
        /// Mouse functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="usersDataGridView"></param>
        public void userDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e, DataGridView usersDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {

                if (usersDataGridView.Columns[e.ColumnIndex].Name == "actionOfClient")
                {
                    usersDataGridView.Rows[e.RowIndex].Cells[9].Value = Properties.Resources.actionBtnHover;
                }
                else if (usersDataGridView.Columns[e.ColumnIndex].Name == "receiveOfClient")
                {


                    if (CompareImages((Bitmap)usersDataGridView.Rows[e.RowIndex].Cells[8].Value, Properties.Resources.notreceived))
                    {
                        usersDataGridView.Rows[e.RowIndex].Cells[8].Value = Properties.Resources.rexeivedHover;
                    }

                }

            }
        }
        public void userDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e, DataGridView usersDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {
                if (usersDataGridView.Columns[e.ColumnIndex].Name == "actionOfClient")
                {
                    usersDataGridView.Rows[e.RowIndex].Cells[9].Value = Properties.Resources.actionBtn;
                }
                else if (usersDataGridView.Columns[e.ColumnIndex].Name == "receiveOfClient")
                {
                    if (CompareImages((Bitmap)usersDataGridView.Rows[e.RowIndex].Cells[8].Value, Properties.Resources.rexeivedHover))
                    {
                        usersDataGridView.Rows[e.RowIndex].Cells[8].Value = Properties.Resources.notreceived;
                    }
                }
            }
        }
        public async void userDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e, DataGridView usersDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {
                if (usersDataGridView.Columns[e.ColumnIndex].Name == "addressOfClient")
                {
                    MessageBox.Show(usersDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                else if (usersDataGridView.Columns[e.ColumnIndex].Name == "receiveOfClient")
                {
                    if (CompareImages((Bitmap)usersDataGridView.Rows[e.RowIndex].Cells[8].Value, Properties.Resources.recieved)) MessageBox.Show("Already payment is received");
                    else
                    {
                        try
                        {
                            usersDataGridView.Rows[e.RowIndex].Cells[8].Value = Properties.Resources.recieved;
                            userDetailsData userdata = fireBaseAction.userDetails(usersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()).ResultAs<userDetailsData>();
                            customerID = userdata.customer_Id;
                            customerName = userdata.nameOF_Client;
                            internetPackages = userdata.packageOf_Client;
                            cablePackagePrice = userdata.cablePackageof_Client;
                            packageDetailsData packageDetailsData = fireBaseAction.packageDetails(internetPackages).ResultAs<packageDetailsData>();
                            internetPackagePrice = packageDetailsData.priceTo_Client;

                            packageDetailsData cablePackageDetailsData = fireBaseAction.packageDetails(cablePackagePrice).ResultAs<packageDetailsData>();
                            cablePackagePrice = cablePackageDetailsData.priceTo_Client;

                            totalAmount = userdata.getDebt.ToString();


                            await Task.Run(() => fireBaseAction.insertDataInUserAsync(userdata.customer_Id, userdata.nameOF_Client, userdata.mobileOf_Client, userdata.addressof_Client, userdata.packageOf_Client, userdata.cablePackageof_Client, userdata.areaOf_Client, 0, 0, true));
                            refreshDataGrids(1);
                            printPreviewDialog.Document = printDocument;
                            printDocument.DefaultPageSettings.PaperSize = new PaperSize("pprnm", 200, 600);
                            printPreviewDialog.ShowDialog();
                        }
                        catch (SerializationException)
                        {

                            MessageBox.Show("Internet Connection is Down");
                        }
                       
                    }

                }
                else if (usersDataGridView.Columns[e.ColumnIndex].Name == "actionOfClient")
                {
                    ConnectionAction connectionAction = new ConnectionAction(usersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    connectionAction.ShowDialog();
                    refreshDataGrids(1);
                }

            }

        }



        public async void workerDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e, DataGridView workerDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {
                if (workerDataGridView.Columns[e.ColumnIndex].Name == "adressOfWorker")
                {
                    MessageBox.Show(workerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                else if (workerDataGridView.Columns[e.ColumnIndex].Name == "paymentOfWroker")
                {
                    try
                    {
                        workerDataGridView.Rows[e.RowIndex].Cells[8].Value = Properties.Resources.paid;
                        workersDetailsData worker = fireBaseAction.workerDetails(workerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()).ResultAs<workersDetailsData>();
                        await Task.Run(() => fireBaseAction.insertDataInWorkerAsync(worker.worker_ID, worker.worker_Name, worker.worker_Mobile, worker.worker_Adress, "0", "0", 0, worker.worker_Area, true));
                        refreshDataGrids(2);
                    }
                    catch (SerializationException)
                    {

                        MessageBox.Show("Internet Connection is Down");
                    }
                   
                }
                else if (workerDataGridView.Columns[e.ColumnIndex].Name == "actionOfWorker")
                {
                    WorkerAction workerAction = new WorkerAction(workerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    workerAction.ShowDialog();
                    refreshDataGrids(2);
                }

            }
        }
        public void workerDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e, DataGridView workerDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {

                if (workerDataGridView.Columns[e.ColumnIndex].Name == "actionOfWorker")
                {
                    workerDataGridView.Rows[e.RowIndex].Cells[9].Value = Properties.Resources.actionBtnHover;
                }
                else if (workerDataGridView.Columns[e.ColumnIndex].Name == "paymentOfWroker")
                {

                    if (CompareImages((Bitmap)workerDataGridView.Rows[e.RowIndex].Cells[8].Value, Properties.Resources.notpay))
                    {
                        workerDataGridView.Rows[e.RowIndex].Cells[8].Value = Properties.Resources.payHover;
                    }

                }
            }
        }
        public void workerDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e, DataGridView workerDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {
                if (workerDataGridView.Columns[e.ColumnIndex].Name == "actionOfWorker")
                {
                    workerDataGridView.Rows[e.RowIndex].Cells[9].Value = Properties.Resources.actionBtn;
                }
                else if (workerDataGridView.Columns[e.ColumnIndex].Name == "paymentOfWroker")
                {
                    if (CompareImages((Bitmap)workerDataGridView.Rows[e.RowIndex].Cells[8].Value, Properties.Resources.payHover))
                    {
                        workerDataGridView.Rows[e.RowIndex].Cells[8].Value = Properties.Resources.notpay;
                    }
                }
            }
        }


        public void areaDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e, DataGridView AreaDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {
                if (AreaDataGridView.Columns[e.ColumnIndex].Name == "action")
                {
                    AreaAction areaAction = new AreaAction(AreaDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                   
                    areaAction.ShowDialog();

                    refreshDataGrids(3);
                }


            }
        }
        public  void areaDataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e, DataGridView AreaDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {

                if (AreaDataGridView.Columns[e.ColumnIndex].Name == "action")
                {
                    AreaDataGridView.Rows[e.RowIndex].Cells[6].Value = Properties.Resources.actionBtnHover;
                }
            }
        }
        public void areaDataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e, DataGridView AreaDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {

                if (AreaDataGridView.Columns[e.ColumnIndex].Name == "action")
                {
                    AreaDataGridView.Rows[e.RowIndex].Cells[6].Value = Properties.Resources.actionBtn;
                }
            }
        }


        public void packagesDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e, DataGridView packageDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {

                if (packageDataGridView.Columns[e.ColumnIndex].Name == "actionOfPackages")
                {
                    packageDataGridView.Rows[e.RowIndex].Cells[5].Value = Properties.Resources.actionBtnHover;
                }
            }
        }
        public void packagesDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e, DataGridView packageDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {

                if (packageDataGridView.Columns[e.ColumnIndex].Name == "actionOfPackages")
                {
                    packageDataGridView.Rows[e.RowIndex].Cells[5].Value = Properties.Resources.actionBtn;
                }
            }
        }
        public void packagesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e, DataGridView packageDataGridView)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex < 10 && e.RowIndex > -1)
            {
                if (packageDataGridView.Columns[e.ColumnIndex].Name == "actionOfPackages")
                {
                    PackagesAction packagesAction = new PackagesAction(packageDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    packagesAction.ShowDialog();
                    refreshDataGrids(4);
                }
            }
        }

        /// <summary>
        /// ending the Mouse events and starting the Refresh datagrid methods
        /// </summary>
        /// <param name="usersDataGridView"></param>

        private void Refresh_UserDataGridView(DataGridView usersDataGridView)
        {
            usersDataGridView.Rows.Clear();
            showDetailsOfUsersInDataGrid(fireBaseAction.userrDetails(), usersDataGridView);
        }
        private void Refresh_WorkerDataGridView(DataGridView WorkerDataGridView)
        {
            WorkerDataGridView.Rows.Clear();
            showDetailsOfWorkersInDataGrid(fireBaseAction.workerDetails(), WorkerDataGridView);
        }
        private void Refresh_AreaDataGridView(DataGridView AreaDataGridView)
        {
            AreaDataGridView.Rows.Clear();
            showDetailsOfAreaInDataGrid(fireBaseAction.areaDetails(), AreaDataGridView);
        }
        private void Refresh_PackagesDataGridView(DataGridView packagesDataGridView)
        {
            packagesDataGridView.Rows.Clear();
            showDetailsOfPackagesInDataGrid(fireBaseAction.packagesDetails(), packagesDataGridView);
        }

        public void refreshDataGrids(int opt) {
            switch (opt){
                case 1:
                    Refresh_UserDataGridView(userDataGridView);
                    break;
                case 2:
                    Refresh_WorkerDataGridView(workerDataGridView);
                    break;
                case 3:
                    Refresh_AreaDataGridView(areaDataGridView);
                    break;
                case 4:
                    Refresh_PackagesDataGridView(packageDataGridView);
                    break;
            }
        }
        public void refreshDataGridsView(int opt,DataGridView dataGridView)
        {
            switch (opt)
            {
                case 1:
                    Refresh_UserDataGridView(dataGridView);
                    break;
                case 2:
                    Refresh_WorkerDataGridView(dataGridView);
                    break;
                case 3:
                    Refresh_AreaDataGridView(dataGridView);
                    break;
                case 4:
                    Refresh_PackagesDataGridView(dataGridView);
                    break;
            }
        }

        public void searchResult (string text) {

            showDetailsOfUsersInDataGridSearch(fireBaseAction.userrDetails(), userDataGridView, text);

        }
        private void showDetailsOfUsersInDataGridSearch(Dictionary<string, userDetailsData> record, DataGridView usersDataGridView,string text)
        {
          
            userDataGridView.Rows.Clear();
            if (text == "Not-Paid")
            {
                int i = 0;
                if (record == null) return;
                foreach (var item in record)
                {
                    if (item.Value.recevie_Payment == 1)
                    {
                        usersDataGridView.Rows.Add(i, item.Value.nameOF_Client, item.Value.mobileOf_Client, item.Value.addressof_Client, item.Value.areaOf_Client, Properties.Resources.activeBtn, "RS" + "  " + item.Value.getDebt, item.Value.packageOf_Client, Properties.Resources.notreceived);
                        
                    }

                    i++;
                }
            }
            else if (text == "Paid")
            {
                int i = 0;
                if (record == null) return;
                foreach (var item in record)
                {
                    if (item.Value.recevie_Payment != 1)
                    {
                        usersDataGridView.Rows.Add(i, item.Value.nameOF_Client, item.Value.mobileOf_Client, item.Value.addressof_Client, item.Value.areaOf_Client, Properties.Resources.activeBtn, "RS" + "  " + item.Value.getDebt, item.Value.packageOf_Client, Properties.Resources.recieved);
                    }

                    i++;
                }
            }
            else {
                int i = 0;
                if (record == null) return;
                foreach (var item in record)
                {
                    if (item.Value.nameOF_Client.Contains(text))
                    {
                        if (item.Value.recevie_Payment == 1)
                        {
                            usersDataGridView.Rows.Add(i, item.Value.nameOF_Client, item.Value.mobileOf_Client, item.Value.addressof_Client, item.Value.areaOf_Client, Properties.Resources.activeBtn, "RS" + "  " + item.Value.getDebt, item.Value.packageOf_Client, Properties.Resources.notreceived);

                        }
                        else
                        {
                            usersDataGridView.Rows.Add(i, item.Value.nameOF_Client, item.Value.mobileOf_Client, item.Value.addressof_Client, item.Value.areaOf_Client, Properties.Resources.activeBtn, "RS" + "  " + item.Value.getDebt, item.Value.packageOf_Client, Properties.Resources.recieved);

                        }
                        i++;
                    }

                   
                }
            }
          
        }
        /// <summary>
        /// Comparing Image Functions
        /// </summary>
        /// <param name="image1"></param>
        /// <param name="image2"></param>
        /// <returns></returns>
        private static bool CompareImages(Bitmap image1, Bitmap image2)
        {
            if (image1.Width == image2.Width && image1.Height == image2.Height)
            {
                for (int i = 0; i < image1.Width; i++)
                {
                    for (int j = 0; j < image1.Height; j++)
                    {
                        if (image1.GetPixel(i, j) != image2.GetPixel(i, j))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           
            try
            {
                int y_diff = 8;
                e.Graphics.DrawImage(Properties.Resources.printFormat, new Point(0, 0));
                e.Graphics.DrawString("Date Created     :", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(10, 184 + y_diff));
                DateTime now = DateTime.Now;
                e.Graphics.DrawString(now.ToString(), new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(95, 184+y_diff));
                e.Graphics.DrawString("Invoice Number   :", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(10, 221 + y_diff));
                invoiceNumbersDetailsData getInvoiceNumbersDetailsData = fireBaseAction.invoiceNumber().ResultAs<invoiceNumbersDetailsData>();
                e.Graphics.DrawString(getInvoiceNumbersDetailsData.invoiceNumber.ToString(), new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(100,221+y_diff));
                e.Graphics.DrawString("Customer ID      :", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(10, 249 + y_diff));
                e.Graphics.DrawString(customerID, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(100, 249+y_diff));
                e.Graphics.DrawString("Customer Name    :", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(10, 270 + y_diff));
                e.Graphics.DrawString(customerName, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(100, 270+y_diff));
                e.Graphics.DrawString("Internet Package :", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(10, 295 + y_diff));
                e.Graphics.DrawString(internetPackages, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(100, 295+y_diff));
                e.Graphics.DrawString("Internet Package", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(10, 323 + y_diff));
                e.Graphics.DrawString("Cable Package", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(108, 323 + y_diff));
                e.Graphics.DrawString("RS", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(10, 348 + y_diff));
                e.Graphics.DrawString(internetPackagePrice, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(30, 348 + y_diff));
                e.Graphics.DrawString("RS", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(108, 348 + y_diff));
                e.Graphics.DrawString(cablePackagePrice, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(138, 348+y_diff));
                e.Graphics.DrawString("Total Amount", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(10, 377 + y_diff));
                e.Graphics.DrawString("After Discount", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(108, 377 + y_diff));
                e.Graphics.DrawString("RS", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(10, 402 + y_diff));
                int totalamount = Convert.ToInt32(internetPackagePrice) + Convert.ToInt32(cablePackagePrice);
                e.Graphics.DrawString(totalamount.ToString(), new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(30, 402+y_diff));
                e.Graphics.DrawString("RS", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(108, 402 + y_diff));
                e.Graphics.DrawString(totalAmount, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(138, 402+y_diff));
                e.Graphics.DrawString("Genrated By :", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 460 + y_diff));
                if (mode) e.Graphics.DrawString("By Admin", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(100, 460+y_diff));
                else e.Graphics.DrawString("By Workers", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(100, 460+y_diff));
                fireBaseAction.invoiceNumber(getInvoiceNumbersDetailsData.invoiceNumber);
                using (Pen dashed_pen = new Pen(Color.Black, 2))
                {
                    dashed_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    e.Graphics.DrawLine(dashed_pen, 0, 170 + y_diff, 200, 170 + y_diff);
                    e.Graphics.DrawLine(dashed_pen, 0, 436 + y_diff, 200, 436 + y_diff);
                }
            }
            catch (SerializationException)
            {

                MessageBox.Show("Internet Connection is Down");
            }

        }
        public void addPackageBtn_Click(object sender, EventArgs e)
        {
            refreshDataGrids(1);
            refreshDataGrids(4);
        }
        public void addAreaBtn_Click(object sender, EventArgs e)
        {
            refreshDataGrids(1);
            refreshDataGrids(3);
        }
    }
}
 