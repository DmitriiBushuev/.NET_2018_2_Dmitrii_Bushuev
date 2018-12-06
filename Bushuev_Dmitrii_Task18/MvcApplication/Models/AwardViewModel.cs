using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace Models
{
    public class AwardViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public bool Checked { get; set; }

        public Award ToAward()
        {
            var award = new Award
            {
                Id = Id,
                Title = Title,
                Description = Description,
            };
            return award;
        }


        public static AwardViewModel GetViewModel(Award award, IEnumerable<Award> userAwards)
        {
            var model = new AwardViewModel();
            model.Id = award.Id;
            model.Title = award.Title;
            model.Description = award.Description;
            model.Checked = userAwards.Any(r => r.Id == award.Id);
            return model;
        }
    }
}