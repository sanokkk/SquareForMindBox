SELECT productName, categoryName 
FROM ProductCategory pc
	JOIN Product p  on pc.productId=p.productId
	LEFT JOIN Category c on pc.categoryId=c.categoryId;