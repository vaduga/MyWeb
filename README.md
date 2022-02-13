
local run: 
  docker-compose up          // psql container
  dotnet run MyWebApp

deployed to heroku: 
  https://dataheavy.herokuapp.com         // DB: heroku psql online data-source
                                          // switched DB connection string in appsettings.json
