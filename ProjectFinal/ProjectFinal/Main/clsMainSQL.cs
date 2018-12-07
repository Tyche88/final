using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Data.OleDb;

namespace Main
{
    public class clsMainSQL
    {
        #region Variables
        /// <summary>
        /// Invoice sql statement
        /// </summary>
        string sInvoiceSQL;
        /// <summary>
        /// ItemDesc sql statement
        /// </summary>
        string sItemDescSQL;
        /// <summary>
        /// LineItem sql statement
        /// </summary>
        string sLineItemSQL;


        /// <summary>
        /// Holds sql statement to delete item in the Invoice table
        /// </summary>
        string sDeleteInvoiceSQL;
        /// <summary>
        /// Holds sql statement to delete item in the LineItem table
        /// </summary>
        string sDeleteLineItemSQL;




        #endregion

        //Class will be nothing but methods that contain different statements of SQL. 
        //SQL statements needed will be to select different types of data on each window.
        //update/insert/delete data on each form. 

        #region Constructor
        /// <summary>
        /// Contructor
        /// </summary>
        public clsMainSQL()
        {






            
        }
        #endregion



        #region LoadInvoiceData()
        /// <summary>
        /// Returns sql statement to get Invoice
        /// </summary>
        /// <returns></returns>
        public string LoadInvoiceData()
        {
            sInvoiceSQL = "SELECT * FROM Invoices";
            return sInvoiceSQL; 
        }
        #endregion



        #region LoadLineItems()
        /// <summary>
        /// Returns sql statment to get all LineItems
        /// </summary>
        /// <returns></returns>
        public string LoadLineItems(int n)
        {
            sLineItemSQL = "SELECT * FROM LineItems WHERE InvoiceNum = " + n;
            return sLineItemSQL;
        }
        #endregion



        #region LoadItemDescData()
        /// <summary>
        /// Returns sql statement to get all ItemDesc
        /// </summary>
        /// <returns></returns>
        public string LoadItemDescData(string s)
        {
            

            sItemDescSQL = "SELECT * FROM ItemDesc WHERE ItemCode = " + "'" + s + "'";
            return sItemDescSQL;
        }
        #endregion



        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string DeleteInvoiceSQL(int n)
        {
            sDeleteInvoiceSQL = "DELETE FROM Invoices WHERE InvoiceNum = " + n;
            return sDeleteInvoiceSQL;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string DeleteLineItemsSQL(int n)
        {
            sDeleteLineItemSQL = "DELETE FROM LineItems WHERE InvoiceNum = " + n;
            return sDeleteLineItemSQL;
        }
        //update SQL

        //create SQL







        #region Example
        /*//////////////////EXAMPLE////////////////////
        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID.
        /// </summary>
        /// <param name="sInvoiceID">The InvoiceID for the invoice to retrieve all data.</param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceData(string sInvoiceId)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceId;

            return sSQL;
        }
        */
        #endregion
    }
}
