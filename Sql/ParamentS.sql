
CREATE OR REPLACE PROCEDURE public.paraments(
	parament integer)
LANGUAGE 'sql'
AS $BODY$
Select *
from employee
where salary < parament;
$BODY$;

ALTER PROCEDURE public.paraments(integer)
    OWNER TO postgres;
