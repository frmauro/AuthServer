
## curl register
curl -X POST "http://localhost:5047/api/auth/register" -H "Content-Type: application/json" -d '{"email":"teste@email.com","password":"Senha123!"}'

## curl login
curl -X POST "http://localhost:5047/api/auth/login" -H "Content-Type: application/json" -d '{"email":"teste@email.com","password":"Senha123!"}'

## curl with Bearer jwt token protected rote
curl -H "Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMmNkYmUzMC00NmUzLTRhMjctYTBlYS01YzY0ZmFmOTQwZWIiLCJlbWFpbCI6InRlc3RlQGVtYWlsLmNvbSIsImp0aSI6ImE1YjhiYjllLWY4NDItNDk3Zi04YjU5LTExODVlODAzM2UzOSIsImV4cCI6MTc0MDA5NTMwN30.OoXfGyixV7WwvS7SZSYMCzXSQTzdz-8QNoxNvIWaJQ4" http://localhost:5047/api/testeauth

## curl without Bearer jwt token protected rote
curl http://localhost:5047/api/testeauth/


## build a image docker
docker build -t authserver .

## command to create a container
 docker run -e  MYSQL_ROOT_HOST=% -e MYSQL_ROOT_PASSWORD=123 --name mysqlserver --network quark -d -p=3306:3306 mysql/mysql-server:5.7.31
 docker run -d -p 5000:8080 --name authserver_container --network quark authserver
 docker run -d -p 5000:5000 -v ./data:/app/data --name authserver authserver


## connectionsString
 "MySqlConnectionString": "Server=localhost;DataBase=quarkAuth;Uid=root;Pwd=123"
 "MySqlConnectionString": "Server= mysqlserver;DataBase=quarkAuth;Uid=root;Pwd=123"


 ## run command bat in windows 11. update enviroment docker
 ./deploy.bat


