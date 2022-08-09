USE SISTEMAVACUNACION
GO

-- PROCEDIMIENTOS ALMACENADOS
-- UBIGEOS
CREATE PROCEDURE SPU_DEPARTAMENTOS_LISTAR
AS BEGIN
	SELECT * FROM departamentos ORDER BY departamento
END
GO

-- FILTRAR PROVINCIAS
CREATE PROCEDURE SPU_PROVINCIAS_LISTAR
@iddepartamento		VARCHAR(2)
AS BEGIN
	SELECT * FROM provincias WHERE iddepartamento = @iddepartamento ORDER BY provincia
END
GO

-- FILTRAR DISTRITOS
CREATE PROCEDURE SPU_DISTRITOS_LISTAR
@idprovincia  VARCHAR(4)
AS BEGIN
	SELECT * FROM distritos WHERE idprovincia = @idprovincia ORDER BY distrito
END
GO

-- CONSULTA A LOS PROCEDIMIENTOS DEL UBIGEO
EXEC SPU_DEPARTAMENTOS_LISTAR
EXEC SPU_PROVINCIAS_LISTAR '01'
EXEC SPU_DISTRITOS_LISTAR '0101'
GO

-- LABORATORIOS
CREATE PROCEDURE SPU_LABORATORIOS_LISTAR
AS BEGIN
	SELECT * FROM laboratorios ORDER BY laboratorio
END
GO

CREATE PROCEDURE SPU_LABORATORIOS_REGISTRAR
@laboratorio	VARCHAR(70),
@pais			VARCHAR(40)
AS BEGIN
	INSERT INTO laboratorios (laboratorio, pais)
		VALUES (@laboratorio, @pais)
END
GO

CREATE PROCEDURE SPU_LABORATORIOS_GETLABORATORIO
@idlaboratorio INT
AS BEGIN
	SELECT * FROM laboratorios WHERE idlaboratorio = @idlaboratorio
END
GO

CREATE PROCEDURE SPU_LABORATORIOS_ACTUALIZAR
@laboratorio	VARCHAR(70),
@pais			VARCHAR(40),
@idlaboratorio	INT
AS BEGIN
	UPDATE laboratorios SET
		laboratorio = @laboratorio,
		pais		= @pais
	WHERE idlaboratorio = @idlaboratorio
END
GO

CREATE PROCEDURE SPU_LABORATORIOS_ELIMINAR
@idlaboratorio	 INT
AS BEGIN
	DELETE FROM laboratorios WHERE idlaboratorio = @idlaboratorio
END
GO

-- LOTES
CREATE PROCEDURE SPU_LOTES_LISTAR
AS BEGIN
	SELECT LTS.idlote, LBT.idlaboratorio, LBT.laboratorio, LTS.fechaentrada, LTS.cantidad
		FROM lotes LTS
		INNER JOIN laboratorios LBT ON LBT.idlaboratorio = LTS.idlaboratorio
		ORDER BY LTS.fechaentrada
END
GO

CREATE PROCEDURE SPU_LOTES_REGISTRAR
@idlaboratorio	INT,
@fechaentrada	DATE,
@cantidad		INT
AS BEGIN
	INSERT INTO lotes (idlaboratorio, fechaentrada, cantidad)
		VALUES (@idlaboratorio, @fechaentrada, @cantidad)
END
GO

CREATE PROCEDURE SPU_LOTES_GETLOTE
@idlote		INT
AS BEGIN
	SELECT * FROM lotes WHERE idlote = @idlote
END
GO

CREATE PROCEDURE SPU_LOTES_ACTUALIZAR
@idlaboratorio	INT,
@fechaentrada	DATE,
@cantidad		INT,
@idlote			INT
AS BEGIN
	UPDATE lotes SET
		idlaboratorio	= @idlaboratorio,
		fechaentrada	= @fechaentrada,
		cantidad		= @cantidad
	WHERE idlote = @idlote
