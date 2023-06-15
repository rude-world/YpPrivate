-- PROCEDURE: public.paramentb(integer)

-- DROP PROCEDURE IF EXISTS public.paramentb(integer);

CREATE OR REPLACE PROCEDURE public.paramentb(
	parament integer)
LANGUAGE 'sql'
AS $BODY$
Select *
from employee
where salary > parament;
$BODY$;

ALTER PROCEDURE public.paramentb(integer)
    OWNER TO postgres;
