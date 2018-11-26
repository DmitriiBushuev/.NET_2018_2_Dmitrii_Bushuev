using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bushuev_Dmitrii_Task13
{
    public partial class UserForm : Form
    {
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string LastName { get; set; }

        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(DateTime birthDate, string lastName, string firstName)
        {
            InitializeComponent();

            dtp_BirthDate.Value = birthDate;
            txt_LastName.Text = lastName;
            txt_FirstName.Text = firstName;
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName = txt_LastName.Text;
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = txt_FirstName.Text;
        }

        private void dtpBirthDate_Validated(object sender, EventArgs e)
        {
            BirthDate = dtp_BirthDate.Value;
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string lastName = txt_LastName.Text;
            bool valid = !string.IsNullOrWhiteSpace(lastName);
            if (valid)
            {
                ctl_ErrorProvider.SetError(txt_LastName, string.Empty);
                e.Cancel = false;
            }
            else
            {
                ctl_ErrorProvider.SetError(txt_LastName, "Введите фамилию!");
                e.Cancel = true;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            string FirstName = txt_FirstName.Text;
            bool valid = !string.IsNullOrWhiteSpace(FirstName);
            if (valid)
            {
                ctl_ErrorProvider.SetError(txt_FirstName, string.Empty);
                e.Cancel = false;
            }
            else
            {
                ctl_ErrorProvider.SetError(txt_FirstName, "Введите имя!");
                e.Cancel = true;
            }
        }

        private void dtpBirthDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime birthDate = dtp_BirthDate.Value;
            
            if ((DateTime.Now.Year - birthDate.Year) < 150 && birthDate < DateTime.Now)
            {
                ctl_ErrorProvider.SetError(dtp_BirthDate, string.Empty);
                e.Cancel = false;
            }
            else
            {
                ctl_ErrorProvider.SetError(dtp_BirthDate, "Не пойдёт!");
                e.Cancel = true;
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
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
    }
}
