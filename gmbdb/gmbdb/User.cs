//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Ajax.Utilities;

namespace gmbdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.CommentToReviews = new HashSet<CommentToReview>();
            this.Reviews = new HashSet<Review>();
            this.UserToReviews = new HashSet<UserToReview>();
        }
    
        public System.Guid Id { get; set; }
        
        /*[Required(ErrorMessage = "Your username has to be 5-30 letters long.")]
        [StringLength(maximumLength: 30, MinimumLength = 5)]*/
        public string Username { get; set; }
        
        /*[Required(ErrorMessage = "Your password has to be 5-30 letters long.")]
        [StringLength(maximumLength: 30, MinimumLength = 5)]*/
        public string Password { get; set; }
        public string Salt { get; set; }
        
        /*[Required(ErrorMessage = "Please enter a valid email-adress!"), DataType(DataType.EmailAddress)]*/
        public string Email { get; set; }
        
        
        /*[Required(ErrorMessage = "Your password has to be 2-50 letters long.")]
        [StringLength(maximumLength: 30, MinimumLength = 2)] */
        [Display(Name = "Your First Name")]
        public string FirstName { get; set; }
        
        
        /*[Required(ErrorMessage = "Your password has to be 2-50 letters long.")]
        [StringLength(maximumLength: 30, MinimumLength = 2)] */
        [Display(Name = "Your Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Author")]
        public string FullName {
            get { return FirstName + " " + LastName; }
            set { FullName = value; }
        } 
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentToReview> CommentToReviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserToReview> UserToReviews { get; set; }
    }
}
