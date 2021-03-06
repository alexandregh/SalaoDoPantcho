# Salão do Pantcho
### Sistema Web - Salão do Pantcho
###### Versão 1.5

###### Descrição:
<p>Projeto Web de um Salão Barbershop chamado Salão do Pantcho.</p>
<p>O Sistema consiste na Interação e Gerenciamento de todas as funcionalidades providas pelo sistema por parte dos seus Clientes e Administradores.</p>

###### Detalhes Técnicos:
- Projeto: ASP NET
- Linguagem: C#
- Tecnologias Back-End: MVC5 + ORM Entity Framework - E.F (Fluent API)  + Ninject + AutoMapper;
- Tecnologias Front-End: HTML5 + CSS3 + JQquery + BootStrap;
- Base de Dados: SQLServer (.mdf);
- Arquitetura do Projeto: a arquitetura do projeto atualmente está criada em DDD - Domain Driven Design contendo dez camadas descritas abaixo: <br />
**SalaoDoPantcho.Entity:** Camada de Entidades de Negócio responsável por todas as Entidades (Objetos) de Negócio da Aplicação, bem como suas Regras de Negócio como Associações e Restrições. Essa camada contém todos os elementos necessários do Domínio da Aplicação como as Interfaces (Interface), Classes (Class), Enumerações (Enum), Relacionamentos (Relationship) **(1)**;<br />
**SalaoDoPantcho.Web:** Camada de Apresentação responsável pela interface com o usuário contendo a arquitetura de padrão de responsabilidades chamada MVC; <br />
**SalaoDoPantcho.App:** Camada de Aplicação responsável pela comunicação entre o usuário (entidade externa ao sistema) e o sistema propriamente dito. É uma camada fina de intercâmbio entre o usuário e o sistema onde um usuário pode solicitar as funcionalidades do sistema e este (sistema) por sua vez, devolver a resposta de sua solicitação.<br />
**SalaoDoPantcho.Domain:** Camada de Domínio originalmente responsável por todas as Entidades (Objetos) de Negócio da Aplicação, bem como suas Regras de Negócio como Associações e Restrições. Essa camada contém todos os elementos necessários do Domínio da Aplicação como as Interfaces (Interface), Classes (Class), Enumerações (Enum), Relacionamentos (Relationship), Serviços de Domínio (DomainServices) e outros elementos **(1)**;<br />
**SalaoDoPantcho.SGBD:** Camada de Repositório de Dados baseada em um Sistema de Gerenciamento de Banco de Dados onde sua finalidade é acessar, manipular e persistir todos os dados da aplicação;<br />
**SalaoDoPantcho.Security:** Camada de Segurança dos Dados de cada usuário responsável, por exemplo, pela criptografia das senhas de todos os usuários cadastrados no sistema afim que os mesmos possam cadastrá-las, alterá-las e realizar seu login no sistema de forma segura; Essa camada baseada no conceito **Cross-Cutting Concerns** e responsável pelas Operações Utilitárias do Sistema;<br />
**SalaoDoPantcho.Mail:** Camada de Envio de E-mails responsável pelo envio de mensagens eletrônicas por parte de usuários cadastrados ou não no sistema com a finalidade de manter contato entre o usuário e o sistema;<br />
**SalaoDoPantcho.Convert:** Camada de Conversão de Dados onde um de seus objetivos é realizar a conversão dos dados de entrada no sistema fornecidos por cada usuário cadastrado ou que está em processo de cadastro no sistema afim de que esses dados possam ser persistidos (criados ou alterados) no sistema de forma correta permitindo a integridade, regras e segurança dos dados no sistema.<br />
**SalaoDoPantcho.Bussiness:** Camada de Regras de Negócios da Aplicação responsável por manter um conjunto de regras de negócio que apoiam o funcionamento da aplicação como um todo. Essa camada tem como finalidade agregar um conjunto de regras de negócio da aplicação em um único local afim de que a aplicação se comporte no que condiz as diretrizes de cada Regra de Négócio em particular.<br />

- Organização do Projeto: na IDE do Visual Studio a organização do projeto está dividida da seguinte forma:<br />
**1 - Camada de Entidades (1)**<br />
**2 - Camada do Sistema**<br />
**2.1 - Camada de Apresentação**<br />
**2.2 - Camada de Aplicação**<br />
**2.3 - Camada de Domínio (1)**<br />
**2.4 - Camada de Infraestrutura**<br />
**2.4.1 - Camada de Banco de Dados**<br />
**2.4.2 - Camada de Banco de Utilitários**<br />
**2.4.2.1 - Camada de Segurança**<br />
**2.4.2.2 - Camada de Mensagens**<br />
**2.4.2.2.1 - Camada de Envio de Email**<br />
**2.4.2.3 - Camada de Conversão**<br />
**2.4.3 - Camada de Regras de Negócio**<br /><br>
**(1)**: No DDD - Domain Driven Design disposto por Eric Evans todas as Entidades (Objetos) de Negócio - Classes e Enums - da Aplicação e suas Regras de Negócio como Associações, Restrições e outras Regras ficam dispostas sempre na Camada de Domínio (Domain Layer) da aplicação o que é a maneira padrão de se implementar o DDD - Domain Driven Design.<br />Optei por dispor a Camada de Entidades fora da Camada do Sistema e consequentemente fora da Camada de Domínio (Domain Layer) por essas Entidades (Objetos) de Negócio estarem externos a implementação do sistema pois independente do sistema existir na forma de aplicação, Entidades (Objetos) de Negócio e suas Regras sempre existirão no Contexto de Negócio.<br />
**Cross-Cutting Concerns**: São funcionalidades que não estão diretamente relacionadas ao domínio da aplicação ou às suas respectivas regras de negócio, mas que ainda sim, são importantes para o Software. Exemplos: envio de emails, criptografia de senhas, etc.<br />
**Observação**: Durante o desenvolvimento da aplicação foi utilizada uma ferramenta do Visual Studio para análise estática de código chamada **Code Analysis**.
