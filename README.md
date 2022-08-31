# Example Docker compose for Telegraf, InfluxDB and Grafana, Sample Asp.Net Core App, MondoDB, Elasticsearch + Kibana

Sample docker-compose file with TIF, Elastisearch + Kibana, Asp.Net Core file, MongoDB


## Start the stack with docker compose

```bash
$ docker-compose up
```

## Services and Ports

### Grafana
- URL: http://localhost:3000 
- User: admin 
- Password: admin 

### Telegraf
- Port: 8125 UDP (StatsD input)

### InfluxDB
- Port: 8086 (HTTP API)
- User: admin 
- Password: admin 
- Database: influx

### Elasticsearch
- Port: 9200/9300

### Kibana
- URL: http://localhost:5601

### Sample Asp.Net Core App
- URL: http://localhost:8080

### MongoDB
- Port: 27017
- User: admin 
- Password: admin 



## License

The MIT License (MIT). Please see [License File](LICENSE) for more information.

