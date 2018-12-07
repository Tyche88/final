using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace wndSearch {
    class clsSearchSQL {
        private string sSQL;

        /// <summary>
        /// Used to populate the datagrid with all invoices.
        /// </summary>
        /// <returns>A string containing the query to return all invoices.</returns>
        public string getAllInvoices() {
            try {
                sSQL = "SELECT * FROM Invoices ORDER BY InvoiceNum";

                return sSQL;
            }
            catch (Exception ex) {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Used to populate the Invoice ID combo box.
        /// </summary>
        /// <returns>A string containing the query to return all invoiceNum.</returns>
        public string getInvoiceIDList() {
            try {
                sSQL = "SELECT InvoiceNum FROM Invoices ORDER BY InvoiceNum";

                return sSQL;
            }
            catch (Exception ex) {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Used to populate the Invoice Price combo box.
        /// </summary>
        /// <returns>A string containing the query to return all invoice costs.</returns>
        public string getInvoicePriceList() {
            try {
                sSQL = "SELECT TotalCost FROM Invoices ORDER BY TotalCost";

                return sSQL;
            }
            catch (Exception ex) {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Used to populate the Invoice Date combo box.
        /// </summary>
        /// <returns>A string containing the query to return all invoice dates.</returns>
        public string getInvoiceDateList() {
            try {
                sSQL = "SELECT InvoiceDate FROM Invoices ORDER BY InvoiceDate";

                return sSQL;
            }
            catch (Exception ex) {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Filters datagrid based off the InvoiceID.
        /// </summary>
        /// <param name="invoiceID">InvoiceID to retrieve all data</param>
        /// <returns>A string containing the query to return all invoices filtered by selected Invoice ID.</returns>
        public string filterDataByInvoiceID(int invoiceID) {
            try {
                sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + invoiceID + " ORDER BY InvoiceNum";

                return sSQL;
            }
            catch (Exception ex) {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        
        /// <summary>
        /// Filters datagrid based off the InvoicePrice.
        /// </summary>
        /// <param name="invoicePrice">InvoicePrice to retrieve all data</param>
        /// <returns>A string containing the query to return all invoices filtered by selected invoice price.</returns>
        public string filterDataByInvoicePrice(int invoicePrice) {
            try {
                sSQL = "SELECT * FROM Invoices WHERE TotalCost = " + invoicePrice + " ORDER BY InvoiceNum";

                return sSQL;
            }
            catch (Exception ex) {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Filters datagrid based off the InvoiceDate.
        /// </summary>
        /// <param name="invoicedate">Invoicedate to retrieve all data</param>
        /// <returns>A string containing the query to return all invoices filtered by selected invoice date.</returns>
        public string filterDataByInvoicedate(int invoicedate) {
            try {
                sSQL = "SELECT * FROM Invoices WHERE InvoiceDate = " + invoicedate + " ORDER BY InvoiceNum";

                return sSQL;
            }
            catch (Exception ex) {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Handle the error.
        /// </summary>
        /// <param name="sClass">The class in which the error occurred in.</param>
        /// <param name="sMethod">The method in which the error occurred in.</param>
        private void HandleError(string sClass, string sMethod, string sMessage) {
            try {
                //Would write to a file or database here.
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex) {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                             "HandleError Exception: " + ex.Message);
            }
        }
    }
}
