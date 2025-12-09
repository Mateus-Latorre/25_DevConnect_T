--DML
INSERT INTO tb_usuario(nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES('Mateus Latorre','mateus_latorre','mateuslatorre@gmail.com','12345ma','fotoperfildevconnect.com'),
('João Paulo','joaozin123','joaopa123@gmail.com','jpa12','fotocarropreto.com'),
('Ana Silva','aninha:)','silva47@gmail.com','silva4632','fotogatinhofofinho.com'),
('Pedro André','pedrin_top','pedrin789@yahoo','pedro0989','fotopedrolegal.com');

INSERT INTO tb_publicacao(id_usuario, descricao, imagem_url, data_publicacao)
VALUES(1,'Imagem da empresa DevConnect','logo_devconnect.com','2025-10-02'),
(2,'Esse é o carro dos meus sonhos','foto-carro-preto-insano.com','2025-10-01'),
(3,'Meu gatinho é muito fofo','foto-gatinho-fofinho.com','2025-05-30');

INSERT INTO tb_comentario(id_usuario, id_publicacao, texto, data_comentario)
VALUES(1,4,'Muito bonita a logo da DevConnect','2025-10-02'),
(3,2,'Esse carro é muito maneiro mesmo','2025-10-01'),
(2,3,'Nossa, seu gatinho é muito fofinho','2025-05-31');

INSERT INTO tb_curtida(id_usuario, id_publicacao)
VALUES(1,4),
(3,2),
(2,3);


INSERT INTO tb_seguidor(id_usuario_seguir,id_usuario_seguida)
VALUES(1,4),
(3,2),
(2,3),
(4,1);

ALTER TABLE tb_curtida
ADD PRIMARY KEY (id_usuario, id_publicacao);
DELETE FROM tb_curtida
WHERE id_usuario = 5      ;  
