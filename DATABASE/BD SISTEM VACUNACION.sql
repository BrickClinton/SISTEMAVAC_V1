CREATE DATABASE SISTEMAVACUNACION
GO

USE SISTEMAVACUNACION
GO

CREATE TABLE tipocentrovac
(
	idtipocentro	INT IDENTITY(1,1),
	tipocentro		VARCHAR(50)	NOT NULL,
	CONSTRAINT pk_tipc_idtipocentro PRIMARY KEY(idtipocentro),
	CONSTRAINT uk_tipc_tipocentro UNIQUE (tipocentro)
)
GO

CREATE TABLE centrovac
(
	idcentrovac		INT IDENTITY(1,1),
	idtipocentro	INT		NOT NULL,
	iddistrito		VARCHAR(6)	NOT NULL,
	nombrecentro	VARCHAR(70)	NOT NULL,
	direccion		VARCHAR(70)	NOT NULL,
	telefono		CHAR(9)		NULL,
	CONSTRAINT pk_ctv_idcentrovac PRIMARY KEY(idcentrovac),
	CONSTRAINT fk_ctv_idtipocentro FOREIGN KEY (idtipocentro) REFERENCES tipocentrovac (idtipocentro),
	CONSTRAINT fk_ctv_iddistrito FOREIGN KEY (iddistrito) REFERENCES distritos (iddistrito)
)
GO

