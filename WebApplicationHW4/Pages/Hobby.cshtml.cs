using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using System.Net;
using System.Threading;
using System.Xml.Linq;
using WebApplicationHW4.Models;

namespace WebApplicationHW4.Pages
{
    public class HobbyModel : PageModel
    {
        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();
        public async Task OnGetAsync()
        {
            Hobbies.Add(new Hobby() { Id = 1, Name = "Skiing", Description = "The action of traveling over snow on skis", Price = 100500.00d });
            Hobbies.Add(new Hobby() { Id = 2, Name = "Cycling ", Description = "The sport or activity of riding a bicycle", Price = 12.50d });
            Hobbies.Add(new Hobby() { Id = 3, Name = "BBQ", Description = "Barbecue or barbeque(informally BBQ) is a term used with significant regional and national variations to describe various cooking methods that use live fire and smoke to cook the food", Price = 333.00d });
        }
    }
}
