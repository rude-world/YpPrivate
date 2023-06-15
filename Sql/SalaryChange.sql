-- PROCEDURE: public.salarychange(integer)

-- DROP PROCEDURE IF EXISTS public.salarychange(integer);

CREATE OR REPLACE PROCEDURE public.salarychange(
	arg integer)
LANGUAGE 'plpgsql'
AS $BODY$
begin
	update Employee set
	Salary = Salary + (Salary * arg * 0.01);
end
$BODY$;

ALTER PROCEDURE public.salarychange(integer)
    OWNER TO postgres;
