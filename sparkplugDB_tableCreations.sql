create table Industries(
	IndustryID int identity(1,1) primary key,
	IndustryName varchar(50) NOT NULL,
);

create table Stakeholders(
	StakeholderID int identity(1,1) primary key,
	StakeholderRole varchar(50) NOT NULL,
	IndustryID int,
	foreign key (IndustryID) references Industries(IndustryID)
);

create table Styles(
	StyleID int identity(1,1) primary key,
	StyleName varchar(50) NOT NULL,
);

create table Platforms(
	PlatformID int identity(1,1) primary key,
	PlatformName varchar(50) NOT NULL,
);

create table ComplexityLevels(
	ComplexityID int identity(1,1) primary key,
	ComplexityLevel varchar(50) NOT NULL,
);

create table BackendTechnologies(
	BackendID int identity(1,1) primary key,
	BackendName varchar(50) NOT NULL,
);

create table FrontendTechnologies(
	FrontendID int identity(1,1) primary key,
	FrontendName varchar(50) NOT NULL,
);

create table Languages(
	LanguageID int identity(1,1) primary key,
	LanguageName varchar(50) NOT NULL,
);

create table Stacks(
	StackID int identity(1,1) primary key,
	StackName varchar(50) NOT NULL,
	LanguageID int,
	FrontendID int,
	BackendID int,
	foreign key (LanguageID) references Languages(LanguageID),
	foreign key (FrontendID) references FrontendTechnologies(FrontendID),
	foreign key (BackendID) references BackendTechnologies(BackendID),
);

create table Projects(
	ProjectID int identity(1,1) primary key,
	ProjectName varchar(50) NOT NULL,
	ProjectDescription varchar(50) NOT NULL,
	StackID int,
	ComplexityID int,
	PlatformID int,
	StyleID int,
	IndustryID int,
	foreign key (StackID) references Stacks(StackID),
	foreign key (ComplexityID) references ComplexityLevels(ComplexityID),
	foreign key (PlatformID) references Platforms(PlatformID),
	foreign key (StyleID) references Styles(StyleID),
	foreign key (IndustryID) references Industries(IndustryID)
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