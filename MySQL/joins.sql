#Joins

select tb_funcionario.nome, tb_setor.nome from tb_funcionario 
		inner join tb_setor on tb_funcionario.codigo_setor = tb_setor.codigo;
        
        

select tb_funcionario.nome, tb_funcionario.sobrenome, tb_endereco.logradouro from tb_funcionario 
		inner join tb_aux_funcionario_endereco 
        inner join tb_endereco 
			on  tb_funcionario.codigo = tb_aux_funcionario_endereco .codigo_funcionario 
				and 
			    tb_endereco.codigo = tb_aux_funcionario_endereco .codigo_endereco;
                
                

select tb_funcionario.nome, tb_setor.nome from tb_funcionario 
		left join tb_setor on tb_funcionario.codigo_setor = tb_setor.codigo;
        









select nome from tb_funcionarios
union
select nome from tb_setor;


select nome from tb_funcionarios
union all
select nome from tb_setor;



SELECT * FROM tb_funcionario
LEFT JOIN tb_setor ON tb_funcionario.codigo_setor = tb_setor.codigo
UNION
SELECT * FROM tb_funcionario
RIGHT JOIN tb_setor ON tb_funcionario.codigo_setor = tb_setor.codigo;


