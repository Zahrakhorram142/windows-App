using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class BookClass
    {
        public int BookID { get; set; }
        public string Name { get; set; }   
        public string Writer { get; set; } 
        public string Subject { get; set; } 
        public string Publishers { get; set; }  
        public  DateTime YearOfPublication { get; set; }
        public string Edition { get; set; }
    }
}
