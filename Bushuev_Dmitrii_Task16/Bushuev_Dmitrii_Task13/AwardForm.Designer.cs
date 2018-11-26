namespace Bushuev_Dmitrii_Task13
{
    partial class AwardForm
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
            this.components = new System.ComponentModel.Container();
            this.lbl_AddAward = new System.Windows.Forms.Label();
            this.btn_AddAward = new System.Windows.Forms.Button();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_AddAwardName = new System.Windows.Forms.Label();
            this.lbl_AddAwardDescription = new System.Windows.Forms.Label();
            this.ctl_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctl_ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddAward
            // 
            this.lbl_AddAward.AutoSize = true;
            this.lbl_AddAward.Location = new System.Drawing.Point(124, 20);
            this.lbl_AddAward.Name = "lbl_AddAward";
            this.lbl_AddAward.Size = new System.Drawing.Size(204, 13);
            this.lbl_AddAward.TabIndex = 0;
            this.lbl_AddAward.Text = "Введите информацию о новой награде";
            // 
            // btn_AddAward
            // 
            this.btn_AddAward.Location = new System.Drawing.Point(312, 216);
            this.btn_AddAward.Name = "btn_AddAward";
            this.btn_AddAward.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAward.TabIndex = 1;
            this.btn_AddAward.Text = "Добавить";
            this.btn_AddAward.UseVisualStyleBackColor = true;
            this.btn_AddAward.Click += new System.EventHandler(this.btn_AddAward_Click);
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(183, 55);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(224, 20);
            this.txt_Title.TabIndex = 2;
            this.txt_Title.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Title_Validating);
            this.txt_Title.Validated += new System.EventHandler(this.txt_Title_Validated);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(71, 216);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(206, 116);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(201, 73);
            this.txt_Description.TabIndex = 4;
            this.txt_Description.Validated += new System.EventHandler(this.txt_Description_Validated);
            // 
            // lbl_AddAwardName
            // 
            this.lbl_AddAwardName.AutoSize = true;
            this.lbl_AddAwardName.Location = new System.Drawing.Point(68, 55);
            this.lbl_AddAwardName.Name = "lbl_AddAwardName";
            this.lbl_AddAwardName.Size = new System.Drawing.Size(109, 13);
            this.lbl_AddAwardName.TabIndex = 5;
            this.lbl_AddAwardName.Text = "Название награды :";
            // 
            // lbl_AddAwardDescription
            // 
            this.lbl_AddAwardDescription.AutoSize = true;
            this.lbl_AddAwardDescription.Location = new System.Drawing.Point(68, 116);
            this.lbl_AddAwardDescription.Name = "lbl_AddAwardDescription";
            this.lbl_AddAwardDescription.Size = new System.Drawing.Size(132, 13);
            this.lbl_AddAwardDescription.TabIndex = 6;
            this.lbl_AddAwardDescription.Text = "Информация о награде :";
            // 
            // ctl_ErrorProvider
            // 
            this.ctl_ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctl_ErrorProvider.ContainerControl = this;
            // 
            // AwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(441, 251);
            this.Controls.Add(this.lbl_AddAwardDescription);
            this.Controls.Add(this.lbl_AddAwardName);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.btn_AddAward);
            this.Controls.Add(this.lbl_AddAward);
            this.Name = "AwardForm";
            this.Text = "AwardForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctl_ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AddAward;
        private System.Windows.Forms.Button btn_AddAward;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_AddAwardName;
        private System.Windows.Forms.Label lbl_AddAwardDescription;
        private System.Windows.Forms.ErrorProvider ctl_ErrorProvider;
    }
}