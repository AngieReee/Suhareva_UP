-- public.materialstype определение

-- Drop table

-- DROP TABLE public.materialstype;

CREATE TABLE public.materialstype (
	materialtypeid int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	title varchar(30) NOT NULL,
	perofdefects numeric NOT NULL,
	CONSTRAINT materialstype_pkey PRIMARY KEY (materialtypeid)
);


-- public.partnerstype определение

-- Drop table

-- DROP TABLE public.partnerstype;

CREATE TABLE public.partnerstype (
	partnerstypeid int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	title varchar(100) NOT NULL,
	CONSTRAINT partnerstype_pkey PRIMARY KEY (partnerstypeid)
);


-- public.productstype определение

-- Drop table

-- DROP TABLE public.productstype;

CREATE TABLE public.productstype (
	producttypeid int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	title varchar(50) NOT NULL,
	CONSTRAINT productstype_pkey PRIMARY KEY (producttypeid)
);


-- public.salespoints определение

-- Drop table

-- DROP TABLE public.salespoints;

CREATE TABLE public.salespoints (
	salepointsid int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	title varchar(100) NOT NULL,
	address varchar(300) NOT NULL,
	CONSTRAINT salespoints_pkey PRIMARY KEY (salepointsid)
);


-- public.materials определение

-- Drop table

-- DROP TABLE public.materials;

CREATE TABLE public.materials (
	material int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	materialtypeid int4 NULL,
	title varchar(300) NOT NULL,
	CONSTRAINT materials_pkey PRIMARY KEY (material),
	CONSTRAINT materials_materialtypeid_fkey FOREIGN KEY (materialtypeid) REFERENCES public.materialstype(materialtypeid)
);


-- public.partners определение

-- Drop table

-- DROP TABLE public.partners;

CREATE TABLE public.partners (
	partnersid int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	partnerstypeid int4 NOT NULL,
	title varchar(100) NOT NULL,
	legaladdress varchar(300) NOT NULL,
	inn varchar(100) NOT NULL,
	head varchar(150) NOT NULL,
	phonenumber varchar(30) NOT NULL,
	email varchar(100) NOT NULL,
	logo varchar(300) NULL,
	rating int4 NULL,
	CONSTRAINT partners_pkey PRIMARY KEY (partnersid),
	CONSTRAINT partners_partnerstypeid_fkey FOREIGN KEY (partnerstypeid) REFERENCES public.partnerstype(partnerstypeid)
);


-- public.partnerssalespoints определение

-- Drop table

-- DROP TABLE public.partnerssalespoints;

CREATE TABLE public.partnerssalespoints (
	partnerssalespointsid int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	salepoint int4 NOT NULL,
	partnersid int4 NOT NULL,
	CONSTRAINT partnerssalespoints_pkey PRIMARY KEY (partnerssalespointsid),
	CONSTRAINT partnerssalespoints_partnersid_fkey FOREIGN KEY (partnersid) REFERENCES public.partners(partnersid),
	CONSTRAINT partnerssalespoints_salepoint_fkey FOREIGN KEY (salepoint) REFERENCES public.salespoints(salepointsid)
);


-- public.products определение

-- Drop table

-- DROP TABLE public.products;

CREATE TABLE public.products (
	productid int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	article varchar(30) NULL,
	producttype int4 NULL,
	title varchar(300) NOT NULL,
	description varchar(600) NULL,
	productimage varchar(300) NULL,
	mincostforpartner numeric NOT NULL,
	height numeric NULL,
	width numeric NULL,
	CONSTRAINT products_pkey PRIMARY KEY (productid),
	CONSTRAINT products_producttype_fkey FOREIGN KEY (producttype) REFERENCES public.productstype(producttypeid)
);


-- public.productsmaterials определение

-- Drop table

-- DROP TABLE public.productsmaterials;

CREATE TABLE public.productsmaterials (
	productsmaterialsid int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	materialid int4 NOT NULL,
	productid int4 NOT NULL,
	CONSTRAINT productsmaterials_pkey PRIMARY KEY (productsmaterialsid),
	CONSTRAINT productsmaterials_materialid_fkey FOREIGN KEY (materialid) REFERENCES public.materials(material),
	CONSTRAINT productsmaterials_productid_fkey FOREIGN KEY (productid) REFERENCES public.products(productid)
);


-- public.partnersproducts определение

-- Drop table

-- DROP TABLE public.partnersproducts;

CREATE TABLE public.partnersproducts (
	partnersproductsid int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	productsid int4 NOT NULL,
	partnersid int4 NOT NULL,
	numberofproducts int4 NOT NULL,
	saledate date NOT NULL,
	CONSTRAINT partnersproducts_pkey PRIMARY KEY (partnersproductsid),
	CONSTRAINT partnersproducts_partnersid_fkey FOREIGN KEY (partnersid) REFERENCES public.partners(partnersid),
	CONSTRAINT partnersproducts_productsid_fkey FOREIGN KEY (productsid) REFERENCES public.products(productid)
);