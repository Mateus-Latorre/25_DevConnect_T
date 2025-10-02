--DML
INSERT INTO tb_usuario(nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES('Mateus Latorre','mateus_latorre','mateuslatorre@gmail.com','12345ma','fotoperfildevconnect.com'),
('João Paulo','joaozin123','joaopa123@gmail.com','jpa12','fotocarropreto.com'),
('Ana Silva','aninha:)','silva47@gmail.com','silva4632','fotogatinhofofinho.com');

INSERT INTO tb_publicacao(id_usuario, descricao, imagem_url, data_publicacao)
VALUES(5,'Imagem da empresa DevConnect','logo_devconnect.com','2025-10-02'),
(7,'Esse é o carro dos meus sonhos','foto-carro-preto-insano.com','2025-10-01'),
(8,'Meu gatinho é muito fofo','foto-gatinho-fofinho.com','2025-05-30');

INSERT INTO tb_comentario(id_usuario, id_publicacao, texto, data_comentario)
VALUES(5,2,'Muito bonita a logo da DevConnect','2025-10-02'),
(8,3,'Esse carro é muito maneiro mesmo','2025-10-01'),
(7,4,'Nossa, seu gatinho é muito fofinho','2025-05-31');

INSERT INTO tb_curtida(id_usuario, id_publicacao)
VALUES(5,2),
(8,3),
(7,4);

INSERT INTO tb_seguidor(id_usuario_seguir,id_usuario_seguida)
VALUES(5,8),
(8,7),
(7,5);
