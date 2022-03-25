echo "start loading data"
psql -v ON_ERROR_STOP=1 --username "$POSTGRES_USER" --dbname "$POSTGRES_DB" <<-EOSQL
    create schema if not exists $SCHEMA;
    GRANT ALL PRIVILEGES ON DATABASE $POSTGRES_DB TO $POSTGRES_USER;
EOSQL

file="./docker-entrypoint-initdb.d/2-sample-data.sql"
echo "Restoring DB using $file"
psql -U $POSTGRES_USER --dbname=$POSTGRES_DB < "$file" || exit 1