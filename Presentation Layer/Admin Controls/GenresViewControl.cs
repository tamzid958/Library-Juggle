using System;
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
        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            if (GenreName.Text == null) return;
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

            InitState();
        }

        private void GenreGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        { 
             if (GenreGridView.CurrentRow == null) return;
             var genreId = int.Parse(StaticMethods.GridViewDataAccess(GenreGridView, "GenreId"));
             var genreName = StaticMethods.GridViewDataAccess(GenreGridView, "GenreName");
             if (string.IsNullOrWhiteSpace(genreName)) return;
             var currentGenre = _genre.GetGenre(genreId);
             currentGenre.GenreName = genreName;
             _genre.UpdateGenre(currentGenre);
        }
    }
}