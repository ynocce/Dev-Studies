#-- Setup Database Jonns --#

CREATE DATABASE jonns;

USE jonns;

CREATE TABLE tb_setor (
	codigo int(11) primary key not null auto_increment,
	nome varchar(45) not null
);


CREATE TABLE tb_funcionario (
	codigo int(11) primary key not null auto_increment, 
	nome varchar(45) not null,
	sobrenome varchar(45) not null, 
	cpf int(11) unique not null, 
	rg int(11) unique not null,
	codigo_setor int(11),

	 foreign key (codigo_setor) references tb_setor(codigo)
);

CREATE TABLE tb_dependentes (
	codigo int(11) primary key not null auto_increment, 
	nome varchar(45) not null,
	sobrenome varchar(45) not null, 
	cpf int(11) unique not null, 
	rg varchar(11) unique not null,
	codigo_funcionario int(11),

	foreign key (codigo_funcionario) references tb_funcionario(codigo)
);

CREATE TABLE tb_telefone_funcionario (
	codigo int(11) primary key not null auto_increment, 
	codigo_area int(45) not null,
	numero varchar(45) not null, 
	codigo_funcionario int(11),

	foreign key (codigo_funcionario) references tb_funcionario(codigo)
);

CREATE TABLE tb_clientes (
	codigo int(11) primary key not null auto_increment, 
	nome varchar(45) not null,
	sobrenome varchar(45) not null, 
	cpf int(11) unique not null, 
	rg int(11) unique not null
);

CREATE TABLE tb_pedidos (
	nr_pedido int(11) primary key not null, 
	cpf_cliente int(11) not null,

	foreign key (cpf_cliente) references tb_clientes(cpf)
);

CREATE TABLE tb_emails (
	codigo int(11) primary key not null auto_increment, 
	email varchar(45) not null,
	codigo_cliente int(11),

	foreign key (codigo_cliente) references tb_clientes(codigo)
);


CREATE TABLE tb_enderecos (
	codigo int(11) primary key not null auto_increment, 
	logradouro varchar(45) not null,
	bairro varchar(45) not null,
	estado varchar(45) not null,
	cep int(11) not null
);

CREATE TABLE tb_aux_cliente_endereco (
	codigo_cliente int(11) not null,
    codigo_endereco int(11) not null,
    
    foreign key (codigo_cliente) references tb_clientes(codigo),
    foreign key (codigo_endereco) references tb_enderecos(codigo)
);

CREATE TABLE tb_aux_funcionario_endereco (
	codigo_funcionario int(11) not null,
	codigo_endereco int(11) not null,

	foreign key (codigo_funcionario) references tb_funcionario(codigo),
	foreign key (codigo_endereco) references tb_enderecos(codigo)
);

CREATE TABLE tb_atendimento_funcionarios_cliente (
	data_atendimento DATE not null,
    codigo_funcionario int(11) not null,
	codigo_cliente int(11) not null,

	foreign key (codigo_funcionario) references tb_funcionario(codigo),
	foreign key (codigo_cliente) references tb_clientes(codigo)
);


