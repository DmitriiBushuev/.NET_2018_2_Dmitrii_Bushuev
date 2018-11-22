using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bushuev_Dmitrii_Task13
{
    public partial class AwardForm : Form
    {
        bool flagForAdd = false;

        public string Title {get; set;}
        public string Description {get; set;}

        public AwardForm()
        {
            InitializeComponent();
        }

        public AwardForm(string title, string description)
        {
            InitializeComponent();

            txt_Title.Text = title;
            txt_Description.Text = description;
        }

        private void txt_Title_Validated(object sender, EventArgs e)
        {
            Title = txt_Title.Text;
        }

        private void txt_Description_Validated(object sender, EventArgs e)
        {
            Description = txt_Description.Text;
        }

        private void btn_AddAward_Click(object sender, EventArgs e)
        {
            bool flagForAdd = true;

            if (this.ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }

        private void txt_Title_Validating(object sender, CancelEventArgs e)
        {
            string Title = txt_Title.Text;
            bool valid = !string.IsNullOrWhiteSpace(Title);
            if (valid)
            {
                ctl_ErrorProvider.SetError(txt_Title, string.Empty);
                e.Cancel = false;
            }
            else
            {
                ctl_ErrorProvider.SetError(txt_Title, "Введите имя!");
                e.Cancel = true;
            }
        }
    }
}
