# Salão do Pantcho
### Sistema Web - Salão do Pantcho
###### Versão 1.0

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
**SalaoDoPantcho.Web:** camada responsável pela apresentação contendo a arquitetura de padrão de responsabilidade chamada MVC; <br />
**SalaoDoPantcho.App:**
**CatalogoLivros.Util:** camada baseada no conceito Cross-Cutting Concerns* e responsável pelas Operações Utilitárias e Secundárias do Sistema; <br />
**CatalogoLivros.Domain:** camada responsável por todas as entidades de negócio, regras e suas características; <br />
**CatalogoLivros.Interfaces:** camada responsável por todas as Assinaturas dos Métodos (Funcionalidades) que são implementados na camada CatalogoLivros.DAL; <br />
**CatalogoLivros.DAL:** camada responsável pela manipulação de dados; **CatalogoLivros.SGBDDAL:** camada responsável pela fonte de acesso dos dados).
- Organização do Projeto: na IDE do Visual Studio a organização do projeto está dividida da seguinte forma:<br />
**Camada de Entidades:** a Camada de Entidades contém todas as Entidades (Objetos) de Negócio - Classes e Enums - da Aplicação e suas Regras de Negócio como Associações e Restrições. 1*<br />
**Camada do Sistema:** a Camada do Sistema subdivide-se em subcamadas a saber:<br />
<p>1.1 - Camada de Apresentação</p>
<p>1.2 - Camada de Aplicação</p>
<p>1.3 - Camada de Domínio</p>
<p>1.4 - Camada de Infraestrutura</p>
<p>A Camada de Infraestrutura subdivide-se em subcamadas a saber:<br />

<p>1*: No DDD - Domain Driven Design disposto por Eric Evans todas as Entidades (Objetos) de Negócio - Classes e Enums - da Aplicação e suas Regras de Negócio como Associações e Restrições ficam dispostas sempre na Camada de Domínio (Domain Layer) da aplicação o que é a maneira padrão de se implementar o DDD - Domain Driven Design.<br />Optei por dispor a Camada de Entidades fora da Camada do Sistema e consequentemente fora da Camada de Domínio (Domain Layer) por essas Entidades (Objetos) de Negócio estarem externos a implementação do sistema pois independente do sistema existir na forma de aplicação, Entidades (Objetos) de Negócio e suas Regras sempre existirão no Contexto de Negócio.</p>
<p>Cross-Cutting Concerns*: São funcionalidades que não estão diretamente relacionadas ao domínio da aplicação ou às suas respectivas regras de negócio, mas que ainda sim, são importantes para o Software. Exemplos: envio de emails, criptografia de senhas, etc.</p>
