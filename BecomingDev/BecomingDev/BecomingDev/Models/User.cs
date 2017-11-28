using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BecomingDev.Models
{
    public class Person
    {
        public string FirstName { get; set; }
    }
    

    public class User
    {

        private Person _person;

        private ISet<Order> _orders = new HashSet<Order>(); // set - collection with unique elements

        public string Email { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime UpdatedAt { get; private set; } //specifies the date of the last update
        public decimal Funds { get; set; } // determines the amount of money used

        public IEnumerable<Order> Orders { get { return _orders; } } // we create this like this (not List<Order> Orders {get; private set; }) to provide encapsulation. In the second case (case with List) we would receive possibility to add orders to object omitting the metod PurchaseOrders

        //composition
        public User(Person person)
        {
            FirstName = person.FirstName;
        }

        public User(string email, string password)
        {
            SetEmail(email);
            SetPassword(password);
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email is incorrect.");
            }
            if (Email == email) //comes out of the method if password is the same
            {
                return;
            }
            Email = email;
            UpDate();
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password is incorrect.");
            }
            if (Password == password) //comes out of the method if password is the same
            {
                return;
            }
            Password = password;
            UpDate();
        }

        public void SetAge(int age)
        {
            if (age < 13)
            {
                throw new Exception("Age must be greater or equal to 13.");
            }
            if (Age == age)
            {
                return;
            }
            Age = age;
            UpDate();
        }

        public void Activate()
        {
            if (IsActive)
            {
                return;
            }
            IsActive = true;
            UpDate();
        }

        public void Deactivate()
        {
            if (!IsActive)
            {
                return;
            }
            IsActive = false;
            UpDate();
        }

        public void IncreaseFunds(decimal funds)
        {
            if (funds <= 0)
            {
                throw new Exception("Funds must be greater than 0.");
            }

            Funds += funds;
            UpDate();
        }


        public void PurchaseOrder(Order order)
        {
            decimal orderPrice = order.TotalPrice;

            if (!IsActive)
            {
                throw new Exception("Only active users can purchase an order.");
            }
            
            if (Funds - orderPrice < 0)
            {
                throw new Exception("You don't have enought money.");
            }

            order.Purchase();
            Funds -= orderPrice;
            _orders.Add(order);
            UpDate();
        }


        private void UpDate()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}