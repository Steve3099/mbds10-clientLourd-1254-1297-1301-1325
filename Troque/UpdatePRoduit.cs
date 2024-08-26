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
using Troque.Api;
using Troque.Model;

namespace Troque
{
    public partial class UpdatePRoduit : Form
    {
        public List<Category> categories { get; set; }
        public UpdatePRoduit(Product p)
        {
            produit = p;
            InitializeComponent();
            LoadImageAsync(p.product_image);
            loadCategories();
            initialiseChamps();
        }

        public Product produit { get; set; }

        public void initialiseChamps()
        {
            this.textBoxNomProduit.Text = produit.product_name;
            this.richTextBoxDescription.Text = produit.description;
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
        private async void loadCategories()
        {
            CategoryApi categoryApi = new CategoryApi();
            categories = await categoryApi.GetCategories();
            this.checkedListBoxCategory.Items.AddRange(categories.ToArray());
            //check them if they are already selected in the product
            foreach (Category category in categories)
            {
                foreach(Category c in produit.categories)
                {
                    if (c.Id == category.Id)
                    {
                        checkedListBoxCategory.SetItemChecked(checkedListBoxCategory.Items.IndexOf(category), true);
                    }
                }
            }
        }

        private void UpdatePRoduit_Load(object sender, EventArgs e)
        {
            /*this.textBoxNomProduit.Text = produit.product_name;
            this.richTextBoxDescription.Text = produit.description;*/
            
        }

        private async void bt_modifierProduit_Click(object sender, EventArgs e)
        {
            //update product
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

                Product result = await productApi.UpdateProduct(produit.id, name, desc, selectedCategoryIds);
                bool resu = await productApi.UploadImage(result.id, image);
                if (result != null && resu)
                {
                    MessageBox.Show("Product updated successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update product");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
