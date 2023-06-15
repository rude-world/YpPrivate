-- FUNCTION: public.minsalarydep(integer)

-- DROP FUNCTION IF EXISTS public.minsalarydep(integer);

CREATE OR REPLACE FUNCTION public.minsalarydep(
	dep integer)
    RETURNS employee
    LANGUAGE 'sql'
    COST 100
    VOLATILE PARALLEL UNSAFE
AS $BODY$
	select * from employee where department = dep
	order by salary desc;
$BODY$;

ALTER FUNCTION public.minsalarydep(integer)
    OWNER TO postgres;
