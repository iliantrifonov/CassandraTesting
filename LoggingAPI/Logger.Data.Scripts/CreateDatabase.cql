CREATE KEYSPACE IF NOT EXISTS logger	 
	WITH REPLICATION = { 
		'class' : 'SimpleStrategy', 'replication_factor' : 1
	}; 

USER logger;

CREATE TABLE IF NOT EXISTS logs (
	id int,
	created_datetime timestamp,
	action text,
	log_text text,
	ip text,
	user_id uuid,
	PRIMARY KEY (id)
);