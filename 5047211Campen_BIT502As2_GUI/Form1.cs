using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _5047211Campen_BIT502As2_GUI
{
    public partial class Form1 : Form
    { 
        /*
         * Setup Form
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
         * Arrays of form controls 
         */
        private TextBox[] FormAreaTextBoxes ()
        {
            TextBox[] formAreaTextBoxes = {tbFirstName, tbLastName, tbAddress1, tbAddress2, tbCity, tbPostcode};
            return formAreaTextBoxes;
        }

        private ComboBox[] FormAreaComboBoxes()
        {
          
            ComboBox[] allComboBoxes = { cbMembershipType, cbMembershipLength, cbPaymentMethod, cbPaymentFreq};
            return allComboBoxes;
        }

        private Label[] FormAreaLabels()
        {
            Label[] formAreaLabels = {labelFirstName, labelLastName, labelAddress1, labelAddress2, labelCity, labelPostcode, labelMembershipType,
            labelMembershipLength, labelPaymentMethod, labelPaymentFreq};
            return formAreaLabels;
        }

        //  As these arrays are referenced by indexing, changes to the order of RequiredFields method should be reflected in the RequiredFieldLabels method too
        private Control[] RequiredFields ()
        {   
            Control[] requiredFields = { tbFirstName, tbLastName, tbAddress1, tbCity, tbPostcode,
            cbMembershipType, cbMembershipLength, cbPaymentMethod, cbPaymentFreq};
                return requiredFields;  
        }

        private Label[] RequiredFieldLabels ()
        {
            Label[] requiredFieldLabelNames = {labelFirstName, labelLastName, labelAddress1, labelCity, labelPostcode, 
            labelMembershipType, labelMembershipLength, labelPaymentMethod, labelPaymentFreq};
            return requiredFieldLabelNames;
        }

        private TextBox[] OutputAreaTextBoxes()
        {
            TextBox[] outputAreaTextBoxes = { tbThanks, tbMembershipCost, tbTotalExtras, tbTotalDiscount, tbNetCost, tbRegularPayment };
            return outputAreaTextBoxes;
        }

        private Label[] OutputAreaLabels()
        {
                Label[] outputAreaLables = { labelMembershipCost, labelMembershipCost, labelTotalExtras, labelTotalDiscount, labelNetCost, labelRegularPayment };
                return outputAreaLables;
        }

        private Button[] OutputAreaButtons()
        {
                Button[] outputAreaButtons = { bSubmit, bReset2 };
                return outputAreaButtons;
        }

        /*
         * Event Handlers 
         */

        private void bCalculate_Click(object sender, EventArgs e)
        {
            if (IsFormValid() is true)
            {
                OutputRates();
                StyleOutputs();
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void bReset2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            SubmitToFile();
        }

        /*
        * Membership Option Cost Lists
        */
        private float[] BaseMembershipCosts ()
        {
            float[] baseMembershipCosts =
            {
                10, //  Basic
                15, //  Regular
                20 //  Premium
            };
            return baseMembershipCosts;
        }

        private float[] MembershipLengthDiscounts ()
        {
            float[] membershipLengthDiscount =
            {
                0, //  3 months
                2, //  12 months
                5 //  24 months 
            };
            return membershipLengthDiscount;
        }

        private float[] PaymentMethodDiscounts ()
        {
            float[] paymentMethodDiscounts =
            {
                0.01F, //  Direct debit (1% discount)
                0 //  Other
            };
            return paymentMethodDiscounts;
        }

        private float[] OptionalExtraCosts()
        {
            float[] optionalExtraCosts =
            {
                1, // 24/7 Access
                20, //  Personal Trainer
                20, // Diet Consultation
                2 // Online videos
            };
            return optionalExtraCosts;
        }

        /*
         * Required Fields - Checking Validity and Styling
         */
        
        //  Returns whether all of the Required fields have a valid input  
        private bool IsFormValid()  
        {
            bool[] validateRequiredFields = ValidateRequiredFields();
            for (int i = 0; i < validateRequiredFields.Length; i++)
            {  
                if (!validateRequiredFields[i]) 
                {
                    return false;
                }
            }
            return true;
        }  

        //  Returns array of required input field validity and has side effect of styling fields
        private bool[] ValidateRequiredFields()  // 
        {  
            Control[] requiredFields = RequiredFields();
            bool[] validateRequiredFields = new bool[requiredFields.Length];  
            for (int i = 0; i < requiredFields.Length; i++)
            {
                validateRequiredFields[i] = !String.IsNullOrEmpty(requiredFields[i].Text);
            }
            StyleRequiredFields(validateRequiredFields);
            return validateRequiredFields;
        }

        //  Changes styling of Required Fields to indicate an error if they are invalid
        private void StyleRequiredFields (bool[] validateRequiredFields)
        {
           Control[] requiredFieldLabels =  RequiredFieldLabels();
            for (int i = 0; i< validateRequiredFields.Length; i++)
            {
                requiredFieldLabels[i].ForeColor = Color.Black; 
                if (validateRequiredFields[i] == false)   
                {
                    requiredFieldLabels[i].ForeColor = Color.Red;
                }
            }
        }

       private float CalculateTotalExtras()
        {
            float[] optionalExtraCosts = MapOptionalFieldCosts();
            float sum = 0;
            foreach (var item in optionalExtraCosts)
            {
                sum += item;
            }
            return sum;  
        }

        //  Maps user selections to array of Extra Costs
        private float[] MapOptionalFieldCosts()
        { 
            float[] optionalExtraCosts = OptionalExtraCosts();
            float[] mapOptionalCoststoValue = new float[optionalExtraCosts.Length];
            for (int i = 0; i < optionalExtraCosts.Length; i++)
            {
                bool extraIsChecked = clExtras.GetItemCheckState(i) == CheckState.Checked;
                if (extraIsChecked)  
                {
                    mapOptionalCoststoValue[i] = optionalExtraCosts[i];
                }
                else
                {
                    mapOptionalCoststoValue[i] = 0;
                }

            }
            return mapOptionalCoststoValue;
        }
          
        /*
         * Calculate Membership Rates
         */
        private float CalculateRegularPayment()
        {
            switch (cbPaymentFreq.SelectedIndex)
            {
                case 1:
                    {
                        return ((CalculateNetMembershipCost() * 52) / 12); //  returns monthly payment
                    }
                default:
                    {
                        return CalculateNetMembershipCost(); //  returns weekly payment
                    }
            }
        }

        private float CalculateNetMembershipCost()
        {
            return MapBaseCost() - CalculateTotalDiscount() + CalculateTotalExtras();
        }

        private float CalculateTotalDiscount()
        {
            return MapMembershipLengthDiscount() + (MapBaseCost() * MapPaymentMethodDiscount());
        }

        private float MapMembershipLengthDiscount ()
        {
            return MembershipLengthDiscounts()[cbMembershipLength.SelectedIndex];
        }

        private float MapPaymentMethodDiscount()
        {
            return PaymentMethodDiscounts()[cbPaymentMethod.SelectedIndex];
        }

        private float MapBaseCost()
        {
           return BaseMembershipCosts()[cbMembershipType.SelectedIndex];
        }

        /*
         * OUTPUT MEMBERSHIP RATES
         */
        private void OutputRates()
        {
            tbThanks.Text = "Thanks " + tbFirstName.Text + "!";
            tbMembershipCost.Text = MapBaseCost().ToString("C");
            tbTotalExtras.Text = CalculateTotalExtras().ToString("C");
            tbTotalDiscount.Text = CalculateTotalDiscount().ToString("C");
            tbNetCost.Text = CalculateNetMembershipCost().ToString("C");
            tbRegularPayment.Text = CalculateRegularPayment().ToString("C") + " " + cbPaymentFreq.Text;
        }

        //  Makes all controls in the Output Area visible and has side effect of turning Calculate button white
        private void StyleOutputs ()
        {
            TextBox[] outputAreaTextBoxes = OutputAreaTextBoxes();
            foreach(TextBox i in outputAreaTextBoxes)
            {
                i.Visible = true;
            }

            Label[] outputAreaLabels = OutputAreaLabels();
            foreach (Label i in outputAreaLabels)
            {
                i.Visible = true;
            }
            Button[] outputAreaButtons = OutputAreaButtons();
            foreach (Button i in outputAreaButtons)
            {
                i.Visible = true;
            }
            
            bCalculate.BackColor = Color.White;
            bCalculate.ForeColor = Color.Black;
            bSubmit.Focus();
        }

        private void ClearForm ()
        {
            ClearTextBoxes();
            ClearComboBoxes();
            ClearCheckedList();
            ResetFormAreaStyling();
            ResetOutputAreaStyling();
        }

        private void ClearTextBoxes ()
        {
            TextBox[] formAreaTextBoxes = FormAreaTextBoxes();
            for (int i = 0; i< formAreaTextBoxes.Length; i++)
            {
                formAreaTextBoxes[i].Clear();
            }
        }

       private void ClearComboBoxes()
        {
            ComboBox[] formAreaComboBoxes = FormAreaComboBoxes();
            for (int i = 0; i < formAreaComboBoxes.Length; i++)
            {
                formAreaComboBoxes[i].SelectedIndex = -1;
            }
        }

        private void ClearCheckedList()
        {
            clExtras.SelectedIndex = -1;
            foreach (int i in clExtras.CheckedIndices)
            {
                clExtras.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        //  Makes text of labels in Form Area black, and changes Calculate button back colour to blue       
        private void ResetFormAreaStyling ()
        {
            Label[] formAreaLabels = FormAreaLabels();
            foreach (Label i in formAreaLabels)
            {
                i.ForeColor = Color.Black;
            }

            bCalculate.BackColor = Color.DodgerBlue;
        }

        //  Hides controls in the Output Area
        private void ResetOutputAreaStyling()
        {

            TextBox[] outputAreaTextBoxes = OutputAreaTextBoxes();
            foreach (TextBox i in outputAreaTextBoxes)
            {
                i.Visible = false;
            }
            Label[] outputAreaLabels = OutputAreaLabels();
            foreach (Label i in outputAreaLabels)
            {
                i.Visible = false;
            }
            Button[] outputAreaButtons = OutputAreaButtons();
            foreach (Button i in outputAreaButtons)
            {
                i.Visible = false;
            }
        }

        //  Saves membership application and rates to new file
        private void SubmitToFile()
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string datetime = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now); //  Unique date/time stamp in case people with same name submit applications
            firstName.Replace(" ", ""); //  Remove spaces for naming of file
            lastName.Replace(" ", ""); //  Remove spaces for naming of file
            TextWriter wr = new StreamWriter("C:/Temp/Application_" + lastName + "_" + firstName + "_" + datetime + ".txt");
            wr.WriteLine("New application submitted " + datetime);
            wr.WriteLine("\r\nFirst Name: " + tbFirstName.Text);
            wr.WriteLine("Last Name: " + tbLastName.Text);
            wr.WriteLine("Address Line 1: " + tbAddress1.Text);
            wr.WriteLine("Address Line 2: " + tbAddress2.Text);
            wr.WriteLine("City: " + tbCity.Text);
            wr.WriteLine("Postcode: " + tbCity.Text);
            wr.WriteLine("\r\nBase membership Type: " + cbMembershipType.Text);
            wr.WriteLine("Membership duration: " + cbMembershipLength.Text);
            wr.WriteLine("Payment method: " + cbPaymentMethod.Text);
            wr.WriteLine("Payment frequency: " + cbPaymentFreq.Text);
            var selectedExtras = new List<string>();

            foreach (var extra in clExtras.CheckedItems) //  Outputs the selected Optional Extras as a string
            {
                selectedExtras.Add(extra.ToString());
            }
            string strExtras = string.Join(", ", selectedExtras);
            wr.WriteLine("Optional Extras: " + strExtras);

            wr.WriteLine("\r\nMembership Rates");
            wr.WriteLine("Base membership Cost: " + tbMembershipCost.Text);
            wr.WriteLine("Total Extras: " + tbTotalExtras.Text);
            wr.WriteLine("Total Discount: " + tbTotalDiscount.Text);
            wr.WriteLine("Net Cost: " + tbNetCost.Text);
            wr.WriteLine("Regular Payment: " + tbRegularPayment.Text);
            wr.Close();
            bSubmit.Visible = false;
            bReset2.Visible = false;
            labelConfirmSubmit.Visible = true;
        }       
    }
}


