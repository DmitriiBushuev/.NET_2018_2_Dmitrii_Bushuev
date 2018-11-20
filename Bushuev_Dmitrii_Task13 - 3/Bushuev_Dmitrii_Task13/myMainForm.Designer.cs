namespace Bushuev_Dmitrii_Task13
{
    partial class myMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Escape = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_AddAward = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_DeleteAward = new System.Windows.Forms.Button();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.btn_EditAward = new System.Windows.Forms.Button();
            this.btn_RewardUser = new System.Windows.Forms.Button();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Awards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.LastName,
            this.FirstName,
            this.BirthDate,
            this.UserAge,
            this.Awards});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlGrid_ColumnHeaderMouseClick);
            // 
            // btn_Escape
            // 
            this.btn_Escape.Location = new System.Drawing.Point(847, 352);
            this.btn_Escape.Name = "btn_Escape";
            this.btn_Escape.Size = new System.Drawing.Size(75, 23);
            this.btn_Escape.TabIndex = 1;
            this.btn_Escape.Text = "Выход";
            this.btn_Escape.UseVisualStyleBackColor = true;
            this.btn_Escape.Click += new System.EventHandler(this.btn_Escape_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(743, 60);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(148, 23);
            this.btn_AddUser.TabIndex = 2;
            this.btn_AddUser.Text = "Добавить пользователя";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 362);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список пользователей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список наград";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAward,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(2, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 243);
            this.dataGridView2.TabIndex = 1;
            // 
            // btn_AddAward
            // 
            this.btn_AddAward.Location = new System.Drawing.Point(743, 225);
            this.btn_AddAward.Name = "btn_AddAward";
            this.btn_AddAward.Size = new System.Drawing.Size(148, 23);
            this.btn_AddAward.TabIndex = 4;
            this.btn_AddAward.Text = "Добавить награду";
            this.btn_AddAward.UseVisualStyleBackColor = true;
            this.btn_AddAward.Click += new System.EventHandler(this.btn_AddAward_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(743, 158);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(148, 23);
            this.btn_DeleteUser.TabIndex = 5;
            this.btn_DeleteUser.Text = "Удалить пользователя";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_DeleteAward
            // 
            this.btn_DeleteAward.Location = new System.Drawing.Point(743, 284);
            this.btn_DeleteAward.Name = "btn_DeleteAward";
            this.btn_DeleteAward.Size = new System.Drawing.Size(148, 23);
            this.btn_DeleteAward.TabIndex = 6;
            this.btn_DeleteAward.Text = "Удалить награду";
            this.btn_DeleteAward.UseVisualStyleBackColor = true;
            this.btn_DeleteAward.Click += new System.EventHandler(this.btn_DeleteAward_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.Location = new System.Drawing.Point(743, 89);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(148, 34);
            this.btn_EditUser.TabIndex = 7;
            this.btn_EditUser.Text = "Редактировать пользователя";
            this.btn_EditUser.UseVisualStyleBackColor = true;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_EditAward
            // 
            this.btn_EditAward.Location = new System.Drawing.Point(743, 255);
            this.btn_EditAward.Name = "btn_EditAward";
            this.btn_EditAward.Size = new System.Drawing.Size(148, 23);
            this.btn_EditAward.TabIndex = 8;
            this.btn_EditAward.Text = "Редактировать награду";
            this.btn_EditAward.UseVisualStyleBackColor = true;
            this.btn_EditAward.Click += new System.EventHandler(this.btn_EditAward_Click);
            // 
            // btn_RewardUser
            // 
            this.btn_RewardUser.Location = new System.Drawing.Point(743, 129);
            this.btn_RewardUser.Name = "btn_RewardUser";
            this.btn_RewardUser.Size = new System.Drawing.Size(148, 23);
            this.btn_RewardUser.TabIndex = 9;
            this.btn_RewardUser.Text = "Наградить пользователя";
            this.btn_RewardUser.UseVisualStyleBackColor = true;
            this.btn_RewardUser.Click += new System.EventHandler(this.btn_RewardUser_Click);
            // 
            // IdUser
            // 
            this.IdUser.DataPropertyName = "IdUser";
            this.IdUser.Frozen = true;
            this.IdUser.HeaderText = "ID";
            this.IdUser.Name = "IdUser";
            this.IdUser.Visible = false;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.Frozen = true;
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.Frozen = true;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.Frozen = true;
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            // 
            // UserAge
            // 
            this.UserAge.DataPropertyName = "UserAge";
            this.UserAge.Frozen = true;
            this.UserAge.HeaderText = "UserAge";
            this.UserAge.Name = "UserAge";
            // 
            // Awards
            // 
            this.Awards.DataPropertyName = "UserAwards";
            this.Awards.Frozen = true;
            this.Awards.HeaderText = "Awards";
            this.Awards.Name = "Awards";
            // 
            // IdAward
            // 
            this.IdAward.DataPropertyName = "IdAward";
            this.IdAward.Frozen = true;
            this.IdAward.HeaderText = "Id";
            this.IdAward.Name = "IdAward";
            this.IdAward.ReadOnly = true;
            this.IdAward.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Название награды";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // myMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 387);
            this.Controls.Add(this.btn_RewardUser);
            this.Controls.Add(this.btn_EditAward);
            this.Controls.Add(this.btn_EditUser);
            this.Controls.Add(this.btn_DeleteAward);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_AddAward);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.btn_Escape);
            this.Name = "myMainForm";
            this.Text = "Пользователи и Награды";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Escape;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_AddAward;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_DeleteAward;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Button btn_EditAward;
        private System.Windows.Forms.Button btn_RewardUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Awards;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

