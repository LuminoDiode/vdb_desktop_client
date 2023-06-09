﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServerQuerier.Models.Auth;

public class LoginRequest
{
	[Required]
	[MaxLength(50)]
	[DataType(DataType.EmailAddress)]
	[EmailAddress]
	public string Email { get; set; }

	[Required]
	[MinLength(6)]
	[MaxLength(256)]
	[DataType(DataType.Password)]
	[PasswordPropertyText]
	public string Password { get; set; }
}
