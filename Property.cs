using System;

namespace Property {
    internal class Property {
        private string address;
        private double price;
        private double suggestion;
        public Property(string address, double price) {
            this.address = address;
            this.price = price;
            suggestion = 0;
        }

        public string Address {
            get { return address; }
            set { address = value; }
        }

        public double Price {
            get { return price; }
            set { price = value; }
        }

        public double Suggestion {
            get { return suggestion; }
            set { suggestion = value; }
        }

        public void PrintInfo() {
            Console.WriteLine("Endereço: " + address);
            Console.WriteLine("Preço: R$ " + price);
            Console.WriteLine("Sugestão: R$ " + suggestion);
        }
    }
}
