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
    public partial class frmProducts : BaseForm
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void ClearComponents()
        {
            txtItemId.Text = txtItemName.Text = txtPublisher.Text = dtPickerReleaseDate.Text = txtItemType.Text =
            pnlBook.Controls["txtAuthor"].Text = pnlBook.Controls["txtISBN"].Text =
            pnlMusic.Controls["txtAlbumName"].Text = pnlMusic.Controls["txtArtist"].Text = "";

            ((CheckBox)pnlMovie.Controls["chkIsSubtitled"]).Checked = pnlBook.Enabled = pnlMovie.Enabled = pnlMusic.Enabled = false;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            dgView.DataSource = Db.Products;
        }

        private void dgView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ClearComponents();


                txtItemId.Text = dgView.CurrentRow.Cells[0].Value.ToString();
                txtItemName.Text = dgView.CurrentRow.Cells[1].Value.ToString();
                txtPublisher.Text = dgView.CurrentRow.Cells[2].Value.ToString();
                dtPickerReleaseDate.Text = dgView.CurrentRow.Cells[3].Value.ToString();

                txtItemType.Text = dgView.CurrentRow.DataBoundItem.GetType().Name;

                switch (txtItemType.Text)
                {
                    case "Book":
                        Book tempBook = (Book)dgView.CurrentRow.DataBoundItem;
                        pnlBook.Controls["txtAuthor"].Text = tempBook.Author;
                        pnlBook.Controls["txtISBN"].Text = tempBook.ISBN;

                        pnlBook.Enabled = true;
                        break;
                    case "Music":
                        Music tempMusic = (Music)dgView.CurrentRow.DataBoundItem;
                        pnlMusic.Controls["txtAlbumName"].Text = tempMusic.AlbumName;
                        pnlMusic.Controls["txtArtist"].Text = tempMusic.Artist;

                        pnlMusic.Enabled = true;
                        break;
                    case "Movie":
                        Movie tempMovie = (Movie)dgView.CurrentRow.DataBoundItem;
                        ((CheckBox)pnlMovie.Controls["chkIsSubtitled"]).Checked = tempMovie.IsSubtitled;

                        pnlMovie.Enabled = true;
                        break;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                txtItemType.Text = dgView.CurrentRow.DataBoundItem.GetType().Name;

                Item tempItem = (Item)dgView.CurrentRow.DataBoundItem;

                tempItem.ItemId = int.Parse(txtItemId.Text);
                tempItem.ItemName = txtItemName.Text;
                tempItem.Publisher = txtPublisher.Text;
                tempItem.ReleaseDate = dtPickerReleaseDate.Value;


                switch (txtItemType.Text)
                {
                    case "Book":
                        Book tempBook = (Book)dgView.CurrentRow.DataBoundItem;

                        tempBook.Author = pnlBook.Controls["txtAuthor"].Text;
                        tempBook.ISBN = pnlBook.Controls["txtISBN"].Text;

                        pnlBook.Enabled = true;
                        break;
                    case "Music":
                        Music tempMusic = (Music)dgView.CurrentRow.DataBoundItem;
                        tempMusic.Artist = pnlMusic.Controls["txtArtist"].Text;
                        tempMusic.AlbumName = pnlMusic.Controls["txtAlbumName"].Text;

                        pnlMusic.Enabled = true;
                        break;
                    case "Movie":
                        Movie tempMovie = (Movie)dgView.CurrentRow.DataBoundItem;
                        tempMovie.IsSubtitled = ((CheckBox)pnlMovie.Controls["chkIsSubtitled"]).Checked;

                        pnlMovie.Enabled = true;
                        break;
                }

                MessageBox.Show("Veriler Güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu!\n" + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayıt Silinsin Mi?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Item selectedItem = (Item)dgView.CurrentRow.DataBoundItem;
                Db.Products.Remove(selectedItem);

                dgView.DataSource = null;
                dgView.DataSource = Db.Products;

            }
        }
    }
}
