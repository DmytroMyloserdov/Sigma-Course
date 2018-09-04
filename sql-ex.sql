/*1*/
SELECT model, speed, hd 
FROM PC 
WHERE price < 500


/*2*/
SELECT DISTINCT maker 
FROM Product 
WHERE type LIKE 'Printer'


/*3*/
SELECT model, ram, screen 
FROM Laptop 
WHERE price > 1000


/*4*/
SELECT * 
FROM Printer 
WHERE color LIKE 'y'


/*5*/
SELECT model, speed, hd 
FROM PC 
WHERE (cd LIKE '12x' OR cd LIKE '24x') AND price < 600


/*6*/
SELECT DISTINCT maker, speed
FROM Product INNER JOIN
Laptop ON Laptop.model = Product.model AND type = 'Laptop' AND hd >= 10


/*7*/
SELECT PC.model, price 
FROM PC 
JOIN Product ON Product.model = PC.model AND Product.maker LIKE 'B'
UNION 
SELECT Laptop.model, price 
FROM Laptop 
JOIN Product ON Product.model = Laptop.model AND Product.maker LIKE 'B'
union
SELECT Printer.model, price 
FROM Printer 
JOIN Product ON Product.model = Printer.model AND Product.maker LIKE 'B'


/*8*/
SELECT DISTINCT maker
FROM Product
WHERE type LIKE 'PC' AND 
      maker NOT IN (SELECT maker 
                    FROM Product 
                    WHERE type LIKE 'Laptop'
					)


/*9*/
SELECT DISTINCT maker
FROM Product 
JOIN PC ON PC.model = Product.model
WHERE PC.speed >= 450


/*10*/
SELECT DISTINCT model, price 
FROM Printer 
WHERE price = (SELECT MAX(price) FROM Printer)


/*11*/
SELECT AVG(speed) FROM PC


/*12*/
SELECT AVG(speed) 
FROM Laptop 
WHERE price > 1000


/*13*/
SELECT AVG(speed) 
FROM PC 
JOIN Product ON Product.model = PC.model
WHERE Product.maker LIKE 'A'


/*14*/
SELECT maker, MAX(type)
FROM Product
GROUP BY maker
HAVING COUNT(model) > 1 AND COUNT(DISTINCT type) = 1


/*15*/
SELECT hd
FROM PC
GROUP BY hd
HAVING COUNT(hd) >= 2


/*16*/
SELECT DISTINCT f.model, s.model, f.speed, f.ram 
FROM PC f, PC s
WHERE f.speed = s.speed AND 
	  f.ram = s.ram AND 
	  f.model > s.model


/*17*/
SELECT DISTINCT p.type, l.model, l.speed 
FROM Laptop l, Product p
WHERE l.speed < ALL (SELECT speed FROM PC) AND 
	  type LIKE 'Laptop'


/*18*/
SELECT DISTINCT Product.maker, Printer.price 
FROM Printer, Product
WHERE price = (SELECT MIN(price) 
			   FROM Printer 
			   WHERE color LIKE 'y'
			   ) AND 
      Printer.color LIKE 'y' AND 
	  maker = (SELECT maker 
			   FROM Product 
			   WHERE model = Printer.model
			   )


/*19*/
SELECT maker, AVG(screen) AS Avg_screen 
FROM Product 
JOIN Laptop ON Laptop.model = Product.model
GROUP BY maker


/*20*/
SELECT maker, COUNT(maker) AS Count_model 
FROM Product 
GROUP BY maker, type
HAVING type LIKE 'PC' AND COUNT(*) >= 3


/*21*/
SELECT p.maker, MAX(price) 
FROM Product p
JOIN PC ON PC.model = p.model
GROUP BY p.maker


/*22*/
SELECT p.speed, AVG(price)
FROM PC p
WHERE p.speed > 600 AND
      p.price IN (SELECT price 
				  FROM PC 
				  WHERE speed = p.speed
				  )
GROUP BY speed


/*23*/
SELECT DISTINCT p.maker 
FROM Product p
JOIN PC ON PC.model = p.model AND PC.speed >= 750
INTERSECT
SELECT DISTINCT p.maker 
FROM Product p
JOIN Laptop l ON p.model = l.model AND l.speed >= 750


/*24*/
WITH Model_Price(model, price) AS 
(
	SELECT p.model, MAX(price) Max_price FROM PC
	JOIN Product p ON p.model = PC.model
	GROUP BY p.model
	UNION
	SELECT p.model, MAX(price) Max_price FROM Laptop l
	JOIN Product p ON p.model = l.model
	GROUP BY p.model
	UNION
	SELECT p.model, MAX(price) Max_price FROM Printer
	JOIN Product p ON p.model = Printer.model
	GROUP BY p.model
)
SELECT model 
FROM Model_Price
WHERE price = (SELECT MAX(price) FROM Model_Price)


/*25*/
SELECT DISTINCT p.maker 
FROM Product p
WHERE p.model IN (SELECT DISTINCT model FROM PC
				  WHERE speed = (SELECT MAX(speed) FROM PC WHERE ram = (SELECT MIN(ram) FROM PC)) AND
				  ram = (SELECT MIN(ram) FROM PC)
				 ) AND 
	  p.maker IN (SELECT maker 
				  FROM Product 
				  WHERE type LIKE 'Printer'
				 )


/*26*/
SELECT AVG(price) 
FROM (SELECT price 
	  FROM PC
	  WHERE model IN (SELECT model 
					  FROM Product 
					  WHERE maker LIKE 'A' AND 
					        type LIKE 'PC'
				     )
	  UNION
	  SELECT price 
	  FROM Laptop 
	  WHERE model IN (SELECT model 
					  FROM Product 
					  WHERE maker LIKE 'A' AND 
						    type LIKE 'Laptop'
					 )
	 ) as a


/*27*/
SELECT Product.maker, AVG(PC.hd)
FROM Product, PC
WHERE Product.type LIKE 'PC' AND 
	  Product.model = PC.model AND 
	  EXISTS(SELECT 'x' FROM Product p
			 WHERE p.maker = Product.maker AND 
			       p.type LIKE 'Printer'
		    )
GROUP BY Product.maker


/*28*/
SELECT COUNT(*) 
FROM (SELECT COUNT(*) as count FROM Product
	  GROUP BY maker
	  HAVING COUNT(*) = 1
	 ) as a
