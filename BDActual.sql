-- drop database sistemaRepartoBD;
create database sistemaRepartoBD;
use sistemaRepartoBD;

create table tipoPermiso(
	idTipoPermiso int auto_increment not null,
    nombreTipoPermiso varchar(35) not null,
    primary key(idTipoPermiso)
) engine = InnoDB default char set latin1;

create table permisos(
	idPermiso varchar(10) primary key not null,
	idTipoPermiso int not null,
	ingresarUser boolean not null, 
	modificarUser boolean not null, 
	dbusuario boolean not null, 
	consultarUser boolean not null,
    /*ingresarUserTipo boolean not null, 
	modificarUserTipo boolean not null, 
	ingresarTipoPermiso boolean not null,
    modificarTipoPermiso boolean not null,
    consultarTipoPermiso boolean not null,*/
    ingresarCliente boolean not null,
    modificarCliente boolean not null,
    dbCliente boolean not null,
    consultarCliente boolean not null,
    ingresarDepartamento boolean not null,
	modificarDepartamento boolean not null,
	dbDepartamento boolean not null,
    consultarDepartamento boolean not null,
    ingresarPuesto boolean not null,
    modificarPuesto boolean not null,
    dbPuesto boolean not null,
    consultarPuesto boolean not null, 
    ingresarPiloto boolean not null,
    modificarPiloto boolean not null,
    dbPiloto boolean not null,
    consultarPiloto boolean not null,
	ingresarEmpleado boolean not null,
	modificarEmpleado boolean not null,
	dbEmpleado boolean not null,
	consultarEmpleado boolean not null,

    ingresarPaqueteEncabezado boolean not null,
    modificarPaqueteEncabezado boolean not null,
    dbPaqueteEncabezado boolean not null,
    consultarPaqueteEncabezado boolean not null,
    ingresarPaqueteDetalle boolean not null,
    modificarPaqueteDetalle boolean not null,
    dbPaqueteDetalle boolean not null,
    consultarPaqueteDetalle boolean not null,
    insertarUbicacion boolean not null,
    modificarUbicacion boolean not null,
    dbubicacion boolean not null,
    consultarUbicacion boolean not null,
    insertarSububicacion boolean not null,
    modificarSububicacion boolean not null,
    dbSububicacion boolean not null,
    consultarSububicacion boolean not null,
    insertarBodega boolean not null,
    modifcarBodega boolean not null,
    dbBodega boolean not null,
    consultarBodega boolean not null,
    insertarInventario boolean not null,
    modificarInventario boolean not null,
    consultarInventario boolean not null,
    -- insertarTipoMov boolean not null,
	-- modificarTipoMov boolean not null,
    -- dbTipoMov boolean not null, 
	-- consultarTipoMov boolean not null,
    -- insertarMovBodega boolean not null,
    -- modificarMovBodega boolean not null,
    consultarMovBodega boolean not null,
    insertarTipoTransp boolean not null,
    modificarTipoTransp boolean not null,
    dbTipoTransp boolean not null,
    consultarTipoTransp boolean not null,
    insertarTransporte boolean not null,
    modificarTransporte boolean not null,
    dbTransporte boolean not null,
    consultarTransporte boolean not null,
    ingresarRuta boolean not null,
    modificarRuta boolean not null,
    dbRuta boolean not null,
    consultarRuta boolean not null,
    ingresarEnvio boolean not null,
    modificarEnvio boolean not null,
    dbEnvio boolean not null,
    consultarEnvio boolean not null,
    ingresarBT boolean not null,
    modificarBT boolean not null,
    consultaBT boolean not null,
    consultaBU boolean not null,
    ingresarCalificacion boolean not null,
    modificarCalificacion boolean not null,
    consultaCalificacion boolean not null,
    reportes boolean not null,
    foreign key (idTipoPermiso) references tipoPermiso(idTipoPermiso)
) engine = InnoDB default char set latin1;

