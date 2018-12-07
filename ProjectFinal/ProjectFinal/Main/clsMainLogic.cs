using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Main
{
    public class clsMainLogic
    {
        #region Variables
        /// <summary>
        /// Create class var named iRet, returns the number of values
        /// </summary>
        public int iRet;
        /// <summary>
        /// Create clsSQL object reference
        /// </summary>
        clsMainSQL MainSQL;
        /// <summary>
        /// Create listInvoice object reference
        /// </summary>
        public List<clsInvoice> lstInvoice;

        /// <summary>
        /// 
        /// </summary>
        public List<clsLineItems> lstLineItems;
        /// <summary>
        /// 
        /// </summary>
        public List<clsItemDesc> clsItemDescs;


        /// <summary>
        /// Create clsDataAccess object reference
        /// </summary>
        clsDataAccess db;
        /// <summary>
        /// Create DataSet object reference to hold the data
        /// </summary>
        public DataSet ds;


       






        #endregion

        #region Constructor
        /// <summary>
        /// Contructor
        /// </summary>
        public clsMainLogic()
        {
            MainSQL = new clsMainSQL();

            ds = new DataSet();

            iRet = 0; 







        }
        #endregion




        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int DeleteLineItemSQL(int n)
        {
            return db.ExecuteNonQuery(MainSQL.DeleteLineItemsSQL(n)); 
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int DeleteInvoiceSQL(int n)
        {
            
            return db.ExecuteNonQuery(MainSQL.DeleteInvoiceSQL(n));
        }






        public string CreateRow()
        {//idk
            DataRow DR = ds.Tables[0].NewRow();
           // DR[0] = Convert.ToString((ds.Tables[0].Rows.Count + 1));
            return DR.ToString();


        }





        #region List<clsInvoice> GetInvoice()
        /// <summary>
        /// List to GetInvoice() data
        /// </summary>
        /// <returns></returns>
        public List<clsInvoice> GetInvoice()
        {
            lstInvoice = new List<clsInvoice>();

            db = new clsDataAccess();

            ds = db.ExecuteSQLStatement(MainSQL.LoadInvoiceData(), ref iRet);

            for (int i = 0; i < iRet; i++)
            {

                lstInvoice.Add(new clsInvoice
                {
                    iInvoiceNum = (int)ds.Tables[0].Rows[i]["InvoiceNum"],
                    sInvoiceDate = ds.Tables[0].Rows[i]["InvoiceDate"].ToString(),
                    sTotalCost = ds.Tables[0].Rows[i]["TotalCost"].ToString()
                });
            }
            return lstInvoice;
        }
        #endregion







        #region List<clsLineItems> GetLineItems()
        /// <summary>
        /// List to get GetLineItems() data
        /// </summary>
        /// <returns></returns>
        public List<clsLineItems> GetLineItems(int n)
        {
            List<clsLineItems> lstLineItems = new List<clsLineItems>();

            db = new clsDataAccess();
    
            ds = db.ExecuteSQLStatement(MainSQL.LoadLineItems(n), ref iRet);

            for (int i = 0; i < iRet; i++)
            {

                lstLineItems.Add(new clsLineItems
                {
                    sInvoiceNum = ds.Tables[0].Rows[i]["InvoiceNum"].ToString(),
                    sLineItemNum = ds.Tables[0].Rows[i]["LineItemNum"].ToString(),
                    sItemCode = ds.Tables[0].Rows[i]["ItemCode"].ToString()
                });

                /*
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                     another way to loop   
                }
                */


            }
            return lstLineItems;
        }
        #endregion



        #region List<clsItemDesc> GetItemDesc()
        /// <summary>
        /// List to get GetItemsDesc() data
        /// </summary>
        /// <returns></returns>
        public List<clsItemDesc> GetItemDesc(string s)
        {
            List<clsItemDesc> lstInvoice = new List<clsItemDesc>();

            db = new clsDataAccess();

            ds = db.ExecuteSQLStatement(MainSQL.LoadItemDescData(s), ref iRet);

            for (int i = 0; i < iRet; i++)
            {

                lstInvoice.Add(new clsItemDesc
                {
                    sItemCode = ds.Tables[0].Rows[i]["ItemCode"].ToString(),
                    sItemDesc = ds.Tables[0].Rows[i]["ItemDesc"].ToString(),
                    sCost = ds.Tables[0].Rows[i]["Cost"].ToString()
                });
            }
            return lstInvoice;
        }
        #endregion
    }
}
