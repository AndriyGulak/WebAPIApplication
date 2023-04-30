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
        [HttpGet]
        public ViewResult Edit(int id, string name, string place)
        {
            // return View("Edit");
            //Console.Write(id);

            Redirect("Friend/Edit");

            ViewBag.FriendID = id;
            ViewBag.Name = name;
            ViewBag.Place = place;

            return View(); //"Edit"
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
            //return View("Create");
        }
        [HttpPut("Edit/{id}")]
        public IActionResult Edit(IFormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                Console.Write(formCollection["FriendID"]);
                Console.Write(formCollection["FriendName"]);
                Console.Write(formCollection["Place"]);
            }
            return View("Index", friends);
        }
    }
}