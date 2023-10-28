using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class MemberClass:PersonClass
    {
        public int MembershipID{ get; set; }
        public string BorrowedBooks { get; set;}
        public DateTime BorrowingDate { get; set; }
        public DateTime ReturnDate { get; set; }
    
            
    }
}
