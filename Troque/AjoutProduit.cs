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
            //categoryApi.GetCategories();
            //categories = ;
            //categories = categoryApi.GetCategories();
        }

        public AjoutProduit(List<Category> categories)
        {
            InitializeComponent();
            this.categories = categories;
            foreach (Category category in categories)
            {

                this.comboBoxCategory.Items.Add(category.Category_name);
                
            }
        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            string desc = this.richTextBoxDescription.Text;
            string name = this.textBoxNomProduit.Text;
            //int selectedCategoryId = -1;
            /*if (this.comboBoxCategory.SelectedItem is Category selectedCategory)
            {
                selectedCategoryId = selectedCategory.Id;
                MessageBox.Show($"Selected Category ID: {selectedCategoryId}");

                // Use the selectedCategoryId as needed
            }*/

            List<int> selectedCategoryIds = new List<int>();

            foreach (Category category in checkedListBoxCategory.CheckedItems)
            {
                Console.WriteLine(category.Id);
                selectedCategoryIds.Add(category.Id); // Assuming Category_id is the ID property
            }

            /*if (string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(name) || selectedCategoryId == -1)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }*/
            ProductApi productApi = new ProductApi();
            Console.WriteLine(selectedCategoryIds);
            bool result = await productApi.AddProduct(name, desc, selectedCategoryIds);
            if (result)
            {
                MessageBox.Show("Product added successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add product");
            }
            Product product = new Product();
        }

        private async void loadCategories()
        {
            CategoryApi categoryApi = new CategoryApi();
            categories = await categoryApi.GetCategories();
            //this.comboBoxCategory.Items.AddRange(categories.ToArray());
            this.checkedListBoxCategory.Items.AddRange(categories.ToArray());
            /*foreach (Category category in categories)
            {
                this.comboBoxCategory.Items.Add(category.Category_name + " " +category.Category_name);
            }*/
        }
    }
}
