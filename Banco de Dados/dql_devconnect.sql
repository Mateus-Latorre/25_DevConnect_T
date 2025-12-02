--DQL
SELECT 
    seguir.nome_usuario AS nome_seguidor,
    seguida.nome_usuario AS nome_seguida
FROM tb_seguidor S
INNER JOIN tb_usuario seguir ON S.id_usuario_seguir = seguir.id
INNER JOIN tb_usuario seguida ON S.id_usuario_seguida = seguida.id;

SELECT 
    U.nome_usuario,
    COUNT(S.id_usuario_seguir) AS qtd_seguidores
FROM tb_seguidor S
INNER JOIN tb_usuario U ON S.id_usuario_seguida = U.id
GROUP BY U.nome_usuario;

SELECT 
    U.nome_usuario,
    P.descricao,
    P.imagem_url
FROM tb_publicacao P
INNER JOIN tb_usuario U ON P.id_usuario = U.id;

SELECT 
    U.nome_usuario,
    C.texto,
    P.imagem_url,
    Pub.nome_usuario AS nome_publicador
FROM tb_comentario C
INNER JOIN tb_usuario U ON C.id_usuario = U.id
INNER JOIN tb_publicacao P ON C.id_publicacao = P.id
INNER JOIN tb_usuario Pub ON P.id_usuario = Pub.id

SELECT 
    U.nome_usuario AS publicador,
    P.imagem_url,
    COUNT(Cur.id_usuario) AS qnt_curtidas
FROM tb_curtida Cur
INNER JOIN tb_publicacao P ON Cur.id_publicacao = P.id
INNER JOIN tb_usuario U ON P.id_usuario = U.id
GROUP BY P.imagem_url,
         U.nome_usuario;

SELECT 
	U.nome_usuario, 
	P.id AS Publicacoes
FROM tb_publicacao P
RIGHT JOIN tb_usuario U ON P.id_usuario = U.id
WHERE P.id IS NULL;

SELECT 
	U.nome_usuario, 
	Cur.id AS Curtidas
FROM tb_curtida Cur
RIGHT JOIN tb_usuario U ON Cur.id_usuario = U.id
WHERE Cur.id IS NULL;

SELECT * FROM tb_usuario
SELECT * FROM tb_publicacao
SELECT * FROM tb_comentario
SELECT * FROM tb_curtida
SELECT * FROM tb_seguidor