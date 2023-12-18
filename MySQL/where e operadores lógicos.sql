#Where

select nome, sobrenome from tb_funcionario where nome = 'rafael';

select nome, sobrenome, salario from tb_funcionario where salario >= 2000;
 
select nome, sobrenome, codigo_setor from tb_funcionario where codigo_setor = 2;
 
select nome, sobrenome, salario from tb_funcionario where salario < 2000;


#Operadores auxiliares

select nome, cpf, salario from tb_funcionario where salario between 1500 and 2500;

select nome, salario, cpf from tb_funcionario where salario in (1000, 2000, 3000);
 
select nome, cpf from tb_funcionario where nome in ('Manuela', 'Rafael', 'Roberto');

select codigo, nome, cpf, salario from tb_funcionario where salario is null;

select nome from tb_funcionario where nome like 'P%';

select nome from tb_funcionario where nome like '%LA';

select nome from tb_funcionario where nome like '_A%';

select nome, sobrenome, salario, codigo_setor from tb_funcionario where salario >= 3000 and codigo_setor = 3;

select nome, sobrenome, salario, codigo_setor from tb_funcionario where salario >= 3000 or codigo_setor = 3;

select nome, sobrenome, salario, codigo_setor from tb_funcionario where not(salario >= 3000 and codigo_setor = 3);

#Ordenação

select nome, sobrenome from tb_funcionario order by nome;

select nome, sobrenome, salario from tb_funcionario where salario <= 3000 order by nome; 

select nome, sobrenome, salario from tb_funcionario where salario <= 3000 order by nome, sobrenome; 

select nome, sobrenome from tb_funcionario order by nome desc;


