USE restaurante

CREATE TABLE menu(
idplato INT,
nombreplato NVARCHAR(50),
numeromesa INT,
valor INT,
nombremesero NVARCHAR


CONSTRAINT id_plato PRIMARY KEY (idplato)

);