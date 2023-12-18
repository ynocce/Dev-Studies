#Agrupamentos

select avg(salario) from tb_funcionario; 

select count(*) from tb_funcionario;

select sum(salario) from tb_funcionario;

select count(*) from tb_funcionario group by codigo_setor;

select count(*) from tb_funcionario  group by codigo_setor having avg(salario) >= 2000;