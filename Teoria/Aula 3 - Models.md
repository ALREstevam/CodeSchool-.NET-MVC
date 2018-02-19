# Aula 3 - Models

## Criação da classe `Character` (model)

Na model, a classe `Character` será criada com o atributo `Name`, assim será possível mostrar o nome de cada personagem, com cada um deles sendo representado por um objeto dessa classe.

![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/06-creatingamodelclass.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/06-creatingamodelclass.PNG?raw=true)

![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/07-addfieldstoourmodel.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/07-addfieldstoourmodel.PNG?raw=true)


***./Models/Character.cs***

	namespace CharacterSheetApp.Models
	{
		public class Character
		{
			public string Name;//campo nome adicionado
		}
	}

> **Obs.:** campos púbicos, variáveis e propriedades do tipo `public` deve ser escrita em **camel case** com a primeira letra capitalizada ex: `public string FullName;` 

## Alterações no `HomeController.cs`
Agora que um personagem será representado por um objeto da classe `Character` o `HomeController` precisa ser alterado, ele está passando para a view uma string com o nome de um caractere

![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/08-settingourmodeltoourcharacterobject.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/08-settingourmodeltoourcharacterobject.PNG?raw=true)


	public IActionResult Index()
	{
		var model = new Character();
		model.Name = "Hux";
		return View(model);
	}

## Namespaces
O código desta forma causará um erro, isso ocorre pois em .NET colocar um código em uma certa pasta faz com que seu namespace seja baseado no nome dela, dessa forma é garantido que código não requerido não será executado.



![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/09-namespacesindotnet.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/09-namespacesindotnet.PNG?raw=true)

Para criar uma instância de `Character` será necessário dizer sua localização usando o namespace correto:

![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/10-usgfullcharnamespace.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/10-usgfullcharnamespace.PNG?raw=true)

***./Controllers/HomeController.cs***

	pubic IActionResult Index()
	{
		var model = new CharacterSheetApp.Models.Character();
		model.Name = "Hux";
		return View(model);
	{

## Mudando a view para usar o novo model

Como a view está esperando uma string e será enviado um objeto do tipo `Character`, ela precisa ser alterada

![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/11-chngview.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/11-chngview.PNG?raw=true)

![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/12-usingnamefield.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/12-usingnamefield.PNG?raw=true)


***./Views/Home/Index.cshtml***

	@model CharacterSheetApp.Models.Character
	<h2> Characters </h2>

	<div>
		<ul>
		<li>@Model.Name</li>
		</ul>
	</div>
