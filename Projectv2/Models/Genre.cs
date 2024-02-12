using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projectv2.Models
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenreID { get; set; }

        public String Name { get; set; }
        public string MostPopularBook { get; set; }
        public string MonthReaders { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}