CREATE TABLE personas 
(
	idpersona		INT IDENTITY(1,1),
	apellidos		VARCHAR(30)	NOT NULL,
	nombres			VARCHAR(30)	NOT NULL,
	tipodocumento	CHAR(3)		NOT NULL,
	nrodocumento	CHAR(8)		NOT NULL DEFAULT 'DNI',
	telefono		CHAR(9)		NULL,
	CONSTRAINT pk_per_idpersona PRIMARY KEY (idpersona),
	CONSTRAINT ck_per_tipodocumento CHECK (tipodocumento IN ('DNI', 'CEX')),
	CONSTRAINT ck_per_nrodocumento CHECK (nrodocumento LIKE ('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	CONSTRAINT uk_per_nrodocumento UNIQUE (nrodocumento),
	CONSTRAINT ck_per_telefono CHECK (telefono LIKE ('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
)
GO

CREATE TABLE laboratorios
(
	idlaboratorio	INT IDENTITY(1,1),
	laboratorio		VARCHAR(70)		NOT NULL,
	pais			VARCHAR(40)		NOT NULL,
	CONSTRAINT pk_lab_idlaboratorio PRIMARY KEY (idlaboratorio),
	CONSTRAINT uk_lab_laboratorio UNIQUE (laboratorio)
)
GO

CREATE TABLE lotes
(
	idlote			INT IDENTITY(1,1),
	idlaboratorio	INT		NOT NULL,
	fechaentrada	DATE	NOT NULL DEFAULT GETDATE(),
	cantidad		INT		NOT NULL,
	CONSTRAINT pk_lot_idlote PRIMARY KEY (idlote),
	CONSTRAINT fk_lot_idlaboratorio FOREIGN KEY (idlaboratorio) REFERENCES laboratorios (idlaboratorio),
	CONSTRAINT ck_lot_fechaentrada CHECK (fechaentrada <= GETDATE()),
	CONSTRAINT ck_lot_cantidad CHECK (cantidad > 0)
)
GO

CREATE TABLE roles
(
	idrol	INT IDENTITY(1,1),
	rol		VARCHAR(70)		NOT NULL,
	CONSTRAINT pk_rol_idrol PRIMARY KEY (idrol),
	CONSTRAINT uk_rol_rol UNIQUE (rol)
)
GO

CREATE TABLE responsables 
(
	idresponsable	INT IDENTITY(1,1),
	idcentrovac		INT		NOT NULL,
	idpersona		INT		NOT NULL,
	idrol			INT		NOT NULL,
	fechaalta		DATE	NOT NULL DEFAULT GETDATE(),
	fechabaja		DATE	NULL,
	estado			BIT		NOT NULL DEFAULT 1,
	CONSTRAINT pk_resp_idresponsable PRIMARY KEY (idresponsable),
	CONSTRAINT fk_resp_idcentrovac FOREIGN KEY (idcentrovac) REFERENCES centrovac (idcentrovac),
	CONSTRAINT fk_resp_idpersona FOREIGN KEY (idpersona) REFERENCES personas (idpersona),
	CONSTRAINT fk_resp_idrol FOREIGN KEY (idrol) REFERENCES roles (idrol),
	CONSTRAINT ck_resp_fechaalta CHECK (fechaalta <= fechabaja)
)
GO

CREATE TABLE stockvacunas
(
	idstockvac			INT IDENTITY(1,1),
	idlote				INT		NOT NULL,
	idcentrovac			INT		NOT NULL,
	fechaasignacion		DATE	NOT NULL,
	cantidad			INT		NOT NULL,
	fechainicio			DATE	NOT NULL DEFAULT GETDATE(),
	fechafin			DATE	NULL,
	CONSTRAINT pk_stv_idstockvac PRIMARY KEY (idstockvac),
	CONSTRAINT fk_stv_idlote FOREIGN KEY (idlote) REFERENCES lotes (idlote),
	CONSTRAINT fk_stv_idcentrovac FOREIGN KEY (idcentrovac) REFERENCES centrovac (idcentrovac),
	CONSTRAINT ck_stv_cantidad CHECK (cantidad > 0),
	CONSTRAINT ck_stv_fechainicio CHECK (fechainicio <= fechafin)
)
GO

CREATE TABLE vacunacion
(
	idvacunacion	INT IDENTITY(1,1),
	idatendido		INT			NOT NULL,
	idresponsable	INT			NOT NULL,
	idstockvac		INT			NOT NULL,
	fechahoravac	DATETIME	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT pk_vac_idvacunacion PRIMARY KEY (idvacunacion),
	CONSTRAINT fk_vac_idatendido FOREIGN KEY (idatendido) REFERENCES personas (idpersona),
	CONSTRAINT fk_vac_idresponsable FOREIGN KEY (idresponsable) REFERENCES responsables (idresponsable),
	CONSTRAINT fk_vac_idstockvac FOREIGN KEY (idstockvac) REFERENCES stockvacunas (idstockvac)
)
GO

-- TABLA AUDITORIA
CREATE TABLE auditoria
(
	idauditoria			INT IDENTITY(1,1),
	nombretabla			VARCHAR(20)	NOT NULL,
	tipoproceso			VARCHAR(15)	NOT NULL,
	ultimamodifiacion	DATETIME	NOT NULL DEFAULT GETDATE(),
	totalelementos		INT			NOT NULL,
	CONSTRAINT pk_aud_idauditoria PRIMARY KEY (idauditoria),
	CONSTRAINT uk_aud_nombretabla UNIQUE(nombretabla)
)
GO

-- DATOS AUDITORIA INICIALIZADO
INSERT INTO auditoria (nombretabla, tipoproceso, ultimamodifiacion, totalelementos) VALUES 
	('lotes', 'REGISTRAR', GETDATE(), 0),
	('centrovac', 'REGISTRAR', GETDATE(), 0),
	('personas', 'REGISTRAR', GETDATE(), 0),
	('stockvacunas', 'REGISTRAR', GETDATE(), 0),
	('responsables', 'REGISTRAR', GETDATE(), 0),
	('vacunacion', 'REGISTRAR', GETDATE(), 0)
GO

-- INGRESANDO ALGUNOS REGISTROS DE TIPOS DE CENTROS
INSERT INTO tipocentrovac (tipocentro) VALUES 
	('Institución Educativa'),
	('Posta médica'),
	('Clínica Particular'),
	('Hospital')
GO


-- CONSULTAS A LOS DEPARTAMENTOS, PROVINCIAS, DISTRITOS
SELECT * FROM departamentos
SELECT * FROM provincias
SELECT * FROM distritos
GO


-- CONSULTA A LAS PROVINCIAS QUE PERTENESCAN A UN DETERMINADO - DEPARTAMENTO
SELECT DPT.iddepartamento, DPT.departamento, PRV.idprovincia, PRV.provincia 
	FROM departamentos DPT
	INNER JOIN provincias PRV ON PRV.iddepartamento = DPT.iddepartamento
	WHERE departamento = 'ica'
GO

SELECT * FROM distritos WHERE distrito = 'chorrillos'
GO

-- CONSULTA TODOS LOS DISTRITOS QUE PERTENESCAN A - 'CHINCHA'
SELECT PRV.provincia, DST.iddistrito, DST.distrito 
	FROM provincias PRV
	INNER JOIN distritos DST ON DST.idprovincia = PRV.idprovincia
	WHERE provincia = 'chincha'
GO


UPDATE auditoria SET totalelementos = 3 WHERE nombretabla = 'centrovac'
SELECT * FROM auditoria
SELECT * FROM centrovac
GO
