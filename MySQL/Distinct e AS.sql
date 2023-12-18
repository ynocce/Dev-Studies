#Distinct e AS

select format((((5+5)*2)/codigo),2) from tb_funcionario;

select format((((5+5)*2)/codigo),2) as formula_matematica from tb_funcionario;

select format((((5+5)*2)/codigo),2) as 'formula matematica' from tb_funcionario;

select distinct nome from tb_funcionario; 

select distinct nome, sobrenome from tb_funcionario; 