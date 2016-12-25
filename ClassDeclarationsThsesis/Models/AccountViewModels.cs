using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace ClassDeclarationsThsesis.Models
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

    public class ClassesViewModel
    {
        public List<Task> task { set; get; }
        public List<Subject> subject { set; get; }
    }

    public class SetHomeworkViewModel
    {
        [Required]
        [Display(Name = "Subject Name")]
        public string subject_name { get; set; }
        [Required]
        [Display(Name="File path")]
        public string file_path { get; set; }
        
        public string task1_name { get; set; }
        public double task1_points { get; set; }
        public string task2_name { get; set; }
        public double task2_points { get; set; }
        public string task3_name { get; set; }
        public double task3_points { get; set; }
        public string task4_name { get; set; }
        public double task4_points { get; set; }
        public string task5_name { get; set; }
        public double task5_points { get; set; }
        public string task6_name { get; set; }
        public double task6_points { get; set; }
        public string task7_name { get; set; }
        public double task7_points { get; set; }
        [Display(Name = "Deadline")]
        [Required]
        [RegularExpression(@"^[0-9._%+-]+(/)+[0-9._%+-]+(/)+[0-9._%+-]$", ErrorMessage = "Input date has to be of form DD/MM/YYYY")]
        public string deadline { get; set; }


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
        [Display(Name = "Email*")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+(@student.mini.pw.edu.pl|@mini.pw.edu.pl)$", ErrorMessage = "Registration limited to university domain email.")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password*")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password*")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name="Name*")]
        public string Name { get; set; }
        [Required]
        [Display(Name="Surname*")]
        public string Surname { get; set; }
        [Display(Name = "Index number")]
        public object IndexNumber { get; set; }
        [Display(Name = "Dean's group")]
        public object DeanGroup { get; set; }
        [Required]
        [Display(Name = "Subject*")]
        public object Subject { get; set; }
        [Display(Name = "Group")]
        public object Group { get; set; }
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
