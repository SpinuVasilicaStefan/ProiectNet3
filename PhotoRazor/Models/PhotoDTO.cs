using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoRazor.Models
{
    public class PhotoDTO
    {
        public PhotoDTO()
        {
            this.Dynamic = new HashSet<DynamicDTO>();
            this.Person = new HashSet<PersonDTO>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Location { get; set; }
        public string Event { get; set; }
        public string Scenery { get; set; }
        public string Status { get; set; }
        public virtual ICollection<DynamicDTO> Dynamic { get; set; }
        public virtual ICollection<PersonDTO> Person { get; set; }
    }
}
