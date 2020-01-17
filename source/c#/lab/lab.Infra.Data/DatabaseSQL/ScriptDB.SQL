CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `Municipios` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CdMunicipio` varchar(7) CHARACTER SET utf8mb4 NOT NULL,
    `Nome` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `Uf` varchar(2) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Municipios` PRIMARY KEY (`Id`)
);

CREATE TABLE `Paises` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CdPais` varchar(5) CHARACTER SET utf8mb4 NOT NULL,
    `Nome` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Paises` PRIMARY KEY (`Id`)
);

CREATE TABLE `PessoasFisica` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nome` varchar(250) CHARACTER SET utf8mb4 NOT NULL,
    `Sobrenome` varchar(300) CHARACTER SET utf8mb4 NOT NULL,
    `DataNascimento` datetime(6) NOT NULL,
    `UrlFoto` varchar(150) CHARACTER SET utf8mb4 NULL,
    `Ativo` int NOT NULL DEFAULT 1,
    `Criacao` datetime(6) NOT NULL,
    CONSTRAINT `PK_PessoasFisica` PRIMARY KEY (`Id`)
);

CREATE TABLE `PessoasJuridica` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nome` varchar(450) CHARACTER SET utf8mb4 NOT NULL,
    `NomeFantasia` varchar(450) CHARACTER SET utf8mb4 NOT NULL,
    `Matriz` int NOT NULL DEFAULT 0,
    `Endereco` varchar(250) CHARACTER SET utf8mb4 NOT NULL,
    `Numero` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
    `Complemento` varchar(100) CHARACTER SET utf8mb4 NULL,
    `Bairro` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `CEP` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
    `Telefone` varchar(15) CHARACTER SET utf8mb4 NULL,
    `Celular` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
    `Email` varchar(250) CHARACTER SET utf8mb4 NOT NULL,
    `InscricaoEstadual` varchar(20) CHARACTER SET utf8mb4 NULL,
    `Cnpj` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `CNAE` varchar(9) CHARACTER SET utf8mb4 NULL,
    `InscricaoMunicipal` varchar(20) CHARACTER SET utf8mb4 NULL,
    `NrSuframa` varchar(9) CHARACTER SET utf8mb4 NULL,
    `NaturezaJuridica` int NOT NULL,
    `NomeContato` varchar(150) CHARACTER SET utf8mb4 NULL,
    `WebSite` varchar(200) CHARACTER SET utf8mb4 NULL,
    `DmContribuicao` int NOT NULL DEFAULT 0,
    `MunicipioId` int NOT NULL,
    `PessoaFisicaId` int NOT NULL,
    CONSTRAINT `PK_PessoasJuridica` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_PessoasJuridica_Municipios_MunicipioId` FOREIGN KEY (`MunicipioId`) REFERENCES `Municipios` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_PessoasJuridica_PessoasFisica_PessoaFisicaId` FOREIGN KEY (`PessoaFisicaId`) REFERENCES `PessoasFisica` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_PessoasJuridica_MunicipioId` ON `PessoasJuridica` (`MunicipioId`);

CREATE INDEX `IX_PessoasJuridica_PessoaFisicaId` ON `PessoasJuridica` (`PessoaFisicaId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20200116163754_addtabelasiniciais', '3.1.0');

CREATE TABLE `GrupoUsers` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nome` varchar(350) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_GrupoUsers` PRIMARY KEY (`Id`)
);

CREATE TABLE `Users` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nome` varchar(350) CHARACTER SET utf8mb4 NOT NULL,
    `Sobrenome` varchar(250) CHARACTER SET utf8mb4 NOT NULL,
    `DataNascimento` datetime(6) NOT NULL,
    `UrlFoto` longtext CHARACTER SET utf8mb4 NULL,
    `Ativo` int NOT NULL DEFAULT 1,
    `Criacao` datetime(6) NOT NULL,
    `Usuario` varchar(250) CHARACTER SET utf8mb4 NOT NULL,
    `Email` varchar(250) CHARACTER SET utf8mb4 NOT NULL,
    `Senha` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Users` PRIMARY KEY (`Id`)
);

CREATE TABLE `UsersGrupo` (
    `GrupoUserId` int NOT NULL,
    `UserId` int NOT NULL,
    `Ativo` int NOT NULL DEFAULT 1,
    CONSTRAINT `PK_UsersGrupo` PRIMARY KEY (`UserId`, `GrupoUserId`),
    CONSTRAINT `FK_UsersGrupo_GrupoUsers_GrupoUserId` FOREIGN KEY (`GrupoUserId`) REFERENCES `GrupoUsers` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UsersGrupo_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_UsersGrupo_GrupoUserId` ON `UsersGrupo` (`GrupoUserId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20200117002417_AddGrupoPorUsuarios', '3.1.0');

