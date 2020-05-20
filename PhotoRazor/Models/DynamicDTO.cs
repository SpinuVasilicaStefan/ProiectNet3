using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoRazor.Models
{
    public class DynamicDTO
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public int PhotoId { get; set; }
        public int PropertiesId { get; set; }

        public virtual PhotoDTO Photo { get; set; }
        public virtual ProprietateDTO Properties { get; set; }
    }
}
