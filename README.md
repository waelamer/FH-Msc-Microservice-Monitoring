# FH-Msc-Microservice-Monitoring

> This demo contains a Microservice Deal&Provider Based on .net Core 6.0 and Frontend based on Vue 3.0 the application  use the opentelemetry NuGet library for  instrumentation and for sending telemetry data to the opentelemetry collector.

<img src="Docs/Architect.jpg" alt="DealstoreWeb Monitoring tools" title="DealstoreWeb Monitoring tools">

#### The demo exposes the following backends:

### App   


    Frontend at http://localhost:8080/
    Backend Provider API at http://localhost:8081/
    Backend Deal API at http://localhost:8082/


  

### Monitor Tools
    Grafana Tools:
    Grafana at  http://0.0.0.0:3000/
    LOKI at http://0.0.0.0:3100/status
    InfluxDB at : http://0.0.0.0:8086/

    OpenTelemtry Tools :
    Jaeger at http://0.0.0.0:16686
    Zipkin at http://0.0.0.0:9411
    Prometheus at http://0.0.0.0:9090

### Run the demo local

> docker plugin install grafana/loki-docker-driver:latest --alias loki --grant-all-permissions
> git clone https://github.com/waelamer/FH-Msc-Microservice-Monitoring.git && cd FH-Msc-Microservice-Monitoring && docker-compose up -d --force-recreate 



