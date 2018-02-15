
# Aula 2 - Rotas (Routes)

A aplicação decide qual view mostrar usando um sistema chamado routes que diz para a web applicatio qual controller e ação do controller acessar com base na URL.

## Como as rotas são mapeadas com Controllers?
Por padrão, a primeira seção da rota mapeia o Controller e a segunda seção mapa com a ação

`http://www.example.com/Home/Index` = chame o método `Index()` do controller `HomeController`

![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/04-routes.PNG?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/04-routes.PNG?raw=true)

O Controller então é mapeado com uma view

	...
	...Class HomeController...
	... Index(){
		return View();
	}

Irá ser mapeado como:

`HomeController`: `Views/Home`
`Index(){}`: `Views/Home/Index.cshtml`

Assim, o comando `return View();` retornará o arquivo `Views/Home/Index.cshtml`

![https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/05-routesthecontrolleralsomapstotheview?raw=true](https://github.com/ALREstevam/CodeSchool-.NET-MVC/blob/master/Teoria/fotos/05-routesthecontrolleralsomapstotheview?raw=true)


## Rotas omitidas

Quando a URL não tem toda a rota (nada ou parte dela) uma rota padrão será usada, tipicamente `.../Home/Index`

Assim, a URL `www.example.com` seria interpretada como `www.example.com/Home/Index`



