-- Correciones

-- CONSULTA 1
-- Sumatoria total que vendió cada empleado este año, pero solo aquellos empleados que no tengan como cargo Gerente ni Distribuidor.
SELECT p.nombre+''+p.apellido AS 'Empleado', SUM(df.precio_unitario * df.cantidad) AS 'Total vendido'
FROM Facturas f
JOIN Detalles_de_Factura df ON df.num_factura = f.num_factura
JOIN Empleados em ON em.id_empleado = f.id_empleado
JOIN Personas p ON p.id_persona = em.id_persona
WHERE em.id_cargo_empleado IN (SELECT id_cargo_empleado FROM Cargos_de_Empleado WHERE nombre != 'Gerente' AND nombre != 'Distribuidor')
AND YEAR(f.fecha_factura) = YEAR(GETDATE())
GROUP BY p.nombre+''+p.apellido;


--CONSULTA 2 (Lucas)
-- Venta total que hizo cada empleado, pero solo aquellos que en donde el promedio total de sus ventas de este año supere al promedio de ventas del año pasado. Como condición, los empleados deben tener más de 25 años.

SELECT p.nombre+''+p.apellido AS 'Nombre Empleado', SUM(df.precio_unitario * df.cantidad) AS 'Total Vendido'
FROM Facturas f
JOIN Detalles_de_Factura df ON df.num_factura = f.num_factura
JOIN Empleados em ON em.id_empleado = f.id_empleado
JOIN Personas p ON p.id_persona = em.id_persona
WHERE DATEDIFF(YEAR, p.fecha_nac, GETDATE()) > 25
AND YEAR(f.fecha_factura) = YEAR(GETDATE())
GROUP BY p.nombre+''+p.apellido
HAVING AVG(df.precio_unitario * df.cantidad) > (SELECT AVG(df1.precio_unitario * df1.cantidad) 
												FROM Detalles_de_Factura df1
												JOIN Facturas f1 ON f1.num_factura = df1.num_factura
												WHERE YEAR(f1.fecha_factura) = YEAR(GETDATE()) - 1);

--CONSULTA 3
-- Emitir un listado de los productos que no fueron vendidos. 
-- En ese listado solo incluir aquellos cuyo precio del artículo oscile entre 10000 y 50000.

SELECT id_producto AS 'Codigo', nombre AS 'Nombre Producto', precio AS 'Precio'
FROM Productos
WHERE precio BETWEEN 10000 AND 50000
AND id_producto NOT IN (SELECT pr.id_producto
						FROM Productos pr
						JOIN Detalles_de_Factura df ON df.id_producto = pr.id_producto
						JOIN Facturas f ON f.num_factura = df.num_factura
						WHERE YEAR(f.fecha_factura) = YEAR(GETDATE()));

--CONSULTA 4
-- Liste los datos de las facturas que solo se efectuaron en mayo y en donde el cliente sea mujer.

SELECT f.num_factura AS 'Numero Factura', f.fecha_factura AS 'Fecha Factura', cl.id_cliente AS 'Codigo Cliente', per.nombre+''+per.apellido AS 'Nombre Cliente'   
FROM Facturas f
JOIN Clientes cl ON cl.id_cliente = f.id_cliente
JOIN Personas per ON per.id_persona = cl.id_persona
WHERE MONTH(f.fecha_factura) = 5
AND cl.id_cliente IN (SELECT cl1.id_cliente
						FROM Clientes cl1
						JOIN Personas p ON p.id_persona = cl1.id_persona
						JOIN Generos g ON g.id_genero = p.id_genero
						WHERE g.nombre = 'Femenino');

-- CONSULTA 5
-- Cantidad de autos vendidos por marca y por mes de los últimos 2 años.
SELECT YEAR(f.fecha_factura) as 'Año', MONTH(f.fecha_factura) as 'Mes', ma.nombre AS 'Marca', SUM(df.cantidad) AS 'Total Autos Vendidos' 
FROM Marcas ma
JOIN Modelos mo ON ma.id_marca=mo.id_marca
JOIN Productos p ON mo.id_modelo = p.id_modelo
JOIN Detalles_de_Factura df ON df.id_producto = p.id_producto
JOIN Facturas f ON df.num_factura = f.num_factura
WHERE YEAR(f.fecha_factura) > YEAR(GETDATE())-2
GROUP BY YEAR(f.fecha_factura), MONTH(f.fecha_factura), ma.nombre
ORDER BY 1 DESC,2 DESC,3 ASC ,4 DESC;

