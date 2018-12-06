using System.Linq;
using System.Web.Mvc;
using Entities;
using Models;
using Department.BLL;

namespace MvcApplication.Controllers
{
    public class UserController : Controller
    {
        private static UsersBL users = new UsersBL();
        private static AwardsBL awards = new AwardsBL();

        static UserController()
        {
            users.InitList();
        }

        // GET: User
        public ActionResult Index()
        {
            ViewBag.HeaderText = "Users list";
            return View(users.GetList().Select(ConvertUser));
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            User u = users.GetList().First(s => s.Id == id);
            return View(UserViewModel.GetViewModel(u, awards.GetList()));
        }

        public ActionResult Edit(int id)
        {
            var currentUser = users.GetList().FirstOrDefault(u => u.Id == id);
            return View(UserViewModel.GetViewModel(currentUser, awards.GetList()));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userModel)
        {
            try
            {
                users.Add(userModel.ToUser());
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, UserViewModel userModel)
        {
            try
            {
                var user = users.GetList().FirstOrDefault(u => u.Id == id);// использую такой костыль т.к. в availableRewards возвращался неполный объект
                var userAwards = awards.GetList().Select(a => AwardViewModel.GetViewModel(a, user.GetAwards()));
                var checkedAwards = userModel.AvailableRewards.Where(a => a.Checked);
                var availableAwards = userAwards.Where(a => checkedAwards.Any(aw => aw.Id == a.Id));
                var deletedAwards = userAwards.Where(a => !checkedAwards.Any(aw => aw.Id == a.Id));

                foreach (var award in availableAwards)
                {
                    award.Checked = true;
                    users.AddAward(id, award.Id);
                }

                foreach (var award in deletedAwards)
                {
                    award.Checked = false;
                    users.RemoveAward(id, award.Id);
                }

                userModel.AvailableRewards = availableAwards.ToList();
                users.Edit(userModel.ToUser());
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var currentUser = users.GetList().FirstOrDefault(u => u.Id == id);
            if (currentUser != null)
            {
                users.Delete(currentUser);
            }

            return RedirectToAction("Index");
        }

        public UserViewModel ConvertUser(User user)
        {
            var userModel = new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Birthdate = user.BirthDate,
                Age = user.UserAge,
                UserAwards = user.GetAwards()
            };
            return userModel;
        }
    }
}
