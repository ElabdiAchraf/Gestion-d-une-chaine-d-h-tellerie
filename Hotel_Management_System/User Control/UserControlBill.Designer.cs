namespace Hotel_Management_System.User_Control
{
    partial class UserControlBill
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlBill = new System.Windows.Forms.TabControl();
            this.tabPageAddBill = new System.Windows.Forms.TabPage();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonGetReservation = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxDinner = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxBreakfast = new Guna.UI2.WinForms.Guna2TextBox();
            this.textGymPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxLaunch = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxIdReservation = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchBill = new System.Windows.Forms.TabPage();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagePrintBill = new System.Windows.Forms.TabPage();
            this.buttonPrint = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewPrint = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlBill.SuspendLayout();
            this.tabPageAddBill.SuspendLayout();
            this.tabPageSearchBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.tabPagePrintBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBill
            // 
            this.tabControlBill.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlBill.Controls.Add(this.tabPageAddBill);
            this.tabControlBill.Controls.Add(this.tabPageSearchBill);
            this.tabControlBill.Controls.Add(this.tabPagePrintBill);
            this.tabControlBill.Location = new System.Drawing.Point(33, 25);
            this.tabControlBill.Name = "tabControlBill";
            this.tabControlBill.SelectedIndex = 0;
            this.tabControlBill.Size = new System.Drawing.Size(969, 360);
            this.tabControlBill.TabIndex = 0;
            // 
            // tabPageAddBill
            // 
            this.tabPageAddBill.Controls.Add(this.buttonAdd);
            this.tabPageAddBill.Controls.Add(this.buttonGetReservation);
            this.tabPageAddBill.Controls.Add(this.textBoxDinner);
            this.tabPageAddBill.Controls.Add(this.textBoxBreakfast);
            this.tabPageAddBill.Controls.Add(this.textGymPrice);
            this.tabPageAddBill.Controls.Add(this.textBoxLaunch);
            this.tabPageAddBill.Controls.Add(this.textBoxIdReservation);
            this.tabPageAddBill.Controls.Add(this.label3);
            this.tabPageAddBill.Controls.Add(this.label8);
            this.tabPageAddBill.Controls.Add(this.label5);
            this.tabPageAddBill.Controls.Add(this.labelTotal);
            this.tabPageAddBill.Controls.Add(this.label6);
            this.tabPageAddBill.Controls.Add(this.label4);
            this.tabPageAddBill.Controls.Add(this.label2);
            this.tabPageAddBill.Controls.Add(this.label1);
            this.tabPageAddBill.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddBill.Name = "tabPageAddBill";
            this.tabPageAddBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddBill.Size = new System.Drawing.Size(961, 324);
            this.tabPageAddBill.TabIndex = 0;
            this.tabPageAddBill.Text = "Add Bill";
            this.tabPageAddBill.UseVisualStyleBackColor = true;
            this.tabPageAddBill.Click += new System.EventHandler(this.tabPageAddBill_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BorderRadius = 15;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(783, 274);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(134, 44);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonGetReservation
            // 
            this.buttonGetReservation.BorderRadius = 15;
            this.buttonGetReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonGetReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonGetReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonGetReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonGetReservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonGetReservation.ForeColor = System.Drawing.Color.White;
            this.buttonGetReservation.Location = new System.Drawing.Point(375, 49);
            this.buttonGetReservation.Name = "buttonGetReservation";
            this.buttonGetReservation.Size = new System.Drawing.Size(172, 44);
            this.buttonGetReservation.TabIndex = 31;
            this.buttonGetReservation.Text = "GET";
            this.buttonGetReservation.Click += new System.EventHandler(this.buttonGetReservation_Click_1);
            // 
            // textBoxDinner
            // 
            this.textBoxDinner.Animated = true;
            this.textBoxDinner.BorderRadius = 15;
            this.textBoxDinner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDinner.DefaultText = "";
            this.textBoxDinner.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDinner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDinner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDinner.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDinner.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDinner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDinner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDinner.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDinner.Location = new System.Drawing.Point(672, 176);
            this.textBoxDinner.Name = "textBoxDinner";
            this.textBoxDinner.PasswordChar = '\0';
            this.textBoxDinner.PlaceholderText = "Dinner Price";
            this.textBoxDinner.SelectedText = "";
            this.textBoxDinner.Size = new System.Drawing.Size(245, 50);
            this.textBoxDinner.TabIndex = 30;
            // 
            // textBoxBreakfast
            // 
            this.textBoxBreakfast.Animated = true;
            this.textBoxBreakfast.BorderRadius = 15;
            this.textBoxBreakfast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBreakfast.DefaultText = "";
            this.textBoxBreakfast.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxBreakfast.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxBreakfast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxBreakfast.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxBreakfast.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxBreakfast.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxBreakfast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxBreakfast.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxBreakfast.Location = new System.Drawing.Point(375, 178);
            this.textBoxBreakfast.Name = "textBoxBreakfast";
            this.textBoxBreakfast.PasswordChar = '\0';
            this.textBoxBreakfast.PlaceholderText = "Beakfast Price";
            this.textBoxBreakfast.SelectedText = "";
            this.textBoxBreakfast.Size = new System.Drawing.Size(258, 48);
            this.textBoxBreakfast.TabIndex = 28;
            // 
            // textGymPrice
            // 
            this.textGymPrice.Animated = true;
            this.textGymPrice.BorderRadius = 15;
            this.textGymPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textGymPrice.DefaultText = "";
            this.textGymPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textGymPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textGymPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textGymPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textGymPrice.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textGymPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textGymPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textGymPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textGymPrice.Location = new System.Drawing.Point(672, 49);
            this.textGymPrice.Name = "textGymPrice";
            this.textGymPrice.PasswordChar = '\0';
            this.textGymPrice.PlaceholderText = "Gym Price";
            this.textGymPrice.SelectedText = "";
            this.textGymPrice.Size = new System.Drawing.Size(245, 43);
            this.textGymPrice.TabIndex = 29;
            // 
            // textBoxLaunch
            // 
            this.textBoxLaunch.Animated = true;
            this.textBoxLaunch.BorderRadius = 15;
            this.textBoxLaunch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLaunch.DefaultText = "";
            this.textBoxLaunch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxLaunch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxLaunch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLaunch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLaunch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxLaunch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLaunch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxLaunch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLaunch.Location = new System.Drawing.Point(93, 178);
            this.textBoxLaunch.Name = "textBoxLaunch";
            this.textBoxLaunch.PasswordChar = '\0';
            this.textBoxLaunch.PlaceholderText = "Launch Price";
            this.textBoxLaunch.SelectedText = "";
            this.textBoxLaunch.Size = new System.Drawing.Size(240, 48);
            this.textBoxLaunch.TabIndex = 27;
            // 
            // textBoxIdReservation
            // 
            this.textBoxIdReservation.Animated = true;
            this.textBoxIdReservation.BorderRadius = 15;
            this.textBoxIdReservation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIdReservation.DefaultText = "";
            this.textBoxIdReservation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxIdReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxIdReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIdReservation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIdReservation.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxIdReservation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIdReservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxIdReservation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIdReservation.Location = new System.Drawing.Point(93, 49);
            this.textBoxIdReservation.Name = "textBoxIdReservation";
            this.textBoxIdReservation.PasswordChar = '\0';
            this.textBoxIdReservation.PlaceholderText = "ID Reservation";
            this.textBoxIdReservation.SelectedText = "";
            this.textBoxIdReservation.Size = new System.Drawing.Size(240, 42);
            this.textBoxIdReservation.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gym Price";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(668, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dinner Price";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Breakfast Price";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(471, 274);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(19, 19);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "?";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total (MAD)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Launch Price";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Reservation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Bill:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPageSearchBill
            // 
            this.tabPageSearchBill.Controls.Add(this.dataGridViewBill);
            this.tabPageSearchBill.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchBill.Name = "tabPageSearchBill";
            this.tabPageSearchBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchBill.Size = new System.Drawing.Size(961, 324);
            this.tabPageSearchBill.TabIndex = 1;
            this.tabPageSearchBill.Text = "Search Bill";
            this.tabPageSearchBill.UseVisualStyleBackColor = true;
            this.tabPageSearchBill.Enter += new System.EventHandler(this.tabPageSearchBill_Enter);
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewBill.Location = new System.Drawing.Point(8, 47);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.RowTemplate.Height = 24;
            this.dataGridViewBill.Size = new System.Drawing.Size(945, 231);
            this.dataGridViewBill.TabIndex = 14;
            this.dataGridViewBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idbill";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Bill";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idreservation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Reservation ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "launchprice";
            this.dataGridViewTextBoxColumn3.HeaderText = "Launch Price (MAD)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "breakfastprice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Breakfast Price (MAD)";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dinnerprice";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dinner Price (MAD)";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "gymprice";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gym Price (MAD)";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn7.HeaderText = "TOTAL (MAD)";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // tabPagePrintBill
            // 
            this.tabPagePrintBill.Controls.Add(this.buttonPrint);
            this.tabPagePrintBill.Controls.Add(this.button1);
            this.tabPagePrintBill.Controls.Add(this.textBoxBill);
            this.tabPagePrintBill.Controls.Add(this.label9);
            this.tabPagePrintBill.Controls.Add(this.dataGridViewPrint);
            this.tabPagePrintBill.Location = new System.Drawing.Point(4, 4);
            this.tabPagePrintBill.Name = "tabPagePrintBill";
            this.tabPagePrintBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrintBill.Size = new System.Drawing.Size(961, 324);
            this.tabPagePrintBill.TabIndex = 2;
            this.tabPagePrintBill.Text = "Print Bill";
            this.tabPagePrintBill.UseVisualStyleBackColor = true;
            this.tabPagePrintBill.Click += new System.EventHandler(this.tabPagePrintBill_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BorderRadius = 15;
            this.buttonPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(390, 259);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(261, 50);
            this.buttonPrint.TabIndex = 33;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click_1);
            // 
            // button1
            // 
            this.button1.BorderRadius = 15;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(426, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 44);
            this.button1.TabIndex = 32;
            this.button1.Text = "GET";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxBill
            // 
            this.textBoxBill.Animated = true;
            this.textBoxBill.BorderRadius = 15;
            this.textBoxBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBill.DefaultText = "";
            this.textBoxBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxBill.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxBill.Location = new System.Drawing.Point(171, 13);
            this.textBoxBill.Name = "textBoxBill";
            this.textBoxBill.PasswordChar = '\0';
            this.textBoxBill.PlaceholderText = "ID Bill";
            this.textBoxBill.SelectedText = "";
            this.textBoxBill.Size = new System.Drawing.Size(240, 42);
            this.textBoxBill.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID Bill";
            // 
            // dataGridViewPrint
            // 
            this.dataGridViewPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewPrint.Location = new System.Drawing.Point(11, 61);
            this.dataGridViewPrint.Name = "dataGridViewPrint";
            this.dataGridViewPrint.RowHeadersWidth = 51;
            this.dataGridViewPrint.RowTemplate.Height = 24;
            this.dataGridViewPrint.Size = new System.Drawing.Size(945, 181);
            this.dataGridViewPrint.TabIndex = 13;
            this.dataGridViewPrint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrint_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idbill";
            this.Column1.HeaderText = "ID Bill";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "idreservation";
            this.Column2.HeaderText = "Reservation ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "price";
            this.Column8.HeaderText = "Room Price (MAD)";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "launchprice";
            this.Column3.HeaderText = "Launch Price (MAD)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "breakfastprice";
            this.Column4.HeaderText = "Breakfast Price (MAD)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dinnerprice";
            this.Column5.HeaderText = "Dinner Price (MAD)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "gymprice";
            this.Column6.HeaderText = "Gym Price (MAD)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "total";
            this.Column7.HeaderText = "TOTAL (MAD)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // UserControlBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlBill);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlBill";
            this.Size = new System.Drawing.Size(1075, 436);
            this.Load += new System.EventHandler(this.UserControlBill_Load);
            this.tabControlBill.ResumeLayout(false);
            this.tabPageAddBill.ResumeLayout(false);
            this.tabPageAddBill.PerformLayout();
            this.tabPageSearchBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.tabPagePrintBill.ResumeLayout(false);
            this.tabPagePrintBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBill;
        private System.Windows.Forms.TabPage tabPageAddBill;
        private System.Windows.Forms.TabPage tabPageSearchBill;
        private System.Windows.Forms.TabPage tabPagePrintBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dataGridViewPrint;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox textBoxBreakfast;
        private Guna.UI2.WinForms.Guna2TextBox textBoxLaunch;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIdReservation;
        private Guna.UI2.WinForms.Guna2TextBox textGymPrice;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDinner;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button buttonGetReservation;
        private Guna.UI2.WinForms.Guna2Button buttonPrint;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxBill;
    }
}
