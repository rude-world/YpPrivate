
CREATE OR REPLACE PROCEDURE public.insert(
	_id integer,
	_name character varying,
	_salary integer,
	_department integer)
LANGUAGE 'plpgsql'
AS $BODY$
begin
	insert into employee(id, name, salary, department)
	values (_id, _name, _salary, _department);
end
$BODY$;
