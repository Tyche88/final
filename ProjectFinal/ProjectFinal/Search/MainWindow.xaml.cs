using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wndSearch {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        #region Attributes

        /// <summary>
        /// Allows other windows to know which invoice was selected by the user.
        /// </summary>
        public string sInvoiceNum;
        
        /// <summary>
        /// Gives public access to the clsDataAccess class.
        /// </summary>
        private clsDataAccess db = new clsDataAccess();

        /// <summary>
        /// Gives public access to the clsSearchSQL class.
        /// </summary>
        private clsSearchSQL sql = new clsSearchSQL();

        /// <summary>
        /// Gives public access to the clsSearchLogic class.
        /// </summary>
        private clsSearchLogic searchLogic = new clsSearchLogic();

        /// <summary>
        /// Used for datagrid.
        /// </summary>
        private DataTable dt;

        /// <summary>
        /// Used to hold the data.
        /// </summary>
        private DataSet ds;

        #endregion



        #region Methods

        public MainWindow() {
            InitializeComponent();

            populateDategrid();
        }

        /// <summary>
        /// Selects highlighted invoice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSelect_Click(object sender, RoutedEventArgs e) {
            try {
                // Sets the selected invoice number to the public variable sInvoiceNum.
                    // This allows other windows to access which invoice was selected.

                // Closes the search window.
                this.Close();

                // Return to the main window.

            }
            catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Cancels the search.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, RoutedEventArgs e) {
            try {
                // Closes the search window.
                this.Close();

                // Return to the main window.

            }
            catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Filters data based on invoice ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmboxInvoiceID_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            try {
                // Filters datagrid based off the invoice id selected.

                // Filters the other combo boxes based off the invoice id selected.
                    // Might be better to lock the other two combo boxes. I will keep this in mind.
            }
            catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Filters data based on amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmboxInvoicePrice_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            try {
                // Filters datagrid based off the invoice price selected.

                // Filters the other combo boxes based off the invoice price selected.
                    // Might be better to lock the other two combo boxes. I will keep this in mind.
            }
            catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Filters data based on date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmboxInvoiceDate_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            try {
                // Filters datagrid based off the invoice date selected.

                // Filters the other comboboxes based off the invoice date selected.
                    // Might be better to lock the other two combo boxes. I will keep this in mind.
            }
            catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Populates the datagrid.
        /// </summary>
        private void populateDategrid() {
            try {
                // Get query needed to find invoice.

                // Fill the dt up with the specified data.

                // Fill the datagrid.

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

        #endregion
    }
}