END
GO

CREATE PROCEDURE SPU_LOTES_ELIMINAR
@idlote INT
AS BEGIN
	DELETE FROM lotes WHERE idlote = @idlote
END
GO

-- TIPO DE CENTROS DE VACUNACIÓN
CREATE PROCEDURE SPU_TIPOCENTROVAC_LISTAR
AS BEGIN
	SELECT * FROM tipocentrovac
END
GO

CREATE PROCEDURE SPU_TIPOCENTROVAC_REGISTRAR
@tipocentro		VARCHAR(50)
AS BEGIN
	INSERT INTO tipocentrovac (tipocentro) VALUES (@tipocentro)
END
GO

CREATE PROCEDURE SPU_TIPOCENTROVAC_ACTUALIZAR
@tipocentro		VARCHAR(50),
@idtipocentro	INT
AS BEGIN
	UPDATE tipocentrovac SET tipocentro = @tipocentro
		WHERE idtipocentro = @idtipocentro
END
GO

CREATE PROCEDURE SPU_TIPOCENTROVAC_ELIMINAR
@idtipocentro	INT
AS BEGIN
	DELETE FROM tipocentrovac WHERE idtipocentro = @idtipocentro
END
GO

-- CENTROS DE VACUNACIÓN
CREATE PROCEDURE SPU_CENTROVAC_LISTAR
AS BEGIN
	SELECT CTV.idcentrovac, TPC.idtipocentro, TPC.tipocentro, CTV.nombrecentro, DPT.iddepartamento, DPT.departamento, 
			PRV.idprovincia, PRV.provincia, DST.iddistrito, DST.distrito, CTV.direccion, CTV.telefono
		FROM centrovac  CTV
		INNER JOIN tipocentrovac TPC ON TPC.idtipocentro = CTV.idtipocentro
		INNER JOIN distritos DST ON DST.iddistrito = CTV.iddistrito
		INNER JOIN provincias PRV ON PRV.idprovincia = DST.idprovincia
		INNER JOIN departamentos DPT ON DPT.iddepartamento = PRV.iddepartamento
		ORDER BY CTV.nombrecentro
END
GO

CREATE PROCEDURE SPU_CENTROVAC_REGISTRAR
@iddistrito		VARCHAR(6),
@idtipocentro	INT,
@nombrecentro	VARCHAR(70),
@direccion		VARCHAR(70),
@telefono		CHAR(9)
AS BEGIN
	IF @telefono = ''SET @telefono = NULL

	INSERT INTO centrovac (iddistrito, idtipocentro, nombrecentro, direccion, telefono)
		VALUES (@iddistrito, @idtipocentro, @nombrecentro, @direccion, @telefono)
END
GO

CREATE PROCEDURE SPU_CENTROVAC_ACTUALIZAR
@iddistrito		VARCHAR(6),
@idtipocentro	INT,
@nombrecentro	VARCHAR(70),
@direccion		VARCHAR(70),
@telefono		CHAR(9),
@idcentrovac	INT
AS BEGIN
	UPDATE centrovac SET
		iddistrito		= @iddistrito,
		idtipocentro	= @idtipocentro,
		nombrecentro	= @nombrecentro,
		direccion		= @direccion,
		telefono		= @telefono
	WHERE idcentrovac = @idcentrovac
END
GO

CREATE PROCEDURE SPU_CENTROVAC_ELIMINAR
@idcentrovac INT
AS BEGIN
	DELETE FROM centrovac WHERE idcentrovac = @idcentrovac
END
GO

-- STOCKVACUNAS
CREATE PROCEDURE SPU_STOCKVACUNAS_LISTAR
AS BEGIN
	SELECT STV.idstockvac, STV.idlote, CTV.idcentrovac, CTV.nombrecentro, STV.fechaasignacion, STV.cantidad,
			STV.fechainicio, STV.fechafin
		FROM stockvacunas STV
		INNER JOIN centrovac CTV ON CTV.idcentrovac = STV.idcentrovac
		ORDER BY idlote,fechaasignacion
