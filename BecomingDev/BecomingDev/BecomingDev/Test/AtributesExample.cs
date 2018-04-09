using System;

namespace BecomingDev.Test
{
    public class AtributesExample
    {
        
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class UserPasswordAttribute : Attribute
    {
        public int Length { get; }

        public UserPasswordAttribute(int length =4)
        {
            Length = length;
        }

    }

    public class User
    {
        [UserPassword]
        public string Password { get; set; }

        public string UserName { get; set; }

        public User(string password, string name)
        {
            UserName = name;
            Password = password;
        }
    }
}