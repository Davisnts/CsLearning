using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCar.Entities {
    internal class CarRental {
        public DateTime Start { get; set; }
        public DateTime Finsh { get; set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finsh, Vehicle vehicle) {
            Start = start;
            Finsh = finsh;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
