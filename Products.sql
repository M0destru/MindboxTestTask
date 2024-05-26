SELECT p.name As 'Имя продукта', c.name AS 'Имя категории'
FROM products p
	LEFT JOIN product_categories pc ON pc.product_id = p.id
	LEFT JOIN categories c ON c.id = pc.category_id;