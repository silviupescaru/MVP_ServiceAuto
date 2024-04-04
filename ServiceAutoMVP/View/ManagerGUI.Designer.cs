namespace ServiceAutoMVP.View
{
    partial class ManagerGUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerGUI));
            labelSearchIDOrOwner = new Label();
            comboBoxOrderBy = new ComboBox();
            labelFilterBy = new Label();
            buttonViewAll = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridViewCarTable = new DataGridView();
            carID = new DataGridViewTextBoxColumn();
            owner = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            color = new DataGridViewTextBoxColumn();
            fuel = new DataGridViewTextBoxColumn();
            labelSelectFilter = new Label();
            comboBoxSelectList = new ComboBox();
            panelCarAttributes = new Panel();
            comboBoxFuel = new ComboBox();
            textBoxBrand = new TextBox();
            textBoxColor = new TextBox();
            textBoxOwner = new TextBox();
            numericUpDownCarID = new NumericUpDown();
            labelFuel = new Label();
            labelColor = new Label();
            labelBrand = new Label();
            labelOwner = new Label();
            labelCarID = new Label();
            labelLoggedUser = new Label();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarTable).BeginInit();
            panelCarAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarID).BeginInit();
            SuspendLayout();
            // 
            // labelSearchIDOrOwner
            // 
            labelSearchIDOrOwner.AutoSize = true;
            labelSearchIDOrOwner.BackColor = Color.Transparent;
            labelSearchIDOrOwner.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearchIDOrOwner.ForeColor = Color.White;
            labelSearchIDOrOwner.Location = new Point(574, 208);
            labelSearchIDOrOwner.Margin = new Padding(4, 0, 4, 0);
            labelSearchIDOrOwner.Name = "labelSearchIDOrOwner";
            labelSearchIDOrOwner.Size = new Size(208, 22);
            labelSearchIDOrOwner.TabIndex = 37;
            labelSearchIDOrOwner.Text = "Search Car ID or Owner";
            // 
            // comboBoxOrderBy
            // 
            comboBoxOrderBy.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxOrderBy.FormattingEnabled = true;
            comboBoxOrderBy.Items.AddRange(new object[] { "", "Owner", "Brand", "Color", "Fuel" });
            comboBoxOrderBy.Location = new Point(579, 163);
            comboBoxOrderBy.Margin = new Padding(4, 3, 4, 3);
            comboBoxOrderBy.Name = "comboBoxOrderBy";
            comboBoxOrderBy.Size = new Size(283, 23);
            comboBoxOrderBy.TabIndex = 36;
            comboBoxOrderBy.SelectedIndexChanged += comboBoxFilterBy_SelectedIndexChanged;
            // 
            // labelFilterBy
            // 
            labelFilterBy.AutoSize = true;
            labelFilterBy.BackColor = Color.Transparent;
            labelFilterBy.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilterBy.ForeColor = Color.White;
            labelFilterBy.Location = new Point(574, 137);
            labelFilterBy.Margin = new Padding(4, 0, 4, 0);
            labelFilterBy.Name = "labelFilterBy";
            labelFilterBy.Size = new Size(82, 22);
            labelFilterBy.TabIndex = 35;
            labelFilterBy.Text = "Filter By";
            // 
            // buttonViewAll
            // 
            buttonViewAll.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonViewAll.Location = new Point(673, 264);
            buttonViewAll.Margin = new Padding(4, 3, 4, 3);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(88, 27);
            buttonViewAll.TabIndex = 34;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = true;
            buttonViewAll.Click += buttonViewAll_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(579, 264);
            buttonSearch.Margin = new Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(88, 27);
            buttonSearch.TabIndex = 33;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(579, 234);
            textBoxSearch.Margin = new Padding(4, 3, 4, 3);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(242, 21);
            textBoxSearch.TabIndex = 32;
            // 
            // dataGridViewCarTable
            // 
            dataGridViewCarTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCarTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCarTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarTable.Columns.AddRange(new DataGridViewColumn[] { carID, owner, brand, color, fuel });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCarTable.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCarTable.Location = new Point(62, 320);
            dataGridViewCarTable.Margin = new Padding(4, 3, 4, 3);
            dataGridViewCarTable.Name = "dataGridViewCarTable";
            dataGridViewCarTable.Size = new Size(806, 315);
            dataGridViewCarTable.TabIndex = 31;
            dataGridViewCarTable.RowStateChanged += dgvCarTable_RowStateChanged;
            // 
            // carID
            // 
            carID.HeaderText = "CarID";
            carID.Name = "carID";
            // 
            // owner
            // 
            owner.HeaderText = "Owner";
            owner.Name = "owner";
            // 
            // brand
            // 
            brand.HeaderText = "Brand";
            brand.Name = "brand";
            // 
            // color
            // 
            color.HeaderText = "Color";
            color.Name = "color";
            // 
            // fuel
            // 
            fuel.HeaderText = "Fuel";
            fuel.Name = "fuel";
            // 
            // labelSelectFilter
            // 
            labelSelectFilter.AutoSize = true;
            labelSelectFilter.BackColor = Color.Transparent;
            labelSelectFilter.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectFilter.ForeColor = Color.White;
            labelSelectFilter.Location = new Point(574, 73);
            labelSelectFilter.Margin = new Padding(4, 0, 4, 0);
            labelSelectFilter.Name = "labelSelectFilter";
            labelSelectFilter.Size = new Size(89, 22);
            labelSelectFilter.TabIndex = 30;
            labelSelectFilter.Text = "Car Filter";
            // 
            // comboBoxSelectList
            // 
            comboBoxSelectList.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSelectList.FormattingEnabled = true;
            comboBoxSelectList.Items.AddRange(new object[] { "", "All", "Filter by Brand and Fuel" });
            comboBoxSelectList.Location = new Point(579, 98);
            comboBoxSelectList.Margin = new Padding(4, 3, 4, 3);
            comboBoxSelectList.Name = "comboBoxSelectList";
            comboBoxSelectList.Size = new Size(283, 23);
            comboBoxSelectList.TabIndex = 29;
            comboBoxSelectList.SelectedIndexChanged += comboBoxSelectList_SelectedIndexChanged;
            // 
            // panelCarAttributes
            // 
            panelCarAttributes.BackColor = Color.Transparent;
            panelCarAttributes.Controls.Add(comboBoxFuel);
            panelCarAttributes.Controls.Add(textBoxBrand);
            panelCarAttributes.Controls.Add(textBoxColor);
            panelCarAttributes.Controls.Add(textBoxOwner);
            panelCarAttributes.Controls.Add(numericUpDownCarID);
            panelCarAttributes.Controls.Add(labelFuel);
            panelCarAttributes.Controls.Add(labelColor);
            panelCarAttributes.Controls.Add(labelBrand);
            panelCarAttributes.Controls.Add(labelOwner);
            panelCarAttributes.Controls.Add(labelCarID);
            panelCarAttributes.Location = new Point(-21, 75);
            panelCarAttributes.Margin = new Padding(4, 3, 4, 3);
            panelCarAttributes.Name = "panelCarAttributes";
            panelCarAttributes.Size = new Size(400, 213);
            panelCarAttributes.TabIndex = 25;
            // 
            // comboBoxFuel
            // 
            comboBoxFuel.AutoCompleteCustomSource.AddRange(new string[] { "", "Diesel", "Gasoline", "Hybrid", "LPG" });
            comboBoxFuel.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFuel.FormattingEnabled = true;
            comboBoxFuel.Items.AddRange(new object[] { "", "Diesel", "Gasoline", "Hybrid", "LPG" });
            comboBoxFuel.Location = new Point(196, 190);
            comboBoxFuel.Margin = new Padding(4, 3, 4, 3);
            comboBoxFuel.Name = "comboBoxFuel";
            comboBoxFuel.Size = new Size(177, 23);
            comboBoxFuel.TabIndex = 10;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBrand.Location = new Point(196, 97);
            textBoxBrand.Margin = new Padding(4, 3, 4, 3);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(177, 21);
            textBoxBrand.TabIndex = 9;
            // 
            // textBoxColor
            // 
            textBoxColor.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxColor.Location = new Point(196, 144);
            textBoxColor.Margin = new Padding(4, 3, 4, 3);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(177, 21);
            textBoxColor.TabIndex = 8;
            // 
            // textBoxOwner
            // 
            textBoxOwner.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOwner.Location = new Point(196, 53);
            textBoxOwner.Margin = new Padding(4, 3, 4, 3);
            textBoxOwner.Name = "textBoxOwner";
            textBoxOwner.Size = new Size(177, 21);
            textBoxOwner.TabIndex = 6;
            // 
            // numericUpDownCarID
            // 
            numericUpDownCarID.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownCarID.Location = new Point(196, 3);
            numericUpDownCarID.Margin = new Padding(4, 3, 4, 3);
            numericUpDownCarID.Name = "numericUpDownCarID";
            numericUpDownCarID.Size = new Size(177, 21);
            numericUpDownCarID.TabIndex = 5;
            // 
            // labelFuel
            // 
            labelFuel.AutoSize = true;
            labelFuel.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFuel.ForeColor = Color.White;
            labelFuel.Location = new Point(85, 183);
            labelFuel.Margin = new Padding(4, 0, 4, 0);
            labelFuel.Name = "labelFuel";
            labelFuel.Size = new Size(55, 26);
            labelFuel.TabIndex = 4;
            labelFuel.Text = "Fuel";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelColor.ForeColor = Color.White;
            labelColor.Location = new Point(85, 137);
            labelColor.Margin = new Padding(4, 0, 4, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(64, 26);
            labelColor.TabIndex = 3;
            labelColor.Text = "Color";
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBrand.ForeColor = Color.White;
            labelBrand.Location = new Point(85, 90);
            labelBrand.Margin = new Padding(4, 0, 4, 0);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(72, 26);
            labelBrand.TabIndex = 2;
            labelBrand.Text = "Brand";
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOwner.ForeColor = Color.White;
            labelOwner.Location = new Point(85, 46);
            labelOwner.Margin = new Padding(4, 0, 4, 0);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(79, 26);
            labelOwner.TabIndex = 1;
            labelOwner.Text = "Owner";
            // 
            // labelCarID
            // 
            labelCarID.AutoSize = true;
            labelCarID.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarID.ForeColor = Color.White;
            labelCarID.Location = new Point(85, 0);
            labelCarID.Margin = new Padding(4, 0, 4, 0);
            labelCarID.Name = "labelCarID";
            labelCarID.Size = new Size(73, 26);
            labelCarID.TabIndex = 0;
            labelCarID.Text = "Car ID";
            // 
            // labelLoggedUser
            // 
            labelLoggedUser.AutoSize = true;
            labelLoggedUser.BackColor = Color.Transparent;
            labelLoggedUser.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoggedUser.ForeColor = Color.White;
            labelLoggedUser.Location = new Point(62, 669);
            labelLoggedUser.Margin = new Padding(4, 0, 4, 0);
            labelLoggedUser.Name = "labelLoggedUser";
            labelLoggedUser.RightToLeft = RightToLeft.Yes;
            labelLoggedUser.Size = new Size(85, 16);
            labelLoggedUser.TabIndex = 41;
            labelLoggedUser.Text = "Logged in as";
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Montserrat", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(63, 692);
            buttonLogout.Margin = new Padding(4, 3, 4, 3);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(76, 23);
            buttonLogout.TabIndex = 40;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // ManagerGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 763);
            Controls.Add(labelLoggedUser);
            Controls.Add(buttonLogout);
            Controls.Add(labelSearchIDOrOwner);
            Controls.Add(comboBoxOrderBy);
            Controls.Add(labelFilterBy);
            Controls.Add(buttonViewAll);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewCarTable);
            Controls.Add(labelSelectFilter);
            Controls.Add(comboBoxSelectList);
            Controls.Add(panelCarAttributes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManagerGUI";
            Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarTable).EndInit();
            panelCarAttributes.ResumeLayout(false);
            panelCarAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelSearchIDOrOwner;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Label labelFilterBy;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewCarTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn carID;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuel;
        private System.Windows.Forms.Label labelSelectFilter;
        private System.Windows.Forms.ComboBox comboBoxSelectList;
        private System.Windows.Forms.Panel panelCarAttributes;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.NumericUpDown numericUpDownCarID;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelCarID;
        public System.Windows.Forms.Label labelLoggedUser;
        private System.Windows.Forms.Button buttonLogout;
    }
}