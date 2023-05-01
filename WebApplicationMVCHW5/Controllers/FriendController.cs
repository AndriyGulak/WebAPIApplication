using Microsoft.AspNetCore.Mvc;
using WebApplicationMVCHW5.Models;

namespace WebApplicationMVCHW5.Controllers
{
    public class FriendController : Controller
    {
        public List<Friend>? friends;

        public List<Friend> GenerateFriends()
        {
            friends = new List<Friend>();
            friends.Add(new Friend { FriendID = 1, FriendName = "Olexandr", Place = "Brovary" });
            friends.Add(new Friend { FriendID = 2, FriendName = "Alona", Place = "Kyiv" });
            friends.Add(new Friend { FriendID = 3, FriendName = "Cat", Place = "Home" });
            return friends;
        }

        public FriendController()
        {
            friends = GenerateFriends();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(friends);
        }
        //[HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        //[HttpGet]
        public ViewResult Edit(int id, string friendName, string place)
        {
            bool isUpdated;
            isUpdated = false;
            foreach (var f in friends.Where(r => r.FriendID == id))
            {
                if (f.FriendName != friendName || f.Place != place) { isUpdated = true; }
                f.FriendName = friendName;
                f.Place = place;
            }

            ViewBag.FriendID = id;
            ViewBag.FriendName = friendName;
            ViewBag.Place = place;

            if (isUpdated) { return View("Index", friends); }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Create(Friend friend)
        {
            if (ModelState.IsValid)
            {
                friends.Add(friend);
                //var f = new Friend { FriendID = 4, FriendName = "test", Place = "qwerty" };
                //friends.Add(f);
               //return View(friend);
            }
            return View("Index", friends);
        }

        public IActionResult Delete(int id)
        {
            var df = friends.Single(r => r.FriendID == id);
            friends.Remove(df);
            return View("Index", friends);
        }

        //[HttpPut("Edit/{id}")]
        public IActionResult EditForm(IFormCollection formCollection)
        {
            if (ModelState.IsValid)
            {

                int id = int.Parse(formCollection["FriendID"]);
                foreach (var f in friends.Where(r => r.FriendID == id))
                {
                    f.FriendName = formCollection["FriendName"];
                    f.Place = formCollection["Place"];
                }
            }
            return View("Index", friends);
        }
    }
}