# Gdd-Cupon
Trabajo práctico realizado para Gestión en Bases de Datos

Consiste en realizar una migración de un sistema viejo a uno nuevo, con la base de Datos desarrollada en Sql Server y la interfaz gráfica en C#. La aplicación consiste en un sistema en el cual hay usuarios registrados según un determinado rol(Cliente, Proveedor, Administrador), cada rol con unas funcionalidades asignadas. El sistema consiste en cargar ofertas de productos, para que los clientes interesados las compren y reciban el cupon correspondiente. Dicho cupón contiene una fecha de vencimiento (que coincide con la fecha de vencimiento de la oferta) y una fecha de consumo apra saber si fue consumido y de esa forma saber si un cupon ya fue canjeado a la hora de utilizarlo. El sistema también debe permitir realizar un reporte de facturación, así como también listados estadísticos.


Script_migracion_inicial: contiene todo el código para la creación de las tablas correspondientes al nuevo sistema, los procedures para realizar la migracion de la tabla Maestra vieja a las tablas nuevas, los alter Table para agregar las constraints y por último la creación de índices. Luego contiene todos los procs utilizados en el sistema para consultas en base a parámetros, inserciones, validaciones, etc.
