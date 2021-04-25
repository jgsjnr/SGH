create database sgh;
use sgh;

create table users (users varchar(10) primary key, passwd varchar(10), nivel varchar(10));

insert into users values('admin', 'admin', 'admin');
insert into users values('user', 'user', 'user');

select * from users;

create table info (nome varchar(60), cpf varchar(14) primary key, nascimento varchar(8),
civil varchar(10), cor varchar(15), sangue varchar(5), alergia varchar(4), obs_alergia varchar(50),
responsavel varchar(4), nome_responsavel varchar(50), cpf_responsavel varchar(14), endereco varchar(60),
complemento varchar(10), cidade varchar(30), uf varchar(4), cep varchar(9), telefone varchar(10), celular varchar(11),
email varchar(30), obs varchar(240));