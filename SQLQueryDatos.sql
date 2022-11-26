insert into CATEGORIA values('Computadoras','https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/%C3%8Dcono_Computadora_-_Internet.JPG/600px-%C3%8Dcono_Computadora_-_Internet.JPG','',1)
insert into CATEGORIA values('Mouse','https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/3-Tasten-Maus_Microsoft.jpg/330px-3-Tasten-Maus_Microsoft.jpg','',1)
insert into CATEGORIA values('Teclado','https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Apple-wireless-keyboard.jpg/1200px-Apple-wireless-keyboard.jpg?20200903165521','',1)
insert into CATEGORIA values('Audifonos','https://upload.wikimedia.org/wikipedia/commons/0/00/S%C5%82uchawki_referencyjne_K-701_firmy_AKG.jpg','',1)
insert into CATEGORIA values('Parlantes','https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Bass_reflex_loudspeakers_by_Focal-JMLab.jpg/330px-Bass_reflex_loudspeakers_by_Focal-JMLab.jpg','',1)
insert into CATEGORIA values('Camara','https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Jcacweb_cam.JPG/1200px-Jcacweb_cam.JPG?20081020004654','',1)
insert into CATEGORIA values('Impresoras','https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Samsung_ML-2010.jpg/420px-Samsung_ML-2010.jpg','',1)
insert into CATEGORIA values('Proyectores','https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Projecteur_de_diapositives_Prestinox_d%C3%A9but_des_ann%C3%A9es_1960.jpg/450px-Projecteur_de_diapositives_Prestinox_d%C3%A9but_des_ann%C3%A9es_1960.jpg','',1)
insert into CATEGORIA values('Redes','https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Modelo_asp.jpg/330px-Modelo_asp.jpg','',1)
insert into CATEGORIA values('Almacenamiento de datos','https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Hard_drive-es.svg/375px-Hard_drive-es.svg.png','',1)
insert into CATEGORIA values('Otros Accesorios','https://i0.wp.com/devir.mx/wp-content/uploads/2016/08/Logo-Otros-2.jpg?ssl=1','',1)

-------------------------MARCAS-------------------------
insert into MARCA values ('HP','https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/HP_logo_2012.svg/368px-HP_logo_2012.svg.png','',1)
insert into MARCA values ('ASUS','https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/ASUS_Logo.svg/315px-ASUS_Logo.svg.png','',1)
insert into MARCA values ('DELL','https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Dell_logo_2016.svg/255px-Dell_logo_2016.svg.png','',1)
insert into MARCA values ('Logitech','https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Logitech_logo.svg/368px-Logitech_logo.svg.png','',1)


--EXEC sp_MSforeachtable 'BEGIN TRY TRUNCATE TABLE PRODUCTO END TRY BEGIN CATCH DELETE FROM PRODUCTO END CATCH' 
--GO 
--DBCC CHECKIDENT(PRODUCTO,RESEED,0)

--EXEC sp_MSforeachtable 'BEGIN TRY TRUNCATE TABLE MARCA END TRY BEGIN CATCH DELETE FROM MARCA END CATCH' 
--GO 
--DBCC CHECKIDENT(MARCA,RESEED,0)

--EXEC sp_MSforeachtable 'BEGIN TRY TRUNCATE TABLE CATEGORIA END TRY BEGIN CATCH DELETE FROM CATEGORIA END CATCH' 
--GO 
--DBCC CHECKIDENT(CATEGORIA,RESEED,0)



insert into PRODUCTO values ('0001','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0002','','Audifono Gammer','Disfruta de juegos y música con confort ligero y sonido potente y limpio.',2,4,300,10,'https://s3.amazonaws.com/online.storage/SEVASA/Products/9728a248-e1e5-42d5-8461-28a54a4988ce.jpg','',GETDATE(),1)
insert into PRODUCTO values ('0003','','Audifono basico','Monoauricular estéreo',3,4,500,10,'https://s3.amazonaws.com/online.storage/SEVASA/Products/95934e69-9da5-4a0c-b78c-16ee4cee8781.JPG','',GETDATE(),1)
insert into PRODUCTO values ('0004','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0005','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0006','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0007','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0008','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0009','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0010','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0011','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0012','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0013','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0014','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0015','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0016','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0017','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0018','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)
insert into PRODUCTO values ('0019','','Laptop','8 GB de RAM',1,1,15000,10,'','',GETDATE(),1)


select *from PRODUCTO