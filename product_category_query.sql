CREATE TABLE products (
  id INT IDENTITY,
  name NVARCHAR(50),
  PRIMARY KEY (id)
);
INSERT products (name) VALUES 
  (N'МСЭ'),
  (N'SIEM'),
  (N'DLP'),
  (N'Антивирус'),
  (N'IDS');

CREATE TABLE categories (
  id INT IDENTITY,
  name NVARCHAR(50),
  PRIMARY KEY (id)
  );
INSERT categories (name) VALUES 
  (N'Первая категория'),
  (N'Вторая категория'),
  (N'Третья категория');

CREATE TABLE products_to_categories (
  id INT IDENTITY,
  product_id INT NOT NULL REFERENCES products(id),
  category_id INT NOT NULL REFERENCES categories(id),
  PRIMARY KEY (id)
);

INSERT products_to_categories (product_id,category_id) VALUES 
  ('2','3'), ('1','1'), ('4','2'), ('5','1'), ('2','2'), ('3','3'), ('4','3');

SELECT products.name, categories.name FROM products
LEFT JOIN products_to_categories ON products.id = products_to_categories.product_id
LEFT JOIN categories ON categories.id = products_to_categories.category_id;