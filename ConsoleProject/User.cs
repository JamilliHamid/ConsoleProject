using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class User
    {
        public int Id;
        public string Name;
        public string Surname;
        public double Balance;
        public string Email;
        public string Password;
        public bool IsAdmin;
        public bool Isblocked;
        public bool Islogged;


        public User(int id, string name, string surname, double balance, string email,string password, bool isadmin, bool isblocked, bool islogged)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Balance = balance;
            Email = email;
            Password = password;
            IsAdmin = isadmin;
            Isblocked = isblocked;
            Islogged = islogged;
           
        }
     
	

	
    }
}
