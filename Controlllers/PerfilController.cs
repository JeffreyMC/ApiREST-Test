using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiREST.NewFolder
{
	[Route("api/[controller]")]
	[ApiController]
	public class PerfilController : ControllerBase
	{
		[HttpGet("{id}")]
		public string Get(int id)
		{
			//retorna la información
			return id switch
			{
				1 => "Jeffrey",
				2 => "Programación",
				_ => throw new NotSupportedException("El id ingresado no existe")
			};
		}

		[HttpPost]
		public string Post(Usuario user)
		{
			//retorna los datos de usuario
			return "Nombre: " + user.Nombre + "\nApellidos: " + user.Apellidos + "\nEdad: " + user.Edad;
		}
	}

	//objeto para el post
	public class Usuario
	{
		public string Nombre { get; set; }
		public string Apellidos { get; set; }

		public int Edad { get; set; }
	}
}
