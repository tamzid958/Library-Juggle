using System;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using MetroFramework;

namespace Library_Juggle.Presentation_Layer.Shared_Controls
{
    public partial class LoansViewControl : UserControl
    {
        private readonly LoanDataAccess _loan;

        public LoansViewControl()
        {
            _loan = new LoanDataAccess();
            InitializeComponent();
            InitState();
        }

        private void InitState()
        {
            LoanGridView.DataSource = null;
            var markCompletedButtonsColumn = new DataGridViewButtonColumn
            {
                HeaderText = @"Mark Completed",
                Name = @"UserDataGridLoanMarkCompleted",
                DataPropertyName = @"LoanId",
                UseColumnTextForButtonValue = true,
                Text = @"✔️",
                FlatStyle = FlatStyle.Flat,
            };

            LoanGridView.DataSource = _loan.GetLoanModelRepository();
            LoanGridView.Columns[0].Visible = false;
            LoanGridView.Columns[1].HeaderText = @"Book";
            LoanGridView.Columns[2].HeaderText = @"Loanee";
            LoanGridView.Columns[3].HeaderText = @"Date Issued";
            LoanGridView.Columns[4].HeaderText = @"Return Date";
            LoanGridView.Columns[5].HeaderText = @"Returned";
            LoanGridView.Columns.Add(markCompletedButtonsColumn);
        }

        private void LoanGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 6 || LoanGridView.CurrentRow == null) return;
            var loanId = int.Parse(StaticMethods.GridViewDataAccess(LoanGridView, "LoanId"));
            try
            {
                _loan.MarkAsReturned(loanId);
                MetroMessageBox.Show(this, @"Marked as Completed!", @"Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            InitState();
        }
    }
}
