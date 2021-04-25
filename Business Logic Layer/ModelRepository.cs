using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Juggle.Business_Logic_Layer
{
    public class LoanModelRepository
    {
        public int LoanId { set; get; }
        public string BookName { set; get; }
        public string UserName { set; get; }
        public DateTime DateIssued { set; get; }
        public DateTime ReturnDate { get; set; }
        public string Returned { get; set; }
    }
}
