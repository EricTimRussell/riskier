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
        totalProduction INT,
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
        production INT,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS divisions(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        divisionNumber INT NOT NULL,
        unitSlot1 VARCHAR(255),
        unitSlot2 VARCHAR(255),
        unitSlot3 VARCHAR(255),
        unitSlot4 VARCHAR(255),
        unitSlot5 VARCHAR(255),
        unitSlot6 VARCHAR(255),
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS armies(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        armyNumber INT NOT NULL,
        unitSlot1 VARCHAR(255),
        unitSlot2 VARCHAR(255),
        unitSlot3 VARCHAR(255),
        unitSlot4 VARCHAR(255),
        unitSlot5 VARCHAR(255),
        unitSlot6 VARCHAR(255),
        unitSlot7 VARCHAR(255),
        unitSlot8 VARCHAR(255),
        unitSlot9 VARCHAR(255),
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS carriers(
        id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        carrierNumber INT NOT NULL,
        unitSlot1 VARCHAR(255),
        unitSlot2 VARCHAR(255),
        unitSlot3 VARCHAR(255),
        unitSlot4 VARCHAR(255),
        unitSlot5 VARCHAR(255),
        unitSlot6 VARCHAR(255),
        unitSlot7 VARCHAR(255),
        unitSlot8 VARCHAR(255),
        groundUnit1 VARCHAR(255),
        groundUnit2 VARCHAR(255),
        groundUnit3 VARCHAR(255),
        groundUnit4 VARCHAR(255),
        groundUnit5 VARCHAR(255),
        groundUnit6 VARCHAR(255),
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES riskierAccounts(id) ON DELETE CASCADE
    ) default charset utf8;