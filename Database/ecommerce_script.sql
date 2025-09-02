--use master;
--go
--drop database if exists ecommerce;
--go
--create database ecommerce collate Croatian_CI_AS;
--go
--use ecommerce;

create table users(
[user_id] int not null primary key identity(1000,1),
first_name varchar(50) not null,
last_name varchar(50) not null,
email varchar(255) not null unique,
password_hash varchar(255) not null,
phone_number varchar(30)
);

create table addresses(
address_id int not null primary key identity(1,1),
[user_id] int not null references users([user_id]),
address_line_1 varchar(255) not null,
address_line_2 varchar(255),
city varchar(50) not null,
postal_code varchar(20) not null,
country varchar(100) not null,
address_type varchar(20) not null check (address_type in ('billing','shipping'))
);

create table categories(
category_id int not null primary key identity(1,1),
category_name varchar(100) not null,
[description] varchar(max)
);

create table products(
product_id int not null primary key identity(1000,1),
category_id int not null references categories(category_id),
[name] varchar(255) not null,
[description] varchar(max),
price decimal(10,2) not null,
sku varchar(100) not null unique,
stock_quantity int not null default 0,
image_url varchar(2048)
);

create table orders(
order_id int not null primary key identity(1000,1),
[user_id] int not null references users([user_id]),
total_amount decimal (10,2) not null,
order_status varchar(30) not null,
order_date datetime not null default getdate(),
shipping_address_id int not null references addresses(address_id),
billing_address_id int not null references addresses(address_id)
);

create table carts(
quantity int not null default 1,
[user_id] int not null references users([user_id]),
product_id int not null references products(product_id),
primary key ([user_id], product_id)
);

create table product_order(
product_order_id int not null primary key identity(1,1),
product_id int not null references products(product_id),
order_id int not null references orders(order_id),
price decimal(10,2) not null,
quantity int not null default 1
);

create table payments(
payment_id int not null primary key identity(1,1),
[user_id] int not null references users([user_id]),
order_id int not null references orders(order_id),
pay_method varchar(100) not null,
total_amount decimal(10,2) not null,
payment_status varchar(100) check (payment_status in ('pending','completed','failed','refunded')),
payment_date datetime
);



