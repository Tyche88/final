using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectFinal.Items
{
    /// <summary>
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        /// <summary>
        /// An observable collection of Items pulled from the database.
        /// </summary>
        private ObservableCollection<Item> itemList = new ObservableCollection<Item>(); 

        /// <summary>
        /// Default Constructor
        /// </summary>
        public wndItems()
        {
            InitializeComponent();

            // Attach the collection to the datagrid "listItemDisplay"
            listItemDisplay.ItemsSource = itemList;
        }

        /// <summary>
        /// OnLoaded()
        /// 
        /// Called with the wndItems Loaded event
        /// </summary>
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            // Call clsItemsLogic.getItemList() to populate itemList when the window loads.
            itemList = clsItemsLogic.getItemList();
        }
        
        /// <summary>
        /// DataGrid_SelectionChanged()
        /// 
        /// Called when the user clicks on a new item in the item list.
        /// Populates the text fields in the edit item group box with the data
        /// from the newly selected item.
        /// Enables the user to edit the text in the fields in the edit item group box.
        /// Enables the edit item button.
        /// Enables the delete item button.
        /// </summary>
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO
            // Update the text fields in the edit item area
            // Allow tab stop for edit item text fields if still disabled
            // Disable isReadOnly for edit item text fields if still enabled
            // Enable Edit Item button
            // Enable Delete Item button
        }

        /// <summary>
        /// ButtonAddItem_Click()
        /// 
        /// Called when the user clicks on the Add New Item button.
        /// Pulls text from the text fields in the Add Item Group box and passes them into clsItemsLogic.addItem()
        /// </summary>
        private void ButtonAddItem_Click(object sender, RoutedEventArgs e)
        {
            // TODO
            // Pass text from area cost and description textboxes to clsItemsLogic.addItem() static method
                // Be prepared to catch a FormatException and display a System.Windows.MessageBox to inform the user of the issue!
                // Be prepared to catch an Exception and display a System.Windows.MessageBox to inform the user of the issue!

            // Call clsItemsLogic.getItemList() to update itemList
        }

        /// <summary>
        /// ButtonEditItem_Click()
        /// 
        /// Called when the user clicks on the Edit Existing Item Button
        /// Confirms that the user wants to edit the existing item, then
        /// pulls the data from the text boxes in the Edit Item Group box and 
        /// the currently selected item from the datagrid then
        /// passes them to clsItemsLogic.updateItem()
        /// </summary>
        private void ButtonEditItem_Click(object sender, RoutedEventArgs e)
        {
            // TODO
            // Display System.Windows.MessageBox to confirm the user wants to process the update
            // On confirmation
            // Collect the item that has been selected from the datagrid
            // Pass text from area cost and description textboxes, and the item selected in the list to clsItemsLogic.updateItem() static method
                // Be prepared to catch a FormatException and display a System.Windows.MessageBox to inform the user of the issue!
                // Be prepared to catch an Exception and display a System.Windows.MessageBox to inform the user of the issue!

            // Update item list datagrid display with new information
        }

        /// <summary>
        /// ButtonDeleteItem_Click()
        /// 
        /// Called when the user clicks on the Delete Item Button
        /// Confirms that the user wants to delete the selected item
        /// Calls clsItemsLogic.checkForInvoices() to check for existing invoices, and
        /// displays a messagebox if invoices exist.
        /// If no invoices exist, calls clsItemsLogic.deleteItem() passing in the selected item.
        /// </summary>
        private void ButtonDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// listOfInvoices
            /// 
            /// Used to display what invoices a given item is associated with
            /// </summary>
            List<string> listOfInvoices = new List<string>();

            // TODO
            // Display System.Windows.MessageBox to confirm the deletion
                // On confirmation
                // Pass listOfInvoices and the selected item to clsItemsLogic.checkForInvoices()
                    // If listOfInvoices.count is greater than 0
                        // Display a message box informing the user that invoices exist with that item.
                        // Use listOfInvoices to display which invoices are involved.
                    // If listOfinvoices.count is 0
                        // Pass item selected in the list to clsItemsLogic.deleteItem()
                        // Be prepared to catch an Exception and display a System.Windows.MessageBox to inform the user of the issue!
        }

        /// <summary>
        /// ButtonExit_Click()
        /// 
        /// Called when the user clicks on the return button.
        /// Closes the item window
        /// </summary>
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            // this.Hide();
            // Change to Hide() if the main window is set up to close this window when it's on closing event is fired.
        }
    }
}
