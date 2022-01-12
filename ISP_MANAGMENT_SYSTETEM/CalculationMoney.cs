using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    class CalculationMoney
    {

        public int getAmountInActionInternet(string packagename, string cablePackageName, ComboBox cableDiscountComboBox, ComboBox internetDiscountComboBox, TextBox extraCharges, ArrayList packageName, ArrayList packagePrice, int pay,int previouseDebt) {
            if (pay == 0) return 0;
            else {

                int amountOfInternet = 0, amountOfcable = 0, totalamount = 0;

                totalamount += previouseDebt;
               
                for (int i = 0; i < packageName.Count; i++)
                {
                    if (packagename == packageName[i].ToString())
                    {
                      
                            amountOfInternet += Convert.ToInt32(packagePrice[i]);
                        
                    }
                    if (cablePackageName == packageName[i].ToString())
                    {
                            amountOfcable = Convert.ToInt32(packagePrice[i]);
                       
                    }
                }
                if (extraCharges.Text != "")
                {
                    totalamount += Convert.ToInt32(extraCharges.Text);
                }
                if ((cableDiscountComboBox.Text != "") || (internetDiscountComboBox.Text != ""))
                {
                    if ((cableDiscountComboBox.Text != "1/3") && (cableDiscountComboBox.Text != "1/2") && (cableDiscountComboBox.Text != "2/3") && (cableDiscountComboBox.Text != ""))
                    {
                        amountOfcable -= Convert.ToInt32(cableDiscountComboBox.Text);
                    }
                    if ((internetDiscountComboBox.Text != "1/3") && (internetDiscountComboBox.Text != "1/2") && (internetDiscountComboBox.Text != "2/3") && (internetDiscountComboBox.Text != ""))
                    {
                        amountOfInternet -= Convert.ToInt32(internetDiscountComboBox.Text);
                    }
                    if ((cableDiscountComboBox.Text == "1/3") || (cableDiscountComboBox.Text == "1/2") || (cableDiscountComboBox.Text == "2/3"))
                    {
                        if (cableDiscountComboBox.Text == "1/3")
                        {
                            amountOfcable = (amountOfcable / 3);
                        }
                        else if (cableDiscountComboBox.Text == "1/2")
                        {
                            amountOfcable = (amountOfcable / 2);
                        }
                        else if (cableDiscountComboBox.Text == "2/3")
                        {
                            amountOfcable = ((2 * amountOfcable) / 3);
                        }
                    }
                    if ((internetDiscountComboBox.Text == "1/3") || (internetDiscountComboBox.Text == "1/2") || (internetDiscountComboBox.Text == "2/3"))
                    {
                        if (internetDiscountComboBox.Text == "1/3")
                        {
                            amountOfInternet = (amountOfInternet / 3);
                        }
                        else if (internetDiscountComboBox.Text == "1/2")
                        {
                            amountOfInternet = (amountOfInternet / 2);
                        }
                        else if (internetDiscountComboBox.Text == "2/3")
                        {
                            amountOfInternet = ((2 * amountOfInternet) / 3);
                        }
                    }
                }
                totalamount += amountOfcable + amountOfInternet;
                return totalamount;
            }
        }
      
        public int getAmountOfClient(string packagename,string cablePackageName,ComboBox cableDiscountComboBox,ComboBox internetDiscountComboBox,TextBox extraCharges,ArrayList packageName,ArrayList packagePrice,int pay)
        {
            if (pay == 0) return 0;
            else
            {
                int amountOfInternet=0,amountOfcable = 0;
                for (int i = 0; i < packageName.Count; i++)
                {
                    if (packagename == packageName[i].ToString())
                    {
                        amountOfInternet = Convert.ToInt32(packagePrice[i]);
                    }
                    if (cablePackageName == packageName[i].ToString()) {

                        amountOfcable = Convert.ToInt32(packagePrice[i]);

                    }
                }
               
                if ((cableDiscountComboBox.Text != "") || (internetDiscountComboBox.Text != ""))
                {
                    if ((cableDiscountComboBox.Text != "1/3") && (cableDiscountComboBox.Text != "1/2") && (cableDiscountComboBox.Text != "2/3") && (cableDiscountComboBox.Text != ""))
                    {
                        amountOfcable -= Convert.ToInt32(cableDiscountComboBox.Text);
                    }
                    if ((internetDiscountComboBox.Text != "1/3") && (internetDiscountComboBox.Text != "1/2") && (internetDiscountComboBox.Text != "2/3") && (internetDiscountComboBox.Text != ""))
                    {
                        amountOfInternet -= Convert.ToInt32(internetDiscountComboBox.Text);
                    }
                    if ((cableDiscountComboBox.Text == "1/3") || (cableDiscountComboBox.Text == "1/2") || (cableDiscountComboBox.Text == "2/3"))
                    {
                        if (cableDiscountComboBox.Text == "1/3")
                        {
                            amountOfcable = (amountOfcable / 3);
                        }
                        else if (cableDiscountComboBox.Text == "1/2")
                        {
                            amountOfcable = (amountOfcable / 2);
                        }
                        else if (cableDiscountComboBox.Text == "2/3")
                        {
                            amountOfcable = ((2 * amountOfcable) / 3);
                        }
                    }
                    if ((internetDiscountComboBox.Text == "1/3") || (internetDiscountComboBox.Text == "1/2") || (internetDiscountComboBox.Text == "2/3"))
                    {
                        if (internetDiscountComboBox.Text == "1/3")
                        {
                            amountOfInternet = (amountOfInternet / 3);
                        }
                        else if (internetDiscountComboBox.Text == "1/2")
                        {
                            amountOfInternet = (amountOfInternet / 2);
                        }
                        else if (internetDiscountComboBox.Text == "2/3")
                        {
                            amountOfInternet = ((2 * amountOfInternet) / 3);
                        }
                    }
                }
                int finalamount = amountOfInternet + amountOfcable;
                if (extraCharges.Text != "")
                {
                    finalamount += Convert.ToInt32(extraCharges.Text);
                }
                
                return finalamount;
            }
        }
    }
}
