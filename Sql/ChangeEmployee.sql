
CREATE OR REPLACE PROCEDURE public.changeemp(
	_id integer,
	_salary integer,
	_department integer)
LANGUAGE 'plpgsql'
AS $BODY$
begin
	update employee
	set salary = _salary,
	department = _department
	where id = _id;
end
$BODY$;
