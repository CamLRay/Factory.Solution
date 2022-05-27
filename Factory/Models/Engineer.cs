using System.Collections.Generic;
using System;

namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.JoinEntities = new HashSet<MachineEngineer>();
        }

        public int EngineerId { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        

        public virtual ICollection<MachineEngineer> JoinEntities { get;}
    }
}