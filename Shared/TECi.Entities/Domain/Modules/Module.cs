using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECi.Entities.Domain.Modules
{

    /// <summary>
    /// Represents a module
    /// </summary>
    public partial class Module
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Category_Name column.
        /// </summary>
        
        public string Module_Name { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Category_Desc column.
        /// </summary>
        
        public string Module_Desc { get; set; }

        /// <summary>
        /// Gets or sets a string value for the IdNumber column.
        /// </summary>
        
        public string IdNumber { get; set; }

        /// <summary>
        /// Gets or sets a int value for the parent column.
        /// </summary>
        
        public int parent { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the enabled column.
        /// </summary>
        
        public bool enabled { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the created_date column.
        /// </summary>
        
        public DateTime? created_date { get; set; }

        /// <summary>
        /// Gets or sets a string value for the created_by column.
        /// </summary>
        
        public string created_by { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the modified_date column.
        /// </summary>
        
        public DateTime? modified_date { get; set; }

        /// <summary>
        /// Gets or sets a string value for the modified_by column.
        /// </summary>
        
        public string modified_by { get; set; }
    }
}
