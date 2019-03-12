CREATE TABLE Equipa (
  ID            int(5) NOT NULL AUTO_INCREMENT comment 'É uma variável do tipo int que recebe o id das equipas, pois as equipas que podem ser criadas são infinitas ou seja o id pode chegar a ter vários digitos, logo tem de ser um bigint.', 
  Nome          varchar(60) NOT NULL UNIQUE comment 'É uma varíavel do tipo String que atribui um nome de cada equipa.', 
  Convocada     bit(1) NOT NULL comment 'É uma variável do tipo boolean que verifica se a equipa está ou não convocada para o torneio tartaruga, se sim a equipa é adicionada à lista de equipas, se não a equipa continua na lista de equipas criadas, mas não se encontra adicionada no torneio.
Não pode ser null.', 
  Classificacao bigint(10) NOT NULL UNIQUE comment 'É uma variável do tipo long que recebe o lugar em que a equipa ficou no decorrer do torneio tartaruga, o motivo para esta ser um long deve-se ao facto de o id também ser um long e como o número de equipas que podem ser criadas é infinito, então a posição em que a equipa se encontra no torneio também pode chegar a conter bastantes digitos, o que leva esta variável a ser um long.
Não pode ser null e é unique.', 
  PRIMARY KEY (ID));
CREATE TABLE Jogador (
  ID       int(5) NOT NULL AUTO_INCREMENT comment 'É uma variável do tipo int que recebe o id dos jogadores, pois os jogadores podem ser criados são infinitos ou seja o id pode chegar a ter vários digitos, logo tem de ser um bigint.', 
  Nome     varchar(60) NOT NULL UNIQUE comment 'É uma varíavel do tipo String que atribui um nome de cada jogador.', 
  Idade    int(3) NOT NULL comment 'Esta variável é um int encarregue atribuição da idade a cada jogador, a variável é do tipo int e não do tipo long porque os jogadores no máximo tem dois digitos no valor da idade, e não é DateTime, pois não é necessário a informação que diz respeito aos meses e dias, ou seja não são crianças com idades inferiores a 1 ano.
Não pode ser null.', 
  Altura   double NOT NULL comment 'É uma variável do tipo double que recebe a altura dos jogadores, pois as alturas têm no máximo 3 digitos mas tem números décimais, logo tem de ser um double.
Não pode ser null.', 
  Posicao  varchar(20) NOT NULL comment 'É uma variável do tipo string que indica a posição do jogador no campo
(base, extremo, poste etc... ) em cada equipa.
Não pode ser null.', 
  EquipaID int(5) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Treinador (
  ID        int(5) NOT NULL AUTO_INCREMENT comment 'É uma variável do tipo int que recebe o id dos treinadores, pois os treinadores podem ser criados são infinitos ou seja o id pode chegar a ter vários digitos, logo tem de ser um bigint.', 
  Nome      varchar(60) NOT NULL UNIQUE comment 'É uma varíavel do tipo String que atribui um nome de cada Treinador.', 
  Idade     int(3) NOT NULL comment 'Esta variável é um int encarregue atribuição da idade a cada treinador, a variável é do tipo int e não do tipo long porque os treinadores no máximo tem dois digitos no valor da idade, e não é DateTime, pois não é necessário a informação que diz respeito aos meses e dias, ou seja não são crianças com idades inferiores a 1 ano.
Não pode ser null.', 
  Altura    double NOT NULL comment 'É uma variável do tipo double que recebe a altura dos treinadores, pois as alturas têm no máximo 3 digitos mas tem números décimais, logo tem de ser um double.
Não pode ser null.', 
  Categoria varchar(40) NOT NULL comment 'É uma variável do tipo stirng que recebe uma string que indica a categoria do treinador na equipa.
Não pode ser null.', 
  EquipaID  int(5) NOT NULL, 
  PRIMARY KEY (ID));
ALTER TABLE Jogador ADD CONSTRAINT Contrata FOREIGN KEY (EquipaID) REFERENCES Equipa (ID);
ALTER TABLE Treinador ADD CONSTRAINT Treina FOREIGN KEY (EquipaID) REFERENCES Equipa (ID);
