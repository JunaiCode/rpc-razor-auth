using System;
using System.ComponentModel.DataAnnotations;

namespace rpc_razor_auth.Models
{
	public class User
	{
		[Key]
		[Required]
		[Display(Name = "User Name")]
		public String UserName { get; set; }
		
		[Required]
		public String Password { get; set; }

		[Required]
		[Display(Name = "First Name")]
		public String FirstName { get; set; }
		
		[Required]
		[Display(Name = "Last Name")]
		public String LastName { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Birth Date")]
		public DateTime BirthDate { get; set; }

		public User()
        {

        }
		public User(String userName, String password, String firstName, String lastName, DateTime birthDate)
		{
			this.UserName = userName;
			this.Password = password;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.BirthDate = birthDate;

		}
	}
}