create table usuario(
	idUser varchar(10) primary key not null,
	idPermiso varchar(10) not null,
	nombreUsuario varchar(60) not null,
	passwordUsuario varchar(60) not null,
    estatusUsuario char(1) not null,
	foreign key (idPermiso) references permisos(idPermiso)
) engine = InnoDB default char set latin1;

create table cliente(  
	idCliente varchar(10) primary key not null,
    nombreCliente varchar(30) not null,
    apellidoCliente varchar(30) not null,
    telefonoCliente varchar(15) not null,
    correoCliente varchar(50) not null,
    direccionCliente varchar(80) not null,
    estatusCliente char(1) not null
    
) engine = InnoDB default char set latin1;

create table departamento(
	idDepartamento varchar(10) primary key not null,
    nombreDepartamentos varchar(35) not null,
    estatusDepartamento char(1) not null
) engine = InnoDB default char set latin1;

create table puesto(
	idPuesto varchar(10) primary key not null,
    nombrePuesto varchar(35) not null,
    estatusPuesto char(1) not null
) engine = InnoDB default char set latin1;

create table piloto(
	idPiloto varchar(10) primary key not null,
    dpiPiloto varchar(10) not null,
    idUser varchar(10) not null,
    nombrePiloto varchar(30) not null,
    apellidoPiloto varchar(30) not null,
    telefonoPiloto varchar(15) not null,
    direccionPiloto varchar(80) not null,
    sueldoPiloto float not null,
    estatusPiloto char(1) not null,
    
    foreign key (idUser) references usuario (idUser)
) engine = InnoDB default char set latin1;

create table empleado(
	idEmpleado varchar(10) primary key not null,
    dpiEmpleado varchar(13) not null,
    idUser varchar(10) not null,
    nombreEmpleado varchar(30) not null,
    apellidoEmpleado varchar(30) not null,
    telefonoEmpleado varchar(15) not null,
    direccionEmpledo varchar(80) not null,
    sueldoEmpleado float not null,
    /*foreign key*/
    -- idTipoEmpleado varchar(10) not null,
    idDepartamentoEmpleado varchar(10) not null,
    idPuestoEmpleado varchar(10) not null,
    estatusEmpleado char(1) not null,
    
    foreign key (idUser) references usuario (idUser),
    foreign key (idDepartamentoEmpleado) references departamento(idDepartamento),
    foreign key (idPuestoEmpleado) references puesto(idPuesto)
) engine = InnoDB default char set latin1;

create table paqueteEncabezado(
	idPaqueteEncabezado varchar(10) not null, 
    idCliente varchar(10) not null,
    fechaRecepcion date not null,
    fechaClienteEntrega date not null,
    NombreRemitente varchar(35) not null,
    direccionRemitente varchar(80) not null,
    telefonoRemitente varchar(15) not null,
    cantidadPaquetes int not null,
    idEmpleado varchar(10) not null,
    estatusPaqEncabezado char(1) not null,
    primary key(idPaqueteEncabezado, idCliente, idEmpleado),
    /* foreign key */
    foreign key (idCliente) references cliente(idCliente),
    foreign key (idEmpleado) references empleado(idEmpleado)
) engine = InnoDB default char set latin1;

create table paqueteDetallado(
	idPaqueteEncabezado varchar(10) not null, 
    idCliente varchar(10) not null,
	idEmpleado varchar(10) not null,
    idOrden int auto_increment not null,
    descripcionProducto varchar(80) not null,
    
    primary key (idOrden, idPaqueteEncabezado, idCliente, idEmpleado),
    -- foreign keys
    foreign key (idPaqueteEncabezado) references paqueteEncabezado(idPaqueteEncabezado),
    foreign key (idCliente) references cliente(idCliente),
    foreign key (idEmpleado) references empleado(idEmpleado)
) engine = InnoDB default char set latin1;

