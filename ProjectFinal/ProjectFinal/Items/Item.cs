using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Items
{
    /// <summary>
    /// A class used to store and transfer items between logic functions
    /// </summary>
    class Item
    {
        /*******************************
         * Private Variables
        *******************************/

        /// <summary>
        /// The code for the item.
        /// This is the primary key for the item in the database.
        /// </summary>
        private readonly string code;

        /// <summary>
        /// The cost for the item.
        /// </summary>
        private string cost;

        /// <summary>
        /// The description of the item.
        /// </summary>
        private string description;

        /*******************************
         * Constructor
        *******************************/

        /// <summary>
        /// Public constructor
        /// 
        /// Builds an item object from existing data
        /// </summary>
        /// <param name="code">The code for the item</param>
        /// <param name="cost">The cost for the item</param>
        /// <param name="description">The description of the item</param>
        public Item(string code, string cost, string description)
        {
            this.code = code;
            this.cost = cost;
            this.description = description;
        }


        /*******************************
         * Properties
        *******************************/

        /// <summary>
        /// Property: Code
        /// 
        /// Get function only
        /// returns the primary key value 
        /// </summary>
        public string Code
        {
            get
            {
                return this.code;
            }
        }

        /// <summary>
        /// Property: Cost
        /// 
        /// Get and Set functions
        /// Returns the cost of the item
        /// or
        /// Sets the cost of the item
        /// </summary>
        public string Cost
        {
            get
            {
                return this.cost;
            }

            set
            {
                this.cost = value;
            }
        }

        /// <summary>
        /// Property: Description
        /// 
        /// Get and Set function
        /// Returns the description for the item
        /// or
        /// Sets the description for the item
        /// </summary>
        public string Description
        {
            get
            {
                return this.description;
            }
            
            set
            {
                this.description = value;
            }
        }


    }
}
