--DDL
CREATE DATABASE db_devconnect_T
USE db_devconnect_T

CREATE TABLE tb_usuario (
id INT IDENTITY (1,1) PRIMARY KEY,
nome_completo NVARCHAR(255) NOT NULL,
nome_usuario NVARCHAR(50) UNIQUE NOT NULL,
email NVARCHAR(255) UNIQUE NOT NULL,
senha NVARCHAR (50) NOT NULL,
foto_perfil_url NVARCHAR(150) NULL
);

CREATE TABLE tb_publicacao(
id INT IDENTITY(1,1) PRIMARY KEY,
id_usuario INT FOREIGN KEY REFERENCES tb_usuario(id),
descricao NVARCHAR(100) NULL,
imagem_url NVARCHAR(100) NULL,
data_publicacao DATE NOT NULL
);

CREATE TABLE tb_comentario(
id INT IDENTITY(1,1) PRIMARY KEY,
id_usuario INT FOREIGN KEY REFERENCES tb_usuario(id),
id_publicacao INT FOREIGN KEY REFERENCES tb_publicacao(id),
texto NVARCHAR(100) NOT NULL,
data_comentario DATE NOT NULL
);

CREATE TABLE tb_curtida(
id INT IDENTITY(1,1) PRIMARY KEY,
id_usuario INT FOREIGN KEY REFERENCES tb_usuario(id),
id_publicacao INT FOREIGN KEY REFERENCES tb_publicacao(id),
);

CREATE TABLE tb_seguidor(
id_usuario_seguir INT NOT NULL, --pessoa que quer seguir
id_usuario_seguida INT NOT NULL, --pessoa que sera seguida
PRIMARY KEY(id_usuario_seguir, id_usuario_seguida)
);
select * from tb_usuario
delete from tb_usuario
where id = 15

