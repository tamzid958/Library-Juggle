using System;
using System.Drawing;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using MetroFramework;

namespace Library_Juggle.Presentation_Layer.Admin_Controls
{
    public partial class GenresViewControl : UserControl
    {
        private readonly GenreDataAccess _genre;

        public GenresViewControl()
        {
            InitializeComponent();
            _genre = new GenreDataAccess();
            InitState();
        }

        private void InitState()
        {
            GenreGridView.DataSource = _genre.GetAllGenres();
            GenreGridView.Columns[0].Visible = GenreGridView.Columns[2].Visible = false;
            var deleteButtonsColumn = new DataGridViewButtonColumn
            {
                HeaderText = @"Delete",
                Name = @"UserDataGridGenreDelete",
                DataPropertyName = @"GenreId",
                UseColumnTextForButtonValue = true,
                Text = @"Delete",
                FlatStyle = FlatStyle.Flat,
            };

            GenreGridView.Columns.Add(deleteButtonsColumn);
        }

        private void ChangeState()
        {
            GenreGridView.DataSource = _genre.GetAllGenres();
            GenreGridView.Columns[0].Visible = GenreGridView.Columns[2].Visible = false;
        }
        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GenreName.Text)) return;
            var newGenre = new Genre {GenreName = GenreName.Text};
            _genre.CreateGenre(newGenre);
            try
            {
                MetroMessageBox.Show(this, @"New Genre Added!", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            ChangeState();
        }

        private void GenreGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        { 
             if (GenreGridView.CurrentRow == null) return;
             var genreId = int.Parse(StaticMethods.GridViewDataAccess(GenreGridView, "GenreId"));
             var genreName = StaticMethods.GridViewDataAccess(GenreGridView, "GenreName");
             var currentGenre = _genre.GetGenre(genreId);
             if (currentGenre == null) return;
             if (string.IsNullOrWhiteSpace(genreName)) return;
             _genre.UpdateGenre(genreId, genreName);
             try
             {
                 MetroMessageBox.Show(this, $"{genreName} Updated!", @"Information", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
             }
             catch (Exception exception)
             {
                 Console.WriteLine(exception);
             }

             ChangeState();
        }

        private void GenreGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3 || GenreGridView.CurrentRow == null) return;
            var genreId = int.Parse(StaticMethods.GridViewDataAccess(GenreGridView, "GenreId"));
            try
            {
                _genre.DeleteGenre(genreId);
                MetroMessageBox.Show(this, @"Genre Deleted!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            ChangeState();
        }
    }
}