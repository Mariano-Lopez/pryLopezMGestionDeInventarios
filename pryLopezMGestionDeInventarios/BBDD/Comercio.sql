CREATE DATABASE Comercio;

USE Comercio;

Drop table productos;

CREATE TABLE Productos (
    Codigo INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255),
    Precio INT NOT NULL,
    Stock INT NOT NULL,
    Categoria VARCHAR(50) NOT NULL
);




INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock, Categoria) VALUES
(1, 'Auriculares Bluetooth', 'Auriculares inalámbricos con micrófono y cancelación de ruido', 4500, 15, 'Electronicos'),
(2, 'Cargador USB-C', 'Cargador rápido de 20W compatible con smartphones', 2200, 30, 'Electronicos'),
(3, 'Cuaderno A4 Rayado', 'Cuaderno de 100 hojas, tapa dura, rayado', 900, 50, 'Bazar/Librería'),
(4, 'Lapicera Gel Azul', 'Lapicera de tinta gel azul, trazo fino', 150, 100, 'Bazar/Librería'),
(5, 'Arroz Largo Fino', 'Paquete de arroz de 1kg, tipo largo fino', 750, 80, 'Alimentos'),
(6, 'Fideos Spaghetti', 'Paquete de fideos tipo spaghetti de 500g', 500, 65, 'Alimentos'),
(7, 'Perfume Floral Mujer', 'Fragancia floral dulce para uso diario', 9500, 20, 'Perfumes'),
(8, 'Perfume Amaderado Hombre', 'Colonia masculina con notas amaderadas', 8900, 18, 'Perfumes'),
(9, 'Lavandina 1L', 'Lavandina desinfectante con aroma a limón', 400, 40, 'Limpieza'),
(10, 'Detergente Líquido', 'Detergente líquido concentrado para cocina', 750, 35, 'Limpieza'),
(11, 'Cable HDMI 2m', 'Cable HDMI 2.0 de alta velocidad, 2 metros', 1800, 25, 'Electronicos'),
(12, 'Mouse Óptico USB', 'Mouse óptico con cable USB, 1200 DPI', 1300, 22, 'Electronicos'),
(13, 'Bolígrafo Negro', 'Bolígrafo tinta negra, punta mediana', 120, 200, 'Bazar/Librería'),
(14, 'Galletitas Dulces', 'Paquete de galletitas sabor vainilla', 600, 75, 'Alimentos'),
(15, 'Shampoo Anticaspa', 'Shampoo con fórmula anticaspa, 400ml', 2200, 28, 'Limpieza'),
(16, 'Desodorante Spray', 'Desodorante en aerosol de larga duración', 1700, 32, 'Limpieza'),
(17, 'Set de Marcadores', 'Set de 12 marcadores de colores variados', 1600, 45, 'Bazar/Librería'),
(18, 'Auriculares Cableados', 'Auriculares con cable, conector 3.5mm', 1000, 27, 'Electronicos'),
(19, 'Aceite Girasol 900ml', 'Aceite comestible de girasol', 1300, 60, 'Alimentos'),
(20, 'Colonia Infantil', 'Colonia suave para niños, sin alcohol', 4500, 19, 'Perfumes');


select * FROM productos;

DELETE FROM productos where Codigo=0;


set DATEFORMAT mdy;

CREATE TABLE Usuarios (
    id INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    contraseña VARCHAR(255),
    estado BIT,
    ultcon DATETIME NOT NULL,
	intentos int NOT NULL
);


drop table usuarios;

INSERT INTO Usuarios (id, nombre, contraseña, estado, ultcon, intentos)
VALUES 
(1, 'mariano', 'asd1', 1, '2025-05-03 18:30:00', 3),
(2, 'facundo', 'asd1', 1, '2025-05-03 18:30:00', 3),
(3,'admin', 'admin', 1, '2025-05-03 18:30:00', 3);

UPDATE Usuarios SET estado = 1, intentos = 3 WHERE id = 1;

select * from usuarios;