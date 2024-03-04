CREATE SCHEMA IF NOT EXISTS public;

DROP TABLE IF EXISTS events CASCADE;
DROP TABLE IF EXISTS tasks CASCADE;
DROP TABLE IF EXISTS task_types CASCADE;
DROP TABLE IF EXISTS areas CASCADE;
DROP TABLE IF EXISTS pets CASCADE;
DROP TABLE IF EXISTS breeds CASCADE;
DROP TABLE IF EXISTS species CASCADE;

CREATE TABLE species (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50)
);

CREATE TABLE breeds (
	id SERIAL PRIMARY KEY,
	name VARCHAR(100),
	species_id INT,
	FOREIGN KEY (species_id) REFERENCES species(id)
);

CREATE TABLE pets(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50),
	breed_id INT,
	birthdate TIMESTAMP,
	chip_id VARCHAR(15),
	is_active BOOLEAN DEFAULT TRUE,
	FOREIGN KEY (breed_id) REFERENCES breeds(id)
);

CREATE TABLE areas(
	id INT PRIMARY KEY,
	name VARCHAR(50) 
);

CREATE TABLE task_types(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50),
	frequency INT,
	remind_before INT,
	needs_deworming BOOLEAN,
	area_id INT,
	FOREIGN KEY (area_id) REFERENCES areas(id)
);

CREATE TABLE tasks(
	id SERIAL PRIMARY KEY,
	type_id INT,
	pet_id INT,
	description VARCHAR(200),
	performed_at TIMESTAMP,
	is_active BOOLEAN DEFAULT TRUE,
	FOREIGN KEY (type_id) REFERENCES task_types(id),
	FOREIGN KEY (pet_id) REFERENCES pets(id)
);

CREATE TABLE events(
	id SERIAL PRIMARY KEY,
	task_id INT,
	notes VARCHAR(500),
	performed_at TIMESTAMP,
	FOREIGN KEY (task_id) REFERENCES tasks(id)
);