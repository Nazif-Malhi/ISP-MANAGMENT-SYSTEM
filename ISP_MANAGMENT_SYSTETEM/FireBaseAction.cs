 using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    class FireBaseAction
    {
        FireBase fireBase = new FireBase();

        public FireBaseAction() 
        {
            try
            {
                fireBase.client = new FireSharp.FirebaseClient(fireBase.config);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occures Due To " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Worker details to insert the data in comboBox
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, userDetailsData> userrDetails()
        {
            FirebaseResponse firebaseResponse = fireBase.client.Get("F4-Fiber/Users/");
            Dictionary<string, userDetailsData> package = JsonConvert.DeserializeObject<Dictionary<string, userDetailsData>>(firebaseResponse.Body.ToString());
            return package;
        }
        public Dictionary<string, workersDetailsData>  workerDetails() {
            FirebaseResponse firebaseResponse = fireBase.client.Get("F4-Fiber/WorkersDetails/");
            Dictionary<string, workersDetailsData> package = JsonConvert.DeserializeObject<Dictionary<string, workersDetailsData>>(firebaseResponse.Body.ToString());
            return package;
        }

        public Dictionary<string, packageDetailsData> packagesDetails()
        {
            FirebaseResponse firebaseResponse = fireBase.client.Get("F4-Fiber/Packages/");
            Dictionary<string, packageDetailsData> package = JsonConvert.DeserializeObject<Dictionary<string, packageDetailsData>>(firebaseResponse.Body.ToString());
            return package;
        }
        public Dictionary<string, areaDetailsData> areaDetails()
        {
            FirebaseResponse firebaseResponse = fireBase.client.Get("F4-Fiber/Area/");
            Dictionary<string, areaDetailsData> package = JsonConvert.DeserializeObject<Dictionary<string, areaDetailsData>>(firebaseResponse.Body.ToString());
            return package;
        }
      

        /// <summary>
        /// Area details to insert the fields on forms
        /// </summary>
        /// <param name="nameKey"></param>
        /// <returns></returns>
        public FirebaseResponse AreaDetails(string nameKey) {
            var result = fireBase.client.Get("F4-Fiber/Area/" + nameKey);
            return result;
        }
        public FirebaseResponse userDetails(string nameKey)
        {
            var result = fireBase.client.Get("F4-Fiber/Users/" + nameKey);
            return result;
        }
        public FirebaseResponse packageDetails(string nameKey)
        {
            var result = fireBase.client.Get("F4-Fiber/Packages/" + nameKey);
            return result;
        }
        public FirebaseResponse workerDetails(string nameKey)
        {
            var result = fireBase.client.Get("F4-Fiber/WorkersDetails/" + nameKey);
            return result;
        }
        public FirebaseResponse settingsDetails(int nameKey)
        {
            var result = fireBase.client.Get("F4-Fiber/Settings/" + nameKey);
            return result;
        }
        //Invoice
        public FirebaseResponse invoiceNumber()
        {

            string totalNumberOfInvoice = "totalNumberOfInvoice";
            var result = fireBase.client.Get("F4-Fiber/Invoice/"+totalNumberOfInvoice);
            return result;
        }





        /// <summary>
        /// update Data in In Area
        /// </summary>
        /// <param name="areaName"></param>
        /// <param name="workerName"></param>
        /// <param name="secondWorkername"></param>
        /// <param name="thirdWorkerName"></param>
        public async Task insertDataInAreaAsync(string areaName,string workerName,string secondWorkername,string thirdWorkerName,bool update) {
            var data = new areaDetailsData
            {
                area_Name=areaName,
                worker_Name=workerName,
                secondWorker_Name=secondWorkername,
                thirdWorker_Name=thirdWorkerName
            };
            if (update)
            {
                if (CheckForInternetConnection())
                {
                    var setters1 = fireBase.client.Update("F4-Fiber/Area/" + areaName, data);
                    MessageBox.Show("Area is updated succesfully");
                }
                else MessageBox.Show("Network is down");
               
            }
            else {
                if (CheckForInternetConnection())
                {
                    SetResponse response = await fireBase.client.SetTaskAsync("F4-Fiber/Area/" + areaName, data);
                    areaDetailsData result = response.ResultAs<areaDetailsData>();
                    MessageBox.Show("Area inserted " + result.area_Name);
                }
                else MessageBox.Show("Network is down");
               
            }
        }
        public async Task insertDataInUserAsync(
            string customerID,
            string nameOfClient,
            string mobileNumber,
            string address,
            string package,
            string cablePackage,
            string area,
            int pay,
            int debt,
            bool update)
        {
            var data = new userDetailsData
            {
                customer_Id = customerID,
                nameOF_Client = nameOfClient,
                mobileOf_Client = mobileNumber,
                addressof_Client = address,
                packageOf_Client = package,
                cablePackageof_Client=cablePackage,
                areaOf_Client = area,
                recevie_Payment = pay,
                getDebt = debt
            };
            if (update)
            {
                if (CheckForInternetConnection())
                {
                    var setters = fireBase.client.Update("F4-Fiber/Users/" + nameOfClient, data);
                    MessageBox.Show("User is updated ");
                }
                else MessageBox.Show("Network is down");
            }
            else
            {
               
                if (CheckForInternetConnection())
                {
                    SetResponse response = await fireBase.client.SetTaskAsync("F4-Fiber/Users/" + nameOfClient, data);
                    userDetailsData result = response.ResultAs<userDetailsData>();
                    MessageBox.Show("User inserted " + result.nameOF_Client);
                }
                else MessageBox.Show("Network is down");
            }
        }
        public async Task insertDataInPackageAsync(string packageID,string packageName,string priceToClient,string actualPrice,bool update)
        {
            var data = new packageDetailsData
            {
                package_ID = packageID,
                package_Name = packageName,
                priceTo_Client = priceToClient,
                actual_Price = actualPrice
            };
            if (update)
            {
                if (CheckForInternetConnection())
                {
                    var setters = fireBase.client.Update("F4-Fiber/Packages/" + packageName, data);
                    MessageBox.Show("Package is Updated Succesfully");
                }
                else MessageBox.Show("Net is down");
            }
            else
            {
                if (CheckForInternetConnection())
                {
                    SetResponse response = await fireBase.client.SetTaskAsync("F4-Fiber/Packages/" + packageName, data);
                    packageDetailsData result = response.ResultAs<packageDetailsData>();
                    MessageBox.Show("Packages inserted " + result.package_Name);
                }
                else MessageBox.Show("Net is down");
            }
        }
        public async Task insertDataInWorkerAsync(string workerID,string workerName,string workerMobile,string workerAdress,string workerPay,string commison,int pay,string workerArea,bool update)
        {
            var data = new workersDetailsData
            {
                worker_ID = workerID,
                worker_Name = workerName,
                worker_Mobile = workerMobile,
                worker_Adress = workerAdress,
                worker_pay = workerPay,
                worker_Comission = commison,
                recevie_Payment = pay,
                worker_Area = workerArea

            };
            if (update)
            {
                if (CheckForInternetConnection())
                {
                    var setters = fireBase.client.Update("F4-Fiber/WorkersDetails/" + workerName, data);
                    MessageBox.Show("Updated successfully");
                }
                else MessageBox.Show("Net is down"); 
            }
            else
            {
                if (CheckForInternetConnection())
                {
                    SetResponse response = await fireBase.client.SetTaskAsync("F4-Fiber/WorkersDetails/" + workerName, data);
                    workersDetailsData result = response.ResultAs<workersDetailsData>();
                    MessageBox.Show("Packages inserted " + result.worker_Name);
                }
                else MessageBox.Show("Net is down");
                          
                      
            }
        }
        public void insertDataInSettingsAsync(string email_ID,string password,bool mainForm)
        {
            int id = 1;
            var data = new settingsDetailsData
            {
                id = id,
              email_ID=email_ID,
              pasword=password
            };
            if (CheckForInternetConnection())
            {
                var setters = fireBase.client.Update("F4-Fiber/Settings/" + id, data);
                if (!mainForm)
                {
                    MessageBox.Show("Updated Succesfully");
                }
            }
            else MessageBox.Show("Net is down");
         
        }
        public void invoiceNumber(int invoiceNumber) {
            string totalNumberOfInvoice = "totalNumberOfInvoice";
            invoiceNumber++;
            var data = new invoiceNumbersDetailsData {
             invoiceNumber =invoiceNumber
            };
            if (CheckForInternetConnection())
            {
                var setters = fireBase.client.Update("F4-Fiber/Invoice/" + totalNumberOfInvoice, data);
            }
            else MessageBox.Show("Net is down");
            
        }

        /// <summary>
        /// delete the elements by pasing path accessible to all
        /// </summary>
        /// <param name="path"></param>
        public void deleteData(string path)
        {
            var setters = fireBase.client.Delete(path);
            MessageBox.Show("Deleted Succesfully");
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
