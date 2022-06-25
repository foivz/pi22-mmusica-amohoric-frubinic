using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_for_you
{
    public partial class komponenta
    {
        public override string ToString()
        {
            return Proizvodac + " " + Naziv + " " + Cijena;
        }
    }

}
