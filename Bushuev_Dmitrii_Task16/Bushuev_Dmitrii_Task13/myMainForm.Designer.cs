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
            this.components = new System.ComponentModel.Container();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.cms_Users = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Escape = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cms_Awards = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_RewardUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_DeleteAward = new System.Windows.Forms.Button();
            this.btn_EditAward = new System.Windows.Forms.Button();
            this.dgv_Awards = new System.Windows.Forms.DataGridView();
            this.btn_AddAward = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Awards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.cms_Users.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.cms_Awards.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Awards)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Users
            // 
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.UserAge,
            this.Awards});
            this.dgv_Users.ContextMenuStrip = this.cms_Users;
            this.dgv_Users.Location = new System.Drawing.Point(0, 0);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.Size = new System.Drawing.Size(676, 243);
            this.dgv_Users.TabIndex = 0;
            this.dgv_Users.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Users_CellMouseDown);
            this.dgv_Users.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlGrid_ColumnHeaderMouseClick);
            this.dgv_Users.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgv_Users_MouseUp);
            // 
            // cms_Users
            // 
            this.cms_Users.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.cms_Users.Name = "cms_Users";
            this.cms_Users.Size = new System.Drawing.Size(155, 70);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_Escape
            // 
            this.btn_Escape.Location = new System.Drawing.Point(618, 386);
            this.btn_Escape.Name = "btn_Escape";
            this.btn_Escape.Size = new System.Drawing.Size(75, 23);
            this.btn_Escape.TabIndex = 1;
            this.btn_Escape.Text = "Выход";
            this.btn_Escape.UseVisualStyleBackColor = true;
            this.btn_Escape.Click += new System.EventHandler(this.btn_Escape_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(6, 274);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(148, 34);
            this.btn_AddUser.TabIndex = 2;
            this.btn_AddUser.Text = "Добавить пользователя";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.cms_Awards;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 363);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseUp);
            // 
            // cms_Awards
            // 
            this.cms_Awards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.редактироватьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.cms_Awards.Name = "cms_Awards";
            this.cms_Awards.Size = new System.Drawing.Size(155, 70);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.btn_AddAward_Click);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.btn_EditAward_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.btn_DeleteAward_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_RewardUser);
            this.tabPage1.Controls.Add(this.dgv_Users);
            this.tabPage1.Controls.Add(this.btn_DeleteUser);
            this.tabPage1.Controls.Add(this.btn_AddUser);
            this.tabPage1.Controls.Add(this.btn_EditUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список пользователей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_RewardUser
            // 
            this.btn_RewardUser.Location = new System.Drawing.Point(352, 274);
            this.btn_RewardUser.Name = "btn_RewardUser";
            this.btn_RewardUser.Size = new System.Drawing.Size(148, 34);
            this.btn_RewardUser.TabIndex = 9;
            this.btn_RewardUser.Text = "Наградить пользователя";
            this.btn_RewardUser.UseVisualStyleBackColor = true;
            this.btn_RewardUser.Click += new System.EventHandler(this.btn_RewardUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(522, 274);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(148, 34);
            this.btn_DeleteUser.TabIndex = 5;
            this.btn_DeleteUser.Text = "Удалить пользователя";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.Location = new System.Drawing.Point(181, 274);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(148, 34);
            this.btn_EditUser.TabIndex = 7;
            this.btn_EditUser.Text = "Редактировать пользователя";
            this.btn_EditUser.UseVisualStyleBackColor = true;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_DeleteAward);
            this.tabPage2.Controls.Add(this.btn_EditAward);
            this.tabPage2.Controls.Add(this.dgv_Awards);
            this.tabPage2.Controls.Add(this.btn_AddAward);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список наград";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteAward
            // 
            this.btn_DeleteAward.Location = new System.Drawing.Point(453, 290);
            this.btn_DeleteAward.Name = "btn_DeleteAward";
            this.btn_DeleteAward.Size = new System.Drawing.Size(148, 23);
            this.btn_DeleteAward.TabIndex = 6;
            this.btn_DeleteAward.Text = "Удалить награду";
            this.btn_DeleteAward.UseVisualStyleBackColor = true;
            this.btn_DeleteAward.Click += new System.EventHandler(this.btn_DeleteAward_Click);
            // 
            // btn_EditAward
            // 
            this.btn_EditAward.Location = new System.Drawing.Point(265, 290);
            this.btn_EditAward.Name = "btn_EditAward";
            this.btn_EditAward.Size = new System.Drawing.Size(148, 23);
            this.btn_EditAward.TabIndex = 8;
            this.btn_EditAward.Text = "Редактировать награду";
            this.btn_EditAward.UseVisualStyleBackColor = true;
            this.btn_EditAward.Click += new System.EventHandler(this.btn_EditAward_Click);
            // 
            // dgv_Awards
            // 
            this.dgv_Awards.AllowUserToOrderColumns = true;
            this.dgv_Awards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Awards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Description});
            this.dgv_Awards.Location = new System.Drawing.Point(2, 41);
            this.dgv_Awards.MultiSelect = false;
            this.dgv_Awards.Name = "dgv_Awards";
            this.dgv_Awards.ReadOnly = true;
            this.dgv_Awards.Size = new System.Drawing.Size(674, 243);
            this.dgv_Awards.TabIndex = 1;
            this.dgv_Awards.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Awards_CellMouseDown);
            this.dgv_Awards.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.awardGrid_ColumnHeaderMouseClick);
            // 
            // btn_AddAward
            // 
            this.btn_AddAward.Location = new System.Drawing.Point(78, 290);
            this.btn_AddAward.Name = "btn_AddAward";
            this.btn_AddAward.Size = new System.Drawing.Size(148, 23);
            this.btn_AddAward.TabIndex = 4;
            this.btn_AddAward.Text = "Добавить награду";
            this.btn_AddAward.UseVisualStyleBackColor = true;
            this.btn_AddAward.Click += new System.EventHandler(this.btn_AddAward_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.Frozen = true;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.Frozen = true;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.Frozen = true;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.Frozen = true;
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.Frozen = true;
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // UserAge
            // 
            this.UserAge.DataPropertyName = "UserAge";
            this.UserAge.Frozen = true;
            this.UserAge.HeaderText = "UserAge";
            this.UserAge.Name = "UserAge";
            this.UserAge.ReadOnly = true;
            // 
            // Awards
            // 
            this.Awards.DataPropertyName = "UserAwards";
            this.Awards.Frozen = true;
            this.Awards.HeaderText = "Awards";
            this.Awards.Name = "Awards";
            this.Awards.ReadOnly = true;
            // 
            // myMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 421);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Escape);
            this.Name = "myMainForm";
            this.Text = "Пользователи и Награды";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.cms_Users.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.cms_Awards.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Awards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.Button btn_Escape;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Awards;
        private System.Windows.Forms.Button btn_AddAward;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_DeleteAward;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Button btn_EditAward;
        private System.Windows.Forms.Button btn_RewardUser;
        private System.Windows.Forms.ContextMenuStrip cms_Users;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_Awards;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Awards;
    }
}

