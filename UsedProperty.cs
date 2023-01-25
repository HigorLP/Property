using System;
using System.Diagnostics;

namespace Property {
    internal class UsedProperty : Property {
        private double suggestion;

        public UsedProperty(string address, double price) : base(address, price) {
            suggestion = price - (price * 0.1);
            base.Suggestion = suggestion;
        }

        public new double Suggestion {
            get { return suggestion; }
        }
    }
}
