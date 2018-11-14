using System;
using System.ComponentModel;
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
        SortOrder lastNameSort = SortOrder.Asc;

        private BindingList<User> userList = new BindingList<User>();

        private BindingList<Award> awardList = new BindingList<Award>();

        public myMainForm()
        {
            InitializeComponent();

            awardList.Add(new Award("First degree hero", "great hero"));
            awardList.Add(new Award("Second degree hero", "so-so hero"));
            awardList.Add(new Award("Darwin Award", "not cool"));
            awardList.Add(new Award("Duelist", "the fastest hand in the wild west"));
            dataGridView2.DataSource = awardList;

            userList.Add(new User(new DateTime (2002, 09, 22),"Тom", "White"));
            userList.Add(new User(new DateTime(2003, 09, 22), "Sam", "Black"));
            userList.Add(new User(new DateTime(2004, 09, 22), "Pall", "Orange"));
            userList.Add(new User(new DateTime(2005, 09, 22), "Sasha", "Blue"));
            userList.Add(new User(new DateTime(2001, 09, 22), "Gor", "Grey"));
            dataGridView1.DataSource = userList;
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            var form = new UserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                userList.Add(new User(form.BirthDate ,form.LastName, form.FirstName));
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
                userList = new BindingList<User>(userList.OrderByDescending(u => u.LastName).ToList());
            }
            else
            {
                userList = new BindingList<User>(userList.OrderBy(u => u.LastName).ToList());
                lastNameSort = SortOrder.Asc;
            }
            dataGridView1.DataSource = userList;
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            var user = dataGridView1.CurrentRow.DataBoundItem as User;

            var form = new DeleteUser();
            if (form.ShowDialog() == DialogResult.OK && (user != null))
            {
                userList.Remove(user);
            }
        }

        private void btn_AddAward_Click(object sender, EventArgs e)
        {
            var form = new AwardForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                awardList.Add(new Award(form.Title, form.Description));
            }
        }

        private void btn_DeleteAward_Click(object sender, EventArgs e)
        {
            var award = dataGridView2.CurrentRow?.DataBoundItem as Award;

            var form = new DeleteAward();
            if (form.ShowDialog() == DialogResult.OK && (award != null))
            {
                awardList.Remove(award);

                foreach (var user in userList)
                {
                    user.DeleteAward(award.Title);
                }
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

                    dataGridView1.Refresh();
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

                    dataGridView2.Refresh();
                }
            }
        }

        private void btn_RewardUser_Click(object sender, EventArgs e)
        {
            var user = dataGridView1.CurrentRow?.DataBoundItem as User;

            if (user != null)
            {
                var form = new UserRewardForm(awardList, user.GetAwards());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    user.ClearAwards();

                    user.AddAwards(form.SelectedAwards);

                    dataGridView1.Refresh();
                }
            }
        }
    }
}
