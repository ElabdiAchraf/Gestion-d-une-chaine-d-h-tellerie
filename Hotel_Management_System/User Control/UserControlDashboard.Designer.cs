namespace Hotel_Management_System.User_Control
{
    partial class UserControlDashboard
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
            this.comboBoxHotel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonSearchRoom = new Guna.UI2.WinForms.Guna2Button();
            this.labelClientCount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelFreeRoom = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelRooms = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
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
            this.comboBoxHotel.Location = new System.Drawing.Point(33, 32);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(264, 36);
            this.comboBoxHotel.TabIndex = 30;
            // 
            // buttonSearchRoom
            // 
            this.buttonSearchRoom.BorderRadius = 15;
            this.buttonSearchRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearchRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearchRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearchRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearchRoom.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonSearchRoom.ForeColor = System.Drawing.Color.White;
            this.buttonSearchRoom.Location = new System.Drawing.Point(312, 32);
            this.buttonSearchRoom.Name = "buttonSearchRoom";
            this.buttonSearchRoom.Size = new System.Drawing.Size(158, 36);
            this.buttonSearchRoom.TabIndex = 31;
            this.buttonSearchRoom.Text = "search";
            this.buttonSearchRoom.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelClientCount
            // 
            this.labelClientCount.Animated = true;
            this.labelClientCount.BorderRadius = 15;
            this.labelClientCount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.labelClientCount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.labelClientCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.labelClientCount.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.labelClientCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelClientCount.FillColor2 = System.Drawing.Color.Blue;
            this.labelClientCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelClientCount.ForeColor = System.Drawing.Color.White;
            this.labelClientCount.IndicateFocus = true;
            this.labelClientCount.Location = new System.Drawing.Point(14, 141);
            this.labelClientCount.Name = "labelClientCount";
            this.labelClientCount.Size = new System.Drawing.Size(308, 181);
            this.labelClientCount.TabIndex = 32;
            this.labelClientCount.Text = "guna2GradientButton1";
            this.labelClientCount.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // labelFreeRoom
            // 
            this.labelFreeRoom.Animated = true;
            this.labelFreeRoom.BorderRadius = 15;
            this.labelFreeRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.labelFreeRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.labelFreeRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.labelFreeRoom.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.labelFreeRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelFreeRoom.FillColor = System.Drawing.Color.Lime;
            this.labelFreeRoom.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelFreeRoom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelFreeRoom.ForeColor = System.Drawing.Color.White;
            this.labelFreeRoom.IndicateFocus = true;
            this.labelFreeRoom.Location = new System.Drawing.Point(355, 141);
            this.labelFreeRoom.Name = "labelFreeRoom";
            this.labelFreeRoom.Size = new System.Drawing.Size(333, 181);
            this.labelFreeRoom.TabIndex = 33;
            this.labelFreeRoom.Text = "guna2GradientButton1";
            this.labelFreeRoom.Click += new System.EventHandler(this.labelFreeRoom_Click);
            // 
            // labelRooms
            // 
            this.labelRooms.Animated = true;
            this.labelRooms.BorderRadius = 15;
            this.labelRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.labelRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.labelRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.labelRooms.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.labelRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelRooms.FillColor = System.Drawing.Color.Yellow;
            this.labelRooms.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelRooms.ForeColor = System.Drawing.Color.White;
            this.labelRooms.IndicateFocus = true;
            this.labelRooms.Location = new System.Drawing.Point(725, 141);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(309, 181);
            this.labelRooms.TabIndex = 34;
            this.labelRooms.Text = "guna2GradientButton1";
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelFreeRoom);
            this.Controls.Add(this.labelClientCount);
            this.Controls.Add(this.buttonSearchRoom);
            this.Controls.Add(this.comboBoxHotel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(1075, 436);
            this.Load += new System.EventHandler(this.UserControlDashboard_Load);
            this.Leave += new System.EventHandler(this.UserControlDashboard_Leave);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxHotel;
        private Guna.UI2.WinForms.Guna2Button buttonSearchRoom;
        private Guna.UI2.WinForms.Guna2GradientButton labelClientCount;
        private Guna.UI2.WinForms.Guna2GradientButton labelFreeRoom;
        private Guna.UI2.WinForms.Guna2GradientButton labelRooms;
    }
}
