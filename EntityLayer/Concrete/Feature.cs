using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature // favori lokasyon prop.
    {
        [Key]
        public int FeatureID { get; set; }
        public string FirstName { get; set; }
        public string FirstDescription { get; set; }
        public string FirstImage { get; set; }
        public bool Status { get; set; }
    }
}
