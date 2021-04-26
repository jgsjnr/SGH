create database sgh;
use sgh;

create table users (users varchar(10) primary key, passwd varchar(10), nivel varchar(10));

insert into users values('admin', 'admin', 'admin');
insert into users values('user', 'user', 'user');

select * from users;

create table info (name varchar(60), cpf varchar(14) primary key, birthday varchar(8),
civil varchar(10), color varchar(15), blood varchar(5), alergy varchar(4), obs_alergy varchar(50),
resp varchar(4), name_resp varchar(50), cpf_resp varchar(14), address varchar(60),
comp varchar(10), city varchar(30), uf varchar(4), cep varchar(9), tel varchar(10), cel varchar(11),
email varchar(30), obs varchar(240));

select * from info;