﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD.Models
{
	[Table("Produto")]
	public class Produto
	{
		[Column("ID")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("Nome")]
		[Display(Name = "Nome")]
		public string Nome { get; set; }
	}
}
