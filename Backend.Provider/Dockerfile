  # syntax=docker/dockerfile:1
  FROM mcr.microsoft.com/dotnet/aspnet:6.0
  COPY telegraf/ App/telegraf/
  COPY bin/Release/net6.0/ App/
  WORKDIR /App
  ENTRYPOINT ["dotnet", "DealStoreweb.Backend.Provider.dll"]
  
  RUN apt update && apt -y upgrade
  RUN apt install wget curl gnupg2 lsb-release ca-certificates apt-transport-https software-properties-common -y
  RUN wget -qO- https://repos.influxdata.com/influxdb.key | apt-key add -
  RUN echo "deb https://repos.influxdata.com/debian $(lsb_release -cs) stable"| tee /etc/apt/sources.list.d/influxdb.list
  RUN apt update && apt install telegraf
  #RUN telegraf --config telegraf/telegraf.conf
  CMD ["telegraf", "--config", "telegraf/telegraf.conf"]
  