END
GO

CREATE PROCEDURE SPU_STOCKVACUNAS_REGISTRAR
@idlote				INT,
@idcentrovac		INT,
@fechaasignacion	DATE,
@cantidad			INT,
@fechainicio		DATE,
@fechafin			DATE
AS BEGIN
	INSERT INTO stockvacunas (idlote, idcentrovac, fechaasignacion, cantidad, fechainicio, fechafin)
		VALUES (@idlote, @idcentrovac, @fechaasignacion, @cantidad, @fechainicio, @fechafin)
END
GO

CREATE PROCEDURE SPU_STOCKVACUNAS_GETSTOCKV
@idstockvac		INT
AS BEGIN
	SELECT * FROM stockvacunas WHERE idstockvac = @idstockvac
END
GO

CREATE PROCEDURE SPU_STOCKVACUNAS_ACTUALIZAR
@idlote				INT,
@idcentrovac		INT,
@fechaasignacion	DATE,
@cantidad			INT,
@fechainicio		DATE,
@fechafin			DATE,
@idstockvac			INT
AS BEGIN
	UPDATE stockvacunas SET
		idlote = @idlote,
		idcentrovac = @idcentrovac,
		fechaasignacion = @fechaasignacion,
		cantidad = @cantidad,
		fechainicio = @fechainicio,
		fechafin = @fechafin
	WHERE idstockvac = @idstockvac
END
GO

CREATE PROCEDURE SPU_STOCKVACUNAS_ELIMINAR
@idstockvac INT
AS BEGIN
	DELETE FROM stockvacunas WHERE idstockvac = @idstockvac
END
GO

-- SPU PERSONAS
CREATE PROCEDURE SPU_PERSONAS_LISTAR
AS BEGIN
	SELECT * FROM personas ORDER BY apellidos, nombres
END
GO

CREATE PROCEDURE SPU_PERSONAS_REGISTRAR
@apellidos		VARCHAR(30),
@nombres		VARCHAR(30),
@tipodocumento	CHAR(3),
@nrodocumento	CHAR(8),
@telefono		CHAR(9)
AS BEGIN
	-- Agregar el null se eltelefono queda vacio
	IF @telefono = '' SET @telefono = NULL

	INSERT INTO personas (apellidos, nombres, tipodocumento, nrodocumento, telefono)
		VALUES (@apellidos, @nombres, @tipodocumento, @nrodocumento, @telefono)
END
GO

CREATE PROCEDURE SPU_PERSONAS_ACTUALIZAR
@apellidos		VARCHAR(30),
@nombres		VARCHAR(30),
@tipodocumento	CHAR(3),
@nrodocumento	CHAR(8),
@telefono		CHAR(9),
@idpersona		INT
AS BEGIN
	UPDATE personas SET
		apellidos		= @apellidos,
		nombres			= @nombres,
		tipodocumento	= @tipodocumento,
		nrodocumento	= @nrodocumento,
		telefono		= @telefono
	WHERE idpersona	= @idpersona
END
GO

CREATE PROCEDURE SPU_PERSONAS_ELIMINAR
@idpersona INT
AS BEGIN
	DELETE FROM personas WHERE idpersona = @idpersona
END
GO


-- RESPONSABLES
CREATE PROCEDURE SPU_RESPONSABLES_LISTAR
AS BEGIN
	SELECT RSP.idresponsable, CTV.idcentrovac, CTV.nombrecentro, PER.idpersona, 
			CONCAT(PER.apellidos, ' ', PER.nombres) AS 'persona', RLS.idrol,
			RLS.rol, RSP.fechaalta, RSP.fechabaja, RSP.estado
		FROM responsables RSP
		INNER JOIN personas PER ON PER.idpersona = RSP.idpersona
		INNER JOIN centrovac CTV ON CTV.idcentrovac = RSP.idcentrovac
		INNER JOIN roles RLS ON RLS.idrol = RSP.idrol
		ORDER BY fechaalta
