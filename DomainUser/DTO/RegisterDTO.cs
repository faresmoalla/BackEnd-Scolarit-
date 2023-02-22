using System.ComponentModel.DataAnnotations;

namespace DomainUser.DTO;

    // Register DTO
    public class RegisterDTO
    {


  
        [Required]
      public string Role { get; set; } = null!;


        [Required]
     public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;



    }

