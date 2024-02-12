using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projectv2.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Author
    {
        public int AuthorID { get; set; }
        public int AmountOfBooks { get; set; }
        public string TotalReaders { get; set; }
        public Grade? Grade { get; set; }
        public virtual Book Book { get; set; }
        public virtual Genre Genre { get; set; }
    }
}