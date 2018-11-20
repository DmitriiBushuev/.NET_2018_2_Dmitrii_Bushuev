using System;
using System.Windows.Forms;

namespace Bushuev_Dmitrii_Task13
{
    public partial class DeleteAward : Form
    {
        public DeleteAward()
        {
            InitializeComponent();
        }

        private void btn_DeleteAward_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }
    }
}
