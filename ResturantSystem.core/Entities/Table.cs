using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem.core.Entities
{
    public class Table
    {
        public int Id { get; set; } 
        public int Number { get; set; }       
        public int Capacity { get; set; }   
        public bool IsOccupied { get; set; }
        public int ResturantId { get; set; }        
        public Resturant Resturant { get; set; }    
    }
}
