namespace ServiceAutoMVP.View
{
    partial class AdministratorGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorGUI));
            labelSearchUsernameOrRole = new Label();
            buttonViewAll = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridViewUserTable = new DataGridView();
            userID = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            panelCarAttributes = new Panel();
            textBoxPassword = new TextBox();
            textBoxRole = new TextBox();
            textBoxUsername = new TextBox();
            numericUpDownUserID = new NumericUpDown();
            labelRole = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            labelUserID = new Label();
            buttonLogout = new Button();
            labelLoggedUser = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserTable).BeginInit();
            panelCarAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).BeginInit();
            SuspendLayout();
            // 
            // labelSearchUsernameOrRole
            // 
            labelSearchUsernameOrRole.AutoSize = true;
            labelSearchUsernameOrRole.BackColor = Color.Transparent;
            labelSearchUsernameOrRole.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearchUsernameOrRole.ForeColor = Color.White;
            labelSearchUsernameOrRole.Location = new Point(544, 144);
            labelSearchUsernameOrRole.Margin = new Padding(4, 0, 4, 0);
            labelSearchUsernameOrRole.Name = "labelSearchUsernameOrRole";
            labelSearchUsernameOrRole.Size = new Size(290, 29);
            labelSearchUsernameOrRole.TabIndex = 37;
            labelSearchUsernameOrRole.Text = "Search Username or Role";
            // 
            // buttonViewAll
            // 
            buttonViewAll.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonViewAll.Location = new Point(737, 220);
            buttonViewAll.Margin = new Padding(4, 3, 4, 3);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(135, 27);
            buttonViewAll.TabIndex = 34;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = true;
            buttonViewAll.Click += buttonViewAll_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(550, 220);
            buttonSearch.Margin = new Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(135, 27);
            buttonSearch.TabIndex = 33;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(550, 177);
            textBoxSearch.Margin = new Padding(4, 3, 4, 3);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(322, 21);
            textBoxSearch.TabIndex = 32;
            // 
            // dataGridViewUserTable
            // 
            dataGridViewUserTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUserTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUserTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserTable.Columns.AddRange(new DataGridViewColumn[] { userID, username, password, role });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewUserTable.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUserTable.Location = new Point(66, 317);
            dataGridViewUserTable.Margin = new Padding(4, 3, 4, 3);
            dataGridViewUserTable.Name = "dataGridViewUserTable";
            dataGridViewUserTable.Size = new Size(806, 335);
            dataGridViewUserTable.TabIndex = 31;
            dataGridViewUserTable.RowStateChanged += dgvUserTable_RowStateChanged;
            // 
            // userID
            // 
            userID.HeaderText = "User ID";
            userID.Name = "userID";
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.Name = "username";
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.Name = "password";
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.Name = "role";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(156, 242);
            buttonUpdate.Margin = new Padding(4, 3, 4, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(88, 27);
            buttonUpdate.TabIndex = 28;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(251, 242);
            buttonDelete.Margin = new Padding(4, 3, 4, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(88, 27);
            buttonDelete.TabIndex = 27;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(62, 242);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(88, 27);
            buttonAdd.TabIndex = 26;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelCarAttributes
            // 
            panelCarAttributes.BackColor = Color.Transparent;
            panelCarAttributes.Controls.Add(textBoxPassword);
            panelCarAttributes.Controls.Add(textBoxRole);
            panelCarAttributes.Controls.Add(textBoxUsername);
            panelCarAttributes.Controls.Add(numericUpDownUserID);
            panelCarAttributes.Controls.Add(labelRole);
            panelCarAttributes.Controls.Add(labelPassword);
            panelCarAttributes.Controls.Add(labelUsername);
            panelCarAttributes.Controls.Add(labelUserID);
            panelCarAttributes.Location = new Point(59, 76);
            panelCarAttributes.Margin = new Padding(4, 3, 4, 3);
            panelCarAttributes.Name = "panelCarAttributes";
            panelCarAttributes.Size = new Size(276, 162);
            panelCarAttributes.TabIndex = 25;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(114, 103);
            textBoxPassword.Margin = new Padding(4, 3, 4, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(162, 21);
            textBoxPassword.TabIndex = 9;
            // 
            // textBoxRole
            // 
            textBoxRole.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRole.Location = new Point(114, 130);
            textBoxRole.Margin = new Padding(4, 3, 4, 3);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(162, 21);
            textBoxRole.TabIndex = 8;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(114, 77);
            textBoxUsername.Margin = new Padding(4, 3, 4, 3);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(162, 21);
            textBoxUsername.TabIndex = 6;
            // 
            // numericUpDownUserID
            // 
            numericUpDownUserID.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownUserID.Location = new Point(114, 51);
            numericUpDownUserID.Margin = new Padding(4, 3, 4, 3);
            numericUpDownUserID.Maximum = new decimal(new int[] { -2, 0, 0, 0 });
            numericUpDownUserID.Name = "numericUpDownUserID";
            numericUpDownUserID.Size = new Size(162, 21);
            numericUpDownUserID.TabIndex = 5;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(4, 130);
            labelRole.Margin = new Padding(4, 0, 4, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(47, 22);
            labelRole.TabIndex = 3;
            labelRole.Text = "Role";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(4, 103);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(91, 22);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(4, 75);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(96, 22);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserID.ForeColor = Color.White;
            labelUserID.Location = new Point(4, 47);
            labelUserID.Margin = new Padding(4, 0, 4, 0);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(70, 22);
            labelUserID.TabIndex = 0;
            labelUserID.Text = "User ID";
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Montserrat", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(59, 703);
            buttonLogout.Margin = new Padding(4, 3, 4, 3);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(76, 23);
            buttonLogout.TabIndex = 38;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // labelLoggedUser
            // 
            labelLoggedUser.AutoSize = true;
            labelLoggedUser.BackColor = Color.Transparent;
            labelLoggedUser.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoggedUser.ForeColor = Color.White;
            labelLoggedUser.Location = new Point(58, 680);
            labelLoggedUser.Margin = new Padding(4, 0, 4, 0);
            labelLoggedUser.Name = "labelLoggedUser";
            labelLoggedUser.RightToLeft = RightToLeft.Yes;
            labelLoggedUser.Size = new Size(85, 16);
            labelLoggedUser.TabIndex = 39;
            labelLoggedUser.Text = "Logged in as";
            labelLoggedUser.Enter += buttonViewAll_Click;
            // 
            // AdministratorGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 763);
            Controls.Add(labelLoggedUser);
            Controls.Add(buttonLogout);
            Controls.Add(labelSearchUsernameOrRole);
            Controls.Add(buttonViewAll);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewUserTable);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(panelCarAttributes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdministratorGUI";
            Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserTable).EndInit();
            panelCarAttributes.ResumeLayout(false);
            panelCarAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelSearchUsernameOrRole;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewUserTable;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelCarAttributes;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.NumericUpDown numericUpDownUserID;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.Button buttonLogout;
        public System.Windows.Forms.Label labelLoggedUser;
    }
}