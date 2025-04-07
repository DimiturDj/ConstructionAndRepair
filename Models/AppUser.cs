using System.ComponentModel.DataAnnotations;

namespace RepairAndConstruction.Models
{
    public class AppUser
    {
        
            public int Id { get; set; } // This is the primary key
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        


    }

 }


