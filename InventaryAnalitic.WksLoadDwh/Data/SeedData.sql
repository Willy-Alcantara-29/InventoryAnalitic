-- SQL Script to Seed Data for Power BI Sales Dashboard Demo
-- Run this against your Source Database

-- =============================================
-- 1. TABLE CREATION (Ensure Schema Exists)
-- =============================================

-- Clientes
IF OBJECT_ID ('dbo.Clientes', 'U') IS NULL BEGIN
CREATE TABLE dbo.Clientes (
    id int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    nombre nvarchar (max),
    ciudad nvarchar (max),
    pais nvarchar (max)
);

END

-- Productos
IF OBJECT_ID ('dbo.Productos', 'U') IS NULL BEGIN
CREATE TABLE dbo.Productos (
    id int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    nombre nvarchar (max),
    categoria nvarchar (max),
    precio decimal(18, 2)
);

END

-- Fuentes
IF OBJECT_ID ('dbo.Fuentes', 'U') IS NULL BEGIN
CREATE TABLE dbo.Fuentes (
    id int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    nombre nvarchar (max),
    tipo nvarchar (max)
);

END

-- Empleados
IF OBJECT_ID ('dbo.Empleados', 'U') IS NULL BEGIN
CREATE TABLE dbo.Empleados (
    id int NOT NULL PRIMARY KEY,
    nombre nvarchar (max),
    titulo nvarchar (max),
    pais nvarchar (max)
);

END

-- Ventas
IF OBJECT_ID ('dbo.Ventas', 'U') IS NULL BEGIN
CREATE TABLE dbo.Ventas (
    id int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    cliente_id int NOT NULL,
    producto_id int NOT NULL,
    fuente_id int NOT NULL,
    empleado_id int NOT NULL DEFAULT 0,
    fecha datetime2 NOT NULL,
    cantidad int NOT NULL,
    total decimal(18, 2) NOT NULL
);

END

-- =============================================
-- 2. DATA SEEDING (DIMENSIONS)
-- =============================================

-- Seed Fuentes
IF NOT EXISTS (
    SELECT *
    FROM Fuentes
) BEGIN
INSERT INTO
    Fuentes (nombre, tipo)
VALUES ('Web', 'Direct'),
    ('App', 'Mobile'),
    ('Partner', 'Referral');

END

-- Seed Clientes (More diverse)
IF(
    SELECT COUNT(*)
    FROM Clientes
) < 20 BEGIN
INSERT INTO
    Clientes (nombre, ciudad, pais)
VALUES (
        'Alfreds Futterkiste',
        'Berlin',
        'Germany'
    ),
    (
        'Ana Trujillo Emparedados',
        'Mexico D.F.',
        'Mexico'
    ),
    (
        'Antonio Moreno Taquería',
        'Mexico D.F.',
        'Mexico'
    ),
    (
        'Around the Horn',
        'London',
        'UK'
    ),
    (
        'Berglunds snabbköp',
        'Luleå',
        'Sweden'
    ),
    (
        'Blauer See Delikatessen',
        'Mannheim',
        'Germany'
    ),
    (
        'Blondel père et fils',
        'Strasbourg',
        'France'
    ),
    (
        'Bólido Comidas preparadas',
        'Madrid',
        'Spain'
    ),
    (
        'Bon app''',
        'Marseille',
        'France'
    ),
    (
        'Bottom-Dollar Marketse',
        'Tsawwassen',
        'Canada'
    ),
    (
        'B''s Beverages',
        'London',
        'UK'
    ),
    (
        'Cactus Comidas para llevar',
        'Buenos Aires',
        'Argentina'
    ),
    (
        'Centro comercial Moctezuma',
        'Mexico D.F.',
        'Mexico'
    ),
    (
        'Chop-suey Chinese',
        'Bern',
        'Switzerland'
    ),
    (
        'Comércio Mineiro',
        'São Paulo',
        'Brazil'
    ),
    (
        'Consolidated Holdings',
        'London',
        'UK'
    ),
    (
        'Drachenblut Delikatessen',
        'Aachen',
        'Germany'
    ),
    (
        'Du monde entier',
        'Nantes',
        'France'
    ),
    (
        'Eastern Connection',
        'London',
        'UK'
    ),
    (
        'Ernst Handel',
        'Graz',
        'Austria'
    );

END

-- Seed Productos (More diverse)
IF(
    SELECT COUNT(*)
    FROM Productos
) < 20 BEGIN
INSERT INTO
    Productos (nombre, categoria, precio)
