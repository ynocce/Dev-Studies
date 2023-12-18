#Alter e Drop

create database teste;

use teste;

create table tb_teste1 (codigo int(11)); 

create table tb_teste2 (codigo int(11));

drop table tb_teste1;

drop database teste; 



use jonns;


ALTER TABLE tb_dependentes RENAME tb_dependente;

ALTER TABLE tb_enderecos RENAME tb_endereco; 

ALTER TABLE tb_pedidos RENAME tb_pedido;

ALTER TABLE tb_emails RENAME tb_email;

ALTER TABLE tb_funcionario add salario float(11,2); 



update tb_funcionario set salario = 2500 where codigo = 1;
update tb_funcionario set salario = 1500 where codigo = 2; 
update tb_funcionario set salario = 3500 where codigo = 3; 
update tb_funcionario set salario = 3000 where codigo = 4; 
update tb_funcionario set salario = 1500 where codigo = 5; 
update tb_funcionario set salario = 2500 where codigo = 6; 
update tb_funcionario set salario = 4500 where codigo = 7; 
update tb_funcionario set salario = 1500 where codigo = 8; 
update tb_funcionario set salario = 3500 where codigo = 9; 
update tb_funcionario set salario = 3000 where codigo = 10;
update tb_funcionario set salario = 2500 where codigo = 11; 
update tb_funcionario set salario = 5000 where codigo = 12; 





