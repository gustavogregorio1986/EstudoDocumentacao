using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo10.Entidade
{
    public class Person
    {
        public required string LastName { get; set; }

        public required string FirstName { get; set; }

        public override string ToString()
        {
            return $"{FirstName}  {LastName}";
        }
    }
}
