namespace ISP_MANAGMENT_SYSTETEM
{
    class userDetailsData
    {
        public string customer_Id { get; set; }
        public string nameOF_Client { get; set; }
        public string mobileOf_Client { get; set; }
        public string addressof_Client { get; set; }
        public string packageOf_Client { get; set; }
        public string cablePackageof_Client { get; set; }
        public string areaOf_Client { get; set; }
        public int recevie_Payment { get; set; }
        public int getDebt { get; set; }
    }
    class workersDetailsData
    {
        public string worker_ID { get; set; }
        public string worker_Name { get; set; }
        public string worker_Mobile { get; set; }
        public string worker_Adress { get; set; }
        public string worker_pay { get; set; }
        public string worker_Comission { get; set; }
        public string worker_Area { get; set; }
        public int recevie_Payment { get; set; }
    }
    class areaDetailsData
    {
        public string area_Name { get; set; }
        public string worker_Name { get; set; }
        public string secondWorker_Name { get; set; }
        public string thirdWorker_Name { get; set; }
    }
    class packageDetailsData
    {
        public string package_ID { get; set; }
        public string package_Name { get; set; }
        public string actual_Price { get; set; }
        public string priceTo_Client { get; set; }
    }
    class settingsDetailsData 
    {
        public int id { get; set; }
        public string email_ID { get; set; }
        public string pasword { get; set; }
     
    }
    class invoiceNumbersDetailsData
    {
      public int invoiceNumber { get; set; }
    }
}
