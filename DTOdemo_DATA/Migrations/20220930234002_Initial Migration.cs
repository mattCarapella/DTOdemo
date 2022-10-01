using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTOdemo_DATA.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Edition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearPublished = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isbn13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isbn10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "FirstName", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { 1, "Solutions Architect and technical lead recognized as a Microsoft MVP, C# corner MVP and Alibaba Cloud MVP. Garcia is a member of Avanet.org community in Medellin and active member of tech events in Colombia.", "Miguel", "Garcia", "Angel Teheran" },
                    { 2, "Senior developer and Microsoft MVP with more than 10 years of experience in .NET technologies.Instructor of his own Academy.", "Hector", "Rojas", "Urield Perez" },
                    { 3, "Mark J. Price is a Microsoft Specialist: Programming in C# and Architecting Microsoft Azure Solutions, with over 20 years' experience. Since 1993, he has passed more than 80 Microsoft programming exams and specializes in preparing others to pass them. Between 2001 and 2003, Mark was employed to write official courseware for Microsoft in Redmond, USA. His team wrote the first training courses for C# while it was still an early alpha version. While with Microsoft, he taught \"train-the-trainer\" classes to get other MCTs up-to-speed on C# and .NET. Currently, Mark creates and delivers training courses for Optimizely's Digital Experience Platform (DXP). Mark holds a Computer Science BSc. Hons. Degree.", "Mark", "Price", "J." },
                    { 4, "", "Adam", "Freeman", "" },
                    { 5, "Nick Singh started his career as a Software Engineer on Facebook's Growth Team, and most recently, worked at SafeGraph, a geospatial analytics startup. He holds a degree in Systems Engineering with a minor in Computer Science from the University of Virginia. In college, he interned at Microsoft, and on the Data Infrastructure team at Google's Nest Labs. His career advice has been read by over 10 million people on LinkedIn. For fun, he likes to DJ, dance, and stan Drake.", "Nick", "Singh", "" },
                    { 6, "Kevin Huo is currently a Data Scientist at a Hedge Fund, and previously was a Data Scientist at Facebook working on Facebook Groups.He holds a degree in Computer Science from the University of Pennsylvania and a degree in Business from Wharton.In college, he interned at Facebook, Bloomberg, and on Wall Street.On the side, he’s helped hundreds of people land data jobs at companies including Apple, Lyft, and Citadel.", "Kevin", "Huo", "" },
                    { 7, "Laurence is a best selling online Instructor, Google Developer Expert who has a passion for all things technology. He enjoys sharing knowledge, discussing digital technology and programming. As an experienced developer, Laurence created his first computer applications in the 1990s. Laurence enjoys sharing knowledge with others and having the opportunity to help share in the wonderful opportunities that the internet provides.", "Laurence", "Svekis", "Lars" },
                    { 8, "Maaike is a software developer and trainer with a passion for learning and boosting the careers of others. She loves to create content to help other software developers (to be) by making videos, writing articles and books. When she's not behind her laptop, she loves to spend time with her family, friends and dog. You'll also catch her reading a lot of educational books when she's offline.", "Maaike", "van Putten", "" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Edition", "Isbn10", "Isbn13", "Pages", "Publisher", "PurchaseUrl", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, "Visual Studio 2022 is the complete and ideal integrated development environment (IDE) for creating large, complex, and scalable applications. It is one of the most complete tools available for development, especially with Microsoft technologies. This book will teach you how to take advantage of the tools available with this IDE to write clean code faster.You'll begin by learning how to set up and start Visual Studio 2022 and how to use all the tools provided by this IDE. You will then explore key combinations, tips, and additional utilities that can help you to code faster and review your code constantly. Next, you will see how to compile, debug, and inspect your project to analyze its current behavior using Visual Studio. The book also shows you how to insert reusable blocks of code writing simple statements. Later, you will learn about visual aids and artificial intelligence that will help you improve productivity and understand what is going on in the project. By the end of this book, you will be able to set up your development environment using Visual Studio 2022, personalize the tools and layout, and use shortcuts and extensions to improve your productivity.", "1st Edition", "1801810540", "978-1801810548", 350, "Packt Publishing", "https://www.amazon.com/Hands-Visual-Studio-2022-productivity/dp/1801810540/ref=sr_1_3?crid=1L2IV91VLBWAO&keywords=.net+books+2022&qid=1664577906&qu=eyJxc2MiOiIxLjcyIiwicXNhIjoiMC4wMCIsInFzcCI6IjAuMDAifQ%3D%3D&sprefix=notebooks+202%2Caps%2C113&sr=8-3", "Hands-On Visual Studio 2022", "2022" },
                    { 2, "Extensively revised to accommodate all the latest features that come with C# 10 and .NET 6, this latest edition of our comprehensive guide will get you coding in C# with confidence. You'll learn object-oriented programming, writing, testing, and debugging functions, implementing interfaces, and inheriting classes. The book covers the .NET APIs for performing tasks like managing and querying data, monitoring and improving performance, and working with the filesystem, async streams, and serialization. You'll build and deploy cross - platform apps, such as websites and services using ASP.NET Core. Instead of distracting you with unnecessary application code, the first twelve chapters will teach you about C# language constructs and many of the .NET libraries through simple console applications. In later chapters, having mastered the basics, you'll then build practical applications and services using ASP.NET Core, the Model-View-Controller (MVC) pattern, and Blazor.", "6th Edition", "1801077363", "978-1801077361", 824, "Packt Publishing", "https://www.amazon.com/10-NET-Cross-Platform-Development-websites/dp/1801077363/ref=sr_1_7?crid=1L2IV91VLBWAO&keywords=.net+books+2022&qid=1664577906&qu=eyJxc2MiOiIxLjcyIiwicXNhIjoiMC4wMCIsInFzcCI6IjAuMDAifQ%3D%3D&sprefix=notebooks+202%2Caps%2C113&sr=8-7", "C# 10 and .NET 6 – Modern Cross-Platform Development", "2021" },
                    { 3, "Professional developers will produce leaner applications for the ASP.NET Core platform using the guidance in this best-selling book, now in its 9th edition and updated for ASP.NET Core for .NET 6. It contains detailed explanations of the ASP.NET Core platform and the application frameworks it supports. This cornerstone guide puts ASP.NET Core for .NET 6 into context and dives deep into the tools and techniques required to build modern, extensible web applications. New features and capabilities such as MVC, Razor Pages, Blazor Server, and Blazor WebAssembly are covered, along with demonstrations of how they are applied. ASP.NET Core for .NET 6 is the latest evolution of Microsoft’s ASP.NET web platform and provides a \"host-agnostic\" framework and a high - productivity programming model that promotes cleaner code architecture, test - driven development, and powerful extensibility. Author Adam Freeman has thoroughly revised this market - leading book and explains how to get the most from ASP.NET Core for .NET 6.He starts with the nuts - and - bolts topics, teaching you about middleware components, built -in services, request model binding, and more.As you gain knowledge and confidence, he introduces increasingly more complex topics and advanced features, including endpoint routing and dependency injection.He goes in depth to give you the knowledge you need.", "9th Edition", "1484279565", "978-1484279564", 1286, "Apress", "https://www.amazon.com/Pro-ASP-NET-Core-Cloud-Ready-Applications/dp/1484279565/ref=sr_1_13?crid=1L2IV91VLBWAO&keywords=.net+books+2022&qid=1664577906&qu=eyJxc2MiOiIxLjcyIiwicXNhIjoiMC4wMCIsInFzcCI6IjAuMDAifQ%3D%3D&sprefix=notebooks+202%2Caps%2C113&sr=8-13", "Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages", "2022" },
                    { 4, "Welcome to this one-stop shop for learning Angular. Pro Angular is the most concise and comprehensive guide available, giving you the knowledge you need to take full advantage of this popular framework for building your own dynamic JavaScript applications. Angular is an open - source JavaScript library maintained by Google.It has many excellent options when it comes to server - side development and is used in some of the largest and most complex web applications in the world to enhance HTML in the browser.Its cornerstone is the ability to create applications that are extendable, maintainable, testable, and standardized.Knowing Angular’s foundations and understanding its applications is an asset in any developer toolbox. The fifth edition of this popular guide explains how to get the most from Angular, presenting the range of benefits it can offer.You will begin learning how to use Angular in your projects, starting with the nuts - and - bolts concepts, and progressing to more advanced and sophisticated features.Each topic in this full - color book provides you with precisely enough learning and detail to be effective.In true Adam Freeman style, the most important features are given full - court press treatment, while also addressing common problems and how to avoid them.", "5th Edition", "1484281756", "978-1484281758", 805, "Apress", "https://www.amazon.com/Pro-Angular-Build-Powerful-Dynamic-dp-1484281756/dp/1484281756/ref=mt_other?_encoding=UTF8&me=&qid=", "Pro Angular: Build Powerful and Dynamic Web Apps", "2022" },
                    { 5, "Learn the essentials and more of TypeScript, a popular superset of the JavaScript language that adds support for static typing. TypeScript combines the typing features of C# or Java with the flexibility of JavaScript, reducing typing errors and providing an easier path to JavaScript development. Author Adam Freeman explains how to get the most from TypeScript 4 in this second edition of his best - selling book.He begins by describing the TypeScript language and the benefits it offers and then shows you how to use TypeScript in real - world scenarios, including development with the DOM API, and popular frameworks such as Angular and React.He starts from the nuts-and - bolts and builds up to the most advanced and sophisticated features. Each topic is covered clearly and concisely, and is packed with the details you need to be effective.The most important features are given a no - nonsense, in-depth treatment and chapters include common problems and teach you how to avoid them.", "5th Edition", "148427010X", "978-1484270103", 581, "Apress", "https://www.amazon.com/Essential-TypeScript-4-Beginner-Pro-dp-148427010X/dp/148427010X/ref=mt_other?_encoding=UTF8&me=&qid=", "Essential TypeScript 4: From Beginner to Pro", "2021" },
                    { 6, "Learn the essentials and more of TypeScript, a popular superset of the JavaScript language that adds support for static typing. TypeScript combines the typing features of C# or Java with the flexibility of JavaScript, reducing typing errors and providing an easier path to JavaScript development. Author Adam Freeman explains how to get the most from TypeScript 4 in this second edition of his best - selling book.He begins by describing the TypeScript language and the benefits it offers and then shows you how to use TypeScript in real - world scenarios, including development with the DOM API, and popular frameworks such as Angular and React.He starts from the nuts-and - bolts and builds up to the most advanced and sophisticated features. Each topic is covered clearly and concisely, and is packed with the details you need to be effective.The most important features are given a no - nonsense, in-depth treatment and chapters include common problems and teach you how to avoid them.", "5th Edition", "0578973839", "978-0578973838", 581, "Apress", "https://www.amazon.com/Ace-Data-Science-Interview-Questions/dp/0578973839/ref=sr_1_19?crid=75YGFUMF8DNA&keywords=data+structure+algorithms+books+2022&qid=1664579217&qu=eyJxc2MiOiIxLjUyIiwicXNhIjoiMC4wMCIsInFzcCI6IjAuMDAifQ%3D%3D&sprefix=data+structure+algorithms+books+2022%2Caps%2C108&sr=8-19", "Ace the Data Science Interview: 201 Real Interview Questions Asked By FAANG, Tech Startups, &Wall Street", "2021" },
                    { 7, "This book demonstrates the capabilities of JavaScript for web application development by combining theoretical learning with code exercises and fun projects that you can challenge yourself with. The guiding principle of the book is to show how straightforward JavaScript techniques can be used to make web apps ranging from dynamic websites to simple browser-based games. JavaScript from Beginner to Professional focuses on key programming concepts and Document Object Model manipulations that are used to solve common problems in professional web applications.These include data validation, manipulating the appearance of web pages, working with asynchronous and concurrent code. The book uses project - based learning to provide context for the theoretical components in a series of code examples that can be used as modules of an application, such as input validators, games, and simple animations.This will be supplemented with a brief crash course on HTML and CSS to illustrate how JavaScript components fit into a complete web application.", "2nd Edition", "1800562527", "978-1800562523", 544, "Packt Publishing", "", "JavaScript from Beginner to Professional", "2021" },
                    { 8, "JavaScript is everywhere - all your favorite websites and also the ones you don’t like use JavaScript. You can do amazing things with JavaScript code, creating web page interactions and updating page content dynamically with code. Your imagination is the only limit. JavaScript allows for interaction with content and makes things happen.JavaScript is the dynamic programming language that, when applied to an HTML document, can provide dynamic interactivity on websites.Used in all browsers its the most popular coding language ever.Websites and web apps everywhere are using JavaScript.It runs directly in your browser and you can create html files with a text editor directly on your computer to run in your browser. Apply JavaScript code to your web pages to make things happen. The contents of this book are based on exercises, to develop and improve skills with JavaScript and interacting with web page elements.The exercises are presented in a step-by - step format, and with challenges for you to try. The best way to learn to code is to try the code and see it in action.Writing code should be fun, the exercises are designed to be interesting and informative.There are lots of coding examples and source code to get you coding.As you go through the lessons, open your editor, and try the code for yourself.The projects are starter projects that can be built upon, adding more functionality, and making them even better.Let your imagination guide you to bring them to the next stage. Book provides a quick overview of core JavaScript syntax, including variables, arrays, objects, functions, conditions, and loops.Explore how to apply logic and build fun web applications from scratch.Select page elements and update the web page element content with JavaScript.Explore the DOM Document Object Model that provides the code a way to connect and interact with the HTML elements.Coding examples for all lessons, how to apply JavaScript for the real world! Array methods, creating and using data in objects, use of Math random, and common modern coding snippets.", "1st Edition", "0000000000", "979-8421438038", 261, "Independent", "https://www.amazon.com/gp/product/B09T2JXVK3/ref=dbs_a_def_rwt_hsch_vapi_tkin_p1_i2", "Learn JavaScript DOM Create Dynamic and Interactive Web Pages", "2022" }
                });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorsId", "BooksId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 6 },
                    { 6, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 8, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
