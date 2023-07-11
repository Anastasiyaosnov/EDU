Создайте таблицу с мобильными телефонами, используя графический интерфейс.
Необходимые поля таблицы: product_name (название товара),
manufacturer (производитель), product_count (количество), price (цена).
Заполните БД произвольными данными.

ЗАДАЧА 1

DROP DATABASE IF EXISTS hw_1;
CREATE DATABASE hw_1;
USE hw_1;

CREATE TABLE mobile_phones(
	id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
	product_name VARCHAR(45) NOT NULL, 
	manufacturer VARCHAR(45) NOT NULL,
        product_count INT  NOT NULL,
	price BIGINT UNSIGNED
);

INSERT INTO mobile_phones (product_name, manufacturer, product_count, price)
VALUES 
('IPhoneX',	'Apple', '3',	76000),
('IPhone8', 'Apple', '2', 51000),
('Galaxy S9', 'Samsung', '2', 56000),
('Galaxy S8', 'Samsung', '1', 41000),
('P20 Pro', 'Huawei', '5', 36000);

ЗАДАЧА 2

SELECT product_name, manufacturer, price FROM mobile_phones
WHERE product_count > 2;

ЗАДАЧА 3

SELECT product_name, manufacturer, price FROM mobile_phones
WHERE manufacturer = 'Samsung';