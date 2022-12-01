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
        totalAgriculture INT NOT NULL
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
    IF NOT EXISTS assets(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        ownerId VARCHAR(255) NOT NULL,
        infantry INT,
        eliteInfantry INT,
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
        factory INT,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;