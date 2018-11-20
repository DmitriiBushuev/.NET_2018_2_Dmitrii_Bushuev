using Department.BLL;
using Entities;
using System;
using System.Windows.Forms;

namespace Bushuev_Dmitrii_Task13
{
    public partial class myMainForm : Form
    {
        //сортировка
        enum SortOrder
        {
            Asc,
            Desc
        };
        SortOrder lastNameSort = SortOrder.Asc;

        private UsersBL userBL = new UsersBL();

        private AwardsBL awardBL = new AwardsBL();

        public myMainForm()
        {
            InitializeComponent();
            awardBL.InitList();
            userBL.InitList();

            DisplayUsers();
            DisplayAwards();
            //dataGridView2.DataSource = awardBL.GetList();
            //dataGridView1.DataSource = userBL.GetList();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            var form = new UserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                userBL.Add(form.BirthDate, form.LastName, form.FirstName);
                DisplayUsers();
            }
        }

        private void btn_Escape_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctlGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lastNameSort == SortOrder.Asc)
            {
                lastNameSort = SortOrder.Desc;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = userBL.SortUsersByNameDesc();
            }
            else
            {
                lastNameSort = SortOrder.Asc;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = userBL.SortUsersByNameAsc();
            }
            dataGridView1.Columns["IdUser"].Visible = false;
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            var user = dataGridView1.CurrentRow.DataBoundItem as User;

            var form = new DeleteUser();
            if (form.ShowDialog() == DialogResult.OK && (user != null))
            {
                userBL.Delete(user);
                DisplayUsers();
            }
        }

        private void btn_AddAward_Click(object sender, EventArgs e)
        {
            var form = new AwardForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                awardBL.Add(new Award(form.Title, form.Description));
                DisplayAwards();
            }
        }

        private void btn_DeleteAward_Click(object sender, EventArgs e)
        {
            var award = dataGridView2.CurrentRow?.DataBoundItem as Award;

            var form = new DeleteAward();
            if (form.ShowDialog() == DialogResult.OK && (award != null))
            {
                awardBL.Delete(award);

                foreach (var user in userBL.GetList())
                {
                    user.DeleteAward(award.Title);
                }
                DisplayUsers();
                DisplayAwards();
            }
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            var user = dataGridView1.CurrentRow?.DataBoundItem as User;

            if (user != null)
            {
                var form = new UserForm(user.BirthDate, user.LastName, user.FirstName);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    user.BirthDate = form.BirthDate;
                    user.LastName = form.LastName;
                    user.FirstName = form.FirstName;

                    DisplayUsers();
                }
            }
        }

        private void btn_EditAward_Click(object sender, EventArgs e)
        {
            var award = dataGridView2.CurrentRow?.DataBoundItem as Award;
            if (award != null)
            {
                var form = new AwardForm(award.Title, award.Description);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    award.Title = form.Title;
                    award.Description = form.Description;

                    DisplayAwards();
                }
            }
        }

        private void btn_RewardUser_Click(object sender, EventArgs e)
        {
            var user = dataGridView1.CurrentRow?.DataBoundItem as User;

            if (user != null)
            {
                var form = new UserRewardForm(awardBL.GetList(), user.GetAwards());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    user.ClearAwards();

                    user.AddAwards(form.SelectedAwards);

                    DisplayUsers();
                }
            }
        }

        private void DisplayUsers()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = userBL.GetList();
            dataGridView1.Columns["IdUser"].Visible = false;
        }

        private void DisplayAwards()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = awardBL.GetList();
            dataGridView2.Columns["IdAward"].Visible = false;
        }
    }
}
