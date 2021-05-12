
CREATE DATABASE VETERINARIO_CETYS;
use VETERINARIO_CETYS;

CREATE TABLE t_VETERINARIOS(
	DNI varchar(20) PRIMARY KEY,
	password varchar(250) NOT NULL,
	Nombre varchar(50) NOT NULL ,
	Apellidos varchar(100),
	Sexo varchar(10),
	Edad Tinyint,
	email varchar(75) NOT NULL,
	Especialidad varchar(50) NOT NULL,
	ID Tinyint NOT NULL
);

ALTER TABLE t_VETERINARIOS add
CONSTRAINT ch_Especialidad CHECK (Especialidad='General' OR Especialidad='Dermatología' OR Especialidad='Cardiología' OR Especialidad='Reproducción' OR Especialidad='Oftalmología');
ALTER TABLE t_VETERINARIOS add
CONSTRAINT ch_Sexo CHECK (Sexo='Hombre' OR Sexo='Mujer');
ALTER TABLE t_VETERINARIOS add
CONSTRAINT ch_ID CHECK (ID='0' OR ID='1' OR ID='2');

CREATE TABLE t_CLIENTES(	
	DNI varchar(20) PRIMARY KEY,
	Nombre varchar(25) NOT NULL,
	Apellidos varchar(50),
	email varchar(75) NOT NULL,
	Movil varchar(15) NOT NULL
);

CREATE TABLE t_MASCOTAS(	
	Chip varchar(50) PRIMARY KEY,
	Nombre varchar(25),
	Raza varchar(25),
	Edad Tinyint,
	Genero varchar(10),
	Amo varchar(20),
	VeterinarioPersonal varchar(20)
);

ALTER TABLE t_MASCOTAS add
CONSTRAINT ch_Raza CHECK (Raza='Canino' OR Raza='Felino' OR Raza='Otro');
ALTER TABLE t_MASCOTAS add
CONSTRAINT ch_Genero CHECK (Genero='Macho' OR Genero='Hembra');

ALTER TABLE t_MASCOTAS add
CONSTRAINT fk_Amo FOREIGN KEY (Amo) REFERENCES t_CLIENTES (DNI)
on update cascade;
ALTER TABLE t_MASCOTAS add
CONSTRAINT fk_VetPer FOREIGN KEY (VeterinarioPersonal) REFERENCES t_VETERINARIOS (DNI)
on update cascade;

CREATE TABLE t_CITAS(
	ID_Citas varchar(99) PRIMARY KEY,
	Veterinario_Cita varchar(20),
	Mascota_Cita varchar(50),
	Fecha varchar(50) NOT NULL,
	Hora varchar(10) NOT NULL,
	Concepto varchar(100)
);

ALTER TABLE t_CITAS add
CONSTRAINT fk_VetCita FOREIGN KEY (Veterinario_Cita) REFERENCES t_VETERINARIOS (DNI);
ALTER TABLE t_CITAS add
CONSTRAINT fk_MascotaCita FOREIGN KEY (Mascota_Cita) REFERENCES t_MASCOTAS (Chip);

-- Insertar valores en las tablas

INSERT INTO t_VETERINARIOS VALUES
('00000000A', '1234', 'Jefe', 'Jefazo', 'Hombre', '50', 'jefemanda@gmail.com', 'General', '0'), 
('11111110A', '1234', 'Pepa', 'Rodríguez', 'Mujer', '57', 'pepita77@gmail.com', 'General', '1'), 
('11111111A', '1234', 'Manuel', 'Ros', 'Hombre', '41', 'manuros@gmail.com', 'General', '1'), 
('11111112A', '1234', 'Rosa', 'Alvarez', 'Mujer', '37', 'rosa644@gmail.com', 'General', '1'),  
('11311111A', '1234', 'Antonio', 'Menendez', 'Mujer', '29', 'antox@gmail.com', 'General', '1'), 
('11211111A', '1234', 'Eugenia', 'Menendez', 'Mujer', '29', 'laeuge@gmail.com', 'General', '1'), 
('11111113A', '1234', 'Jose', 'Rodríguez', 'Hombre', '27', 'joserod@gmail.com', 'Dermatología', '2'), 
('11111114A', '1234', 'Jorge', 'Moreno', 'Hombre', '44', 'jorgerubio@gmail.com', 'Dermatología', '2'), 
('11111115A', '1234', 'Pablo', 'Alvarez', 'Hombre', '52', 'pabloduck@gmail.com', 'Cardiología', '2'), 
('11111116A', '1234', 'María', 'Caparros', 'Mujer', '35', 'merivampi@gmail.com', 'Cardiología', '2'),
('11111117A', '1234', 'Sofía', 'Lorenzo', 'Mujer', '31', 'sofichao@gmail.com', 'Reproducción', '2'), 
('11111118A', '1234', 'Natalia', 'Rodríguez', 'Mujer', '35', 'natinat@gmail.com', 'Reproducción', '2'), 
('11111119A', '1234', 'Federico', 'Matamoros', 'Hombre', '34', 'fedemata@gmail.com', 'Oftalmología', '2'), 
('12111111A', '1234', 'Marcos', 'Guapo', 'Hombre', '29', 'marcwapo@gmail.com', 'Oftalmología', '2');

