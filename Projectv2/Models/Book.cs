using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projectv2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [StringLength(80, ErrorMessage = "This text is too long")]
        public string Title { get; set; }
        [StringLength(70, ErrorMessage ="This text is too long")]
        public string Genre { get; set; }
        [StringLength(70, ErrorMessage = "This text is too long")]
        public string OriginalLanguage { get; set; }
        [StringLength(70, ErrorMessage = "This text is too long")]
        public string Writer { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublishingDate { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}