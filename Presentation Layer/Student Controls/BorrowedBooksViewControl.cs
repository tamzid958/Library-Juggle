using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;

namespace Library_Juggle.Presentation_Layer.Student_Controls
{
    public partial class BorrowedBooksViewControl : UserControl
    {
        private readonly LoanDataAccess _loan;
        private readonly UserDataAccess _user;
        public BorrowedBooksViewControl()
        {
            _loan = new LoanDataAccess();
            _user = new UserDataAccess();
            InitializeComponent();
            InitState();
        }

        private void InitState()
        {
            BorrowedBooksGrid.DataSource = _loan.GetLoanModelRepositoryForSpecificUser(_user.CurrentUser().UserId);
            BorrowedBooksGrid.Columns[0].Visible = BorrowedBooksGrid.Columns[2].Visible = false; ;
            BorrowedBooksGrid.Columns[1].HeaderText = @"Book";
            BorrowedBooksGrid.Columns[3].HeaderText = @"Date Issued";
            BorrowedBooksGrid.Columns[4].HeaderText = @"Return Date";
            BorrowedBooksGrid.Columns[5].HeaderText = @"Returned";
        }
    }
}
