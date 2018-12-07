using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;       //Used for ObservableCollection<>
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Items
{
    /// <summary>
    /// A class containing static methods used with the wndItems.xaml.cs
    /// </summary>
    class clsItemsLogic
    {

        /// <summary>
        /// getItemList()
        /// 
        /// A method that takes an ObservableCollection<Item> and fills it with information from the database.
        /// Calls static method clsItemsSQL.itemList()
        /// </summary>
        public static ObservableCollection<Item> getItemList()
        {
            // Create the Observable Collection to return
            ObservableCollection<Item> itemList = new ObservableCollection<Item>();

            // Create a DataSet to collect the information

            // Get DataSet from the items table using clsItemsSQL.itemList()
                // Be prepared to Catch and Raise an Exception!

            // Loop through the values returned
                // Create a new Item with the row information
                // Add it to itemList

            // Return the Observable Collection
            return itemList;

            
        }

        /// <summary>
        /// addItem()
        /// 
        /// Validates the input of string cost and string description
        /// If the validation is passed, calls clsItemsSQL.addItem() using
        /// the validated data.
        /// </summary>
        /// <param name="cost">A string containing the cost of the item. Should be of format $x.## where x is one or more digits and # is a single digit.</param>
        /// <param name="description">A string containing the description of the item. Should only contain letters, whitespace, and '/' or '-' characters.</param>
        public static void addItem(string cost, string description)
        {
            // Validate input of cost - Compare to regex ^\${1}(\d+\.{1}\d{2}){1}$ (System.Text.RegularExpressions) $x.## x = one or more digits
                // Throw new FormatException if invalid

            // Validate input of description - Compare to regex ^[A-Za-z\/\s\-]+$ (System.Text.RegularExpressions) One or more letters, whitespace, '/', or '-' characters.
                // Throw new FormatException if invalid

            // Run clsItemsSQL.addItem() with the validated cost and description strings
                // Catch and Raise Exception if addItem() throws one.
        }

        /// <summary>
        /// updateItem()
        /// 
        /// Validates the input of string cost and string description
        /// If the validation is passed, calls clsItemsSQL.updateItem() using
        /// the validated data and the passed in Item.
        /// </summary>
        /// <param name="cost">A string containing the cost of the item. Should be of format $x.## where x is one or more digits and # is a single digit.</param>
        /// <param name="description">A string containing the description of the item. Should only contain letters, whitespace, and '/' or '-' characters.</param>
        /// <param name="originalItem">The item whose cost and/or description are to be updated</param>
        public static void updateItem(string cost, string description, Item originalItem)
        {
            // Validate input of cost - Compare to regex ^\${1}(\d+\.{1}\d{2}){1}$ (System.Text.RegularExpressions) $x.## x = one or more digits
            // Throw new FormatException if invalid

            // Validate input of description - Compare to regex ^[A-Za-z\/\s\-]+$ (System.Text.RegularExpressions) One or more letters, whitespace, '/', or '-' characters.
            // Throw new FormatException if invalid

            // Run clsItemsSQL.updateItem() using the validated cost and description strings and the code from originalItem.

            // Inform any open windows displaying invoice data that an update has occurred.
				// This will be done by updating a boolean value indicating that a change has been made
				// Then passing a list of invoice numbers affected by the change.
        }

        /// <summary>
        /// deleteItem()
        /// 
        /// Takes an Item argument and deletes the corresponding item from the database
        /// </summary>
        /// <param name="originalItem">The item to be deleted</param>
        public static void deleteItem(Item originalItem)
        {
            
            // If numberOfExistingInvoices is greater than 0, then invoices exist which contain this item.
                // Using invoiceList generate a System.Windows.MessageBox which lists the invoices containing the selected item.

            // If numberOfExistingInvoices is 0, then no invoices contain this item.
                // Run clsItemsSQL.deleteItem()
        }
        
        /// <summary>
        /// checkForInvoices()
        /// 
        /// Takes an item, compares it to the database and adds the invoice number of any invoices
        /// that contain the item to the referenced invoiceList.
        /// </summary>
        /// <param name="invoiceList">A list of invoice numbers. Invoices that contain the included item will be added to this list.</param>
        /// <param name="itemToCheck">The item to compare to the database.</param>
        public static void checkForInvoices(ref List<string> invoiceList, Item itemToCheck)
        {
            /// <summary>
            /// Used with checkForInvoices()
            /// This will hold the number of invoices returned from the query
            /// </summary>
            int numberOfExistingInvoices = 0;

            /// <summary>
            /// Used with chekcForInvoices()
            /// This will hold any 
            /// </summary>
            DataSet invoiceInformation = new DataSet();

            // call clsItemsSQL.checkForInvoices() to populate numberOfExistingInvoices and invoiceInformation.

            // Check numberOfExistingInvoices
                // If greater than 0
                // Iterate through invoiceInformation and add the invoice numbers as strings to invoiceList;
        }
    }
}
