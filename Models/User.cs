using System;
using System.ComponentModel.DataAnnotations;

namespace rpc_razor_auth.Models
{
	public class User
	{
		[Key]
		[Required]
		public String UserName { get; set; }

		[Required]
		public String Password { get; set; }

		[Required]
		public String FirstName { get; set; }
		
		[Required]
		public String LastName { get; set; }

		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }

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


