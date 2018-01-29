# CodeSchool .NET MVC
## O que é o ASP.NET MVC?
* Um framework .NET para desenvolver aplicações web rapidamente
	* Ajuda a manter o código limpo e fácil de manter
	* Lida com tudo desde a UI até o ambiente do servidor e tudo no meio
* Roda no Windows, Linux e OS10
* Outros nomes são:
	* ASP.NET MVC
	* .NET MVC
	* ASP.NET CORE

## Como os dados fluem em uma aplicação MVC
* MVC é um padrão de projeto estrutural para organizar o código de maneira lógica

1. O usuário entra com uma **URL** no browser e um pedido (request) é feito
2. O **Controller** recebe o pedido
3. O **Controller** acessa dados do **Model** baseado na **URL** que foi enviada
4. O **Controller** passa os dados acessados no **Model** para a **View**
5. A interface gerada pela **View** é enviada e exibida ao usuário

![https://raw.githubusercontent.com/ALREstevam/CodeSchool-.NET-MVC/master/Teoria/fotos/01-howdataflowsthroughtanmvcapplication.PNG?token=AWTj1245uE_bxlQKcK2Sxml_zgZBPqMtks5aeNi_wA%3D%3D](https://raw.githubusercontent.com/ALREstevam/CodeSchool-.NET-MVC/master/Teoria/fotos/01-howdataflowsthroughtanmvcapplication.PNG?token=AWTj1245uE_bxlQKcK2Sxml_zgZBPqMtks5aeNi_wA%3D%3D)

## Estrutura de um projeto ASP.NET MVC
* É preciso dividir o projeto em diretórios para armazenar Model, View e Controller
* A pasta raiz (root) precisa ter o nome do projeto
* Neste diretório deverão estar as pastas
	* Models
	* Views
	* Controllers



Exemplo de estrutura:
* `CharacterSheetApp`
	* `Controllers`
		* `HomeController.cs`
	* `Models`
		* `Home.cs`
	* `Views`
		* `Home`
			* `Index.cshtml`
	* `Proprieties`
	* ...

Como os arquivos compartilham o nome "`Home`",  esses arquivos serão automaticamente conectados

## Criando a view

Criar um arquivo `.cshtml` depende do editor que está sendo utilizado, como:
* Visual Studio
* Visual Studio Code
* Xamarin Studui
* MonoDevelop
* SharpDevelop

> Um `cshtml` é um arquivo que permite o uso de HTML e C# para gerar as págians

### Razor

> Quando HTML e C# estão sendo misturados, é feito o uso de uma engine embutida chamada **Razor**

Será desenvolvida uma aplicação que permitirá a inserção  e recuperação de nomes de personagens em uma lista de forma dinâmica

Primeiro, pode-se começar com HTML cru:

***./Views/Home/Index.cshtml***


	...
	<h2>Characters:</h2>
	<div>
		<ul>
			<li>Hux</li>
			...
		</ul>
	</div>
	...


Para obter as funcionalidades requeridas, será preciso:
1. Atualizar a view para esta poder aceitar os dados
2. Atualizar o controle para este ser capaz de enviar os dados


**Na view**

	@model String
	...
	<h2>Characters:</h2>
	<div>
		<ul>
			<li>Hux</li>
			...
		</ul>
	</div>
	...


> Em Razor, a palavra-chave `@model` diz para a view qual tipo de dado será envidado, `@model String` diz ao Razor que será enviada uma única String de dados

> `@Model` dá acesso aos dados passados pela view ao controller


	@model String
	...
	<h2>Characters:</h2>
	<div>
		<ul>
			<li>@Model</li>
			...
		</ul>
	</div>
	...


**No controller**

***./Controllers/HomeController.cs***

	namespace CharacterSheetApp.Controllers
	{
		public class HomeController : Controller
		{
			public IActionResult Index()
			{
				return View();
			}	
		}
	}

> Métodos que retornam um objeto `IActionResult` são chamados de  "Action methods", eles provém as respostas utilizáveis pelos browsers

![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/02-alookinsidethecontroller.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/02-alookinsidethecontroller.PNG?raw=true)


***./Controllers/HomeController.cs***

	namespace CharacterSheetApp.Controllers
	{
		public class HomeController : Controller
		{
			public IActionResult Index()
			{
				var name = "Hux";
				return View("Index", name);
			}	
		}
	}


![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/03-passingournamebacktotheview.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/03-passingournamebacktotheview.PNG?raw=true)