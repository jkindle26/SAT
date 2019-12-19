using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA
{
    #region Course

  
    [MetadataType(typeof(CourseMetadata))]//referencing the metadata class
    public partial class Course { }
    public class CourseMetadata
    {
        /*
        [Display] - change the display text (on the view)
            [DisplayFormat] - apply formatting to a value (i.e. display a date as mm/dd/yyyy, currency as $x.xx, etc.)
            - can add ApplyFormatInEditMode property if the formatting should be applied while editing
            [Required] - the field is non-nullable in the data structure
            [StringLength] - limit the number of characters that can be input (match field data type - DB)
            [Range] - used for numeric ranges (i.e. user should enter a number between 1 and 5)
            [UIHint("HintText")] - change the way an MVC control (DisplayFor, EditorFor) will render (on the view)
            [DataType(type)] - use .NET default validation for a specific data type (i.e. dates, email, etc. vs. RegEx)            
        */
        [StringLength(50,ErrorMessage ="Course name must be 50 characters or less")]
        [Required(ErrorMessage ="***Required***")]
        [Display(Name ="Course")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "***Required***")]
        [Display(Name ="Description")]
        public string CourseDescription { get; set; }

        [Range(1,6,ErrorMessage ="Classes must have 1-6 credit hours")]
        [Required(ErrorMessage = "***Required***")]
        [Display(Name ="Credit Hrs")]
        public byte CreditHours { get; set; }

        [StringLength(250,ErrorMessage ="Curriculum must be less than 250 characters")]
        [Display(Name ="Curriculum")]
        public string Curriculum { get; set; }
        public string Notes { get; set; }

        [Display(Name ="Active")]
        public Nullable<bool> IsActive { get; set; }

    }
    #endregion

    #region Student
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student { }
    public  class StudentMetadata
    {
        [Required(ErrorMessage ="***Required***")]
        [Display(Name ="First Name")]
        [StringLength(20,ErrorMessage ="***First Name can't be more than 20 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "***Required***")]
        [Display(Name ="Last Name")]
        [StringLength(20, ErrorMessage = "***Last Name can't be more than 20 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "***Required***")]
        [Display(Name ="Major")]
        [StringLength(15, ErrorMessage = "***Major can't be more than 15 characters")]
        public string Major { get; set; }
        [StringLength(50,ErrorMessage ="Address can't be more than 50 characters")]
        public string Address { get; set; }
        [StringLength(25,ErrorMessage ="City can't be more than 25 characters")]
        public string City { get; set; }
        [StringLength(2,MinimumLength=2,ErrorMessage ="Use state abbrievation")]
        public string State { get; set; }
        [StringLength(10,ErrorMessage ="Zip code can't be more than 10 characters")]
        [Display(Name ="Zip Code")]
        [DataType(DataType.PostalCode,ErrorMessage ="Please enter valid zip code")]
        public string ZipCode { get; set; }
        [StringLength(13,ErrorMessage ="Phone number can't be more than 13 characters")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "***Required***")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please enter valid email address")]
        public string Email { get; set; }
        public string PhotoUrl { get; set; }
    }
    #endregion

    #region Enrollments

    [MetadataType(typeof(EnrollmentsMetadata))]
    public partial class Enrollment { }
    public class EnrollmentsMetadata
    {
        [Required(ErrorMessage ="***Required***")]
        [DataType(DataType.Date, ErrorMessage = "Enter valid date")]
        [Display(Name ="Enrollment Date")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:d}", NullDisplayText ="[--N/A--]")]
        public System.DateTime EnrollmentDate { get; set; }

    }

    #endregion

    #region ScheduledClass

    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass { }
    public class ScheduledClassMetadata
    {
        [Required(ErrorMessage ="***Required***")]
        [DataType(DataType.Date,ErrorMessage ="Enter valid date")]
        public System.DateTime StartDate { get; set; }

        [Required(ErrorMessage = "***Required***")]
        [DataType(DataType.Date, ErrorMessage = "Enter valid date")]
        public System.DateTime EndDate { get; set; }

        [Required(ErrorMessage = "***Required***")]
        [StringLength(40,ErrorMessage ="Instructors name can't exceed 40 characters")]
        public string InstructorName { get; set; }

        [Required(ErrorMessage = "***Required***")]
        [StringLength(20,ErrorMessage ="Location must be 20 character or less")]
        public string Location { get; set; }

    }

    #endregion

    #region StudentStatus
    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }
    public class StudentStatusMetadata
    {
        [Required(ErrorMessage ="***Required***")]
        [StringLength(30,ErrorMessage ="Can not exceed 30 characters")]
        [Display(Name ="Student Status")]
        public string SSName { get; set; }
        [StringLength(250,ErrorMessage ="Description can not exceed 250 characters")]
        [Display(Name ="Discription")]
        [UIHint("MultilineText")]
        public string SSdescription { get; set; }

    }

    #endregion

    #region ScheduledClassStatus
    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
    public class ScheduledClassStatusMetadata
    {
        [Required(ErrorMessage ="**Required**")]
        [Display(Name ="Class status")]
        [StringLength(50,ErrorMessage ="Class status can't be more than 50 characters")]
        public string SCSName { get; set; }

    }

    #endregion
}
