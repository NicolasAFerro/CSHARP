# DOCKER

Cliente-Internet-Servidor(serviço);
frontEnd - BackEnd;
app -------Cloud
web -------DataCenter$$$
CaxEle

Cloud(via demanda,Internet,DataCenter Remoto)-AWS(pioneiro),Azure, googleCloud,Oracle $

## VM

VIRTUALIZAÇÃO-Simulação de Hardware(um software que pega a memória e consegue dividi-la);1990-Potencialização de hardware;
Otimização 1 servidor em 3-4;
Cria uma camada de abstração
-Permite que um único computador(hardware), seja dividido em vários computadores
(ESQUEMA VIRTUALIZAÇÃO)
-E se eu pudesse dividir a máquina virtual também? Abstrair dela em pequenos servições
Nesse contexto=><strong>Microserviços <strong>/ Antigamente Monolitico

MicroserviçOs: pequenos independentes que se comunicam utilizando API;
-Mais facil de inserir uma funcionalidade
-O microsserviço só funciona em uma parte da VM; Se está tendo muita requisição, então eu só duplico ele e não a VM inteira; mesmo que seja para outra máquina, pois o microsserviço é pequeno; com isso, otimiza a VM=><strong>CONTEINER<strong>; o microsserviço só é possivel graças ao conteiner

Um bloco de codigo de um APP(Isolado) e neste bloco só coloco recursos que desejo para aquele aplicativo;somente oq eu preciso para a execução de um microssreviço especifico

para isso:

### DOCKER

é esse container-migrar de um ambiente para outro;
na teoria vai funcionar em diferentes SO, funciona em qualquer ambiente;
-aplicação multilinguagem;

https://www.ibm.com/br-pt/cloud/learn/containers

https://www.redhat.com/pt-br/topics/containers

https://www.redhat.com/pt-br/topics/containers/containers-vs-vms

https://www.redhat.com/pt-br/topics/containers/what-is-docker

https://docs.microsoft.com/pt-br/dotnet/architecture/microservices/container-docker-introduction/docker-defined

https://medium.com/xp-inc/principais-comandos-docker-f9b02e6944cd

https://docs.docker.com/engine/reference/commandline/docker/

https://dev.to/soutoigor/docker-imagens-containers-e-seus-principais-comandos-23p6

Abaixo os códigos-fonte para você copiar e colar
Executando um contêiner
docker pull ubuntu
docker run ubuntu
docker run ubuntu sleep 10
docker run ubuntu sleep 1500
docker stop [id]
docker run --help
docker run -it ubuntu

Executando aplicações no contêiner
docker run -dti ubuntu
docker exec -it [id ou nome] /bin/bash

Excluindo e nomeando contêineres
docker stop [id]
docker rm [id]
docker rmi [imagem]

docker run -dti --name Ubuntu-A ubuntu

Copiando arquivos para o contêiner
docker exec -ti Ubuntu-A /bin/bash
docker exec Ubuntu-A mkdir /destino/
docker exec Ubuntu-A mkdir ls -l /
nano Arquivo.txt
docker cp arquivo.txt Ubuntu-A:/aula/

Copiando arquivos do container
docker cp Ubuntu-A:/destino/Meuzip.zip Zipcopia.zip

Criando um contêiner do MySQL
docker cp Ubuntu-A:/destino/Meuzip.zip Zipcopia.zip

Acessando um container externamente
docker pull mysql

docker run -e MYSQL_ROOT_PASSWORD=Senha123 --name mysql-A -d -p 3306:3306 mysql

docker exec -it mysql-A bash

mysql -u root -p --protocol=tcp

CREATE DATABASE aula;
show databases;

docker inspect mysql-A

mysql -u root -p --protocol=tcp
