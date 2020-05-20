using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoRazor.Models
{
    public class PersonDTO
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhotoId { get; set; }
        public virtual PhotoDTO Photo { get; set; }
    }
}
