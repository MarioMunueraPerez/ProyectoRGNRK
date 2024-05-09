﻿namespace RGNRK.Data
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }
        public string Email { get; set; }

        public enum Category
        {
            basic,
            standar,
            advanced
        }

        public Category UserCategory { get; set; }


    }
}
