
CREATE OR REPLACE PROCEDURE public.delete(
	_id integer)
LANGUAGE 'plpgsql'
AS $BODY$
begin
	delete from employee
	where id = _id;
end
$BODY$;

ALTER PROCEDURE public.delete(integer)
    OWNER TO postgres;
