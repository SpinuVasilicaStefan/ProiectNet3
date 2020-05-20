using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoRazor.Models
{
    public class ProprietateDTO
    {
        public ProprietateDTO()
        {
            this.Dynamic = new HashSet<DynamicDTO>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DynamicDTO> Dynamic { get; set; }
    }
}
