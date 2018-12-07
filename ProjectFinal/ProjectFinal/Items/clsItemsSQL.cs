using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Items
{
    /// <summary>
    /// A class which contains SQL code in static methods for the Items window
    /// </summary>
    class clsItemsSQL
    {
        /*******************************
         * Public Static Variables
        *******************************/

        /// <summary>
        /// Create an object of type clsDataAccess to access the database
        /// </summary>
        private static clsDataAccess db = new clsDataAccess();

        /*******************************
         * Public Static Methods
        *******************************/

        /// <summary>
        /// itemList()
        /// 
        /// A query that returns a DataSet which contains the entire ItemDesc table
        /// Orders and names output columns as Code, Cost, Description
        /// </summary>
        /// <returns>Returns a DataSet which contains the entire ItemDesc table</returns>
        public static DataSet itemList()
        {
            int rowsReturned = 0;

            try
            {
                DataSet ds = new DataSet();

                ds = db.ExecuteSQLStatement("SELECT ItemCode AS Code, Cost, ItemDesc AS Description " +
                                            "FROM ItemDesc",
                                            ref rowsReturned);

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }


        /// <summary>
        /// addItem()
        /// 
        /// A SQL statement that takes the string cost and description of an item
        /// and creates a new entry in the database with those values.
        /// </summary>
        /// <param name="cost">The cost of the item.</param>
        /// <param name="description">The description of the item.</param>
        /// <returns>An integer that indicates how many lines were added to the database. A value different than 1 indicates an error</returns>
        public static int addItem(string cost, string description)
        {
            // Note: These values will be validated in the calling method inside clsItemLogic.
            try
            {
                return db.ExecuteNonQuery("INSERT INTO ItemDesc (Cost, ItemDesc) " +
                                          "VALUES (" + cost + ", " + description + ")");
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// updateItem()
        /// 
        /// A SQL statement that takes the primary key "code" for an item in the ItemDesc database
        /// and updates the cost and description for the item.
        /// </summary>
        /// <param name="code">The code of the item to be changed. This value is not updated.</param>
        /// <param name="cost">The new cost of the item. May be identical to the original</param>
        /// <param name="description">The new description of the item. May be identical to the original</param>
        /// <returns>Returns an integer that indicates how many lines were changed in the database. A value different than 1 indicates an error, or a code that does not exist in the database</returns>
        public static int updateItem(string code, string cost, string description)
        {
            // Note: These values will be validated in the calling method inside clsItemLogic.
            try
            {
                return db.ExecuteNonQuery("UPDATE ItemDesc" +
                                          "SET Cost = " + cost +
                                          ", ItemDesc = " + description +
                                          "WHERE code = " + code);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// checkForInvoices()
        /// 
        /// A query that searches for any invoices that contain a given item.
        /// </summary>
        /// <param name="invoiceList">A reference to a DataSet which is filled with all returned invoices</param>
        /// <param name="iRetVal">A reference to an integer that is updated to indicate the number of returned lines. A value greater than 0 indicates the presence of invoices in the invoiceList</param>
        /// <param name="itemToCheck">The item to be checked against all invoices</param>
        public static void checkForInvoices(ref DataSet invoiceList, ref int iRetVal, Item itemToCheck)
        {
            try
            {
                invoiceList = db.ExecuteSQLStatement("SELECT DISTINCT InvoiceNum " +
                                                     "FROM LineItems " +
                                                     "WHERE ItemCode = " + itemToCheck.Code,
                                                     ref iRetVal);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// deleteItem()
        /// 
        /// A SQL statement that deletes a given item from the ItemDesc database
        /// </summary>
        /// <param name="deleteThis">The item to be deleted</param>
        /// <returns>An integer indicating how many lines were updated. A value other than 1 indicated an error, or that the Item.Code was invalid</returns>
        public static int deleteItem(Item deleteThis)
        {
            try
            {
                return db.ExecuteNonQuery("DELETE * " +
                                          "FROM ItemDesc " +
                                          "WHERE ItemCode = " + deleteThis.Code);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

    }
}