VALUES ('Chai', 'Beverages', 18.00),
    ('Chang', 'Beverages', 19.00),
    (
        'Aniseed Syrup',
        'Condiments',
        10.00
    ),
    (
        'Chef Anton''s Cajun Seasoning',
        'Condiments',
        22.00
    ),
    (
        'Chef Anton''s Gumbo Mix',
        'Condiments',
        21.35
    ),
    (
        'Grandma''s Boysenberry Spread',
        'Condiments',
        25.00
    ),
    (
        'Uncle Bob''s Organic Dried Pears',
        'Produce',
        30.00
    ),
    (
        'Northwoods Cranberry Sauce',
        'Condiments',
        40.00
    ),
    (
        'Mishi Kobe Niku',
        'Meat/Poultry',
        97.00
    ),
    ('Ikura', 'Seafood', 31.00),
    (
        'Queso Cabrales',
        'Dairy Products',
        21.00
    ),
    (
        'Queso Manchego La Pastora',
        'Dairy Products',
        38.00
    ),
    ('Konbu', 'Seafood', 6.00),
    ('Tofu', 'Produce', 23.25),
    (
        'Genen Shouyu',
        'Condiments',
        15.50
    ),
    (
        'Pavlova',
        'Confections',
        17.45
    ),
    (
        'Alice Mutton',
        'Meat/Poultry',
        39.00
    ),
    (
        'Carnarvon Tigers',
        'Seafood',
        62.50
    ),
    (
        'Teatime Chocolate Biscuits',
        'Confections',
        9.20
    ),
    (
        'Sir Rodney''s Marmalade',
        'Confections',
        81.00
    );

END

-- Seed Empleados
IF NOT EXISTS (
    SELECT *
    FROM Empleados
) BEGIN
INSERT INTO
    Empleados (id, nombre, titulo, pais)
VALUES (
        1,
        'Nancy Davolio',
        'Sales Representative',
        'USA'
    ),
    (
        2,
        'Andrew Fuller',
        'Vice President, Sales',
        'USA'
    ),
    (
        3,
        'Janet Leverling',
        'Sales Representative',
        'USA'
    ),
    (
        4,
        'Margaret Peacock',
        'Sales Representative',
        'USA'
    ),
    (
        5,
        'Steven Buchanan',
        'Sales Manager',
        'UK'
    ),
    (
        6,
        'Michael Suyama',
        'Sales Representative',
        'UK'
    ),
    (
        7,
        'Robert King',
        'Sales Representative',
        'UK'
    ),
    (
        8,
        'Laura Callahan',
        'Inside Sales Coordinator',
        'USA'
    ),
    (
        9,
        'Anne Dodsworth',
        'Sales Representative',
        'UK'
    );

END

-- =============================================
-- 3. DATA SEEDING (FACTS GENERATOR)
-- =============================================

DECLARE @TargetRows INT = 2000;
DECLARE @CurrentRows INT = (SELECT COUNT(*) FROM Ventas);

IF @CurrentRows < @TargetRows
BEGIN
    DECLARE @i INT = 0;
    DECLARE @Limit INT = @TargetRows - @CurrentRows;
    
    -- Variables for random generation
    DECLARE @rCliente INT, @rProducto INT, @rFuente INT, @rEmpleado INT, @rCantidad INT;
    DECLARE @rPrecio DECIMAL(18,2), @rTotal DECIMAL(18,2);
    DECLARE @rFecha DATETIME2;
    DECLARE @start DATE = '2023-01-01';
    DECLARE @end

DATE = '2024-12-31';

-- Min/Max IDs
DECLARE @minCli INT = (SELECT MIN(id) FROM Clientes);
    DECLARE @maxCli INT = (SELECT MAX(id) FROM Clientes);
    DECLARE @minProd INT = (SELECT MIN(id) FROM Productos);
    DECLARE @maxProd INT = (SELECT MAX(id) FROM Productos);
    DECLARE @minEmp INT = (SELECT MIN(id) FROM Empleados);
    DECLARE @maxEmp INT = (SELECT MAX(id) FROM Empleados);
    DECLARE @minSrc INT = (SELECT MIN(id) FROM Fuentes);
    DECLARE @maxSrc INT = (SELECT MAX(id) FROM Fuentes);

    WHILE @i < @Limit
    BEGIN
        -- Random IDs
        SET @rCliente = ROUND(((@maxCli - @minCli -1) * RAND() + @minCli), 0);
        SET @rProducto = ROUND(((@maxProd - @minProd -1) * RAND() + @minProd), 0);
        SET @rEmpleado = ROUND(((@maxEmp - @minEmp -1) * RAND() + @minEmp), 0);
        SET @rFuente = ROUND(((@maxSrc - @minSrc -1) * RAND() + @minSrc), 0);
        
        -- Safe fallbacks
        IF @rCliente IS NULL SET @rCliente = @minCli;
        IF @rProducto IS NULL SET @rProducto = @minProd;
        IF @rEmpleado IS NULL SET @rEmpleado = @minEmp;
        IF @rFuente IS NULL SET @rFuente = @minSrc;

        -- Random Date
        SET @rFecha = DATEADD(DAY, ABS(CHECKSUM(NEWID()) % DATEDIFF(DAY, @start, @end

)), @start);

-- Random Quantity & Total
SET @rCantidad = ABS(CHECKSUM (NEWID ()) % 50) + 1;

SELECT @rPrecio = precio FROM Productos WHERE id = @rProducto;

IF @rPrecio IS NULL SET @rPrecio = 10;

SET @rTotal = @rCantidad * @rPrecio;

INSERT INTO
    Ventas (
        cliente_id,
        producto_id,
        fecha,
        cantidad,
        total,
        fuente_id,
        empleado_id
    )
VALUES (
        @rCliente,
        @rProducto,
        @rFecha,
        @rCantidad,
        @rTotal,
        @rFuente,
        @rEmpleado
    );

SET @i = @i + 1;

END END