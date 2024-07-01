using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }

    public class Individual: Participant
    {
        public string University { get; set; }
        public int YearOfGraduation { get; set; }
        public bool IsIntern { get; set; }
    }
    
    public class Coprate: Participant
    {
        public string Company { get; set; }
        public string JobTitle { get; set; }
    }
}
