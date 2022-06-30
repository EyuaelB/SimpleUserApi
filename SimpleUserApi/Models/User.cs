
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace SimpleUserApi
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string  Email { get; set; } = string.Empty ;
        public string Password { get; set; } = string.Empty ;


        ////Constructor

        //public User(String firstName, string lastName, string email, string password)
        //{
        //    this.FirstName = firstName ;
        //    this.LastName = lastName ;
        //    this.Email = email ;
        //    this.Password = password ;
             

        //}
    }
}
