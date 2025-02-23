Aanvraag voor biedingen:

De volgende oplossing heeft als hoofddoel het demonstreren van de capaciteit om verzoeken van een oplossing in .NET Core 8.0 WepAPI te verwerken.

Technologieën en architectuur:

.NET Core 8.0 WepAPI;
RabbitMQ;
Entity Framework Core 8.0;
SqlServer;
K6;
Repository;
Dependency Injection;
Singleton;
Swagger;

Solide;
CleanCode;
Microservices;

K6 Resultaten:

Test Case 1:
- Kijkers: 210
- Duur: 100s
- mislukt:0%

     execution: local
        script: .\BidPostAPILoadingTest.js
        output: -

     scenarios: (100.00%) 1 scenario, 210 max VUs, 2m10s max duration (incl. graceful stop):
              * default: 210 looping VUs for 1m40s (gracefulStop: 30s)


     data_received..................: 3.6 MB 35 kB/s
     data_sent......................: 596 kB 5.9 kB/s
     http_req_blocked...............: avg=22.7ms   min=0s      med=0s       max=1.79s    p(90)=0s       p(95)=0s
     http_req_connecting............: avg=54.09µs  min=0s      med=0s       max=26.04ms  p(90)=0s       p(95)=0s
     http_req_duration..............: avg=592.97ms min=8.25ms  med=435.42ms max=3.24s    p(90)=1.33s    p(95)=1.55s
       { expected_response:true }...: avg=592.97ms min=8.25ms  med=435.42ms max=3.24s    p(90)=1.33s    p(95)=1.55s
     http_req_failed................: 0.00%  0 out of 13178
     http_req_receiving.............: avg=6.82ms   min=0s      med=0s       max=594.28ms p(90)=11.7ms   p(95)=44.9ms
     http_req_sending...............: avg=48.83µs  min=0s      med=0s       max=2.01ms   p(90)=304.59µs p(95)=473.9µs
     http_req_tls_handshaking.......: avg=22.39ms  min=0s      med=0s       max=1.77s    p(90)=0s       p(95)=0s
     http_req_waiting...............: avg=586.1ms  min=506.1µs med=426.39ms max=3.24s    p(90)=1.33s    p(95)=1.55s
     http_reqs......................: 13178  129.506225/s
     iteration_duration.............: avg=1.61s    min=1s      med=1.43s    max=4.36s    p(90)=2.33s    p(95)=2.56s
     iterations.....................: 13178  129.506225/s
     vus............................: 185    min=185        max=210
     vus_max........................: 210    min=210        max=210


running (1m41.8s), 000/210 VUs, 13178 complete and 0 interrupted iterations
default ✓ [======================================] 210 VUs  1m40s

Test Case 2:
- Kijkers: 250
- Duur: 100s
- mislukt:0.32%

     execution: local
        script: .\BidPostAPILoadingTest.js
        output: -

     scenarios: (100.00%) 1 scenario, 250 max VUs, 2m10s max duration (incl. graceful stop):
              * default: 250 looping VUs for 1m40s (gracefulStop: 30s)
 data_received..................: 3.9 MB 38 kB/s
     data_sent......................: 660 kB 6.5 kB/s
     http_req_blocked...............: avg=15ms     min=0s     med=0s       max=1.81s    p(90)=0s      p(95)=0s
     http_req_connecting............: avg=26.26µs  min=0s     med=0s       max=7.79ms   p(90)=0s      p(95)=0s
     http_req_duration..............: avg=745.07ms min=0s     med=615.69ms max=2.29s    p(90)=1.48s   p(95)=1.73s
       { expected_response:true }...: avg=747.47ms min=8.42ms med=616.79ms max=2.29s    p(90)=1.48s   p(95)=1.73s
     http_req_failed................: 0.32%  46 out of 14332
     http_req_receiving.............: avg=1.59ms   min=0s     med=0s       max=545.64ms p(90)=0s      p(95)=750.48µs
     http_req_sending...............: avg=48.33µs  min=0s     med=0s       max=1.57ms   p(90)=306.7µs p(95)=474.3µs
     http_req_tls_handshaking.......: avg=14.82ms  min=0s     med=0s       max=1.79s    p(90)=0s      p(95)=0s
     http_req_waiting...............: avg=743.43ms min=0s     med=615.14ms max=2.29s    p(90)=1.48s   p(95)=1.73s
     http_reqs......................: 14332  141.596352/s
     iteration_duration.............: avg=1.76s    min=1s     med=1.61s    max=3.81s    p(90)=2.51s   p(95)=2.77s
     iterations.....................: 14332  141.596352/s
     vus............................: 166    min=166         max=250
     vus_max........................: 250    min=250         max=250
