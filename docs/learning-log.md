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