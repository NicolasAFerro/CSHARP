# MÓDULO TEÓRICO BANCO DE DADOS - MANIPULAR(DESENVOLVIMENTO)

<strong>introdução<strong>

  <p> coleção organizada de informações<p>
    insirir 
    atualizar
    recuperar         precisa atender todo mundo de uma maneira organizada 
                      se chama informações sem acessos 
                      ataques ao banco

## Tipos de banco

<strong>relacional<strong>

relacional: tabelas que se relacionam entre si;
nome - dataNascimento -igual planilha de excel;

<p>tabela de vendas<p> 
  produto-cliente-vendas
    vendas vai se relacionar com cliente(alguem) 
    e também com produto(vendeu algo)
    Mysql - gratuito- site pessoal, pequenas empresas
    Oracle-mais robusto-redundancia-$$--100%online - <strong>hospital<strong>
    SQLserver - mais robusto - Médio e grande porte

    <strong> Tabela autodescritiva <strong>
            melhor separar dados para não ficar muito longa
            tabela endereços tem apontamento para a tabela endereço
                                    ^ IDCLIENTE
    Não sai do padrão-regras rigidas

<strong>NÃO RELACIONAL<strong>
são armazenados de forma não estruturada ou semi-estruturada;
Não possui regras rigidas -
SemiEstruturado: JSON(COLUNA TEXTO-pode ser id, valor, qualquer coisa);
Não estruturado: PDF, musica, post em Rede social;dado bruto;GRANDES QUANTIDADE DE INFORMAÇOES
BigData,Mobile,muito+rapido(escalável)-performace;
MongoDB(document database)

# DBMS

-Software utilizado para acessar, manipular e monitorar um banco de dados;
-sql server managemte Studio(VISUAL)-Na maquina de desenvolvedor
-Cada banco de dados tem o seu -IDE

# SQL TABELAS E TIPOS DE DADOS

-structured query language:

SQL COMMANDS- DDL DCL DML TCL DQL
ddl:data definition
dcl data control
*dml data manipulation
tcl transaction control https://www.guru99.com/sql-commands-dbms-query.html
*dql data query

              A DATABASE PODE SER DE DIFERENTES SISTEMAS
              ai cada database tem suas tabelas e funções
        ativar banco manualmente

Servername: localhost\sqlexpress
autentication: windows autentication - sqlserver(para remotos)
SQL SERVER MANAGEMENT CONFIGURATION MANAGER
SQL SERVER MANAGEMENT STUDIO

                    edit>intelliSense>Refresh

### PRESTAR ATENÇÃO PARA ONDE A QUERY ESTÁ APONTANDO

SELECT \* FROM nome_tabela;

<!-- ctrl kc -->

### EXIBIÇÃO

ORDER BY nome_coluna DESC(decrescente)/// ORDER BY Nome, Sobrenome

SELECT Nome,Sobrenome FROM nome_tabela;(Traz apenas algumas colunas)-Boa Prática

### Filtrar dados:

WHERE Nome = 'Adam' AND Sobrenome = 'reynalds'
OR
(WHERE TEM QUE VIR ANTES DO ORDER BY)

-quero trazer todos com uma letra
WHERE Nome LIKE 'G%'('%G%'=g no nome) % é irrelevante

<!-- formato 'AAAA-MM-DD HH:MM:SS', que é o formato de data e hora aceito pelo SQL Server.2010-02-16 00:00:00 -->

### INSERIR DADOS

<!--
aqui se eu quiser passar sobrenome primeiro da certo -->

