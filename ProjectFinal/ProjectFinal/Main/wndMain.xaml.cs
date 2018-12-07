using ProjectFinal.Items;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using wndSearch;

namespace Main
{
    /// <summary>
    /// class logic for the window for the wndMain class
    /// </summary>
    public partial class wndMain : Window
    {
        #region Variables
        /// <summary>
        /// Create MainLogic object reference so that we can use that class in this main window, wndMain class. 
        /// </summary>
        clsMainLogic MainLogic;


        /// <summary>
        /// Create list object reference to pass a list of our invoices into
        /// </summary>
        List<clsInvoice> newLstInvoice;


        /// <summary>
        /// 
        /// </summary>
        List<clsLineItems> newLstLineItems;

        /// <summary>
        /// 
        /// </summary>
        List<clsItemDesc> newLstItemDesc;


        /// <summary>
        /// 
        /// </summary>
        bool bIsDeleting;





        #endregion
        #region MainWindow() - Constructor
        /// <summary>
        /// MainWindow() - Constructor
        /// </summary>
        public wndMain()
        {
            //loads window wndMain
            InitializeComponent();

            //To close application -  to be included in all WPF applications - makes sure other windows close and the objects that have been instantiated will be cleared from memory.
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

            //instantiate MainLogic object so that we can use methods from the clsMainLogic class
            MainLogic = new clsMainLogic();

            //instantiate newLstInvoice object so that we can pass our list from MainLogic.lstInvoice into newLstInvoice
            newLstInvoice = new List<clsInvoice>();

            newLstLineItems = new List<clsLineItems>();

            newLstItemDesc = new List<clsItemDesc>();

            //get the lstInvoice from MainLogic and pass it into our new list called newLstInvoice
            newLstInvoice = MainLogic.GetInvoice();

            //bind the data from our new list onto our datagrid called dataGridView
            dataGridView1.ItemsSource = newLstInvoice;

            /*need to add button columns*/

            create_btn.IsEnabled = false;
            edit_btn.IsEnabled = false;


        }
        #endregion













        #region Delete
        /// <summary>
        /// Deletes selected item from data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridView1.SelectedIndex < newLstInvoice.Count && dataGridView1.SelectedItem != null)
            {
                //create and instanitate a new Invoice object 
                clsInvoice Invoice = new clsInvoice();

                //set the new object called Invoice to the selected item in the datagrid called dataGridView
                Invoice = (clsInvoice)dataGridView1.SelectedItem;

                bIsDeleting = true;

                //delete the Line item at the current selected item. 
                MainLogic.DeleteLineItemSQL(Invoice.iInvoiceNum);

                //delete the Invoice at the current selected item.
                MainLogic.DeleteInvoiceSQL(Invoice.iInvoiceNum);


                //set the new list called newLstInvoice to get the lstInvoice that will return the data in the dataset. 
                newLstInvoice = MainLogic.GetInvoice();

                //bind the data from our new list into the datagrid called dataGridView
                dataGridView1.ItemsSource = newLstInvoice;

                bIsDeleting = false;

                //commits changes to database.
                MainLogic.ds.AcceptChanges();

                //refresh items in the datagrid called dataGridView
                dataGridView1.Items.Refresh();
            }
        }
        #endregion

        private void dataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            newLstLineItems.Clear();
            dataGridView2.Items.Refresh();
            //checks to make sure that we cannot select a row without invoice data. 
            if (dataGridView1.SelectedIndex < newLstInvoice.Count && bIsDeleting == false)
            {

                clsInvoice Invoice = new clsInvoice();
                Invoice = (clsInvoice)dataGridView1.SelectedItem;

                newLstLineItems = MainLogic.GetLineItems(Invoice.iInvoiceNum);
                dataGridView2.ItemsSource = newLstLineItems;


                dataGridView2.Columns[1].Visibility = System.Windows.Visibility.Hidden;

            }

        }





        private void DataGridView2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            newLstItemDesc.Clear();
            dataGridView3.Items.Refresh();
            if (dataGridView2.SelectedIndex < newLstLineItems.Count && bIsDeleting == false)
            {
                clsLineItems LineItems = new clsLineItems();
                LineItems = (clsLineItems)dataGridView2.SelectedItem;

                for (int i = 0; i < newLstLineItems.Count; i++)
                {

                    newLstItemDesc = MainLogic.GetItemDesc(LineItems.sItemCode);


                }

                dataGridView3.ItemsSource = newLstItemDesc;
            }

        }



        #region Search - MenuItem_Click()
        /// <summary>
        /// Menu -> File -> Search - Opens "search" window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //open "search" window. 

            //MessageBox.Show("Opens SEARCH window");

            MainWindow searchWindow = new MainWindow();
            searchWindow.ShowDialog();
        }
        #endregion
        #region Item - MenuItem_Click()
        /// <summary>
        /// Menu -> Edit -> Item - Opens "items" window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //open "items" window. 

            //MessageBox.Show("Opens ITEMS window");

            wndItems items = new wndItems();
            items.ShowDialog();
        }

        #endregion

        private void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MainLogic.CreateRow());
            dataGridView1.Items.Refresh();
        }
    }
}
