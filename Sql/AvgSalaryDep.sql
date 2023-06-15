
CREATE OR REPLACE PROCEDURE public.avgsalarydep(
	dep integer)
LANGUAGE 'sql'
AS $BODY$
Select count(*),
sum(salary)/count(*) as avg
from employee
where department = dep;
$BODY$;

ALTER PROCEDURE public.avgsalarydep(integer)
    OWNER TO postgres;
