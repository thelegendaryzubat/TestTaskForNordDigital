CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

DROP TABLE IF EXISTS public."Users" CASCADE;
DROP TABLE IF EXISTS public."Todos";

CREATE TABLE  public."Users"
(
    Id           UUID PRIMARY KEY,
    UserName     TEXT NOT NULL,
    Password     TEXT NOT NULL
);

CREATE TABLE  public."Todos"
(
    Id           UUID PRIMARY KEY,
    Title        VARCHAR NOT NULL,
    UserId       UUID NOT NULL REFERENCES "Users" (Id) ON DELETE CASCADE
);

INSERT INTO public."Users" (Id, UserName, Password)
VALUES ('1568f882-6185-4ffc-ac01-230d87e7d6fe', 'John Doe', MD5(random()::text)),
       ('7fc7976d-6c67-4431-a390-370e8f2ede3b', 'Jane Doe', MD5(random()::text)),
       ('4de09b2e-99de-416a-b8ed-5d07eca5ac95', 'Adam Smith', MD5(random()::text));

INSERT INTO public."Todos" (Id, Title, UserId)
VALUES (uuid_generate_v4(), MD5(random()::text), '1568f882-6185-4ffc-ac01-230d87e7d6fe'),
       (uuid_generate_v4(), MD5(random()::text), '1568f882-6185-4ffc-ac01-230d87e7d6fe'),
       (uuid_generate_v4(), MD5(random()::text), '1568f882-6185-4ffc-ac01-230d87e7d6fe'),
       (uuid_generate_v4(), MD5(random()::text), '1568f882-6185-4ffc-ac01-230d87e7d6fe'),
       (uuid_generate_v4(), MD5(random()::text), '1568f882-6185-4ffc-ac01-230d87e7d6fe'),
       (uuid_generate_v4(), MD5(random()::text), '7fc7976d-6c67-4431-a390-370e8f2ede3b'),
       (uuid_generate_v4(), MD5(random()::text), '7fc7976d-6c67-4431-a390-370e8f2ede3b'),
       (uuid_generate_v4(), MD5(random()::text), '7fc7976d-6c67-4431-a390-370e8f2ede3b'),
       (uuid_generate_v4(), MD5(random()::text), '4de09b2e-99de-416a-b8ed-5d07eca5ac95');