END
GO

CREATE PROCEDURE SPU_RESPONSABLES_REGISTRAR
@idcentrovac	INT,
@idpersona		INT,
@idrol			INT,
@fechaalta		DATE,
@fechabaja		DATE
AS BEGIN
	IF @fechaalta = '' SET @fechaalta = GETDATE()
	IF @fechabaja = '' SET @fechabaja = NULL

	INSERT INTO responsables (idcentrovac, idpersona, idrol, fechaalta, fechabaja)
		VALUES (@idcentrovac, @idpersona, @idrol, @fechaalta, @fechabaja)
END
GO

CREATE PROCEDURE SPU_RESPONSABLES_GETRESPONSABLE
@idresponsable	INT
AS BEGIN
	SELECT * FROM responsables WHERE idresponsable = @idresponsable
END
GO

CREATE PROCEDURE SPU_RESPONSABLES_ACTUALIZAR
@idcentrovac	INT,
@idpersona		INT,
@idrol			INT,
@fechaalta		DATE,
@fechabaja		DATE,
@idresponsable	INT
AS BEGIN
	IF @fechabaja = '' SET @fechabaja = NULL
	UPDATE responsables SET
		idcentrovac = @idcentrovac,
		idpersona	= @idpersona,
		idrol		= @idrol,
		fechaalta	= @fechaalta,
		fechabaja	= @fechabaja
	WHERE idresponsable = @idresponsable
END
GO

EXEC SPU_RESPONSABLES_ACTUALIZAR 3, 4, 1, '2021-06-29', '', 1 
GO

CREATE PROCEDURE SPU_RESPONSABLES_ELIMINAR
@idresponsable INT
AS BEGIN
	DELETE FROM responsables WHERE idresponsable = @idresponsable
END
GO

-- NUEVO ++++++++++++++++++++++++++++++++++++++++++++
CREATE PROCEDURE SPU_RESPONSABLE_FILTRAR_CENTRO
@idcentro INT
AS 
BEGIN
	SELECT RSP.idresponsable, CONCAT(PER.apellidos, ' ', PER.nombres) AS 'responsable'
		FROM responsables RSP
		INNER JOIN personas PER ON PER.idpersona = RSP.idpersona
		INNER JOIN centrovac CTV ON CTV.idcentrovac = RSP.idcentrovac
		WHERE RSP.idcentrovac = @idcentro
END
GO

EXEC SPU_RESPONSABLE_FILTRAR_CENTRO 3
SELECT CAST('3' AS int)
GO

EXEC SPU_RESPONSABLE_FILTRAR_CENTRO 3
GO

-- VACUNACION
CREATE PROCEDURE SPU_VACUNACION_LISTAR
AS BEGIN
	SELECT VCN.idvacunacion, CTV.idcentrovac, PER.idpersona, CONCAT(PER.apellidos, ' ',PER.nombres ) AS 'atendido', RSP.idresponsable,
			(SELECT CONCAT(apellidos, ' ', nombres) FROM personas WHERE idpersona = RSP.idpersona) AS 'responsable',
			STK.idstockvac, VCN.fechahoravac
		FROM vacunacion VCN
		INNER JOIN personas PER ON PER.idpersona = VCN.idatendido
		INNER JOIN responsables RSP ON RSP.idresponsable = VCN.idresponsable
		INNER JOIN centrovac CTV ON CTV.idcentrovac = RSP.idcentrovac
		INNER JOIN stockvacunas STK ON STK.idstockvac = VCN.idstockvac
		ORDER BY fechahoravac
END
GO

CREATE PROCEDURE SPU_VACUNACION_REGISTRAR
@idatendido		INT,
@idresponsable	INT,
@idstockvac		INT
AS BEGIN
	INSERT INTO vacunacion (idatendido, idresponsable, idstockvac, fechahoravac)
		VALUES (@idatendido, @idresponsable, @idstockvac, GETDATE())
