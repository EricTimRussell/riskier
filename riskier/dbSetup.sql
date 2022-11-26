CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture',
        teamName VARCHAR(255) NOT NULL,
        totalCapital INT NOT NULL DEFAULT 40,
        totalIndustry INT NOT NULL DEFAULT 40,
        totalAgriculture INT NOT NULL DEFAULT 40
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS regions(
        id INT NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        ownedBy VARCHAR(255),
        capital INT NOT NULL,
        industry INT NOT NULL,
        agriculture INT NOT NULL,
        environment VARCHAR(255) NOT NULL,
        ownerId VARCHAR(255) NOT NULL,
        FOREIGN KEY (ownerId) REFERENCES accounts(id) ON DELETE CASCADE
    ) default charset utf8;

CREATE TABLE
    IF NOT EXISTS assets(
        id VARCHAR(255) NOT NULL primary key,
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
        FOREIGN KEY (ownerId) REFERENCES accounts(id) ON DELETE CASCADE
    ) default charset utf8;