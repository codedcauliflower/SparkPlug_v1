USE SparkPlugDB
GO

create table Industries(
	IndustryID int identity(1,1) primary key,
	IndustryName varchar(50) NOT NULL,
);

create table Styles(
	StyleID int identity(1,1) primary key,
	StyleName varchar(50) NOT NULL,
);

create table AppTypes(
	AppTypeID int identity(1,1) primary key,
	AppType varchar(50) NOT NULL,
);

create table ComplexityLevels(
	ComplexityID int identity(1,1) primary key,
	ComplexityLevel varchar(50) NOT NULL,
);

create table BackendTechnologies(
	BackendID int identity(1,1) primary key,
	BackendName varchar(50) NOT NULL,
);

create table [Databases](
	DatabaseID int identity(1,1) primary key,
	DatabaseName varchar(50) NOT NULL,
);

create table FrontendTechnologies(
	FrontendID int identity(1,1) primary key,
	FrontendName varchar(50) NOT NULL,
);

create table Languages(
	LanguageID int identity(1,1) primary key,
	LanguageName varchar(50) NOT NULL,
);

create table Projects(
	ProjectID int identity(1,1) primary key,
	ProjectName varchar(50) NOT NULL,
	ProjectDescription varchar(50) NOT NULL,
	ComplexityID int,
	AppTypeID int,
	StyleID int,
	IndustryID int,
	LanguageID int,
	FrontendID int,
	BackendID int,
	DatabaseID int,
	foreign key (ComplexityID) references ComplexityLevels(ComplexityID),
	foreign key (AppTypeID) references AppTypes(AppTypeID),
	foreign key (StyleID) references Styles(StyleID),
	foreign key (LanguageID) references Languages(LanguageID),
	foreign key (FrontendID) references FrontendTechnologies(FrontendID),
	foreign key (BackendID) references BackendTechnologies(BackendID),
	foreign key (DatabaseID) references [Databases](DatabaseID),

);

create table Concepts(
	ConceptID int identity(1,1) primary key,
	ConceptName varchar(50) NOT NULL,
);

create table Projects_Concepts(
	ProjectID INT,
    ConceptID INT,
    PRIMARY KEY (ProjectID, ConceptID),
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID),
    FOREIGN KEY (ConceptID) REFERENCES Concepts(ConceptID)
);