using System.Xml.Linq;

namespace GroceryStoreApp

{
    public partial class Form1 : Form
    {
        private GroceryStore groceryStore;

        public Form1()
        {
            InitializeComponent();
            groceryStore = new GroceryStore();
        }





        private void UpdateInventoryDisplay()
        {
            // Clear the list box
            lstInventory.Items.Clear();

            // Display the inventory in the list box
            foreach (var item in groceryStore.Inventory.Items)
            {
                lstInventory.Items.Add(item);
            }
        }

        public class InventoryItem
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public string Category { get; set; }

            public override string ToString()
            {
                return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Category: {Category}";
            }
        }


        public class Inventory
        {
            private List<InventoryItem> items;

            public Inventory()
            {
                items = new List<InventoryItem>();
            }

            public List<InventoryItem> Items => items;

            public void AddItem(InventoryItem item)
            {
                items.Add(item);
            }

            public void RemoveItem(InventoryItem item)
            {
                items.Remove(item);
            }
        }

        // Class representing the grocery store
        public class GroceryStore
        {
            public Inventory Inventory { get; }

            public GroceryStore()
            {
                Inventory = new Inventory();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Retrieve item details from text boxes
            string name = txtName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            string category = txtCategory.Text;

            // Create a new inventory item
            InventoryItem newItem = new InventoryItem
            {
                Name = name,
                Price = price,
                Quantity = quantity,
                Category = category
            };

            // Add the item to the inventory
            groceryStore.Inventory.AddItem(newItem);

            // Update the inventory display
            UpdateInventoryDisplay();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            
            
                // Remove the selected item from the inventory
                if (lstInventory.SelectedIndex != -1)
                {
                    InventoryItem selectedItem = (InventoryItem)lstInventory.SelectedItem;
                    groceryStore.Inventory.RemoveItem(selectedItem);

                    // Update the inventory display
                    UpdateInventoryDisplay();
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        
        
    }
}