END
GO

CREATE PROCEDURE SPU_VACUNACION_GETVACUNACION
@idvacunacion INT
AS BEGIN
	SELECT * FROM vacunacion WHERE idvacunacion = @idvacunacion
END
GO

CREATE PROCEDURE SPU_VACUNACION_ACTUALIZAR
@idatendido		INT,
@idresponsable	INT,
@idstockvac		INT,
@fechahoravac	DATETIME,
@idvacunacion	INT
AS BEGIN
	UPDATE vacunacion SET
		idatendido		= @idatendido,
		idresponsable	= @idresponsable,
		idstockvac		= @idstockvac,
		fechahoravac	= @fechahoravac
	WHERE idvacunacion = @idvacunacion
END
GO

CREATE PROCEDURE SPU_VACUNACION_ELIMINAR
@idvacunacion INT
AS BEGIN
	DELETE FROM vacunacion WHERE idvacunacion = @idvacunacion
END
GO

-- TRIGGER - AUDITORIA - LOTES REGISTRAR
CREATE TRIGGER TG_LOTES_REGISTRAR
ON lotes
FOR INSERT
AS BEGIN
	-- Variable declarada
	DECLARE @nuevosRegistros INT

	-- Asignando datos a la variale
	SET @nuevosRegistros = (SELECT COUNT(*) FROM inserted)

	-- Actualizando datos de la auditoria
	UPDATE auditoria SET
		ultimamodifiacion = GETDATE(),
		tipoproceso = 'REGISTRAR',
		totalelementos = totalelementos + @nuevosRegistros
		WHERE nombretabla = 'lotes'
END
GO

-- TG ELIMINAR LOTES
CREATE TRIGGER TG_LOTES_ELIMINAR
ON lotes
FOR DELETE
AS BEGIN
	-- Variable declarada
	DECLARE @totalRegistro INT

	-- Asignando datos a la variable
	SET @totalRegistro = (SELECT COUNT(*) FROM deleted)

	-- Actualizando valores de la tabla auditoria
	UPDATE auditoria SET
		tipoproceso = 'ELIMINAR',
		ultimamodifiacion = GETDATE(),
		totalelementos = totalelementos - @totalRegistro
	WHERE nombretabla = 'lotes'
END
GO

-- TG AUDITORIA PARA CENTROVAC
CREATE TRIGGER TG_CENTROVAC_REGISTRAR
ON centrovac
FOR INSERT
AS BEGIN
	-- Variale declarada
	DECLARE @totalRegistro INT
	-- Datos obtenidos de la tabla tmp
	SET @totalRegistro = (SELECT COUNT(*) FROM inserted)

	-- actualizando datos de la tabla auditoria
	UPDATE auditoria SET
		tipoproceso = 'REGISTRAR',
		ultimamodifiacion = GETDATE(),
		totalelementos = totalelementos + @totalRegistro
	WHERE nombretabla = 'centrovac'
END
GO

CREATE TRIGGER TG_CENTROVAC_ELIMINAR
ON centrovac
FOR DELETE
AS BEGIN
	-- Variale declarada
	DECLARE @totalRegistro INT
	-- Datos obtenidos de la tabla tmp
	SET @totalRegistro = (SELECT COUNT(*) FROM deleted)

	-- actualizando datos de la tabla auditoria
	UPDATE auditoria SET
		tipoproceso = 'ELIMINAR',
		ultimamodifiacion = GETDATE(),
		totalelementos = totalelementos - @totalRegistro
	WHERE nombretabla = 'centrovac'
END
GO

SELECT * FROM auditoria
SELECT * FROM lotes
SELECT * FROM roles
SELECT * FROM stockvacunas
SELECT * FROM centrovac
SELECT * FROM laboratorios
SELECT * FROM tipocentrovac
SELECT * FROM distritos
GO