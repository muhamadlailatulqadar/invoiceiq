# invoiceiq

to run api -
1. docker compose up -d
2. dotnet run --project src/InvoiceIQ.Api 


Your log confirms it. The API itself is fine ("Application started"), but the line Health check AppDbContext with status Unhealthy means it can't reach the database. Your PC was probably restarted since yesterday, so Docker isn't running.

Open Docker Desktop and wait until it says it's running.
From the repo root, run docker compose up -d, then docker compose ps. It should say Up.
Wait about 30 seconds for SQL Server to boot, then refresh http://localhost:4200. There's no need to restart the API, because the health check tries again on every request.

It should turn green: API Healthy. This is your Step 4 upgrade doing its job. It reported Unhealthy because the database really was unreachable.


to run frontend -
1. cd wed
2. ng serve