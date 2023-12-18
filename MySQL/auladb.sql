drop schema auladb;
create schema auladb;
use auladb;

create table departamento(
	numero integer primary key,
    nome varchar(255),
    fk_empregado_numero_seguro_social char(20),
    gerencia_data_inicio date
);
create table Localizacao(
	id_localizacao integer not null unique primary key auto_increment,
    logradouro varchar(255),
    cep char(8) not null,
    bairro varchar(255), 
    cidade varchar(255),
    UF char(2),
    fk_departamento_numero integer,
    foreign key(fk_departamento_numero) references departamento(numero)
);
create table empregado(
	numero_seguro_social char(20) primary key,
    nome varchar(255),
    salario decimal(8,2), 
    sexo char(20),
    nascimento date,
    fk_departamento_alocado integer,
    foreign key(fk_departamento_alocado) 
    references departamento(numero),
    fk_empregado_supervisiona char(20),
    foreign key(fk_empregado_supervisiona)
    references empregado(numero_seguro_social)
);

CREATE TABLE DEPENDENTE(
	nascimento date not null,
    nome varchar(255) not null,
    certidao_nascimento int not null,
    fk_empregado_numero_seguro_social char(20),
    foreign key(fk_empregado_numero_seguro_social)
    references empregado(numero_seguro_social)
);

alter table departamento add 
constraint 
foreign key(fk_empregado_numero_seguro_social)
references empregado(numero_seguro_social);

create table projeto(
	nome varchar(255),
    numero integer primary key,
    logradouro varchar(255),
    cep char(8) not null,
    bairro varchar(255), 
    cidade varchar(255),
    UF char(2),
    fk_departamento_numero integer,
    foreign key(fk_departamento_numero) references departamento(numero)
);

create table projeto_empregado_trabalha(
	data_inicio_semana date,
    horas_trabalhadas decimal(2,2),
    fk_empregado_numero_seguro_social char(20),
    foreign key(fk_empregado_numero_seguro_social)
	references empregado(numero_seguro_social),
    fk_projeto_numero integer,
    foreign key(fk_projeto_numero) references projeto(numero),
    primary key(data_inicio_semana,fk_empregado_numero_seguro_social,fk_projeto_numero)
);

