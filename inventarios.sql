DROP TABLE IF EXISTS categorias CASCADE;
CREATE TABLE categorias (
    id bigserial NOT NULL,
    nombre text NOT NULL,

    PRIMARY KEY (id)
);

DROP TABLE IF EXISTS productos CASCADE;
CREATE TABLE productos (
    id bigserial NOT NULL,
    nu_categoria bigint NOT NULL,
    nombre text NOT NULL,
    descripcion text,

    PRIMARY KEY (id),
    FOREIGN KEY (nu_categoria) REFERENCES categorias(id)
);

DROP TABLE IF EXISTS ubicaciones CASCADE;
CREATE TABLE ubicaciones (
    id bigserial NOT NULL,
    nombre text NOT NULL,
    descripcion text,

    PRIMARY KEY (id)
);

DROP TABLE IF EXISTS entradas CASCADE;
CREATE TABLE entradas
(
    id bigserial NOT NULL,
    nu_producto bigint NOT NULL,
    nu_ubicacion bigint NOT NULL,
    cantidad INT NOT NULL,
    factura text,
    fecha_factura date,
    monto numeric(20, 2),
    condicion smallint CHECK(condicion in (0, 1)),
    
    PRIMARY KEY (id),
    FOREIGN KEY (nu_producto) REFERENCES productos(id),
    FOREIGN KEY (nu_ubicacion) REFERENCES ubicaciones(id)
);

DROP TABLE IF EXISTS inventarios CASCADE;
CREATE TABLE inventarios 
(
    id bigserial NOT NULL,
    nu_producto bigint NOT NULL,
    nu_ubicacion bigint NOT NULL,
    cantidad int,

    PRIMARY KEY (id),
    FOREIGN KEY (nu_producto) REFERENCES productos(id),
    FOREIGN KEY (nu_ubicacion) REFERENCES ubicaciones(id)
);
