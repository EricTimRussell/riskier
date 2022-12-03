-- Active: 1666715465757@@SG-alive-fang-7766-6843-mysql-master.servers.mongodirector.com@3306@FakeDb

CREATE TABLE
    IF NOT EXISTS riskierAccounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture',
        teamName VARCHAR(255) DEFAULT 'Team Name',
        totalCapital INT NOT NULL,
        totalIndustry INT NOT NULL,
        totalAgriculture INT NOT NULL,
        infantry INT,
        specialForces INT,
        MECH INT,
        IFV INT,
        MBT INT,
        artillery INT,
        ssArtillery INT,
        antiAircraft INT,
        fighterAircraft INT,
        closeAirSupport INT,
        carrier INT,
        cruiser INT,
        destroyer INT,
        supplyTruck INT,
        transportAircraft INT,
        airfield INT,
        navalYard INT,
        warehouse INT,
        factory INT
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS regions(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        regionNumber INT NOT NULL,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        environment VARCHAR(255) NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS infantry(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS specialForces(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS mech(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS ifv(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS mbt(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS artillery(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS ssArtillery(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS antiAircraft(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS supplyTruck(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS fighterAircraft(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS closeAirSupport(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS transportAircraft(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS airfield(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS navalYard(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS warehouse(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS factory(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS carrier(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS cruiser(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS destroyer(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;