INSERT INTO Clientes (Nome,Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES('Nicolas','ferro','@gmail', 1, GETDATE())

-OMITINDO TIPOS DE DADOS
INSERT INTO Clientes VALUES ('MARIA','ferro','@gmail', 0, GETDATE())

ID=PRIMARY KEY

### UPTADE

UPDATE Clientes
SET Email = 'maria@gmail.com'
WHERE Id = 70 <!-- sempre fazer com um where -->

BEGIN TRAN <!-- permite um ctrlZ -->
ROLLBACK

### DELETE

DELETE Clientes
WHERE Id = 68

### CRIAR TABELA

CREATE TABLE Clientes (
Id int IDENTITY(1,1) NOT NULL,
Nome varchar(255) NULL,
Sobrenome varchar(255) NULL,
Email varchar(255) NULL,
AceitaComunicados bit Null,
DataCadastro datetime2 (7) NULL
)

CREATE TABLE Produtos (
Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,<!-- ,(VALIDAÇÕES) -->
Nome varchar(255) NOT NULL,
Cor varchar(50) NULL,
Preco decimal(13,2) NOT NULL,
Tamanho varchar(5) Null,
Genero char (1) NULL
)

### TIPOS DE DADOS

STRING
-char:sigla de estado, certeza que é só aquilo
-varchar

inteiros normais, decimal
float,real;

DATETIME2
DATE
TIME

## BUILT-IN FUNCTIONS

-funções pre-existentes no sistema;
<strong>COUNT<strong>retorna apenas uma consulta- só um numero;
SELECT COUNT (\*) FROM Produtos
SELECT COUNT (\*) QuantidadeProdutos FROM Produtos
SELECT COUNT (\*) QuantidadeProdutosM FROM Produtos WHERE Tamanho ='M'
<strong>SUM<strong>
SELECT SUM(Preco) PrecoTotal FROM Produtos
SELECT SUM(Preco) PrecoTotal FROM Produtos WHERE Tamanho ='M'(soma dos valores de todos os produtos que tenham o tamanho M)
<strong>MAX E MIN<strong>
SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos
SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos WHERE Tamanho ='M'
SELECT AVG(Preco) Media FROM Produtos
<strong>CONCATENANDO<strong>
SELECT Nome +' cor: ' + Cor NomeProduto FROM Produtos
<strong> UPPER LOWER<strong>
SELECT Nome +' cor: ' + Cor NomeCompleto
UPPER(Nome) nome,
LOWER(Cor) cor
FROM Produtos
<strong> ADICIONANDO COLUNA<strong>
ALTER TABLE Produtos
ADD DataCadastro DATETIME2

UPDATE Produtos SET DataCadastro = GETDATE()

SELECT \* FROM Produtos
<strong>DELETANDO COLUNA<strong>
ALTER TABLE Produtos
ADD DataCadastro DATETIME2
<strong>FORMATANDO DATA<strong>
SELECT
Nome +' cor: ' + Cor + '-' + Genero NomeProdutoCompleto,
UPPER(Nome) nome,
LOWER(Cor) cor,
FORMAT(DataCadastro, 'dd-MM-yyyy HH:mm') Data
FROM Produtos
<strong>GROUP BY<strong>
-contar quantos produtos eu tenho agrupando pelo tamanho do produto;
quando produtos M, G ou p

SELECT
Tamanho,
COUNT(\*) Quantidade
FROM Produtos
WHERE Tamanho <>''
GROUP BY Tamanho
ORDER BY Quantidade DESC

#### PRIMARY KEY e FOREIGN KEY

primary key - Id
foreign key - chave de outra tabela
Sua tabela de endereçõs também tem seu proprio id interno e uma coluna que faz referencia
CREATE TABLE Enderços(
Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
IdCliente int NULL,
Rua varchar(255) NULL,
Bairro varchar(255) NULL,
Cidade varchar(255) NULL,
Estado char (2) NULL,

    CONSTRAINT FK_Enderecos_Cliente FOREIGN KEY (IdCliente)
    REFERENCES Clientes(Id)

)

<!-- toda foreign key é uma constrait(restrição)
CONSTRAINT nome FOREIGN KEY(qual coluna que vai fazer referencia com a outra tabela)
REFERENCES Clientes(Id) -->

INSERT INTO Endereços VALUES(4,'RUA TESTE', 'BAIRRO TESTE', 'CIDADE TESTE', 'SP');

<!-- Prestar atenção da ordem que eu criei a tabela, pois 4 é IdCliente -->

SELECT \* FROM Enderços WHERE IdCliente = 4

## <strong>JOIN <strong>

TEM VARIOS JOINS

-Trazer o cliente e o endereço em um unico SELECT
SELECT \* FROM Clientes
INNER JOIN Endereços ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4
