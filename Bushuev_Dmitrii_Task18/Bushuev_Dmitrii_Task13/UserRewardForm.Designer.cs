namespace Bushuev_Dmitrii_Task13
{
    partial class UserRewardForm
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
            this.btn_Reward = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.chkbx_Awards = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_Reward
            // 
            this.btn_Reward.Location = new System.Drawing.Point(212, 293);
            this.btn_Reward.Name = "btn_Reward";
            this.btn_Reward.Size = new System.Drawing.Size(124, 23);
            this.btn_Reward.TabIndex = 0;
            this.btn_Reward.Text = "Изменить награды";
            this.btn_Reward.UseVisualStyleBackColor = true;
            this.btn_Reward.Click += new System.EventHandler(this.btn_Reward_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(76, 293);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // chkbx_Awards
            // 
            this.chkbx_Awards.FormattingEnabled = true;
            this.chkbx_Awards.Location = new System.Drawing.Point(76, 23);
            this.chkbx_Awards.Name = "chkbx_Awards";
            this.chkbx_Awards.Size = new System.Drawing.Size(211, 214);
            this.chkbx_Awards.TabIndex = 2;
            // 
            // UserRewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 337);
            this.Controls.Add(this.chkbx_Awards);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Reward);
            this.Name = "UserRewardForm";
            this.Text = "UserRewardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Reward;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckedListBox chkbx_Awards;
    }
}