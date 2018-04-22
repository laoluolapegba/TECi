//====================================================================================================
// Base code generated with Inertia: BE Gen (Build 3.0.5701.25371)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Laolu at BLUECHIP-PC on 06/10/2017 20:21:07 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace TECi.Entities
{
    /// <summary>
    /// Represents a row of course data.
    /// </summary>
    [DataContract]
    public partial class Courseold
    {
        /// <summary>
        /// Gets or sets a int value for the id column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the categoryid column.
        /// </summary>
        [DataMember]
        public int? categoryid { get; set; }

        /// <summary>
        /// Gets or sets a string value for the idnumber column.
        /// </summary>
        [DataMember]
        public string idnumber { get; set; }

        /// <summary>
        /// Gets or sets a string value for the course_name column.
        /// </summary>
        [DataMember]
        public string course_name { get; set; }

        /// <summary>
        /// Gets or sets a string value for the course_description column.
        /// </summary>
        [DataMember]
        public string course_description { get; set; }

        /// <summary>
        /// Gets or sets a string value for the course_summary column.
        /// </summary>
        [DataMember]
        public string course_summary { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the start_date column.
        /// </summary>
        [DataMember]
        public DateTime start_date { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the end_date column.
        /// </summary>
        [DataMember]
        public DateTime end_date { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the enabled column.
        /// </summary>
        [DataMember]
        public bool enabled { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the created_date column.
        /// </summary>
        [DataMember]
        public DateTime? created_date { get; set; }

        /// <summary>
        /// Gets or sets a string value for the created_by column.
        /// </summary>
        [DataMember]
        public string created_by { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the modified_date column.
        /// </summary>
        [DataMember]
        public DateTime? modified_date { get; set; }

        /// <summary>
        /// Gets or sets a string value for the modified_by column.
        /// </summary>
        [DataMember]
        public string modified_by { get; set; }

        /// <summary>
        /// Gets or sets a int value for the completion_tracking column.
        /// </summary>
        [DataMember]
        public int completion_tracking { get; set; }

        /// <summary>
        /// Gets or sets a int value for the completion_notify column.
        /// </summary>
        [DataMember]
        public int completion_notify { get; set; }
    }
}