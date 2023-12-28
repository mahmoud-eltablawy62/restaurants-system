using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem.core.Entities
{
    public class Staff
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Position { get; set; }
        public decimal Salary { get; set; }    

        public int ResturantId { get; set; }    
        public Resturant Resturant { get; set; }    


    }
}