create table ubicacion(
	idUbicacion varchar(10) primary key not null,
    nombreUbicacion varchar(35) not null,
    estatusUbicacion char(1) not null
) engine = InnoDB default char set latin1;

create table subUbicacion(
	idSububicacion varchar(10) primary key not null,
    nombreSubUbicacion varchar(35) not null,
    estatusSubUbicacion char(1) not null
) engine = InnoDB default char set latin1;

create table bodega(
	idBodega varchar(10) primary key not null,
    /*foreign key*/
    idUbicacionBodega varchar(10) not null,
    idSububicacionBodega varchar(10) not null,
    /*Llave compuesta paquete
    -- idPaqueteE varchar(10) not null, 
    -- idCliente varchar(10) not null,   -- para saber que empleado recibio el producto
    -- idEmpleado varchar(10) not null,
    
    -- primary key (idBodega, idUbicacionBodega, idSububicacionBodega, idPaqueteE, idCliente, idEmpleado),*/
    
    estatusBodega char(1) not null,
    /*foreign key*/
    foreign key (idUbicacionBodega) references ubicacion(idUbicacion),
    foreign key (idSububicacionBodega) references subUbicacion(idSububicacion)
	/*foreign key (idPaqueteE) references paqueteEncabezado(idPaqueteEncabezado),
    foreign key (idCliente) references cliente(idCliente),
    foreign key (idEmpleado) references empleado(idEmpleado)*/
) engine = InnoDB default char set latin1;

create table tipoMovimiento(
	idTipoMov varchar(10) primary key not null,
    nombreTipoMov varchar(35) not null,
    estatusTipoMov char(1) not null
) engine = InnoDB default char set latin1;

/*Movimiento de la bodega
- cuando un empleado va a sacar o colocar productos en la bodega*/

/*Movimientos de bodega, --Abastecer/Desabastecer*/
create table movimientoBodega(
	idMovBodega varchar(10) not null,
    idBodega varchar(10) not null,
    /* idUbicacionBodega varchar(10) not null,
    idSububicacionbodega varchar(10) not null,*/
    idTipoMovMB varchar(10) not null,         -- carga y descarga
    idPaquete varchar(10) not null,
    idCliente varchar(10) not null,
    idEmpleadoMB varchar(10) not null,
    fechaHoraMB datetime not null,           -- del movimiento 
    
    /*foreign key*/
    primary key (idMovBodega, idBodega, idPaquete, idCliente, idEmpleadoMB),
    foreign key (idBodega) references bodega(idBodega),
    foreign key (idTipoMovMB) references tipoMovimiento (idTipoMov),
	foreign key (idPaquete) references paqueteEncabezado(idPaqueteEncabezado),
    foreign key (idCliente) references cliente(idCliente),
    
    foreign key (idEmpleadoMB) references empleado (idEmpleado)
) engine = InnoDB default char set latin1;

create table inventario(     
	idInventario varchar(10) primary key not null,
    -- idMovBodega varchar(10) not null,
    idBodega varchar(10) not null,
    idPaquete varchar(10) not null,
	idCliente varchar(10) not null,
    idEmpleadoMB varchar(10) not null,
    cantidadInventario float not null,   -- cantidad de paquetes
    fechaIngresoInventario datetime not null,
    
    /*foreign key*/
    -- foreign key (idMovBodega) references movimientoBodega(idMovBodega),
    foreign key (idBodega) references bodega(idBodega),
	foreign key (idPaquete) references paqueteEncabezado(idPaqueteEncabezado),
    foreign key (idCliente) references cliente(idCliente),
    foreign key (idEmpleadoMB) references empleado(idEmpleado)
) engine = InnoDB default char set latin1;

create table tipoTransporte(
	idTipoTransporte varchar(10) primary key not null,
    nombreTipoTransporte varchar(35) not null,
    estatusTipoTransporte char(1) not null
) engine = InnoDB default char set latin1;

