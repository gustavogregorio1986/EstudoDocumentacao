using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Estudo16.Entidade
{
    public class Car : IEquatable<Car>
    {
        public string? Make { get; set; }

        public string? Model { get; set; }

        public string? Year { get; set; }

        public bool Equals(Car car)
        {
            return(this.Make,this.Model,this.Year) ==
            (car?.Make, car?.Model, car?.Year);
        }
    }
}
