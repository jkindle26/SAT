using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentitySample.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        #region Student Property Info
        [Required(ErrorMessage = "***Required***")]
        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "***First Name can't be more than 20 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "***Required***")]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "***Last Name can't be more than 20 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "***Required***")]
        [Display(Name = "Major")]
        [StringLength(15, ErrorMessage = "***Major can't be more than 15 characters")]
        public string Major { get; set; }
        [StringLength(50, ErrorMessage = "Address can't be more than 50 characters")]
        public string Address { get; set; }
        [StringLength(25, ErrorMessage = "City can't be more than 25 characters")]
        public string City { get; set; }
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Use state abbrievation")]
        public string State { get; set; }
        [StringLength(10, ErrorMessage = "Zip code can't be more than 10 characters")]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode, ErrorMessage = "Please enter valid zip code")]
        public string ZipCode { get; set; }
        [StringLength(13, ErrorMessage = "Phone number can't be more than 13 characters")]
        public string Phone { get; set; }
        [Display(Name = "Photo Url")]
        public string PhotoUrl { get; set; }

        #endregion

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}