


#-- Inserts database jonns --#

#Setor
insert into tb_setor (nome) values ('Vendas');
insert into tb_setor (nome) values ('Marketing');
insert into tb_setor (nome) values ('Financeiro');


insert into tb_setor (nome) values ('Informatica'),
                                   ('Recursos Humanos'),
                                   ('Diretoria');

#funcionarios
insert into tb_funcionario (nome, sobrenome, rg, cpf, codigo_setor) values ('Rafael', 'Silveira', 1111, 1111, 1),
																			('Pedro', 'Paliardi', 2222, 2222, 1),
																			('Jose', 'Silveira', 3333, 3333, 2),
																			('Augusto', 'Costa', 4444, 4444, 2),
																			('Rafael', 'Antunes', 5555, 5555, 3),
																			('Roberto', 'Camargo', 6666, 6666, 3),
																			('Joana', 'Nunes', 7777, 7777, 4),
																			('Manuela', 'Pereira', 8888, 8888, 5),
																			('Rafael', 'Montenegro', 9999, 9999, 6);
                                 
#dependentes
insert into tb_dependentes (nome, sobrenome, rg, cpf, codigo_funcionario) values ('Bruno', 'Nogueira', 1111, 1111, 1),
																				('leonardo', 'Paliardi', 2222, 2222, 1),
																				('Rafael', 'Silveira', 3333, 3333, 3),
																				('Renata', 'Silveira', 4444, 4444, 3),
																				('Joao', 'Costa', 5555, 5555, 4),
																				('Antonela', 'Antunes', 6666, 6666, 4),
																				('Manuela', 'Camargo', 7777, 7777, 5),
																				('Leandro', 'Camargo', 8888, 8888, 5),
																				('Douglas', 'Montenegro', 9999, 9999, 8);

#update
update tb_funcionario set sobrenome = 'Silva' where codigo = 1;
update tb_dependentes set sobrenome = 'Silva' where codigo_funcionario = 1;

#delete
delete from tb_funcionario where codigo = 2;
delete from tb_dependentes where codigo = 9;







INSERT INTO `jonns`.`tb_endereco` (`logradouro`, `bairro`, `estado`, `cep`) VALUES ('Endereco1', 'Bairro1', 'Estado', '1234311');
INSERT INTO `jonns`.`tb_endereco` (`logradouro`, `bairro`, `estado`, `cep`) VALUES ('Endereco2', 'Bairro2', 'Estado', '32112');
INSERT INTO `jonns`.`tb_endereco` (`logradouro`, `bairro`, `estado`, `cep`) VALUES ('Endereco3', 'Bairro3', 'Estado', '12331');
INSERT INTO `jonns`.`tb_endereco` (`logradouro`, `bairro`, `estado`, `cep`) VALUES ('Endereco4', 'Bairro4', 'Estado', '54889');
INSERT INTO `jonns`.`tb_endereco` (`logradouro`, `bairro`, `estado`, `cep`) VALUES ('Endereco5', 'Bairro4', 'Estado', '579624');
INSERT INTO `jonns`.`tb_endereco` (`logradouro`, `bairro`, `estado`, `cep`) VALUES ('Endereco6', 'Bairro5', 'Estado', '57824');
INSERT INTO `jonns`.`tb_endereco` (`logradouro`, `bairro`, `estado`, `cep`) VALUES ('Endereco7', 'Bairro5', 'Estado', '78932');
INSERT INTO `jonns`.`tb_endereco` (`logradouro`, `bairro`, `estado`, `cep`) VALUES ('Endereco8', 'Bairro6', 'Estado', '65989');
INSERT INTO `jonns`.`tb_endereco` (`logradouro`, `bairro`, `estado`, `cep`) VALUES ('Endereco9', 'Bairro6', 'Estado', '65798');

INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('1', '1');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('3', '2');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('4', '3');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('5', '4');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('6', '5');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('7', '6');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('8', '7');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('9', '8');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('10', '9');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('11', '8');
INSERT INTO `jonns`.`tb_aux_funcionario_endereco` (`codigo_funcionario`, `codigo_endereco`) VALUES ('12', '1');


INSERT INTO `jonns`.`tb_funcionario` (`nome`, `sobrenome`, `cpf`, `rg`) VALUES ('Funcionario', 'Sem Setor', '0', '0');

INSERT INTO `jonns`.`tb_setor` (`nome`) VALUES ('Setor sem Funcionario');








