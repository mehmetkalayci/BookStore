using BookStore.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmAddProduct : BaseForm
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void ClearComponents()
        {
            txtItemId.Text = txtItemName.Text = txtPublisher.Text = dtPickerReleaseDate.Text =
            pnlBook.Controls["txtAuthor"].Text = pnlBook.Controls["txtISBN"].Text =
            pnlMusic.Controls["txtAlbumName"].Text = pnlMusic.Controls["txtArtist"].Text = "";

            ((CheckBox)pnlMovie.Controls["chkIsSubtitled"]).Checked = pnlBook.Enabled = pnlMovie.Enabled = pnlMusic.Enabled = false;
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBook.Enabled = pnlMusic.Enabled = pnlMovie.Enabled = false;
            switch (cmbItemType.SelectedIndex)
            {
                case 0:
                    pnlBook.Enabled = true;
                    break;
                case 1:
                    pnlMusic.Enabled = true;
                    break;
                case 2:
                    pnlMovie.Enabled = true;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbItemType.SelectedIndex)
                {
                    case 0:
                        Book book = new Classes.Book();
                        book.ItemId = int.Parse(txtItemId.Text);
                        book.ItemName = txtItemName.Text;
                        book.Publisher = txtPublisher.Text;
                        book.ReleaseDate = dtPickerReleaseDate.Value;
                        book.Author = pnlBook.Controls["txtAuthor"].Text;
                        book.ISBN = pnlBook.Controls["txtISBN"].Text;

                        Db.Products.Add(book);
                        MessageBox.Show("Kitap Eklendi!");

                        break;
                    case 1:

                        Music music = new Classes.Music();
                        music.ItemId = int.Parse(txtItemId.Text);
                        music.ItemName = txtItemName.Text;
                        music.Publisher = txtPublisher.Text;
                        music.ReleaseDate = dtPickerReleaseDate.Value;
                        music.AlbumName = pnlMusic.Controls["txtAlbumName"].Text;
                        music.Artist = pnlMusic.Controls["txtArtist"].Text;

                        Db.Products.Add(music);
                        MessageBox.Show("Müzik Eklendi!");

                        break;
                    case 2:

                        Movie movie = new Classes.Movie();
                        movie.ItemId = int.Parse(txtItemId.Text);
                        movie.ItemName = txtItemName.Text;
                        movie.Publisher = txtPublisher.Text;
                        movie.ReleaseDate = dtPickerReleaseDate.Value;
                        movie.IsSubtitled = ((CheckBox)pnlMovie.Controls["chkIsSubtitled"]).Checked;


                        Db.Products.Add(movie);
                        MessageBox.Show("Film Eklendi!");

                        break;
                }

                ClearComponents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu!\n" + ex.Message);
            }

        }

    }
}
