﻿using Microsoft.EntityFrameworkCore;

namespace DTOdemo_DATA.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books => Set<Book>();
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Category> Categories => Set<Category>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "Hands-On Visual Studio 2022", Description = "Visual Studio 2022 is the complete and ideal integrated development environment (IDE) for creating large, complex, and scalable applications. It is one of the most complete tools available for development, especially with Microsoft technologies. This book will teach you how to take advantage of the tools available with this IDE to write clean code faster.You'll begin by learning how to set up and start Visual Studio 2022 and how to use all the tools provided by this IDE. You will then explore key combinations, tips, and additional utilities that can help you to code faster and review your code constantly. Next, you will see how to compile, debug, and inspect your project to analyze its current behavior using Visual Studio. The book also shows you how to insert reusable blocks of code writing simple statements. Later, you will learn about visual aids and artificial intelligence that will help you improve productivity and understand what is going on in the project. By the end of this book, you will be able to set up your development environment using Visual Studio 2022, personalize the tools and layout, and use shortcuts and extensions to improve your productivity.", Pages = 350, Edition = "1st Edition", Publisher = "Packt Publishing", YearPublished = "2022", Isbn13 = "978-1801810548", Isbn10 = "1801810540", PurchaseUrl = "https://www.amazon.com/Hands-Visual-Studio-2022-productivity/dp/1801810540/ref=sr_1_3?crid=1L2IV91VLBWAO&keywords=.net+books+2022&qid=1664577906&qu=eyJxc2MiOiIxLjcyIiwicXNhIjoiMC4wMCIsInFzcCI6IjAuMDAifQ%3D%3D&sprefix=notebooks+202%2Caps%2C113&sr=8-3" },
            
            new Book { Id = 2, Title = "C# 10 and .NET 6 – Modern Cross-Platform Development", Description = "Extensively revised to accommodate all the latest features that come with C# 10 and .NET 6, this latest edition of our comprehensive guide will get you coding in C# with confidence. You'll learn object-oriented programming, writing, testing, and debugging functions, implementing interfaces, and inheriting classes. The book covers the .NET APIs for performing tasks like managing and querying data, monitoring and improving performance, and working with the filesystem, async streams, and serialization. You'll build and deploy cross - platform apps, such as websites and services using ASP.NET Core. Instead of distracting you with unnecessary application code, the first twelve chapters will teach you about C# language constructs and many of the .NET libraries through simple console applications. In later chapters, having mastered the basics, you'll then build practical applications and services using ASP.NET Core, the Model-View-Controller (MVC) pattern, and Blazor.", Pages = 824, Edition = "6th Edition", Publisher = "Packt Publishing", YearPublished = "2021", Isbn13 = "978-1801077361", Isbn10 = "1801077363", PurchaseUrl = "https://www.amazon.com/10-NET-Cross-Platform-Development-websites/dp/1801077363/ref=sr_1_7?crid=1L2IV91VLBWAO&keywords=.net+books+2022&qid=1664577906&qu=eyJxc2MiOiIxLjcyIiwicXNhIjoiMC4wMCIsInFzcCI6IjAuMDAifQ%3D%3D&sprefix=notebooks+202%2Caps%2C113&sr=8-7" },

            new Book { Id = 3, Title = "Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages", Description = "Professional developers will produce leaner applications for the ASP.NET Core platform using the guidance in this best-selling book, now in its 9th edition and updated for ASP.NET Core for .NET 6. It contains detailed explanations of the ASP.NET Core platform and the application frameworks it supports. This cornerstone guide puts ASP.NET Core for .NET 6 into context and dives deep into the tools and techniques required to build modern, extensible web applications. New features and capabilities such as MVC, Razor Pages, Blazor Server, and Blazor WebAssembly are covered, along with demonstrations of how they are applied. ASP.NET Core for .NET 6 is the latest evolution of Microsoft’s ASP.NET web platform and provides a \"host-agnostic\" framework and a high - productivity programming model that promotes cleaner code architecture, test - driven development, and powerful extensibility. Author Adam Freeman has thoroughly revised this market - leading book and explains how to get the most from ASP.NET Core for .NET 6.He starts with the nuts - and - bolts topics, teaching you about middleware components, built -in services, request model binding, and more.As you gain knowledge and confidence, he introduces increasingly more complex topics and advanced features, including endpoint routing and dependency injection.He goes in depth to give you the knowledge you need.", Pages = 1286, Edition = "9th Edition", Publisher = "Apress", YearPublished = "2022", Isbn13 = "978-1484279564", Isbn10 = "1484279565", PurchaseUrl = "https://www.amazon.com/Pro-ASP-NET-Core-Cloud-Ready-Applications/dp/1484279565/ref=sr_1_13?crid=1L2IV91VLBWAO&keywords=.net+books+2022&qid=1664577906&qu=eyJxc2MiOiIxLjcyIiwicXNhIjoiMC4wMCIsInFzcCI6IjAuMDAifQ%3D%3D&sprefix=notebooks+202%2Caps%2C113&sr=8-13" },
            
            new Book { Id = 4, Title = "Pro Angular: Build Powerful and Dynamic Web Apps", Description = "Welcome to this one-stop shop for learning Angular. Pro Angular is the most concise and comprehensive guide available, giving you the knowledge you need to take full advantage of this popular framework for building your own dynamic JavaScript applications. Angular is an open - source JavaScript library maintained by Google.It has many excellent options when it comes to server - side development and is used in some of the largest and most complex web applications in the world to enhance HTML in the browser.Its cornerstone is the ability to create applications that are extendable, maintainable, testable, and standardized.Knowing Angular’s foundations and understanding its applications is an asset in any developer toolbox. The fifth edition of this popular guide explains how to get the most from Angular, presenting the range of benefits it can offer.You will begin learning how to use Angular in your projects, starting with the nuts - and - bolts concepts, and progressing to more advanced and sophisticated features.Each topic in this full - color book provides you with precisely enough learning and detail to be effective.In true Adam Freeman style, the most important features are given full - court press treatment, while also addressing common problems and how to avoid them.", Pages = 805, Edition = "5th Edition", Publisher = "Apress", YearPublished = "2022", Isbn13 = "978-1484281758", Isbn10 = "1484281756", PurchaseUrl = "https://www.amazon.com/Pro-Angular-Build-Powerful-Dynamic-dp-1484281756/dp/1484281756/ref=mt_other?_encoding=UTF8&me=&qid=" },
            
            new Book { Id = 5, Title = "Essential TypeScript 4: From Beginner to Pro", Description = "Learn the essentials and more of TypeScript, a popular superset of the JavaScript language that adds support for static typing. TypeScript combines the typing features of C# or Java with the flexibility of JavaScript, reducing typing errors and providing an easier path to JavaScript development. Author Adam Freeman explains how to get the most from TypeScript 4 in this second edition of his best - selling book.He begins by describing the TypeScript language and the benefits it offers and then shows you how to use TypeScript in real - world scenarios, including development with the DOM API, and popular frameworks such as Angular and React.He starts from the nuts-and - bolts and builds up to the most advanced and sophisticated features. Each topic is covered clearly and concisely, and is packed with the details you need to be effective.The most important features are given a no - nonsense, in-depth treatment and chapters include common problems and teach you how to avoid them.", Pages = 581, Edition = "5th Edition", Publisher = "Apress", YearPublished = "2021", Isbn13 = "978-1484270103", Isbn10 = "148427010X", PurchaseUrl = "https://www.amazon.com/Essential-TypeScript-4-Beginner-Pro-dp-148427010X/dp/148427010X/ref=mt_other?_encoding=UTF8&me=&qid=" },

            new Book { Id = 6, Title = "Ace the Data Science Interview: 201 Real Interview Questions Asked By FAANG, Tech Startups, &Wall Street", Description = "Learn the essentials and more of TypeScript, a popular superset of the JavaScript language that adds support for static typing. TypeScript combines the typing features of C# or Java with the flexibility of JavaScript, reducing typing errors and providing an easier path to JavaScript development. Author Adam Freeman explains how to get the most from TypeScript 4 in this second edition of his best - selling book.He begins by describing the TypeScript language and the benefits it offers and then shows you how to use TypeScript in real - world scenarios, including development with the DOM API, and popular frameworks such as Angular and React.He starts from the nuts-and - bolts and builds up to the most advanced and sophisticated features. Each topic is covered clearly and concisely, and is packed with the details you need to be effective.The most important features are given a no - nonsense, in-depth treatment and chapters include common problems and teach you how to avoid them.", Pages = 581, Edition = "5th Edition", Publisher = "Apress", YearPublished = "2021", Isbn13 = "978-0578973838", Isbn10 = "0578973839", PurchaseUrl = "https://www.amazon.com/Ace-Data-Science-Interview-Questions/dp/0578973839/ref=sr_1_19?crid=75YGFUMF8DNA&keywords=data+structure+algorithms+books+2022&qid=1664579217&qu=eyJxc2MiOiIxLjUyIiwicXNhIjoiMC4wMCIsInFzcCI6IjAuMDAifQ%3D%3D&sprefix=data+structure+algorithms+books+2022%2Caps%2C108&sr=8-19" },

            new Book { Id = 7, Title = "JavaScript from Beginner to Professional", Description = "This book demonstrates the capabilities of JavaScript for web application development by combining theoretical learning with code exercises and fun projects that you can challenge yourself with. The guiding principle of the book is to show how straightforward JavaScript techniques can be used to make web apps ranging from dynamic websites to simple browser-based games. JavaScript from Beginner to Professional focuses on key programming concepts and Document Object Model manipulations that are used to solve common problems in professional web applications.These include data validation, manipulating the appearance of web pages, working with asynchronous and concurrent code. The book uses project - based learning to provide context for the theoretical components in a series of code examples that can be used as modules of an application, such as input validators, games, and simple animations.This will be supplemented with a brief crash course on HTML and CSS to illustrate how JavaScript components fit into a complete web application.", Pages = 544, Edition = "2nd Edition", Publisher = "Packt Publishing", YearPublished = "2021", Isbn13 = "978-1800562523", Isbn10 = "1800562527", PurchaseUrl = "" },

            new Book { Id = 8, Title = "Learn JavaScript DOM Create Dynamic and Interactive Web Pages", Description = "JavaScript is everywhere - all your favorite websites and also the ones you don’t like use JavaScript. You can do amazing things with JavaScript code, creating web page interactions and updating page content dynamically with code. Your imagination is the only limit. JavaScript allows for interaction with content and makes things happen.JavaScript is the dynamic programming language that, when applied to an HTML document, can provide dynamic interactivity on websites.Used in all browsers its the most popular coding language ever.Websites and web apps everywhere are using JavaScript.It runs directly in your browser and you can create html files with a text editor directly on your computer to run in your browser. Apply JavaScript code to your web pages to make things happen. The contents of this book are based on exercises, to develop and improve skills with JavaScript and interacting with web page elements.The exercises are presented in a step-by - step format, and with challenges for you to try. The best way to learn to code is to try the code and see it in action.Writing code should be fun, the exercises are designed to be interesting and informative.There are lots of coding examples and source code to get you coding.As you go through the lessons, open your editor, and try the code for yourself.The projects are starter projects that can be built upon, adding more functionality, and making them even better.Let your imagination guide you to bring them to the next stage. Book provides a quick overview of core JavaScript syntax, including variables, arrays, objects, functions, conditions, and loops.Explore how to apply logic and build fun web applications from scratch.Select page elements and update the web page element content with JavaScript.Explore the DOM Document Object Model that provides the code a way to connect and interact with the HTML elements.Coding examples for all lessons, how to apply JavaScript for the real world! Array methods, creating and using data in objects, use of Math random, and common modern coding snippets.", Pages = 261, Edition = "1st Edition", Publisher = "Independent", YearPublished = "2022", Isbn13 = "979-8421438038", Isbn10 = "0000000000", PurchaseUrl = "https://www.amazon.com/gp/product/B09T2JXVK3/ref=dbs_a_def_rwt_hsch_vapi_tkin_p1_i2" }

            //new Book { Id = , Title = "", Description = "", Pages = 0, Edition = " Edition", Publisher = "", YearPublished = "", Isbn13 = "000-0000000000", Isbn10 = "0000000000", PurchaseUrl = "" }
        );
        
        modelBuilder.Entity<Author>().HasData(
            new Author { Id = 1, FirstName = "Miguel", MiddleName="Angel Teheran", LastName = "Garcia", Bio = "Solutions Architect and technical lead recognized as a Microsoft MVP, C# corner MVP and Alibaba Cloud MVP. Garcia is a member of Avanet.org community in Medellin and active member of tech events in Colombia." },
            
            new Author { Id = 2, FirstName = "Hector", MiddleName = "Urield Perez", LastName = "Rojas", Bio = "Senior developer and Microsoft MVP with more than 10 years of experience in .NET technologies.Instructor of his own Academy." },
            
            new Author { Id = 3, FirstName = "Mark", MiddleName = "J.", LastName = "Price", Bio = "Mark J. Price is a Microsoft Specialist: Programming in C# and Architecting Microsoft Azure Solutions, with over 20 years' experience. Since 1993, he has passed more than 80 Microsoft programming exams and specializes in preparing others to pass them. Between 2001 and 2003, Mark was employed to write official courseware for Microsoft in Redmond, USA. His team wrote the first training courses for C# while it was still an early alpha version. While with Microsoft, he taught \"train-the-trainer\" classes to get other MCTs up-to-speed on C# and .NET. Currently, Mark creates and delivers training courses for Optimizely's Digital Experience Platform (DXP). Mark holds a Computer Science BSc. Hons. Degree." },
            
            new Author { Id = 4, FirstName = "Adam", MiddleName = "", LastName = "Freeman", Bio = "" },
            
            new Author { Id = 5, FirstName = "Nick", MiddleName = "", LastName = "Singh", Bio = "Nick Singh started his career as a Software Engineer on Facebook's Growth Team, and most recently, worked at SafeGraph, a geospatial analytics startup. He holds a degree in Systems Engineering with a minor in Computer Science from the University of Virginia. In college, he interned at Microsoft, and on the Data Infrastructure team at Google's Nest Labs. His career advice has been read by over 10 million people on LinkedIn. For fun, he likes to DJ, dance, and stan Drake." },

            new Author { Id = 6, FirstName = "Kevin", MiddleName = "", LastName = "Huo", Bio = "Kevin Huo is currently a Data Scientist at a Hedge Fund, and previously was a Data Scientist at Facebook working on Facebook Groups.He holds a degree in Computer Science from the University of Pennsylvania and a degree in Business from Wharton.In college, he interned at Facebook, Bloomberg, and on Wall Street.On the side, he’s helped hundreds of people land data jobs at companies including Apple, Lyft, and Citadel." },

            new Author { Id = 7, FirstName = "Laurence", MiddleName = "Lars", LastName = "Svekis", Bio = "Laurence is a best selling online Instructor, Google Developer Expert who has a passion for all things technology. He enjoys sharing knowledge, discussing digital technology and programming. As an experienced developer, Laurence created his first computer applications in the 1990s. Laurence enjoys sharing knowledge with others and having the opportunity to help share in the wonderful opportunities that the internet provides." },

            new Author { Id = 8, FirstName = "Maaike", MiddleName = "", LastName = "van Putten", Bio = "Maaike is a software developer and trainer with a passion for learning and boosting the careers of others. She loves to create content to help other software developers (to be) by making videos, writing articles and books. When she's not behind her laptop, she loves to spend time with her family, friends and dog. You'll also catch her reading a lot of educational books when she's offline." }

            //new Author { Id = , FirstName = "", MiddleName = "", LastName = "", Bio = "" },
        );

        modelBuilder.SharedTypeEntity<Dictionary<string, object>>("AuthorBook").HasData(
            new { AuthorsId = 1, BooksId = 1 },
            new { AuthorsId = 2, BooksId = 1 },
            new { AuthorsId = 3, BooksId = 2 },
            new { AuthorsId = 4, BooksId = 3 },
            new { AuthorsId = 4, BooksId = 4 },
            new { AuthorsId = 4, BooksId = 5 },
            new { AuthorsId = 5, BooksId = 6 },
            new { AuthorsId = 6, BooksId = 6 },
            new { AuthorsId = 7, BooksId = 7 },
            new { AuthorsId = 7, BooksId = 8 },
            new { AuthorsId = 8, BooksId = 7 }
         );

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "C#" },
            new Category { Id = 2, Name = "ASP.NET" },
            new Category { Id = 3, Name = "Javascript" },
            new Category { Id = 4, Name = "C++" },
            new Category { Id = 5, Name = "Python" },
            new Category { Id = 6, Name = "Software Development" },
            new Category { Id = 7, Name = "Web Development" },
            new Category { Id = 8, Name = "Interview Prep" },
            new Category { Id = 9, Name = "Data Science" },
            new Category { Id = 10, Name = "Artificial Intelligence" }
        );

        modelBuilder.SharedTypeEntity<Dictionary<string, object>>("BookCategory").HasData(
            new { BooksId = 1, CategoriesId = 1 },
            new { BooksId = 1, CategoriesId = 2 },
            new { BooksId = 2, CategoriesId = 1 },
            new { BooksId = 2, CategoriesId = 2 },
            new { BooksId = 3, CategoriesId = 1 },
            new { BooksId = 3, CategoriesId = 2 },
            new { BooksId = 3, CategoriesId = 7 },
            new { BooksId = 4, CategoriesId = 3 },
            new { BooksId = 4, CategoriesId = 7 },
            new { BooksId = 5, CategoriesId = 3 },
            new { BooksId = 5, CategoriesId = 7 },
            new { BooksId = 6, CategoriesId = 8 },
            new { BooksId = 6, CategoriesId = 9 },
            new { BooksId = 7, CategoriesId = 3 },
            new { BooksId = 7, CategoriesId = 7 },
            new { BooksId = 8, CategoriesId = 3 },
            new { BooksId = 8, CategoriesId = 7 }
            //new { BooksId = , CategoriesId =  },
         );
    }
}
