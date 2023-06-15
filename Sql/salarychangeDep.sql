

CREATE OR REPLACE PROCEDURE public.salarychangeDep(
	dep integer,
	arg integer)
LANGUAGE 'plpgsql'
AS $BODY$
begin
	update Employee set
	Salary = Salary + (Salary * arg * 0.01)
	where department = dep;
end
$BODY$;

ALTER PROCEDURE public.salarychangeDep(integer, integer)
    OWNER TO postgres;
