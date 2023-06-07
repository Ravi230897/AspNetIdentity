using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AspNetIdentityApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AspNetIdentityAppUser class
public class AspNetIdentityAppUser : IdentityUser
{
    [Required]
    [PersonalData]
    [Column(TypeName="nvarchar(100)")]
    public string FirstName { get; set; }
    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "Phone Number")]
    [Required(ErrorMessage = "Phone Number Required!")]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
    public string PhoneNumber { get; set; }
}

