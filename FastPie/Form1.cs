/*  Assignment:     Project 7 Pizza App
 *  Chapter:        10
 *  Problem:        10
 *  Page:           690
 *  Developer:      Joshua Fischer
 *  Date:           04/07/2015
 *  Purpose:        Create a Pizza ordering app
 *                  for a Pizza Delivery Company.
 *                  Provide a place for user to enter
 *                  contact information, as well as choose
 *                  at least 12 items to place on Pizza.
 *                  Must include a logo, display the price,
 *                  and allow the user to change order. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FastPie
{
    public partial class Form1 : Form
    {
        int cnt = 1;

        double[] pizzaPrice = new double[25];

        string contactString,
               orderString;

        Random rnd = new Random();

        StreamWriter writeToOrder;
        StreamReader readFromOrder;
        PizzaClass PizzaObject;


        public Form1()
        {
            InitializeComponent();
        }

        //This saves all the contact data into a string to be used at checkout.        
        private void btnContactSubmit_Click(object sender, EventArgs e)
        {
            string zip = "",
                   phone = "";

            int orderNumber = rnd.Next(1000); 
            
            //resets the background color incase an exception thrown
            txBxZip.BackColor = Color.White;
            txBxZip.ForeColor = Color.Black;
            txBxPhone.BackColor = Color.White;
            txBxPhone.ForeColor = Color.Black;


            
            
            
            try
            {
                //This tests zipcode and phone number for length and int.
                GetZip(txBxZip.Text, out zip);
                GetPhone(txBxPhone.Text, out phone);

                //If no exception thrown it saves all contact data to contact string.
                contactString = ("Order Number: " + orderNumber + Environment.NewLine + Environment.NewLine +
                                txBxName.Text + Environment.NewLine +
                                txBxStreet.Text + Environment.NewLine +
                                txBxCity.Text +  " " + cmbBXState.Text + ", " + zip + ", " + Environment.NewLine +
                                "Phone number :" + phone +
                                Environment.NewLine + Environment.NewLine);

                //It also hides the label "Contact info needed" and moves to next tab.
                lblContactInfo.Visible = false;
                this.tabControl1.SelectedTab = tabPgSize;
                grpBxSize.Visible = true;

            }

            //If exception is thrown for zip code and phone number this
            // this will set the background color of the text box to red.
            catch (InvalidOperationException exc)
            {
                MessageBox.Show(exc.Message, "Error");

                if (exc.Message.Contains("zip"))
                {
                    txBxZip.Text = "";
                    txBxZip.BackColor = Color.Red;
                    txBxZip.ForeColor = Color.White;
                }
                else if (exc.Message.Contains("phone"))
                {
                    txBxPhone.Text = "";
                    txBxPhone.BackColor = Color.Red;
                    txBxPhone.ForeColor = Color.White;
                }
            }

        }

        //Tests for int and length, throws exception if incorrect
        private static void GetZip(string inputZip, out string zip)
        {
            long num;

            if (long.TryParse(inputZip, out num) == false)
            {
                throw new InvalidOperationException("Letter used in zip");    
            }

            else if (inputZip.Length != 5)
            {
                throw new InvalidOperationException("Length of zip not correct");
            }
            else
                zip = inputZip;

        }

        //Tests for int and length, throws exception if incorrect
        private static void GetPhone(string inputPhone, out string phone)
        {
            long num;

            if (long.TryParse(inputPhone, out num) == false)
            {
                throw new InvalidOperationException("Letter used in phone number");
            }

            else if (inputPhone.Length != 10)
            {
                throw new InvalidOperationException("Length of phone not correct");
            }
            else
                phone = inputPhone;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PizzaObject = new PizzaClass();
            
            PizzaObject.Cnt = cnt;
            GetSize();
            GetCrust();
            GetMeat();
            GetVeggie();
            PizzaObject.Price = pizzaPrice[cnt];

            orderString += PizzaObject.ToString();
            txBxCurrentTotal.Text = pizzaPrice.Sum().ToString("C");
            txBxPizzaCnt.Text = (cnt).ToString();

            ResetAllBtn();

            btnAdd.Visible = false;
            btnCheckout.Visible = true;

            
            this.tabControl1.SelectedTab = tabPgSize;
            this.pictureBox1.BackgroundImage = Image.FromFile("FastPieLogo.png");
            cnt++;
                        
        }

        //Saves the size of the pizzaobject as string
        //It also adds the price to the price array for that pizza
        private void GetSize()
        {
            if (this.radBtnSizeXSmall.Checked == true)
            {
                 PizzaObject.Size = radBtnSizeXSmall.Text;
                 pizzaPrice[cnt] += 4;
            }
            else if (this.radBtnSizeSmall.Checked == true)
            {
                PizzaObject.Size = radBtnSizeSmall.Text;
                pizzaPrice[cnt] += 6;
            }
            else if (this.radBtnSizeMedium.Checked == true)
            {
                PizzaObject.Size = radBtnSizeMedium.Text;
                pizzaPrice[cnt] += 8;
            }
            else if (this.radBtnSizeLarge.Checked == true)
            {
                PizzaObject.Size = radBtnSizeLarge.Text;
                pizzaPrice[cnt] += 10;
            }
            else if (this.radBtnSizeXLarge.Checked == true)
            {
                PizzaObject.Size = radBtnSizeXLarge.Text;
                pizzaPrice[cnt] += 13;
            }
        }

        private void GetCrust()
        {
            if (this.radBtnCrustHand.Checked == true)
            {
                PizzaObject.Crust = radBtnCrustHand.Text;
            }
            else if (this.radBtnCrustNewYork.Checked == true)
            {
                PizzaObject.Crust = radBtnCrustNewYork.Text;
            }
            else if (this.radBtnCrustChicago.Checked == true)
            {
                PizzaObject.Crust = radBtnCrustChicago.Text;
            }
            else if (this.radBtnCrustGluten.Checked == true)
            {
                PizzaObject.Crust = radBtnCrustGluten.Text;
            }
            else if (this.radBtnCrustCrunchyThin.Checked == true)
            {
                PizzaObject.Crust = radBtnCrustCrunchyThin.Text;
            }
            
            this.tabControl1.SelectedTab = tabPgMeat;
            
        }

        private void GetMeat()
        {
            foreach (string val in chLstBxMeat.CheckedItems)
            {
                PizzaObject.Meat += val + ", ";
                pizzaPrice[cnt] += .50;
            }
        }

        private void GetVeggie()
        {
            foreach (string val in chLstBxVeggie.CheckedItems)
            {
                PizzaObject.Veggie += val + ", ";
                pizzaPrice[cnt] += .35;
            }
        }

        public void ResetAllBtn()
        {
            //clears all the size and crust rad btn
            radBtnSizeXSmall.Checked = false;
            radBtnSizeSmall.Checked = false;
            radBtnSizeMedium.Checked = false;
            radBtnSizeLarge.Checked = false;
            radBtnSizeXLarge.Checked = false;

            radBtnCrustCrunchyThin.Checked = false;
            radBtnCrustChicago.Checked = false;
            radBtnCrustGluten.Checked = false;
            radBtnCrustNewYork.Checked = false;
            radBtnCrustHand.Checked = false;
            
            //loop to remove the checked meat items
            for (int cnt = 0; chLstBxMeat.CheckedItems.Count > 0; cnt++)
            {
                chLstBxMeat.SetItemChecked(cnt, false);
            }

            //loop to remove the checked veggie items
            for (int cnt = 0; chLstBxVeggie.CheckedItems.Count > 0; cnt++)
            {
                chLstBxVeggie.SetItemChecked(cnt, false);
            }
        }

               
        //Used to change the picture and move to the next tab
        private void radBtnSizeXSmall_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = Image.FromFile("xsmall.png");
            this.tabControl1.SelectedTab = tabPgCrust;
            this.grpBxCrust.Visible = true;
            
        }
        private void radBtnSizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = Image.FromFile("small.png");
            this.tabControl1.SelectedTab = tabPgCrust;
            this.grpBxCrust.Visible = true;
        }
        private void radBtnSizeMedium_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = Image.FromFile("medium.png");
            this.tabControl1.SelectedTab = tabPgCrust;
            this.grpBxCrust.Visible = true;
        }
        private void radBtnSizeLarge_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = Image.FromFile("large.png");
            this.tabControl1.SelectedTab = tabPgCrust;
            this.grpBxCrust.Visible = true;
        }
        private void radBtnSizeXLarge_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = Image.FromFile("xlarge.png");
            this.tabControl1.SelectedTab = tabPgCrust;
            this.grpBxCrust.Visible = true;
        }

          
        //Used to change the picture of the meats on Pizza
        private void chLstBxMeat_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string curItem = chLstBxMeat.SelectedItem.ToString();

            if (curItem == "Pepperoni")
                this.pictureBox1.BackgroundImage = Image.FromFile("meat.p.png");

            else if (curItem == "Italian Sausage")
                this.pictureBox1.BackgroundImage = Image.FromFile("meat.i.png");

            else if (curItem == "Beef")
                this.pictureBox1.BackgroundImage = Image.FromFile("meat.b.png");

            else if (curItem == "Bacon")
                this.pictureBox1.BackgroundImage = Image.FromFile("meat.ba.png");

            else if (curItem == "Philly Steak")
                this.pictureBox1.BackgroundImage = Image.FromFile("meat.ph.png");

            else if (curItem == "Ham")
                this.pictureBox1.BackgroundImage = Image.FromFile("meat.h.png");

        }

        //Compiles all the data and writes it to a txt file.
        //It then reads that same file to pop up a message box with details.
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            double subtotal = 0;
            string invalue,
                   pizzaOrderDetails = contactString;

                //writes just the pizza details to the file
                writeToOrder = new StreamWriter("order.txt");
                writeToOrder.WriteLine(orderString);
                writeToOrder.Close();

                readFromOrder = new StreamReader("order.txt");

                //reads the file and saves each line to a string
                while ((invalue = readFromOrder.ReadLine()) != null)
                {
                    pizzaOrderDetails += (invalue + Environment.NewLine);
                }

                //used to get the subtotal of the price array with the discount
                for (int i = 1; i < 24; i++)
                {
                    subtotal += pizzaPrice[i];
                }
                //adds the subtotal, discount, and total to the end of the string
                pizzaOrderDetails += ("Subtotal :\t" + subtotal.ToString("C") +
                                    "\n" + MakeDiscountString() +
                                    "\nTotal    :\t" + pizzaPrice.Sum().ToString("C"));

                readFromOrder.Close();
                
            //sends the string with the contact info, pizza details, and price to message box
                MessageBox.Show(pizzaOrderDetails);
            
            this.Close();            
        }

        

        //Used to move to the next tab
        private void radBtnCrustHand_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPgMeat;
            MakeMeatAndCheeseVis();
        }
        private void radBtnCrustNewYork_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPgMeat;
            MakeMeatAndCheeseVis();
        }
        private void radBtnCrustChicago_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPgMeat;
            MakeMeatAndCheeseVis();
        }
        private void radBtnCrustCrunchyThin_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPgMeat;
            MakeMeatAndCheeseVis();
        }
        private void radBtnCrustGluten_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPgMeat;
            MakeMeatAndCheeseVis();
        }
             
        //resets all data
        private void btnStartOver_Click(object sender, EventArgs e)
        {
            btnCheckout.Visible = false;
            this.tabControl1.SelectedTab = tabPgContact;
            this.grpBxSize.Visible = false;
            this.grpBxCrust.Visible = false;
            this.chLstBxMeat.Visible = false;
            btnChangeTabMeat.Visible = false;
            this.chLstBxVeggie.Visible = false;
            lblContactInfo.Visible = true;
            btnDiscount.Visible = true;
            lblMeatPrice.Visible = false;
            lblVeggiePrice.Visible = false;

            //clears all the contact tab info
            txBxName.Text = "";
            txBxStreet.Text = "";
            txBxCity.Text = "";
            txBxZip.Text = "";
            txBxPhone.Text = "";
            txBxCurrentTotal.Text = "";

            //clears the previous pizza info
            contactString = "";
            orderString = "";
            this.cnt = 1;
            
            ResetAllBtn();

            //clears the price array
            for (int cnt = 0; cnt < 25; cnt++)
            {
                pizzaPrice[cnt] = 0;
            }

            txBxDiscount.Enabled = true;
            txBxDiscount.Text = "";
            txBxPizzaCnt.Text = "";
            

        }

        //moves to the veggie tab within the meat tab
        private void btnChangeTabMeat_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPgVeggie;
        }

        //applies discount, changes current total txbx
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            switch (txBxDiscount.Text)
            {
                case "doyle": pizzaPrice[0] = -3;
                    break;
                default: MessageBox.Show("Code not found", "Error");
                    break;
            }

            txBxDiscount.Enabled = false;
            txBxCurrentTotal.Text = pizzaPrice.Sum().ToString("C");
            btnDiscount.Visible = false;

        }

        //determines if a discount is added, if not sends empty string
        private string MakeDiscountString()
        {
            string discount;
            if (pizzaPrice[0] != 0)
            {
                discount = "Discount :\t " + pizzaPrice[0].ToString("C"); 
            }
            else
            {
                discount = "";
            }
            return discount;
        }
        
        //used to change tabs after a crust is picked
        private void MakeMeatAndCheeseVis()
        {
            chLstBxMeat.Visible = true;
            btnChangeTabMeat.Visible = true;
            chLstBxVeggie.Visible = true;
            btnAdd.Visible = true;
            lblMeatPrice.Visible = true;
            lblVeggiePrice.Visible = true;
        }
                 
    }
}
