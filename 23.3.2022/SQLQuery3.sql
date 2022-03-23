CREATE TABLE Users
(
	"Id" INT PRIMARY KEY not null,
	"FirstName" varchar,
	"LastName" varchar,
	"PostalCodeId" INT,
	FOREIGN KEY ("PostalCodeId") REFERENCES PlaceOfBirth("PostalCode")
);