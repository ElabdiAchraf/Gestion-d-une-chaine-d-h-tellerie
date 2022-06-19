namespace Hotel_Management_System.User_Control
{
    partial class UserControlRoom
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
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageSearchRooms = new System.Windows.Forms.TabPage();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxHotel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageHotel = new System.Windows.Forms.TabPage();
            this.dataGridViewHotels = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagecat = new System.Windows.Forms.TabPage();
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlRoom.SuspendLayout();
            this.tabPageSearchRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.tabPageHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).BeginInit();
            this.tabPagecat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.tabPageSearchRooms);
            this.tabControlRoom.Controls.Add(this.tabPageHotel);
            this.tabControlRoom.Controls.Add(this.tabPagecat);
            this.tabControlRoom.Location = new System.Drawing.Point(39, 31);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(969, 360);
            this.tabControlRoom.TabIndex = 0;
            // 
            // tabPageSearchRooms
            // 
            this.tabPageSearchRooms.Controls.Add(this.guna2Button1);
            this.tabPageSearchRooms.Controls.Add(this.comboBoxHotel);
            this.tabPageSearchRooms.Controls.Add(this.dataGridViewRooms);
            this.tabPageSearchRooms.Controls.Add(this.label2);
            this.tabPageSearchRooms.Controls.Add(this.label1);
            this.tabPageSearchRooms.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRooms.Name = "tabPageSearchRooms";
            this.tabPageSearchRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRooms.Size = new System.Drawing.Size(961, 326);
            this.tabPageSearchRooms.TabIndex = 0;
            this.tabPageSearchRooms.Text = "Search Rooms";
            this.tabPageSearchRooms.UseVisualStyleBackColor = true;
            this.tabPageSearchRooms.Click += new System.EventHandler(this.tabPageSearchRooms_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(540, 25);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(158, 36);
            this.guna2Button1.TabIndex = 33;
            this.guna2Button1.Text = "search";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxHotel.BorderRadius = 15;
            this.comboBoxHotel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHotel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxHotel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxHotel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxHotel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxHotel.ItemHeight = 30;
            this.comboBoxHotel.Items.AddRange(new object[] {
            "Tanger",
            "Casablanca",
            "Khouribga",
            "Marrakech",
            "Errachidia",
            "Tetouan",
            "Essaouira",
            "Rabat"});
            this.comboBoxHotel.Location = new System.Drawing.Point(227, 25);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(264, 36);
            this.comboBoxHotel.TabIndex = 32;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewRooms.Location = new System.Drawing.Point(42, 94);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 24;
            this.dataGridViewRooms.Size = new System.Drawing.Size(880, 214);
            this.dataGridViewRooms.TabIndex = 11;
            this.dataGridViewRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idroom";
            this.Column1.HeaderText = "ID Room";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "phoneroom";
            this.Column2.HeaderText = "No Phone";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cat";
            this.Column3.HeaderText = "Categorie";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "namehotel";
            this.Column4.HeaderText = "Hotel";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "freeroom";
            this.Column5.HeaderText = "Free";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search rooms:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ville";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPageHotel
            // 
            this.tabPageHotel.Controls.Add(this.dataGridViewHotels);
            this.tabPageHotel.Location = new System.Drawing.Point(4, 4);
            this.tabPageHotel.Name = "tabPageHotel";
            this.tabPageHotel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHotel.Size = new System.Drawing.Size(961, 326);
            this.tabPageHotel.TabIndex = 1;
            this.tabPageHotel.Text = "Hotels";
            this.tabPageHotel.UseVisualStyleBackColor = true;
            this.tabPageHotel.Enter += new System.EventHandler(this.tabPageHotel_Enter);
            // 
            // dataGridViewHotels
            // 
            this.dataGridViewHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewHotels.Location = new System.Drawing.Point(41, 65);
            this.dataGridViewHotels.Name = "dataGridViewHotels";
            this.dataGridViewHotels.RowHeadersWidth = 51;
            this.dataGridViewHotels.RowTemplate.Height = 24;
            this.dataGridViewHotels.Size = new System.Drawing.Size(880, 214);
            this.dataGridViewHotels.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idhotel";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Hotel";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "namehotel";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hotel Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "addresshotel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "phonehotel";
            this.dataGridViewTextBoxColumn4.HeaderText = "No Phone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // tabPagecat
            // 
            this.tabPagecat.Controls.Add(this.dataGridViewCat);
            this.tabPagecat.Location = new System.Drawing.Point(4, 4);
            this.tabPagecat.Name = "tabPagecat";
            this.tabPagecat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagecat.Size = new System.Drawing.Size(961, 326);
            this.tabPagecat.TabIndex = 2;
            this.tabPagecat.Text = "Categories";
            this.tabPagecat.UseVisualStyleBackColor = true;
            this.tabPagecat.Enter += new System.EventHandler(this.tabPagecat_Enter);
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewCat.Location = new System.Drawing.Point(40, 56);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.RowHeadersWidth = 51;
            this.dataGridViewCat.RowTemplate.Height = 24;
            this.dataGridViewCat.Size = new System.Drawing.Size(880, 214);
            this.dataGridViewCat.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idcat";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID Categorie";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cat";
            this.dataGridViewTextBoxColumn6.HeaderText = "Categorie";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1075, 436);
            this.Load += new System.EventHandler(this.UserControlRoom_Load);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageSearchRooms.ResumeLayout(false);
            this.tabPageSearchRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.tabPageHotel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).EndInit();
            this.tabPagecat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageSearchRooms;
        private System.Windows.Forms.TabPage tabPageHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage tabPagecat;
        private System.Windows.Forms.DataGridView dataGridViewHotels;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridViewCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxHotel;
    }
}
