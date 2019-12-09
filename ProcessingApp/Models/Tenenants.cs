using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessingApp.Models
{
    public class Tenenants
    {
        [key]

        public virtual int TenenatsId { get; set; }

        public virtual String TenantReviews { get; set; }

        public virtual String Ambiance { get; set; }


    }
}
