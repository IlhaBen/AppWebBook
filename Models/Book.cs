﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebBook.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PublicationYear { get; set; }
        public string Author { get; set; }
        public Book()
        {

        }
    }
}
