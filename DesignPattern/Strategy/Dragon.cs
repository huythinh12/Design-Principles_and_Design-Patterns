using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class Dragon : Character,IMovementStrategy
    {
      
        public string Move()
        {
            return "Movement type: Flying";
        }
    }
}
