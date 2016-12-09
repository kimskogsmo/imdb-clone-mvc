//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Linq;
using System.Web.Caching;
using System.Web.Mvc;

namespace gmbdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Review
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Review()
        {
            this.CommentToReviews = new HashSet<CommentToReview>();
            this.UserToReviews = new HashSet<UserToReview>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid CreatorUserId { get; set; }


        [Required(ErrorMessage = "The title has to at least 5 letters long")]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Your review needs to be longer than 5 letters!")]
        [StringLength(maximumLength: 15000, MinimumLength = 5)]
        public string Description { get; set; }

        [Display(Name = "Date Added")]
        public System.DateTime CreatedDate { get; set; }

        public string ShortDate
        {
            get { return CreatedDate.ToShortDateString(); }
            set { value = ShortDate; }
        }

        [Display(Name = "Review Rating")]
        public decimal ReviewRating { get; set; }

        [Display(Name = "User Rating")]
        public int UserRating { get; set; }

        [Display(Name = "Likes")]
        public int LikeCount { get; set; }

        [Display(Name = "Dislikes")]
        public int DislikeCount { get; set; }
        public string Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentToReview> CommentToReviews { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserToReview> UserToReviews { get; set; }

    }
}