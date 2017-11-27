using System;

namespace BecomingDev.Models
{
    public interface IEmailSender
    {
        void SendMessage(string receiver, string title, string message);
        
    }

    public class EmailSender : IEmailSender
    {
        public void SendMessage(string receiver, string title, string message)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IDatabase
    {
        bool IsConnected { get; }

        void Connect();

        User GetUser(string email);

        Order GetOrder(int id);

        void SaveChanges();
    }

    public class DataBase : IDatabase
    {
        public bool IsConnected
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Connect()
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(string email)
        {
            throw new System.NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }

    //business logic
    public interface IOrdrerProcessor
    {
        void ProcessOdrer(string email, int orderId);
    }

    public class OrderProcessor : IOrdrerProcessor
    {
        //create fields to use only in constructor
        private readonly IDatabase _database;
        private readonly IEmailSender _emailSender;
        
        public OrderProcessor(IDatabase database, IEmailSender emailSender) // constructor
        {
            _database = database;
            _emailSender = emailSender;
        }

        public void ProcessOdrer(string email, int orderId)
        {
            User user = _database.GetUser(email); //Fetch from db (pobrać z db)
            //TODO: write validation
            if (user == null)
            {
                //error
            }
            Order order = _database.GetOrder(orderId); //Fetch from db
            //TODO: write validation

            user.PurchaseOrder(order);
            _database.SaveChanges();
            _emailSender.SendMessage(email, "Order purchased", "You've purchased and order.");

        }
    }

    public class FakeEmailSender : IEmailSender
    {
        public void SendMessage(string receiver, string title, string message)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeDatabase : IDatabase
    {
        public bool IsConnected { get; }
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public User GetUser(string email)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }


    public class Shop
    {
        public void CompleteOrder()
        {
            IDatabase database = new DataBase();
            IEmailSender emailSender = new EmailSender();

            IOrdrerProcessor orderProcessor = new OrderProcessor(database, emailSender);
        }

        public void CompleteFakeOrder()
        {
            IDatabase database = new FakeDatabase();
            IEmailSender emailSender = new FakeEmailSender();

            IOrdrerProcessor orderProcessor = new OrderProcessor(database, emailSender);
        }
    }



}