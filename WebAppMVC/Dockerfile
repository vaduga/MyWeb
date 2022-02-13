FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
EXPOSE 5000

# to define netcore build version, add to .cjproj <GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>

COPY bin/Release/net6.0/publish/ ./

#ENTRYPOINT ["dotnet", "WebAppMVC.dll"]


# --net=host  to let use postgres local ports


# for heroku

CMD ASPNETCORE_URLS=http://*:$PORT dotnet WebAppMVC.dll