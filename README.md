# Luizalabs Employee Manager
Desafio proposto por Luizalabs

Implementação de uma Web API Rest para gestão de informações referente a gestão de objetos do tipo "Employee", como no exemplo:

{
	"Name": "Rodrigo Arantes",
	"Email": "rodrigo@luizalabs.com",
	"Department": "Mobile"
}


### Recursos

Implementação com uso de EntityFramework para controle de persistência, Swagger para acesso a informações referentes a API e projeto de teste unitário,
permitindo a validaçãod e cada uma das rotas da API

### Sugestão de Testes
A aplicação é usada através de requisições GET, POST e DELETE, acessíveis por meio do recurso Swagger:

```
http://localhost:8000/swagger
```

Ou utilização de outras ferramentas, pomo o Postman na URL:

```
http://localhost:8000/employee
```
