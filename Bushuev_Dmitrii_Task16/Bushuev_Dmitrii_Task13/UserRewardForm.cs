using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bushuev_Dmitrii_Task13
{
    public partial class UserRewardForm : Form
    {
        public UserRewardForm(IEnumerable<Award> listAwards, IEnumerable<string> userAwards)
        {
            InitializeComponent();

            chkbx_Awards.Items.AddRange(listAwards.Select(a => a.Title).ToArray());
            for (int i = 0; i < chkbx_Awards.Items.Count; i++)
            {
                if (chkbx_Awards.Items[i] is string award && userAwards.Contains(award))
                {
                    chkbx_Awards.SetItemChecked(i, true);
                }
            }
        }

        private void btn_Reward_Click(object sender, EventArgs e)
        {
            SelectedAwards = chkbx_Awards.CheckedItems.OfType<string>();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }

        public IEnumerable<string> SelectedAwards
        {
            get; set;
        }
    }
}
