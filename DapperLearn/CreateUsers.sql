CREATE TABLE Users
    (
      Id INT NOT NULL
             PRIMARY KEY
             IDENTITY ,
      Name NVARCHAR(10) NOT NULL ,
      AGE INT NOT NULL
    );