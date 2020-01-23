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

CREATE TABLE `Ref311` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Codigo` varchar(5) CHARACTER SET utf8mb4 NOT NULL,
    `Versao` varchar(5) CHARACTER SET utf8mb4 NOT NULL,
    `Leiaout` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Periodo` datetime(6) NOT NULL,
    CONSTRAINT `PK_Ref311` PRIMARY KEY (`Id`)
);

CREATE TABLE `Regs0000EFDC` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `REG` varchar(4) CHARACTER SET utf8mb4 NOT NULL DEFAULT '0000',
    `Ref311Id` int NOT NULL,
    `TIPO_ESCRIT` int NOT NULL,
    `IND_SIT_ESP` int NOT NULL,
    `NUM_REC_ANTERIOR` varchar(41) CHARACTER SET utf8mb4 NULL,
    `DT_INI` datetime(6) NOT NULL,
    `DT_FIN` datetime(6) NOT NULL,
    `IND_NAT_PJ` int NOT NULL,
    `IND_ATIV` int NOT NULL,
    `PessoaJuridicaId` int NOT NULL,
    `UserId` int NOT NULL,
    `MunicipioId` int NULL,
    CONSTRAINT `PK_Regs0000EFDC` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Regs0000EFDC_Municipios_MunicipioId` FOREIGN KEY (`MunicipioId`) REFERENCES `Municipios` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Regs0000EFDC_PessoasJuridica_PessoaJuridicaId` FOREIGN KEY (`PessoaJuridicaId`) REFERENCES `PessoasJuridica` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Regs0000EFDC_Ref311_Ref311Id` FOREIGN KEY (`Ref311Id`) REFERENCES `Ref311` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Regs0000EFDC_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`) ON DELETE CASCADE
);

INSERT INTO `Ref311` (`Id`, `Codigo`, `Leiaout`, `Periodo`, `Versao`)
VALUES (1, '001', 'ADE Cofis nº 31/2010', '2011-04-01 00:00:00.000000', '1.00');
INSERT INTO `Ref311` (`Id`, `Codigo`, `Leiaout`, `Periodo`, `Versao`)
VALUES (2, '002', 'ADE Cofis nº 34/2010, atualizado pelo ADE Cofis nº 37/2010', '2011-04-01 00:00:00.000000', '1.01');
INSERT INTO `Ref311` (`Id`, `Codigo`, `Leiaout`, `Periodo`, `Versao`)
VALUES (3, '002', 'ADE Cofis nº 20/2012', '2011-04-01 00:00:00.000000', '2.00');
INSERT INTO `Ref311` (`Id`, `Codigo`, `Leiaout`, `Periodo`, `Versao`)
VALUES (4, '003', 'ADE Cofis nº 20/2012', '2012-07-01 00:00:00.000000', '2.01A');
INSERT INTO `Ref311` (`Id`, `Codigo`, `Leiaout`, `Periodo`, `Versao`)
VALUES (5, '004', 'ADE Cofis nº 20/2012', '2018-06-01 00:00:00.000000', '3.0.0');
INSERT INTO `Ref311` (`Id`, `Codigo`, `Leiaout`, `Periodo`, `Versao`)
VALUES (6, '005', 'ADE Cofis nº 82/2018', '2019-01-01 00:00:00.000000', '3.1.0');
INSERT INTO `Ref311` (`Id`, `Codigo`, `Leiaout`, `Periodo`, `Versao`)
VALUES (7, '006', 'ADE Cofis nº 82/2018', '2020-01-01 00:00:00.000000', '3.2.0');

CREATE INDEX `IX_Regs0000EFDC_MunicipioId` ON `Regs0000EFDC` (`MunicipioId`);

CREATE UNIQUE INDEX `IX_Regs0000EFDC_PessoaJuridicaId` ON `Regs0000EFDC` (`PessoaJuridicaId`);

CREATE INDEX `IX_Regs0000EFDC_Ref311Id` ON `Regs0000EFDC` (`Ref311Id`);

CREATE UNIQUE INDEX `IX_Regs0000EFDC_UserId` ON `Regs0000EFDC` (`UserId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20200123024314_AdicionandoRegitroEFDC0000', '3.1.0');

