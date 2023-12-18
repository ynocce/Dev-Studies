drop schema auladb;
create schema auladb;
use auladb;

CREATE TABLE `departamento` (
  `numero` int(11) NOT NULL,
  `nome` varchar(255) DEFAULT NULL,
  `fk_empregado_numero_seguro_social` char(20) DEFAULT NULL,
  `gerencia_data_inicio` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `dependente` (
  `nascimento` date NOT NULL,
  `nome` varchar(255) NOT NULL,
  `certidao_nascimento` int(11) NOT NULL,
  `fk_empregado_numero_seguro_social` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `empregado` (
  `numero_seguro_social` char(20) NOT NULL,
  `nome` varchar(255) DEFAULT NULL,
  `salario` decimal(8,2) DEFAULT NULL,
  `sexo` char(20) DEFAULT NULL,
  `nascimento` date DEFAULT NULL,
  `fk_departamento_alocado` int(11) DEFAULT NULL,
  `fk_empregado_supervisiona` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;




INSERT INTO departamento (`numero`, `nome`, `fk_empregado_numero_seguro_social`, `gerencia_data_inicio`) VALUES
(11, 'Departamento de Tecnologia', '111313134', '2020-01-01'),
(52, 'Departamento de Artes', '1237132131', '2016-04-08'),
(33, 'Departamento de Segurança', '111121314', '2019-03-10'),
(44, 'Departamento de Desenvolvimento', '156456123', '2020-08-31'),
(55, 'Departamento de recursos humanos', '123154667', '2022-12-25');

INSERT INTO `dependente` (`nascimento`, `nome`, `certidao_nascimento`, `fk_empregado_numero_seguro_social`) VALUES
('2012-11-10', 'Bernardo Nascimento', 'nascimento63456436', '123131111'),
('1999-02-30', 'Jose Carlos Nascimento Junior', '684568568', '24631312512'),
('2001-01-25', 'Jose Carlos Nascimento Junior', '3959359359', '2654646466'),
('1998-02-10', 'Jose Carlos Nascimento Junior', '56439364', '12354356462'),
('2001-08-13', 'Clara Nunes', 2015032011, '5767572342');

INSERT INTO `empregado` (`numero_seguro_social`, `nome`, `salario`, `sexo`, `nascimento`, `fk_departamento_alocado`, `fk_empregado_supervisiona`) VALUES
('1111111111', 'Rodrigo Pacheco', '29350.50', 'Masculino', '1990-03-01', NULL, NULL),
('222222222', 'Jose Carlos Nascimento', '550.50', 'Masculino', '1970-01-12', NULL, NULL),
('333333333', 'Jose Carlos Nascimento', '900.50', 'Masculino', '1953-05-29', NULL, NULL),
('44444444', 'Jose Carlos Nascimento', '340.50', 'Masculino', '1988-01-31', NULL, NULL),
('7777777777', 'Jose Carlos Nascimento', '600.50', 'Masculino', '1977-08-10', NULL, NULL);

CREATE TABLE `localizacao` (
  `id_localizacao` int(11) NOT NULL,
  `logradouro` varchar(255) DEFAULT NULL,
  `cep` char(8) NOT NULL,
  `bairro` varchar(255) DEFAULT NULL,
  `cidade` varchar(255) DEFAULT NULL,
  `UF` char(2) DEFAULT NULL,
  `fk_departamento_numero` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `localizacao` (`id_localizacao`, `logradouro`, `cep`, `bairro`, `cidade`, `UF`, `fk_departamento_numero`) VALUES
(13, 'Rua Belem', '23445555', 'Centro', 'Londrina', 'PR', 1),
(05, 'Rua Belem', '64546654', 'Centro', 'São paulo', 'SP', 2),
(23, 'Rua Belem', '45634555', 'Centro', 'Bahia', 'BH', 3),
(54, 'Rua Belem', '53454120', 'Centro', 'Los Los', 'Los', 4),
(65, 'R. José Corrêa de Águiar', '87053276', 'Jardim Leblon', 'Maringá', 'PR', 5);

CREATE TABLE `projeto` (
  `nome` varchar(255) DEFAULT NULL,
  `numero` int(11) NOT NULL,
  `logradouro` varchar(255) DEFAULT NULL,
  `cep` char(8) NOT NULL,
  `bairro` varchar(255) DEFAULT NULL,
  `cidade` varchar(255) DEFAULT NULL,
  `UF` char(2) DEFAULT NULL,
  `fk_departamento_numero` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `projeto` (`nome`, `numero`, `logradouro`, `cep`, `bairro`, `cidade`, `UF`, `fk_departamento_numero`) VALUES
('Sistema de Controle Escolar', 1, 'Rua Rafeael', '8000234', 'Centro', 'São paulo', 'SP', 1),
('Sistema de Carros', 2, 'Rua mario nunes', '81456666', 'Centro', 'São Paulo', 'SP', 2),
('Sistema de Logistica', 3, 'Rua marancadu', '85435345', 'Centro', 'Rio de janeiro', 'RJ', 3),
('Sistema de Segurança', 4, 'Rua Maracaru', '81920380', 'Centro', 'Curitiba', 'PR', 4),
('Sistema de Controle de Projetos', 5, 'R. José Corrêa de Águiar', '87053276', 'Jardim Leblon', 'Maringá', 'PR', 5);

CREATE TABLE `projeto_empregado_trabalha` (
  `data_inicio_semana` date NOT NULL,
  `horas_trabalhadas` decimal(2,2) DEFAULT NULL,
  `fk_empregado_numero_seguro_social` char(20) NOT NULL,
  `fk_projeto_numero` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `projeto_empregado_trabalha` (`data_inicio_semana`, `horas_trabalhadas`, `fk_empregado_numero_seguro_social`, `fk_projeto_numero`) VALUES
('2019-03-14', '5', '9139193193', '645645646'),
('2013-03-14', '15', '66469193193', '45645646'),
('2000-02-14', '5', '1239193193', '5645646'),
('2022-03-12', '34', '88793193', '8945646'),
('2021-02-23', '45', '65653193', '5464546');
