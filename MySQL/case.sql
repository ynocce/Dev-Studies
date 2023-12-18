-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.
--LINK DOWNLOAD BRMODELO 
--https://sourceforge.net/projects/brmodelo30/
--SCRIP SQL RESULTADO DO MODELO CONCEITUAL E LOGICO
CREATE DATABASE CASO_CURSO;

USE CASO_CURSO

CREATE TABLE cliente (
id_cliente INT NOT NULL PRIMARY KEY,
nome_cliente VARCHAR(50)  NOT NULL ,
ultimo_nome VARCHAR(50)  NOT NULL,
email VARCHAR(50) NOT NULL,
sexo VARCHAR(50) NOT NULL,
id_pais INT NOT NULL,
id_cidade INT NOT NULL,
id_profissao INT NOT NULL,
id_etnia INT NOT NULL,
id_idioma INT NOT NULL,
data_nasc SMALLDATETIME NOT NULL
)

CREATE TABLE etnia (
id_etnia INT NOT NULL PRIMARY KEY,
nome_etnia VARCHAR(50) NOT NULL
)

CREATE TABLE pais (
id_pais INT NOT NULL PRIMARY KEY,
nome_pais VARCHAR(50) NOT NULL
)

CREATE TABLE cidade (
id_cidade INT NOT NULL PRIMARY KEY,
nome_cidade VARCHAR(50) NOT NULL
)

CREATE TABLE idioma (
id_idioma INT NOT NULL PRIMARY KEY,
nome_idioma VARCHAR(50) NOT NULL
)

CREATE TABLE Profissao (
id_profissao INT NOT NULL PRIMARY KEY,
nome_profissao VARCHAR(50) NOT NULL
)

CREATE TABLE modelo_carro (
id_carro INT NOT NULL PRIMARY KEY,
nome_carro INT NOT NULL,
id_montadora INT NOT NULL
)

CREATE TABLE montadora (
id_montadora INT NOT NULL PRIMARY KEY,
nome_montadora VARCHAR(50) NOT NULL
)

CREATE TABLE carro_cliente (
id_cliente INT NOT NULL,
id_carro INT NOT NULL,
ano_carro INT NOT NULL,
FOREIGN KEY(id_cliente) REFERENCES cliente (id_cliente),
FOREIGN KEY(id_carro) REFERENCES modelo_carro (id_carro)
)

ALTER TABLE cliente ADD FOREIGN KEY(id_pais) REFERENCES pais (id_pais)
ALTER TABLE cliente ADD FOREIGN KEY(id_cidade) REFERENCES cidade (id_cidade)
ALTER TABLE cliente ADD FOREIGN KEY(id_profissao) REFERENCES Profissao (id_profissao)
ALTER TABLE cliente ADD FOREIGN KEY(id_etnia) REFERENCES etnia (id_etnia)
ALTER TABLE cliente ADD FOREIGN KEY(id_idioma) REFERENCES idioma (id_idioma)
ALTER TABLE modelo_carro ADD FOREIGN KEY(id_montadora) REFERENCES montadora (id_montadora)
