
namespace _5047211Campen_BIT502As2_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.labelRegularPayment = new System.Windows.Forms.Label();
            this.labelNetCost = new System.Windows.Forms.Label();
            this.labelTotalDiscount = new System.Windows.Forms.Label();
            this.labelTotalExtras = new System.Windows.Forms.Label();
            this.labelMembershipCost = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.bCalculate = new System.Windows.Forms.Button();
            this.clExtras = new System.Windows.Forms.CheckedListBox();
            this.labelPaymentFreq = new System.Windows.Forms.Label();
            this.labelMembershipType = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelOptionalExtras = new System.Windows.Forms.Label();
            this.labelMembershipLength = new System.Windows.Forms.Label();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbPaymentFreq = new System.Windows.Forms.ComboBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cbMembershipLength = new System.Windows.Forms.ComboBox();
            this.cbMembershipType = new System.Windows.Forms.ComboBox();
            this.tbThanks = new System.Windows.Forms.TextBox();
            this.tbMembershipCost = new System.Windows.Forms.TextBox();
            this.tbTotalExtras = new System.Windows.Forms.TextBox();
            this.tbTotalDiscount = new System.Windows.Forms.TextBox();
            this.tbNetCost = new System.Windows.Forms.TextBox();
            this.tbRegularPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bReset2 = new System.Windows.Forms.Button();
            this.labelConfirmSubmit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Calibri", 9F);
            this.tbFirstName.Location = new System.Drawing.Point(142, 153);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(179, 22);
            this.tbFirstName.TabIndex = 1;
            // 
            // labelRegularPayment
            // 
            this.labelRegularPayment.AutoSize = true;
            this.labelRegularPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelRegularPayment.ForeColor = System.Drawing.Color.Black;
            this.labelRegularPayment.Location = new System.Drawing.Point(166, 788);
            this.labelRegularPayment.Name = "labelRegularPayment";
            this.labelRegularPayment.Size = new System.Drawing.Size(184, 19);
            this.labelRegularPayment.TabIndex = 118;
            this.labelRegularPayment.Text = "Regular payment amount";
            this.labelRegularPayment.Visible = false;
            // 
            // labelNetCost
            // 
            this.labelNetCost.AutoSize = true;
            this.labelNetCost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetCost.ForeColor = System.Drawing.Color.Black;
            this.labelNetCost.Location = new System.Drawing.Point(191, 760);
            this.labelNetCost.Name = "labelNetCost";
            this.labelNetCost.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelNetCost.Size = new System.Drawing.Size(159, 24);
            this.labelNetCost.TabIndex = 117;
            this.labelNetCost.Text = "Net membership cost:";
            this.labelNetCost.Visible = false;
            // 
            // labelTotalDiscount
            // 
            this.labelTotalDiscount.AutoSize = true;
            this.labelTotalDiscount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDiscount.ForeColor = System.Drawing.Color.Black;
            this.labelTotalDiscount.Location = new System.Drawing.Point(265, 739);
            this.labelTotalDiscount.Name = "labelTotalDiscount";
            this.labelTotalDiscount.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelTotalDiscount.Size = new System.Drawing.Size(85, 20);
            this.labelTotalDiscount.TabIndex = 116;
            this.labelTotalDiscount.Text = "Total discount";
            this.labelTotalDiscount.Visible = false;
            // 
            // labelTotalExtras
            // 
            this.labelTotalExtras.AutoSize = true;
            this.labelTotalExtras.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalExtras.ForeColor = System.Drawing.Color.Black;
            this.labelTotalExtras.Location = new System.Drawing.Point(269, 718);
            this.labelTotalExtras.Name = "labelTotalExtras";
            this.labelTotalExtras.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelTotalExtras.Size = new System.Drawing.Size(81, 20);
            this.labelTotalExtras.TabIndex = 115;
            this.labelTotalExtras.Text = "Extra charges";
            this.labelTotalExtras.Visible = false;
            // 
            // labelMembershipCost
            // 
            this.labelMembershipCost.AutoSize = true;
            this.labelMembershipCost.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembershipCost.ForeColor = System.Drawing.Color.Black;
            this.labelMembershipCost.Location = new System.Drawing.Point(220, 697);
            this.labelMembershipCost.Name = "labelMembershipCost";
            this.labelMembershipCost.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelMembershipCost.Size = new System.Drawing.Size(130, 20);
            this.labelMembershipCost.TabIndex = 114;
            this.labelMembershipCost.Text = "Base membership cost";
            this.labelMembershipCost.Visible = false;
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.Color.White;
            this.bReset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(336, 572);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(175, 33);
            this.bReset.TabIndex = 13;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bCalculate
            // 
            this.bCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.bCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalculate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalculate.ForeColor = System.Drawing.Color.White;
            this.bCalculate.Location = new System.Drawing.Point(142, 572);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(188, 33);
            this.bCalculate.TabIndex = 12;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = false;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // clExtras
            // 
            this.clExtras.CheckOnClick = true;
            this.clExtras.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clExtras.FormattingEnabled = true;
            this.clExtras.Items.AddRange(new object[] {
            "24/7 Access ($1 per week) ",
            "Personal trainer ($20 per week) ",
            "Diet consultation ($20 per week) ",
            "Access online fitness videos ($2 per week) "});
            this.clExtras.Location = new System.Drawing.Point(142, 484);
            this.clExtras.Name = "clExtras";
            this.clExtras.Size = new System.Drawing.Size(262, 72);
            this.clExtras.TabIndex = 11;
            // 
            // labelPaymentFreq
            // 
            this.labelPaymentFreq.AutoSize = true;
            this.labelPaymentFreq.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelPaymentFreq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPaymentFreq.Location = new System.Drawing.Point(142, 416);
            this.labelPaymentFreq.Name = "labelPaymentFreq";
            this.labelPaymentFreq.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPaymentFreq.Size = new System.Drawing.Size(118, 19);
            this.labelPaymentFreq.TabIndex = 110;
            this.labelPaymentFreq.Text = "Payment frequency *";
            // 
            // labelMembershipType
            // 
            this.labelMembershipType.AutoSize = true;
            this.labelMembershipType.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelMembershipType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMembershipType.Location = new System.Drawing.Point(142, 367);
            this.labelMembershipType.Name = "labelMembershipType";
            this.labelMembershipType.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelMembershipType.Size = new System.Drawing.Size(141, 19);
            this.labelMembershipType.TabIndex = 109;
            this.labelMembershipType.Text = "Base membership type *";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(142, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 18);
            this.label13.TabIndex = 108;
            this.label13.Text = "Membership details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(142, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 18);
            this.label12.TabIndex = 107;
            this.label12.Text = "Customer details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(189, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(345, 46);
            this.label10.TabIndex = 104;
            this.label10.Text = "Complete the form below to \r\ncalculate your City Gym membership rates";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOptionalExtras
            // 
            this.labelOptionalExtras.AutoSize = true;
            this.labelOptionalExtras.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelOptionalExtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelOptionalExtras.Location = new System.Drawing.Point(142, 463);
            this.labelOptionalExtras.Name = "labelOptionalExtras";
            this.labelOptionalExtras.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelOptionalExtras.Size = new System.Drawing.Size(90, 19);
            this.labelOptionalExtras.TabIndex = 101;
            this.labelOptionalExtras.Text = "Optional extras";
            // 
            // labelMembershipLength
            // 
            this.labelMembershipLength.AutoSize = true;
            this.labelMembershipLength.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelMembershipLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMembershipLength.Location = new System.Drawing.Point(296, 367);
            this.labelMembershipLength.Name = "labelMembershipLength";
            this.labelMembershipLength.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelMembershipLength.Size = new System.Drawing.Size(123, 19);
            this.labelMembershipLength.TabIndex = 100;
            this.labelMembershipLength.Text = "Membership length *";
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPaymentMethod.Location = new System.Drawing.Point(295, 416);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPaymentMethod.Size = new System.Drawing.Size(122, 19);
            this.labelPaymentMethod.TabIndex = 99;
            this.labelPaymentMethod.Text = "Method of payment *";
            // 
            // labelPostcode
            // 
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelPostcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPostcode.Location = new System.Drawing.Point(396, 277);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPostcode.Size = new System.Drawing.Size(65, 19);
            this.labelPostcode.TabIndex = 98;
            this.labelPostcode.Text = "Postcode *";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCity.Location = new System.Drawing.Point(142, 277);
            this.labelCity.Name = "labelCity";
            this.labelCity.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelCity.Size = new System.Drawing.Size(68, 19);
            this.labelCity.TabIndex = 97;
            this.labelCity.Text = "City/Town *";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAddress2.Location = new System.Drawing.Point(142, 229);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelAddress2.Size = new System.Drawing.Size(86, 19);
            this.labelAddress2.TabIndex = 96;
            this.labelAddress2.Text = "Address Line 2";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelAddress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAddress1.Location = new System.Drawing.Point(142, 180);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelAddress1.Size = new System.Drawing.Size(95, 19);
            this.labelAddress1.TabIndex = 95;
            this.labelAddress1.Text = "Address Line 1 *";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLastName.Location = new System.Drawing.Point(332, 132);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelLastName.Size = new System.Drawing.Size(72, 19);
            this.labelLastName.TabIndex = 93;
            this.labelLastName.Text = "Last name *";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Calibri", 9F);
            this.labelFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFirstName.Location = new System.Drawing.Point(142, 132);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelFirstName.Size = new System.Drawing.Size(74, 19);
            this.labelFirstName.TabIndex = 92;
            this.labelFirstName.Text = "First name *";
            // 
            // tbPostcode
            // 
            this.tbPostcode.Font = new System.Drawing.Font("Calibri", 9F);
            this.tbPostcode.Location = new System.Drawing.Point(396, 298);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(114, 22);
            this.tbPostcode.TabIndex = 6;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Calibri", 9F);
            this.tbCity.Location = new System.Drawing.Point(142, 298);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(247, 22);
            this.tbCity.TabIndex = 5;
            // 
            // tbAddress2
            // 
            this.tbAddress2.Font = new System.Drawing.Font("Calibri", 9F);
            this.tbAddress2.Location = new System.Drawing.Point(142, 250);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(369, 22);
            this.tbAddress2.TabIndex = 4;
            // 
            // tbAddress1
            // 
            this.tbAddress1.Font = new System.Drawing.Font("Calibri", 9F);
            this.tbAddress1.Location = new System.Drawing.Point(142, 201);
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(369, 22);
            this.tbAddress1.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Calibri", 9F);
            this.tbLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbLastName.Location = new System.Drawing.Point(332, 153);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(179, 22);
            this.tbLastName.TabIndex = 2;
            // 
            // cbPaymentFreq
            // 
            this.cbPaymentFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentFreq.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbPaymentFreq.FormattingEnabled = true;
            this.cbPaymentFreq.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.cbPaymentFreq.Location = new System.Drawing.Point(142, 438);
            this.cbPaymentFreq.Name = "cbPaymentFreq";
            this.cbPaymentFreq.Size = new System.Drawing.Size(148, 22);
            this.cbPaymentFreq.TabIndex = 9;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbPaymentMethod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Direct debit (save 1% on base price)",
            "Other"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(296, 438);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(215, 22);
            this.cbPaymentMethod.TabIndex = 10;
            // 
            // cbMembershipLength
            // 
            this.cbMembershipLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembershipLength.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbMembershipLength.FormattingEnabled = true;
            this.cbMembershipLength.Items.AddRange(new object[] {
            "3 months",
            "12 months (save $2 per week)",
            "24 months (save $5 per week)"});
            this.cbMembershipLength.Location = new System.Drawing.Point(296, 388);
            this.cbMembershipLength.Name = "cbMembershipLength";
            this.cbMembershipLength.Size = new System.Drawing.Size(215, 22);
            this.cbMembershipLength.TabIndex = 8;
            // 
            // cbMembershipType
            // 
            this.cbMembershipType.BackColor = System.Drawing.SystemColors.Window;
            this.cbMembershipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembershipType.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbMembershipType.FormattingEnabled = true;
            this.cbMembershipType.Items.AddRange(new object[] {
            "Basic ($10 per week)",
            "Regular ($15 per week)",
            "Premium $20 per week)"});
            this.cbMembershipType.Location = new System.Drawing.Point(142, 388);
            this.cbMembershipType.Name = "cbMembershipType";
            this.cbMembershipType.Size = new System.Drawing.Size(148, 22);
            this.cbMembershipType.TabIndex = 7;
            // 
            // tbThanks
            // 
            this.tbThanks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbThanks.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbThanks.Location = new System.Drawing.Point(145, 652);
            this.tbThanks.Name = "tbThanks";
            this.tbThanks.Size = new System.Drawing.Size(366, 24);
            this.tbThanks.TabIndex = 129;
            this.tbThanks.Text = "Thanks!";
            this.tbThanks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbThanks.Visible = false;
            // 
            // tbMembershipCost
            // 
            this.tbMembershipCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMembershipCost.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbMembershipCost.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMembershipCost.Location = new System.Drawing.Point(369, 701);
            this.tbMembershipCost.Name = "tbMembershipCost";
            this.tbMembershipCost.Size = new System.Drawing.Size(116, 16);
            this.tbMembershipCost.TabIndex = 130;
            this.tbMembershipCost.Text = "123";
            this.tbMembershipCost.Visible = false;
            // 
            // tbTotalExtras
            // 
            this.tbTotalExtras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalExtras.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.tbTotalExtras.Location = new System.Drawing.Point(369, 722);
            this.tbTotalExtras.Name = "tbTotalExtras";
            this.tbTotalExtras.Size = new System.Drawing.Size(101, 16);
            this.tbTotalExtras.TabIndex = 131;
            this.tbTotalExtras.Text = "123";
            this.tbTotalExtras.Visible = false;
            // 
            // tbTotalDiscount
            // 
            this.tbTotalDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalDiscount.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.tbTotalDiscount.Location = new System.Drawing.Point(369, 743);
            this.tbTotalDiscount.Name = "tbTotalDiscount";
            this.tbTotalDiscount.Size = new System.Drawing.Size(101, 16);
            this.tbTotalDiscount.TabIndex = 132;
            this.tbTotalDiscount.Text = "123";
            this.tbTotalDiscount.Visible = false;
            // 
            // tbNetCost
            // 
            this.tbNetCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNetCost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNetCost.Location = new System.Drawing.Point(369, 764);
            this.tbNetCost.Name = "tbNetCost";
            this.tbNetCost.Size = new System.Drawing.Size(101, 20);
            this.tbNetCost.TabIndex = 133;
            this.tbNetCost.Text = "123";
            this.tbNetCost.Visible = false;
            // 
            // tbRegularPayment
            // 
            this.tbRegularPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegularPayment.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbRegularPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tbRegularPayment.Location = new System.Drawing.Point(369, 787);
            this.tbRegularPayment.Name = "tbRegularPayment";
            this.tbRegularPayment.Size = new System.Drawing.Size(116, 20);
            this.tbRegularPayment.TabIndex = 134;
            this.tbRegularPayment.Text = "123";
            this.tbRegularPayment.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(309, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 136;
            this.label1.Text = "* Required field";
            // 
            // bSubmit
            // 
            this.bSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.bSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSubmit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.ForeColor = System.Drawing.Color.White;
            this.bSubmit.Location = new System.Drawing.Point(145, 823);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(188, 33);
            this.bSubmit.TabIndex = 137;
            this.bSubmit.Text = "Submit application";
            this.bSubmit.UseVisualStyleBackColor = false;
            this.bSubmit.Visible = false;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bReset2
            // 
            this.bReset2.BackColor = System.Drawing.Color.White;
            this.bReset2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bReset2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bReset2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bReset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset2.Location = new System.Drawing.Point(339, 823);
            this.bReset2.Name = "bReset2";
            this.bReset2.Size = new System.Drawing.Size(175, 33);
            this.bReset2.TabIndex = 138;
            this.bReset2.Text = "Reset";
            this.bReset2.UseVisualStyleBackColor = false;
            this.bReset2.Visible = false;
            this.bReset2.Click += new System.EventHandler(this.bReset2_Click);
            // 
            // labelConfirmSubmit
            // 
            this.labelConfirmSubmit.AutoSize = true;
            this.labelConfirmSubmit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelConfirmSubmit.Location = new System.Drawing.Point(113, 830);
            this.labelConfirmSubmit.Name = "labelConfirmSubmit";
            this.labelConfirmSubmit.Size = new System.Drawing.Size(421, 19);
            this.labelConfirmSubmit.TabIndex = 139;
            this.labelConfirmSubmit.Text = "We\'ve received your application and will be in touch shortly";
            this.labelConfirmSubmit.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(665, 878);
            this.Controls.Add(this.bReset2);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRegularPayment);
            this.Controls.Add(this.tbNetCost);
            this.Controls.Add(this.tbTotalDiscount);
            this.Controls.Add(this.tbTotalExtras);
            this.Controls.Add(this.tbMembershipCost);
            this.Controls.Add(this.tbThanks);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.labelRegularPayment);
            this.Controls.Add(this.labelNetCost);
            this.Controls.Add(this.labelTotalDiscount);
            this.Controls.Add(this.labelTotalExtras);
            this.Controls.Add(this.labelMembershipCost);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.clExtras);
            this.Controls.Add(this.labelPaymentFreq);
            this.Controls.Add(this.labelMembershipType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelOptionalExtras);
            this.Controls.Add(this.labelMembershipLength);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.labelPostcode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.tbAddress1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.cbPaymentFreq);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.cbMembershipLength);
            this.Controls.Add(this.cbMembershipType);
            this.Controls.Add(this.labelConfirmSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label labelRegularPayment;
        private System.Windows.Forms.Label labelNetCost;
        private System.Windows.Forms.Label labelTotalDiscount;
        private System.Windows.Forms.Label labelTotalExtras;
        private System.Windows.Forms.Label labelMembershipCost;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.CheckedListBox clExtras;
        private System.Windows.Forms.Label labelPaymentFreq;
        private System.Windows.Forms.Label labelMembershipType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelOptionalExtras;
        private System.Windows.Forms.Label labelMembershipLength;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ComboBox cbPaymentFreq;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.ComboBox cbMembershipLength;
        private System.Windows.Forms.ComboBox cbMembershipType;
        private System.Windows.Forms.TextBox tbThanks;
        private System.Windows.Forms.TextBox tbMembershipCost;
        private System.Windows.Forms.TextBox tbTotalExtras;
        private System.Windows.Forms.TextBox tbTotalDiscount;
        private System.Windows.Forms.TextBox tbNetCost;
        private System.Windows.Forms.TextBox tbRegularPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bReset2;
        private System.Windows.Forms.Label labelConfirmSubmit;
    }
}

