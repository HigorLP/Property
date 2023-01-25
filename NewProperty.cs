using System;
using System.Diagnostics;

namespace Property {
    internal class NewProperty : Property {
        private double suggestion;

        public NewProperty(string address, double price) : base(address, price) {
            suggestion = price + (price * 0.2);
            base.Suggestion = suggestion;
        }

        public new double Suggestion {
            get { return suggestion; }
        }
    }
}