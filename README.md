# API REST con dos métodos: GET y POST

Api sencilla para pruebas utilizando GET y POST

## Consideraciones

* Visual Studio 2019
* Windows 10
* Lenguaje de programación C#
* Se utilizó Postman para probar el método POST.

## Observaciones

* Se puede prescindir de <code>[Route("api/[controller]")]</code> siempre y cuando se especifique la ruta del controlador y los atributos (si es que los hay) ya sea POST, GET, PUT, etc.

Ejemplo:

```c#
		[HttpPost("Perfil")]
		public string Post(Usuario user)
		{
			//retorna los datos de usuario
			return "Nombre: " + user.Nombre + "\nApellidos: " + user.Apellidos + "\nEdad: " + user.Edad;
		}
```

* Si se utiliza <code>[Route("api/[controller]")]</code> es importante colocar como propiedad el tipo de método que va a utilizar la función (GET, POST, PUT, DELETE) y pasarle los atributos en caso de los GET.

Por ejemplo:

```c#
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
```