create table transporte(
	idTransporte varchar(10) primary key not null,
    nombreTransporte varchar(35) not null,
    idTipoTransporte varchar(10) not null,  -- foránea
    placaTransporte varchar(10) not null,
    colorTransporte varchar(35) not null,
    noChasisTransporte varchar(35) not null,
    modeloTransporte int not null,
    marcaTransporte varchar(35) not null,
    propietarioTransporte varchar(35) not null,
    estatusTransporte char(1) not null,
    
    /*foreign key*/
    foreign key (idTipoTransporte) references tipoTransporte (idTipoTransporte)
) engine = InnoDB default char set latin1;

create table ruta(
	idRuta varchar(10) primary key not null,
    inicioRuta varchar(80) not null,
    finalRuta varchar(80) not null,
    estatusRuta char(1) not null
) engine = InnoDB default char set latin1;

-- drop table envio;
create table envio(
	-- DPI
	idPiloto varchar(10) not null, 
	idOrdenE int primary key auto_increment not null,
			
    idTransporteE varchar(10) not null,
    idRutaE varchar(10) not null,
    idMovBodega varchar(10) not null,
    idBodega varchar(10) not null,
	idPaquete varchar(10) not null,
    idCliente varchar(10) not null,
    idEmpleado varchar(10) not null,
    
    fechaE datetime not null,
    estatusE char(1) not null,     -- para saber si ya llego o no el paquete
    -- foreign key
    foreign key (idPiloto) references piloto(idPiloto),
    foreign key (idTransporteE) references transporte(idTransporte),
    foreign key (idRutaE) references ruta(idRuta),
    foreign key (idMovBodega) references movimientoBodega(idMovBodega),
    foreign key (idBodega) references bodega(idBodega),
	foreign key (idPaquete) references paqueteEncabezado(idPaqueteEncabezado),
    foreign key (idCliente) references cliente(idCliente),
    foreign key (idEmpleado) references empleado(idEmpleado)
    
) engine = InnoDB default char set latin1;

create table bitacoraTransporte(
	idBitacora int primary key auto_increment not null,
    idTransporte varchar(10) not null,
    idPiloto varchar(10) not null,
    kmInicial double not null,
    KmFinal double not null,
    fechaSalida date not null,
    fechaEntrada date not null,
    horaSalida time not null,
    horaEntrada time not null,
    lugarSalida varchar(35) not null,
    lugarLlegada varchar(35) not null,
    nivelGasolina varchar(35) not null,
    
    -- foreign key
    foreign key (idTransporte) references transporte(idTransporte),
    foreign key (idPiloto) references piloto(idPiloto)
) engine = InnoDB default char set latin1;

-- drop table bitacoraUsuario;
create table bitacoraUsuario(
	idBitacoraUsuario int primary key auto_increment not null,
    idUser varchar(10) not null,
    -- direccionMac varchar(10) not null,
    -- direccionIP varchar(15) not null,
    accionRealizada varchar(50) not null,
    fechaHora datetime not null,
    
    foreign key (idUser) references usuario(idUser)
) engine = InnoDB default char set latin1;

create table calificacionPiloto(
	idCalificacion int primary key auto_increment not null,
    idPiloto varchar(10) not null,
    -- Llave foranea pedido encabezado
    idPaqueteEncabezado varchar(10) not null, 
    idCliente varchar(10) not null,
    idEmpleado varchar(10) not null,
	
    fechaRecepcion date not null,
	llegadaTardia boolean not null,
	llegadaTiempo boolean not null,
    percances boolean not null,
    retrasos boolean not null,
    observaciones varchar(80),
    
    -- foreign key
    foreign key (idPaqueteEncabezado) references paqueteEncabezado(idPaqueteEncabezado),
    foreign key (idCliente) references cliente(idCliente),
    foreign key (idEmpleado) references empleado(idEmpleado),
    foreign key (idPiloto) references piloto(idPiloto)
) engine = InnoDB default char set latin1;