INSERT INTO t_CLIENTES VALUES
('20000000A', 'Jesus', 'Garrido', 'yisus@gmail.com', '600000000'),
('20000001A', 'Juan', 'Fernandez', 'ferxo11@gmail.com', '600000001'),
('20000002A', 'Jimena', 'Labandeira', 'jime69@gmail.com', '600000002'),
('20000003A', 'Maria', 'Rosa', 'merisous@gmail.com', '600000003'),
('20000004A', 'Natalia', 'Rodrigo', 'pollito22@gmail.com', '600000004'),
('20000005A', 'Alfredo', 'Garrido', 'alfred888@gmail.com', '600000005'),
('20000006A', 'Karel', 'Java', 'fibonacci10@gmail.com', '600000006'),
('20000007A', 'Mateo', 'Laguna', 'chetao44@gmail.com', '600000007');

INSERT INTO t_MASCOTAS VALUES
('A1111111', 'Luno', 'Canino', '3', 'Macho', '20000000A', '11111111A'),
('B1111111', 'Mika', 'Canino', '7', 'Hembra', '20000001A', '11111111A'),
('C1111111', 'Cosix', 'Canino', '2', 'Macho', '20000002A', '11111111A'),
('D1111111', 'Tedy', 'Felino', '10', 'Macho', '20000003A', '11111112A'),
('E1111111', 'Lula', 'Felino', '5', 'Hembra', '20000004A', '11111112A'),
('F1111111', 'Gery', 'Otro', '2', 'Macho', '20000005A', '11111112A'),
('H1111111', 'Perry', 'Otro', '5', 'Hembra', '20000006A', '11111112A'),
('I1111111', 'Totix', 'Canino', '1', 'Hembra', '20000007A', '00000000A'),
('J1111111', 'Gerard', 'Felino', '3', 'Macho', '20000007A', '00000000A'),
('K1111111', 'Yoryo', 'Otro', '2', 'Macho', '20000001A', '00000000A');


INSERT INTO t_CITAS VALUES
('11111111', '11111117A', 'E1111111', '27/02/2020', '16:00', 'Revision para parto inminente'),
('11111112', '11111112A', 'F1111111', '21/12/2020', '17:00', 'Revision general rudimentaria'),
('11111113', '11111117A', 'C1111111', '14/02/2020', '08:00', 'Inyeccion contra posibles parasitos'),
('11111114', '12111111A', 'A1111111', '10/03/2020', '10:00', 'Revision general'),
('11111115', '11111110A', 'I1111111', '10/05/2020', '17:00', 'Revision contra parasitos'),
('11111116', '12111111A', 'D1111111', '14/05/2020', '18:00', 'Revision general'),
('11111117', '11111118A', 'B1111111', '5/06/2020', '10:00', 'Revision preventiva para pulgas'),
('11111118', '11111119A', 'J1111111', '17/06/2020', '15:00', 'Revision general'),
('12111110', '11111119A', 'I1111111', '11/01/2020', '11:00', 'Revision general'),
('12111111', '11311111A', 'F1111111', '14/02/2020', '12:00', 'Revision general'),
('12111112', '11111119A', 'F1111111', '10/02/2020', '18:00', 'Revision general'),
('12111113', '11111119A', 'A1111111', '19/03/2020', '17:00', 'Revision general'),
('12111114', '11311111A', 'A1111111', '10/03/2020', '19:00', 'Revision general'),
('12111115', '11311111A', 'J1111111', '14/04/2020', '12:00', 'Revision general'),
('12111116', '11211111A', 'J1111111', '11/05/2020', '11:00', 'Revision general'),
('12111117', '11211111A', 'K1111111', '01/06/2020', '12:00', 'Revision general'),
('12111118', '11211111A', 'K1111111', '07/09/2020', '17:00', 'Revision general'),
('11111119', '11111110A', 'H1111111', '1/07/2020', '12:00', 'Inyeccion rudimentaria');
