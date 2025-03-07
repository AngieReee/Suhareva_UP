create table MaterialsType(
MaterialTypeID int not null generated always as identity primary key,
Title varchar(30) not null,
PerOfDefects decimal not null
);

create table Materials(
Material int not null generated always as identity primary key,
MaterialTypeID int,
Title varchar(300) not null
);

create table ProductsType(
ProductTypeID int not null generated always as identity primary key,
Title varchar(50) not null
);

create table Products(
ProductID int not null generated always as identity primary key,
Article varchar(30),
ProductType int,
Title varchar(300) not null,
Description varchar(600),
ProductImage varchar(300),
MinCostForPartner decimal not null,
Height decimal,
Width decimal
);


create table SalesPoints(
SalePointsID int not null generated always as identity primary key,
Title varchar(100) not null,
Address varchar(300) not null
);

create table PartnersType(
PartnersTypeID int not null generated always as identity primary key,
Title varchar(100) not null
);

create table Partners(
PartnersID int not null generated always as identity primary key,
PartnersTypeID int not null,
Title varchar(100) not null,
LegalAddress varchar(300) not null,
INN varchar(100) not null,
Head varchar(150) not null,
PhoneNumber varchar(30) not null,
Email varchar(100) not null,
Logo varchar(300),
Rating int
);

create table PartnersProducts(
PartnersProductsID int not null generated always as identity primary key,
ProductsID int not null,
PartnersID int not null,
NumberOfProducts int not null,
SaleDate date not null
);

create table PartnersSalesPoints(
PartnersSalesPointsID int not null generated always as identity primary key,
SalePoint int not null,
PartnersID int not null
);

create table ProductsMaterials(
ProductsMaterialsID int not null generated always as identity primary key,
MaterialID int not null,
ProductID int not null
);

alter table PartnersProducts 
add foreign key (ProductsID) references Products(ProductID)

alter table PartnersProducts 
add foreign key (PartnersID) references Partners(PartnersID)

alter table Partners 
add foreign key (PartnersTypeID) references PartnersType(PartnersTypeID)

alter table PartnersSalesPoints 
add foreign key (SalePoint) references SalesPoints(SalePointsID)

alter table PartnersSalesPoints 
add foreign key (PartnersID) references Partners(PartnersID)

alter table Products 
add foreign key (ProductType) references ProductsType(ProductTypeID)

alter table Materials
add foreign key (MaterialTypeID) references MaterialsType(MaterialTypeID)

alter table ProductsMaterials 
add foreign key (ProductID) references Products(ProductID)

alter table ProductsMaterials 
add foreign key (MaterialID) references Materials(Material)