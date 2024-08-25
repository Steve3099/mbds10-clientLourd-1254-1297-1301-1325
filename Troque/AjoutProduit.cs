using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Troque.Api;
using Troque.Model;

namespace Troque
{
    public partial class AjoutProduit : Form
    {
        public List<Category> categories { get; set; }
        public AjoutProduit()
        {
            InitializeComponent();
            CategoryApi categoryApi = new CategoryApi();
            loadCategories();
        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            string desc = this.richTextBoxDescription.Text;
            string name = this.textBoxNomProduit.Text;
            Image image = this.pictureBoxImage.Image;

            List<int> selectedCategoryIds = new List<int>();

            foreach (Category category in checkedListBoxCategory.CheckedItems)
            {
                Console.WriteLine(category.Id);
                selectedCategoryIds.Add(category.Id); // Assuming Category_id is the ID property
            }
            ProductApi productApi = new ProductApi();
            try
            {
                
                Product result = await productApi.AddProduct(name, desc, selectedCategoryIds);
                bool resu = await productApi.UploadImage(result.id, image);
                if (result!=null && resu)
                {
                    MessageBox.Show("Product added successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add product");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void loadCategories()
        {
            CategoryApi categoryApi = new CategoryApi();
            categories = await categoryApi.GetCategories();
            this.checkedListBoxCategory.Items.AddRange(categories.ToArray());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file's path
                    string selectedFilePath = openFileDialog.FileName;

                    // Load the image from the file
                    Image originalImage = Image.FromFile(selectedFilePath);

                    // Resize the image to fit the PictureBox dimensions
                    Image resizedImage = ResizeImageToFitPictureBox(originalImage, pictureBoxImage.Width, pictureBoxImage.Height);

                    // Set the resized image to the PictureBox
                    pictureBoxImage.Image = resizedImage;
                }
            }
        }

        private Image ResizeImageToFitPictureBox(Image image, int width, int height)
        {
            // Create a new Bitmap with the same dimensions as the PictureBox
            Bitmap resizedBitmap = new Bitmap(width, height);

            // Use Graphics to draw the original image onto the new Bitmap, resizing it
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                // Set the interpolation mode for high quality resizing
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Draw the original image onto the new Bitmap at the specified size
                graphics.DrawImage(image, 0, 0, width, height);
            }

            return resizedBitmap;
        }

        private void checkedListBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AjoutProduit_Load(object sender, EventArgs e)
        {

        }
    }
}
