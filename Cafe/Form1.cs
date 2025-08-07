//using Cafe.context;
//using Cafe.models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Cafe
{
    public partial class Form1 : Form
    {
        CafeContext dbContext = new CafeContext();
        BindingSource bindingSource = new BindingSource();
        private void LoadCurrentTabData()
        {
            // Clear current binding
            bindingSource.Clear();

            // Determine which tab is selected
            switch (tabControlCafe.SelectedTab.Name)
            {
                case "tabDrinks":
                    bindingSource.DataSource = dbContext.Drinks.ToList();
                    break;
                case "tabDesserts":
                    bindingSource.DataSource = dbContext.Desserts.ToList();
                    break;
                case "tabFoods":
                    bindingSource.DataSource = dbContext.Foods.ToList();
                    break;
                default:
                    bindingSource.DataSource = null;
                    break;
            }

            // Bind grid to data source
            dgvItems.DataSource = bindingSource;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCurrentTabData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string Prompt(string text)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = text,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label label = new Label() { Left = 20, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 240 };
            Button confirmation = new Button() { Text = "OK", Left = 200, Top = 80, DialogResult = DialogResult.OK };

            prompt.Controls.Add(label);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = Prompt("Enter item name:");
            if (string.IsNullOrWhiteSpace(itemName)) return;

            if (!decimal.TryParse(Prompt("Enter price:"), out decimal itemPrice))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            switch (tabControlCafe.SelectedTab.Name)
            {
                case "tabDrinks":
                    dbContext.Drinks.Add(new Drink { Name = itemName, Price = itemPrice });
                    break;
                case "tabDesserts":
                    dbContext.Desserts.Add(new Dessert { Name = itemName, Price = itemPrice });
                    break;
                case "tabFoods":
                    dbContext.Foods.Add(new Food { Name = itemName, Price = itemPrice });
                    break;
            }

            dbContext.SaveChanges();
            LoadCurrentTabData();
        }

        private void tabControlCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCurrentTabData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var selectedItem = bindingSource.Current;

            if (selectedItem == null)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                switch (selectedItem)
                {
                    case Drink drink:
                        dbContext.Drinks.Remove(drink);
                        break;
                    case Dessert dessert:
                        dbContext.Desserts.Remove(dessert);
                        break;
                    case Food food:
                        dbContext.Foods.Remove(food);
                        break;
                }

                dbContext.SaveChanges();
                LoadCurrentTabData();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
        }
        public static string Prompt2(string text, string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = text,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label label = new Label() { Left = 20, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 240, Text = defaultValue };
            Button confirmation = new Button() { Text = "OK", Left = 200, Top = 80, DialogResult = DialogResult.OK };

            prompt.Controls.Add(label);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            var selectedItem = bindingSource.Current;

            if (selectedItem == null)
            {
                MessageBox.Show("Please select an item to edit.");
                return;
            }

            string currentName = "";
            decimal currentPrice = 0m;

            // Get current values
            switch (selectedItem)
            {
                case Drink drink:
                    currentName = drink.Name;
                    currentPrice = drink.Price;
                    break;
                case Dessert dessert:
                    currentName = dessert.Name;
                    currentPrice = dessert.Price;
                    break;
                case Food food:
                    currentName = food.Name;
                    currentPrice = food.Price;
                    break;
            }

            // Prompt user for new name
            string newName = Prompt2("Edit Item Name", currentName);
            if (string.IsNullOrWhiteSpace(newName))
                return;

            // Prompt user for new price
            string priceInput = Prompt2("Edit Item Price", currentPrice.ToString());
            if (!decimal.TryParse(priceInput, out decimal newPrice))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            // Update values
            switch (selectedItem)
            {
                case Drink drink:
                    drink.Name = newName;
                    drink.Price = newPrice;
                    break;
                case Dessert dessert:
                    dessert.Name = newName;
                    dessert.Price = newPrice;
                    break;
                case Food food:
                    food.Name = newName;
                    food.Price = newPrice;
                    break;
            }

            dbContext.SaveChanges(); 
            LoadCurrentTabData();   
        
    }
    }
}
