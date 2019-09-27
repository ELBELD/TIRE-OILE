namespace tireoil
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.txtCalibre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAdditem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnDelteItem = new System.Windows.Forms.Button();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboSearchName = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ComboSerachCompany = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSerachcalibre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // comboName
            // 
            this.comboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboName.FormattingEnabled = true;
            this.comboName.Items.AddRange(new object[] {
            "دواليب جديدة",
            "دواليب قديمة",
            "زيوت",
            "فلاتر",
            "شحم"});
            this.comboName.Location = new System.Drawing.Point(20, 53);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(240, 33);
            this.comboName.TabIndex = 2;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.ComboName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "أسم الشركة";
            // 
            // comboCompany
            // 
            this.comboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Items.AddRange(new object[] {
            "windforce ",
            "powertrac",
            "kapsen",
            "hankook",
            "davanti",
            "oil LUBLAN",
            "oil sharlu",
            "oil brava",
            "oil Nobel",
            "oil champion",
            "oil century",
            "شحم",
            "oil rovel",
            "oil Oryx",
            "oil Liberty"});
            this.comboCompany.Location = new System.Drawing.Point(20, 122);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(240, 33);
            this.comboCompany.TabIndex = 4;
            // 
            // txtCalibre
            // 
            this.txtCalibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalibre.Location = new System.Drawing.Point(20, 183);
            this.txtCalibre.Name = "txtCalibre";
            this.txtCalibre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCalibre.Size = new System.Drawing.Size(240, 35);
            this.txtCalibre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "العيار ";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 495);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(934, 315);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(831, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(898, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "الكمية";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(524, 49);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantity.Size = new System.Drawing.Size(240, 35);
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(831, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(896, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "التكلفة";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(524, 119);
            this.txtCost.Name = "txtCost";
            this.txtCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCost.Size = new System.Drawing.Size(240, 35);
            this.txtCost.TabIndex = 14;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(831, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(897, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "السعر";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(524, 186);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(240, 35);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(786, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 29);
            this.label13.TabIndex = 22;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(882, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 29);
            this.label14.TabIndex = 21;
            this.label14.Text = "ملاحظة";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(20, 266);
            this.txtNote.Name = "txtNote";
            this.txtNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNote.Size = new System.Drawing.Size(738, 35);
            this.txtNote.TabIndex = 20;
            // 
            // btnAdditem
            // 
            this.btnAdditem.FlatAppearance.BorderSize = 0;
            this.btnAdditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdditem.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditem.Image = ((System.Drawing.Image)(resources.GetObject("btnAdditem.Image")));
            this.btnAdditem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdditem.Location = new System.Drawing.Point(216, 315);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(188, 73);
            this.btnAdditem.TabIndex = 23;
            this.btnAdditem.Text = "إضافة";
            this.btnAdditem.UseVisualStyleBackColor = true;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.FlatAppearance.BorderSize = 0;
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateItem.Image")));
            this.btnUpdateItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateItem.Location = new System.Drawing.Point(410, 315);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(188, 73);
            this.btnUpdateItem.TabIndex = 24;
            this.btnUpdateItem.Text = "تعديل";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnDelteItem
            // 
            this.btnDelteItem.FlatAppearance.BorderSize = 0;
            this.btnDelteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelteItem.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelteItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDelteItem.Image")));
            this.btnDelteItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelteItem.Location = new System.Drawing.Point(604, 315);
            this.btnDelteItem.Name = "btnDelteItem";
            this.btnDelteItem.Size = new System.Drawing.Size(160, 73);
            this.btnDelteItem.TabIndex = 25;
            this.btnDelteItem.Text = "إلغاء";
            this.btnDelteItem.UseVisualStyleBackColor = true;
            this.btnDelteItem.Click += new System.EventHandler(this.btnDelteItem_Click);
            // 
            // txtpid
            // 
            this.txtpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpid.Location = new System.Drawing.Point(216, 3);
            this.txtpid.Name = "txtpid";
            this.txtpid.ReadOnly = true;
            this.txtpid.Size = new System.Drawing.Size(240, 35);
            this.txtpid.TabIndex = 26;
            this.txtpid.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(155, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 29);
            this.label15.TabIndex = 28;
            this.label15.Text = ":";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 29);
            this.label16.TabIndex = 27;
            this.label16.Text = "piD";
            this.label16.Visible = false;
            this.label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(766, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 73);
            this.button1.TabIndex = 29;
            this.button1.Text = "بيع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(20, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(188, 73);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "إفراغ ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboSearchName
            // 
            this.comboSearchName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchName.FormattingEnabled = true;
            this.comboSearchName.Items.AddRange(new object[] {
            "NEW TIRE",
            "USED TIRE",
            "OIL\t"});
            this.comboSearchName.Location = new System.Drawing.Point(22, 446);
            this.comboSearchName.Name = "comboSearchName";
            this.comboSearchName.Size = new System.Drawing.Size(240, 33);
            this.comboSearchName.TabIndex = 32;
            this.comboSearchName.SelectedIndexChanged += new System.EventHandler(this.comboSearchName_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 404);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 29);
            this.label18.TabIndex = 31;
            this.label18.Text = "بحث حسب ألإسم";
            // 
            // ComboSerachCompany
            // 
            this.ComboSerachCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSerachCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSerachCompany.FormattingEnabled = true;
            this.ComboSerachCompany.Items.AddRange(new object[] {
            "BRIDJSTON",
            "TOTAL"});
            this.ComboSerachCompany.Location = new System.Drawing.Point(293, 446);
            this.ComboSerachCompany.Name = "ComboSerachCompany";
            this.ComboSerachCompany.Size = new System.Drawing.Size(240, 33);
            this.ComboSerachCompany.TabIndex = 35;
            this.ComboSerachCompany.SelectedIndexChanged += new System.EventHandler(this.ComboSerachCompany_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(288, 404);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 29);
            this.label20.TabIndex = 34;
            this.label20.Text = "بحث حسب الشركة";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(561, 404);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 29);
            this.label22.TabIndex = 38;
            this.label22.Text = "بحث حسب العيار";
            // 
            // txtSerachcalibre
            // 
            this.txtSerachcalibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerachcalibre.Location = new System.Drawing.Point(566, 446);
            this.txtSerachcalibre.Name = "txtSerachcalibre";
            this.txtSerachcalibre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSerachcalibre.Size = new System.Drawing.Size(240, 35);
            this.txtSerachcalibre.TabIndex = 37;
            this.txtSerachcalibre.TextChanged += new System.EventHandler(this.txtSerachcalibre_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtSerachcalibre);
            this.Controls.Add(this.ComboSerachCompany);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboSearchName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.btnDelteItem);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnAdditem);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCalibre);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1004, 838);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCompany;
        private System.Windows.Forms.TextBox txtCalibre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAdditem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDelteItem;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comboSearchName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ComboSerachCompany;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSerachcalibre;
    }
}
