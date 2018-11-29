using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWSSchduler.Model
{
    [Table("Current User")]
    public class User
    {
        [AutoIncrement, PrimaryKey, Column("id")]
        public int ID { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("Token")]
        public string Token { get; set; }
    }
}
