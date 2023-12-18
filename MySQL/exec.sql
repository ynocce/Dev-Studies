create database Clinica;
use Clinica;

create table ambulatorio(
	nroa int primary key,
	andar numeric(3) not null,
	capacidade smallint
);


create table medicos(
	codm int primary key,
    nome varchar(40) not null,
    idade smallint not null,
    especialidade char(40),
    cpf char(11) unique,
    cidade varchar(30),
    nroa integer,
	foreign key (nroa) references ambularorios(nroa)
);

create table Pacientes(
	codp integer primary key,
    nome varchar(40) not null,
    idade smallint not null,
    cidade  varchar(30),
    cpf char(11),
    doenca varchar(40) not null
);
create unique index cpf_paciente on medicos(cpf);

create table funcionarios(
	codf integer primary key,
    nome varchar(40) not null,
    idade smallint,
    cpf char(11) unique,
    cidade varchar(30),
    salario numeric(10,2),
    cargo varchar(20)
);

create table consultas(
	codm integer,
    codp integer,
    data date,
    hora time,
    primary key(codm, data, hora),
    foreign key(codm) references medicos(codm),
    foreign key(codp) references pacientes(codp)
);

select * from medicos;

insert into medicos values (6, "roberto", 30,"geral", 793249249, "São paulo");
insert into medicos values (1, "Joao", 40, "ortopedia", 10000100000, "Florianopolis", 1),
			(2, "Maria", 42, "traumatologia", 10000110000, "Blumenau", 2),
			(3, "Pedro", 51, "pediatria", 11000100000, "São José", 2),
			(4, "Carlos", 28, "ortopedia", 11000110000, "Joinville",null),
			(5, "Marcia", 33, "neurologia", 11000111000, "Biguacu",3);

insert into ambulatorio values(1, 1, 30),
								(2, 1, 50),
								(3, 2 ,40),
								(4, 2 ,25),
								(5, 2 ,55);

insert into Pacientes values (1, "Ana", 20, "Florianopolis", 20000200000, "gripe"),
(2, "Paulo" , 24, "Palhoca", 20000220000, "fratura"),
(3, "Lucia", 30, "Biguacu", 22000200000, "tendinite"),
(4 ,"Carlos" ,28 ,"Joinville",11000110000, "sarampo");
                                
insert into funcionarios values (1, "Rita", 32, "Sao Jose", 1200, "20000100000"),
(2, "Maria" ,55 ,"Palhoca", 1220, "30000110000"),
(3, "Caio", 45, "Florianopolis", 1100, "41000100000"),
(4, "Carlos", 44, "Florianopolis", 1200, "1000110000"),
(5, "Paula", 33, "Florianopolis", 2500, "61000111000");


                                
create unique index cpf_medico on medicos(cpf);