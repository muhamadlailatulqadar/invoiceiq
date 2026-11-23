1. Install Git as time machine for the code in local machine
2. then download/upgrade new .net sdk (.net 10)
3. Install node.js - all by using winget
4. install wsl for ubuntu used for docker
5. install docker desktop to create container
6. 7 install Angular CLI for this project
7. Install VS code extension for .net/c# used
8. do git config to initialize who is using the user
    -git config --global user.name "Muhamad Lailatulqadar"
    -git config --global user.email "muhmdlailatulqadar@gmail.com"


Step 1 QnA :-
1.  What is the difference between Git and GitHub?
        Git and GitHub: very good. One small fix: Git doesn’t put your code anywhere. It records the changes to code that’s already in your folder.

2.  Why does InvoiceIQ run SQL Server in Docker on your computer, instead of installing it normally?
        Docker: good. Strengthen it with “and anyone can delete it and start fresh in seconds.”

3.  What is a .gitignore file, and why does it matter for security?
        .gitignore: good. Add its limit: it only protects files that were never committed. Once a secret is pushed, it stays in the history.

4.  What does the .NET SDK give you that a plain text editor doesn't?
        .NET SDK: the two you forgot are the base libraries (ready-made code for files, web and dates) and the dotnet command (create, build, run, test). Full set: compiler, runtime, libraries, CLI.

Step 2 QnA :-
1.  Why is InvoiceIQ split into four projects instead of one?
        Why four projects? Half right. It’s less about SOLID being “dynamic” and more about separation of concerns: each project has one job, so you can change one without breaking the others. Interview version: “Business rules, use cases, external tools and the web layer live apart, so I can swap the database or AI provider without touching the business rules, and I can test the rules on their own.”

2.  Why does the Domain project reference nothing?
        Domain: this one’s wrong, so let’s fix it. Pages and routes belong to the Angular app (web/) and the Api project. Domain holds the business itself: what an Invoice and a LineItem are, plus rules like “line items must add up to the subtotal”. It references nothing so that those rules never depend on a database, a website or Claude.

3.  What does global.json do, and why would a team want it?
        global.json: correct. Add the “why”: “the same build on every machine, including the server that builds it automatically.”

4.  Why did we turn off server-side rendering for the Angular app?
        SSR: half right. Give the reason, not just the cost: “InvoiceIQ is behind a login, so search engines never see it. SSR would add complexity for no benefit.”

Step 3 QnA :-
1.  Why run SQL Server in Docker instead of installing it on Windows?
        why Docker: half right. Being the same on every machine is the main reason. Two more points make it a stronger interview answer. First, nothing gets installed on Windows itself, so there’s no leftover mess. Second, you can delete it and rebuild it in seconds, which is exactly what you just did with down -v.
            “Docker gives every developer the same SQL Server version with one command, keeps my machine clean, and lets me reset the database in seconds.”

2.  Why is the database password in .env and not in docker-compose.yml? What is .env.example for?
        .env: good. One thing to add: your repo is public, so anything committed can be read by anyone. Even if you delete it later, it stays in the git history. That’s why secrets never go in committed files.

3.  What is a health check, and who would call it?
        Health check: good, with one addition. Angular is one caller, but the main callers are tools that watch your app while you’re asleep. MonsterASP, uptime monitors and load balancers call /api/health every minute or so. If it stops answering “Healthy”, they alert you or restart the app. Later we’ll make it also check the database, so it reports unhealthy if the API is up but can’t reach SQL Server.
            “A health check is a small endpoint that monitoring tools call to confirm the app is alive and its dependencies are reachable.”

4.  Why does Angular need a proxy in development but not in production for this project?
        1. proxy: one correction. A proxy isn’t a kind of CORS. It’s a way to avoid needing CORS at all.
            -The browser has a safety rule: a page from one address (port 4200) can’t read answers from a different address (port 5046) unless that other address gives permission.
            -CORS is that permission: the API says “I allow 4200”.
            -The proxy avoids the question. The browser only ever talks to 4200, and Angular’s dev server quietly passes /api calls on to 5046 behind the scenes. As far as the browser can tell, it’s one website.
        In production, the API serves the Angular files itself from the same site, so neither CORS nor a proxy is needed.
        
        2. the proxy is like vendor that didnt break any rules and bring goods and shop owner let the vendor come and sell his good in his shop like that
            -That works, with one tweak so it matches what actually happens. The important part is who the customer talks to.
                Customer = the browser
                Shop = Angular’s dev server (port 4200)
                Supplier = your API (port 5046)
            The customer only ever buys from the shop and never goes to the supplier. When the customer asks for something the shop doesn’t stock (anything starting with /api), the shop orders it from the supplier and hands it over the counter. So the proxy is less the vendor and more the shop’s ordering service. In your words for an interview:
                “The browser only talks to one address. The dev server forwards API requests to the backend for it, like a shop ordering from a supplier on the customer’s behalf.”

5.  Your page shows three states: loading, offline and healthy. Why bother handling all three?
        three states: good test. You never saw “Checking the API…” because on your own computer the answer comes back in a few thousandths of a second. On a slow phone connection it would show for a few seconds. Without it, the user would just see a blank space and wonder whether anything was happening. If you want to see it, open the browser’s DevTools (F12), go to the Network tab, set throttling to Slow 3G, and refresh.
            -My page never shown loading, but it shows offline when i turn down the API the dotnet run and if i turn on again it will change healthy
                “Every network call has three outcomes: waiting, failed, or succeeded. I design for all three so the user is never left guessing.”

Step 4 QnA:-
1.  What is an ORM, and what does EF Core save you from doing?
        ORM is object relation mapping that is EF (Entity Framework) used in C#, . Net. Basically it works as a translator using C# language to SQL.
        ORM: good. Add one benefit: EF Core sends values separately from the SQL text, which protects you from SQL injection (an attack where someone types SQL into a form).

2.  Why is the Invoice class in Domain but AppDbContext in Infrastructure?
        Invoice Class in Domain because it works as Entity that dont have to know regarding the database, but business logics while AppDbContext in infrastructure works as gateway translation to database that why it in Infrastructure.
        Domain vs Infrastructure: very good. That's the answer.

3.  Why does Invoice have private set and a private constructor? How do you create one?
        Invoice have private set because in private entity or class only it can be change outside of it it cannot be change the method called encapsulation.
        Private set: half there. Yes, it's encapsulation. The second part of the question was how do you create one: only through Invoice.Upload(fileName, time), because the constructor is private. That guarantees every invoice starts valid, with a file name and the status Queued.

4.  What is a migration, and why are migrations committed to git?
        Migration is the way to update your databases, migration is updated to git because it will have standardized the database for all machine not just local machine
        Migrations: good. Add: they run in order, and the __EFMigrationsHistory table remembers which have run. On MonsterASP, the same command brings an empty database to exactly your shape.

5.  Where is your connection string stored on your machine, and where will it be stored in production?
        connection string will be stored in local machine user secrets, for production im not sure (answer below)
        Production: in the hosting control panel. MonsterASP lets you set connection strings and environment variables for the site, and .NET reads them at start-up. The rule is the same as locally: never in git.

6.  Why store the status as text and put an index on it?
        Status as text, with an index:
                - Text: anyone opening the table sees NeedsReview instead of 2. If someone later reorders the enum, stored numbers would silently change meaning, but words can't.
                - Index: the dashboard will constantly ask "show me all invoices that need review". Without an index, SQL Server reads every row. With one, it jumps straight to the matches, like a book index.