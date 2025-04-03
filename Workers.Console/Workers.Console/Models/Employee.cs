using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers.Console.Models
{
    public class Employee
    {
        private decimal _pay;
        private string _email;

        public Employee(string email, string name)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                throw new ArgumentException("Érvénytelen email cím.");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("A név nem lehet üres.");

            _email = email;
            Name = name;
            _pay = 0;
        }

        public string Name { get; set; }
        public decimal Pay
        {
            get => _pay;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("A fizetés nem lehet nulla vagy negatív.");
                _pay = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrEmpty(value) || !value.Contains("@"))
                    throw new ArgumentException("Érvénytelen email cím.");
                _email = value;
            }
        }

        public void AddPay(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("A fizetés nem lehet nulla vagy negatív.");
            _pay += amount;
        }

        public override string ToString()
        {
            return $"{Name} ({_email}) - {_pay} Ft";
        }
    }

}
