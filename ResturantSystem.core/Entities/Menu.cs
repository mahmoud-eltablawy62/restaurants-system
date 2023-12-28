using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem.core.Entities
{
    public class Menu
    {
        public int Id { get; set; } 

        public int ResId { get; set; }
        public Resturant Res { get; set; }  
    }
}
