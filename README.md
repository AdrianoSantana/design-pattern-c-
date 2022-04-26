# design-pattern-c-
Learning design patterns using the language C#


# Motivo da criação de design patterns ?

Alguns problemas de desenvolvimento eram comuns em vários projetos, e possuiam soluções também identicas. Quatro engenheiros de software mapearam esses padrões e escreveram um livro chamado: Padrões de projeto: Soluções reutilizáveis de software orientado a objetos

# Classificação dos design patterns
* Criacional --> Se preocupam com o processo de criação de um objeto.
* Estrutural --> Se preocupam com a composição de classes ou de objetos.
* Comportamental --> Definem a maneira como classes ou objetos deverão se comportar.

# Criacionais
## Factory Method

Seu objetivo é criar uma "Fábrica" de classes em tempo de execução e deixar que a classe (Fábrica) decida seu tipo dinamicamente.
(Uma classe que cria objetos de classes diferentes)

## Abstract Factory

O objetivo deste design pattern é agrupar diversas factories que possuam características semelhantes, utilizando uma única interface.