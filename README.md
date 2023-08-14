Задача: В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.

Создание таблиц
--------------
CREATE TABLE Products(
id INT PRIMARY KEY IDENTITY,
name NVARCHAR(100) NOT NULL);

CREATE TABLE Categories(
id INT PRIMARY KEY IDENTITY,
name NVARCHAR(100) NOT NULL);

CREATE TABLE CategoryProducts(
productId INT NOT NULL,
categoryId INT NOT NULL,
FOREIGN KEY(productId) REFERENCES Products(id) ON DELETE CASCADE,
FOREIGN KEY(categoryId) REFERENCES Categories(id) ON DELETE CASCADE);
----------------
Заполнение данными
__________________
INSERT INTO Products VALUES('Компьютер'), ('Ноутбук'), ('Телефон');
INSERT INTO Products VALUES('Компьютеры'), ('Телефоны');
INSERT INTO CategoryProducts VALUES(1,1), (2,1), (3,2);
___________________

Задача:

SELECT p.name AS product, c.name AS category FROM Products AS p
LEFT JOIN CategoryProducts AS cp ON p.id = cp.productId
INNER JOIN Categories AS c ON c.id = cp.categoryId
ORDER BY product;
