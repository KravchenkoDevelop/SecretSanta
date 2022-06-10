using System;
using System.Collections.Generic;

namespace DM.Models
{
    public class Tenant
    {
        /// <summary>
        ///  tenant ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///  tenant name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  tenant account creation date
        /// </summary>
        public DateTime CreationDate { get; set; } = DateTime.Now;

        /// <summary>
        ///  tenant binding with users  
        /// </summary>
        public virtual ICollection<Person> Users { get; set; }
    }
}