using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCHW5.Models
{
    public class Friend
    {
        //Create a Model named “Friend” with following properties : FriendID,FriendName,Place
        [Required]
        public int FriendID { get; set; }
        [Required(ErrorMessage = "Friend Name Empty Not Allowed")]
        public string FriendName { get; set; } = "";
        [StringLength(25, ErrorMessage = "Max length 25")]
        public string Place { get; set; } = "";
    }
}
