select p.name , c.name
from Product p 
left join ProductCategory pc on p.id = pc.productId
left join Category c on c.id = pc.categoryId
