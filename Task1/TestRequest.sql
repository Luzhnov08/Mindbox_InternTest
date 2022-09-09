SELECT Products.name, Categories.ctg_name 
FROM Products 
LEFT JOIN Categories 
ON instr(Products.ctg_id, Categories.ctg_id) 
LEFT JOIN Products AS P
ON P.ctg_id = Categories.ctg_id
WHERE P.ctg_id IS NULL