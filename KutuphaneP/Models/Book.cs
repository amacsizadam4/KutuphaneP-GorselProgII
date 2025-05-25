using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneP.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PDFPath { get; set; }
        public string CoverPath { get; set; } 
        public int TotalPages { get; set; }

    }

}
