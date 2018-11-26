using Department.BLL;
using Entities;
using System;
using System.Linq;
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
        SortOrder Sort = SortOrder.Asc;

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
            var column = dgv_Users.Columns[e.ColumnIndex];
            Func<User, object> orderBy = null;

            switch (column.Name)
            {
                case nameof(User.LastName):
                    orderBy = u => u.LastName;
                    break;

                case nameof(User.FirstName):
                    orderBy = u => u.FirstName;
                    break;

                case nameof(User.BirthDate):
                    orderBy = u => u.BirthDate;
                    break;

                case nameof(User.UserAge):
                    orderBy = u => u.UserAge;
                    break;

                case nameof(User.UserAwards):
                    orderBy = u => u.UserAwards;
                    break;

                default:
                    return;
            }

            dgv_Users.DataSource = null;

            if (Sort == SortOrder.Asc)
            {
                Sort = SortOrder.Desc;
                dgv_Users.DataSource = userBL.SortByAsc(orderBy);
            }
            else
            {
                Sort = SortOrder.Asc;
                dgv_Users.DataSource = userBL.SortByDesc(orderBy);
            }

            dgv_Users.Columns["Id"].Visible = false;
        }

        private void awardGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dgv_Awards.Columns[e.ColumnIndex];
            Func<Award, object> orderBy = null;

            switch (column.Name)
            {
                case nameof(Award.Title):
                    orderBy = a => a.Title;
                    break;

                case nameof(Award.Description):
                    orderBy = a => a.Description;
                    break;

                default:
                    return;
            }

            dgv_Awards.DataSource = null;

            if (Sort == SortOrder.Asc)
            {
                Sort = SortOrder.Desc;
                dgv_Awards.DataSource = awardBL.SortByAsc(orderBy);
            }
            else
            {
                Sort = SortOrder.Asc;
                dgv_Awards.DataSource = awardBL.SortByDesc(orderBy);
            }

            dgv_Awards.Columns["Id"].Visible = false;
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            var user = dgv_Users.CurrentRow.DataBoundItem as User;

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
            var award = dgv_Awards.CurrentRow?.DataBoundItem as Award;

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
            var user = dgv_Users.CurrentRow?.DataBoundItem as User;

            if (user != null)
            {
                var form = new UserForm(user.BirthDate, user.LastName, user.FirstName);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    user.BirthDate = form.BirthDate;
                    user.LastName = form.LastName;
                    user.FirstName = form.FirstName;

                    userBL.Edit(user);

                    DisplayUsers();
                }
            }
        }

        private void btn_EditAward_Click(object sender, EventArgs e)
        {
            var award = dgv_Awards.CurrentRow?.DataBoundItem as Award;
            if (award != null)
            {
                var form = new AwardForm(award.Title, award.Description);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    award.Title = form.Title;
                    award.Description = form.Description;
                    awardBL.Edit(award);
                    DisplayUsers();
                    DisplayAwards(); 
                }
            }
        }

        private void btn_RewardUser_Click(object sender, EventArgs e)
        {
            var user = dgv_Users.CurrentRow?.DataBoundItem as User;

            if (user != null)
            {
                var form = new UserRewardForm(awardBL.GetList(), user.GetAwards());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var awardsNow = awardBL.GetList().Where(a => user.GetAwards().Contains(a.Title));
                    var selectedAwards = awardBL.GetList().Where(a => form.SelectedAwards.Contains(a.Title));

                    var awardToAdd = selectedAwards.Where(sa => !awardsNow.Any(a => a.Id == sa.Id));
                    var awardToDelete = awardsNow.Where(a => !selectedAwards.Any(sa => sa.Id == a.Id));

                    foreach (var toAdd in awardToAdd)
                    {
                        userBL.AddAward(user.Id, toAdd.Id);
                    }

                    foreach (var toDelete in awardToDelete)
                    {
                        userBL.RemoveAward(user.Id, toDelete.Id);
                    }

                    DisplayUsers();
                }
            }
        }

        private void DisplayUsers()
        {
            dgv_Users.DataSource = null;
            dgv_Users.DataSource = userBL.GetList();
            dgv_Users.Columns["Id"].Visible = false;
        }

        private void DisplayAwards()
        {
            dgv_Awards.DataSource = null;
            dgv_Awards.DataSource = awardBL.GetList();
            dgv_Awards.Columns["Id"].Visible = false;
        }

        private void dgv_Users_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms_Users.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms_Awards.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void dgv_Awards_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgv_Awards.ClearSelection();

                dgv_Awards.CurrentCell = dgv_Awards.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void dgv_Users_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgv_Users.ClearSelection();

                dgv_Users.CurrentCell = dgv_Users.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
    }
}
