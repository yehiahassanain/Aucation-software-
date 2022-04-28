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
alter table admin 
add (items varchar(20));

create table relation_user_admin (user_id_fk number(20) primary key,
admin_id_fk number(20),
constraint user_fk foreign key (user_id_fk) references Aucation_user(user_id),
constraint admin_fk foreign key (admin_id_fk) references admin(admin_id)
);


--insert in table aucation_user
insert into Aucation_user (name, email, user_id, password)
values ('Mohamed Ali','mohamedali@gmail.com',1,'mohamed12')
insert into Aucation_user (name, email, user_id, password)
values ('Youssef mahmoud','youssefmahmoud@gmail.com',2,'youssef12')
insert into Aucation_user (name, email, user_id, password)
values ('ahmed mahmoud','ahmedmahmoud@gmail.com',3,'ahmed12')
insert into Aucation_user (name, email, user_id, password)
values ('ali mahmoud','alimahmoud@gmail.com',4,'ali12')
insert into Aucation_user (name, email, user_id, password)
values ('monna mahmoud','monnamahmoud@gmail.com',5,'monna12')
insert into Aucation_user (name, email, user_id, password)
values ('nour mahmoud','nourahmoud@gmail.com',6,'nour12')
insert into Aucation_user (name, email, user_id, password)
values ('adel mahmoud','adelmahmoud@gmail.com',7,'adel12')
--update in coulme adv_id
update Aucation_user set adv_id = 2 WHERE user_id = 1;
update Aucation_user set adv_id = 2 WHERE user_id = 2;
update Aucation_user set adv_id = 3 WHERE user_id = 3;
update Aucation_user set adv_id = 3 WHERE user_id = 4;
update Aucation_user set adv_id = 4 WHERE user_id = 5;
update Aucation_user set adv_id = 3 WHERE user_id = 6;
update Aucation_user set adv_id = 4 WHERE user_id = 7;
--insert in table advertiser
insert into advertiser (name, advertiser_id, password, items)
values ('Hossam ahmed',2,10,'watch')
update advertiser set items = 'watch,TV,fridge' WHERE advertiser_id = 2;
insert into advertiser (name, advertiser_id, password, items)
values ('Sayed ahmed',3,11,'TV,painting,house')
insert into advertiser (name, advertiser_id, password, items)
values ('mostafa aweed',4,12,'gold_plate,watch,TV')
--insert in table admin
insert into admin (name, admin_id, password, email, price, credit_card, items)
values ('Yehia hassanain',20191700753,'Yehia12','yehiahassanain@gmail.com',100,5078021159253408,'watch')
insert into admin (name, admin_id, password, email, price, credit_card, items)
values ('mohamed ahmed',20191600789,'mohamed15','mohamesahmed@gmail.com',5000,5078021159253488,'TV')
insert into admin (name, admin_id, password, email, price, credit_card, items)
values ('Essra mohamed',20191800853,'Essraa12','essramohamed@gmail.com',1000,5078021159258403,'fridge')
insert into admin (name, admin_id, password, email, price, credit_card, items)
values ('mohamed hassanain',20291700853,'mohamed12','mohamedhassanain@gmail.com',6000,5078028159553408,'painting')
insert into admin (name, admin_id, password, email, price, credit_card, items)
values ('ali ahmed',20191500623,'ali12','aliahmed@gmail.com',200000,5078021859253408,'house')
insert into admin (name, admin_id, password, email, price, credit_card, items)
values ('Nawal amin',20691500783,'nawal12','Nawalamin@gmail.com',4000,8078021159253408,'gold_plate')

--update in table admins
update admin set adv_admin_id = 3 WHERE admin_id = 20191600789;
update admin set adv_admin_id = 2 WHERE admin_id = 20191800853;
update admin set adv_admin_id = 4 WHERE admin_id = 20191700753;
update admin set adv_admin_id = 2 WHERE admin_id = 20191800853;
update admin set adv_admin_id = 3 WHERE admin_id = 20291700853;
update admin set adv_admin_id = 4 WHERE admin_id = 20191500623;
update admin set adv_admin_id = 4 WHERE admin_id = 20691500783;

--insert in table relation_user_admin
insert into relation_user_admin (user_id_fk,admin_id_fk)
values (1,20191700753)
insert into relation_user_admin (user_id_fk,admin_id_fk)
values (2,20191600789)
insert into relation_user_admin (user_id_fk,admin_id_fk)
values (3,20191800853)
insert into relation_user_admin (user_id_fk,admin_id_fk)
values (4,20191800853)
insert into relation_user_admin (user_id_fk,admin_id_fk)
values (5,20291700853)
insert into relation_user_admin (user_id_fk,admin_id_fk)
values (6,20191500623)
insert into relation_user_admin (user_id_fk,admin_id_fk)
values (7,20691500783)

--desc advertiser;