using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troque
{
    public partial class CardProduit : UserControl
    {
        public CardProduit(bool includeCheckBox = false)
        {
            InitializeComponent();
        }

        public void setButtonVisibility(bool visible)
        {
            Details.Visible = visible;
        }

        public void setCheckBoxVisibility(bool visible)
        {
            checkBox1.Visible = visible;
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CardProduit_Load(object sender, EventArgs e)
        {
            LoadImageAsync(_imageUrl);

        }

        private void nomProduit_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        public int idProduit { get; set; }
        public int userId { get; set; }

        public string nomProduit
        {
            get { return labelNomProduit.Text; }
            set { labelNomProduit.Text = value; }
        }

        public string description
        {
            get { return labeldescription.Text; }
            set { labeldescription.Text = value; }
        }

        public string categorie
        {
            get { return labelcategorie.Text; }
            set { labelcategorie.Text = value; }
        }

        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                LoadImageAsync(_imageUrl);
            }
        }
        private string _imageUrl;
        public async Task SetImageUrlAsync(string imageUrl)
        {
            _imageUrl = imageUrl;
            await LoadImageAsync(_imageUrl);
        }
        

        public async Task LoadImageAsync(string imageUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        this.pictureBoxImage.Image = Image.FromStream(ms);
                        this.pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom; // Adjust the image size mode as needed
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Failed to load image: {ex.Message}");
                Console.WriteLine($"Failed to load image: {ex.Message}");
            }
        }

        private void Details_Click(object sender, EventArgs e)
        {
            CreateEchange createEchange = new CreateEchange(this.userId);
            createEchange.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
