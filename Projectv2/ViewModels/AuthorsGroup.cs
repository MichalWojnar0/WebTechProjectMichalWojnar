using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projectv2.ViewModels
{
    public class AuthorsGroup
    {
        [DataType(DataType.Text)] 
        public string Writer { get; set; }

        public int BooksCount { get; set; }

    }
}