-- CONSULTA 6
 --Lista de los empleados que en los últimos seis meses vendieron un monto total menor 
 --al promedio del acumulado en esos 6 meses (se divide en la cantidad de empleados que vendieron en ese lapso).

SELECT e.id_empleado AS 'ID Empleado', p.apellido+' '+p.nombre AS 'Nombre Completo', SUM(df.precio_unitario*df.cantidad) AS 'Total Vendido',MAX(fecha_factura)as 'Ultima Venta' 
FROM Empleados e, Personas p, Detalles_de_Factura df, Facturas f
WHERE YEAR(f.fecha_factura) = YEAR(GETDATE()) 
AND DATEDIFF(MONTH, f.fecha_factura, GETDATE()) <= 6
AND e.id_persona = p.id_persona AND f.id_empleado = e.id_empleado AND df.num_factura = f.num_factura
GROUP BY e.id_empleado, p.apellido+' '+p.nombre
HAVING SUM(df.precio_unitario * df.cantidad) < (SELECT AVG(df1.precio_unitario * df1.cantidad)												
												FROM Detalles_de_Factura df1, Facturas f1 
												WHERE YEAR(f1.fecha_factura) = YEAR(GETDATE()) 
												AND DATEDIFF(MONTH, f1.fecha_factura, GETDATE()) <= 6 
												AND f1.num_factura = df1.num_factura)
ORDER BY 2 ASC, 3 DESC;

-- CONSULTA 7
-- Modelos de automoviles que no fueron vendidos entre los años 2015 y 2017. Luego ordenar por codigo en forma descendiente y modelo de forma ascendente.
SELECT pr.id_producto AS 'Codigo Producto', mo.nombre AS 'Modelo'
FROM Productos pr
JOIN Modelos mo ON mo.id_modelo = pr.id_modelo
AND pr.id_producto NOT IN (SELECT df.id_producto 
							 FROM Detalles_de_Factura df
							 JOIN Facturas f ON f.num_factura = df.num_factura
							 WHERE YEAR(f.fecha_factura) BETWEEN '2015' AND '2017')
ORDER BY 1 DESC, 2 ASC;

-- CONSULTA 8
-- Listar todos empleados con sus Totales de facturación mensual(2019) y Promedios de facturación mensual(2019), de solo aquellos en donde su 
-- promedio de facturacion sea menor al del año pasado y que todos aquellos empleados tengan cargo de vendedor 
-- y que tengan más de un año de antiguedad en la empresa.

SELECT MONTH(f.fecha_factura) AS 'Mes', p.nombre+' '+p.apellido AS 'Empleado', SUM(df.precio_unitario * df.cantidad) AS 'Total Factura', AVG(df.precio_unitario * df.cantidad) AS 'Promedio Facturado'
FROM Facturas f
JOIN Detalles_de_Factura df ON df.num_factura = f.num_factura
JOIN Empleados e ON e.id_empleado = f.id_empleado
JOIN Personas p ON p.id_persona = e.id_persona
JOIN Cargos_de_Empleado ce ON e.id_cargo_empleado = ce.id_cargo_empleado
WHERE ce.nombre = 'Vendedor'
AND DATEDIFF(YEAR, e.fecha_insercion, GETDATE()) > 1
AND YEAR(f.fecha_factura) = '2019'
GROUP BY MONTH(f.fecha_factura), p.nombre+' '+p.apellido
HAVING AVG(df.precio_unitario * df.cantidad) < (SELECT AVG(df1.precio_unitario * df1.cantidad) 
												FROM Detalles_de_Factura df1
												JOIN Facturas f1 ON f1.num_factura = df1.num_factura
												WHERE YEAR(f1.fecha_factura) = YEAR(GETDATE()) - 1)
ORDER BY 2 ASC, 3 DESC;



