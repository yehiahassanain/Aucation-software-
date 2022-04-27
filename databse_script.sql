create table Aucation_user (name varchar2(20) NOT NULL,
email varchar2(30) NOT NULL,
user_id number(20) primary key,
password varchar2(30) unique not null,
);
alter table Aucation_user 
add (adv_id number(20),
constraint adv_fk foreign key (adv_id) references advertiser(advertiser_id));

create table advertiser (name varchar2(20) NOT NULL,
advertiser_id number(20),
password varchar2(20) unique not null,
items varchar2(20) not null,
constraint adver primary key(advertiser_id));

create table admin (name varchar2(20) NOT NULL,
admin_id number(20) primary key,
password varchar2(20) unique not null,
email varchar2(30) NOT NULL,
price varchar2(20) NOT NULL,
credit_card number(16) unique);

alter table admin 
add (adv_admin_id number(20),
constraint adm_fk foreign key (adv_admin_id) references advertiser(advertiser_id));

create table relation_user_admin (user_id_fk number(20) primary key,
admin_id_fk number(20),
constraint user_fk foreign key (user_id_fk) references Aucation_user(user_id),
constraint admin_fk foreign key (admin_id_fk) references admin(admin_id)
);


--desc advertiser;