using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime Birthdate { get; set; }

        public IEnumerable<Award> UserAwards { get; set; }

        public List<AwardViewModel> AvailableRewards { get; set; }

        public UserViewModel()
        {
            AvailableRewards = new List<AwardViewModel>();
        }

        public User ToUser()
        {
            var user = new User
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                BirthDate = Birthdate
            };
            var awards = AvailableRewards
                    .Where(r => r.Checked == true)
                    .Select(r => new Award
                    {
                        Id = r.Id,
                        Title = r.Title,
                        Description = r.Description
                    }).ToList();
            user.AddAwards(awards);
            return user;
        }
        public static UserViewModel GetViewModel(User user, IEnumerable<Award> awards)
        {
            var userModel = new UserViewModel();
            userModel.Id = user.Id;
            userModel.FirstName = user.FirstName;
            userModel.LastName = user.LastName;
            userModel.Birthdate = user.BirthDate;
            userModel.Age = user.UserAge;
            userModel.UserAwards = user.GetAwards();

            var rewards = new List<AwardViewModel>();
            foreach (var award in awards)
            {
                rewards.Add(AwardViewModel.GetViewModel(award, user.GetAwards()));
            }

            userModel.AvailableRewards = rewards.ToList();

            return userModel;
        }
    }
}