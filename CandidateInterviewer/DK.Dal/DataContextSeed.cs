using DK.Core;
using DK.DataAccess.Entities;
using DK.DataAccess.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DK.DataAccess
{
    public class DataContextSeed
    {
        public static void Seed(DataContext dataContext, ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                if (!dataContext.Categories.Any())
                {
                    dataContext.Categories.AddRange(GetInitialCategories());
                    dataContext.SaveChanges();
                }

                if (!dataContext.Exams.Any())
                {
                    dataContext.Exams.AddRange(GetInitialExams());
                    dataContext.SaveChanges();
                }

                if (!dataContext.Questions.Any())
                {
                    dataContext.Questions.AddRange(GetInitialQuestions());
                    dataContext.SaveChanges();
                }

                if (!dataContext.Answers.Any())
                {
                    dataContext.Answers.AddRange(GetInitialAnswers());
                    dataContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<DataContextSeed>();
                    log.LogError(ex.Message);
                    Seed(dataContext, loggerFactory, retryForAvailability);
                }
            }
        }

        static IEnumerable<Category> GetInitialCategories()
        {
            return new List<Category>()
            {
                //Mobile Development
                new Category() { Name = "Xamarin", Description = "Free and open source mobile app platform for building native and high-performance iOS, Android, tvOS, watchOS, macOS, and Windows apps.", Logo = "cat-xamarin.png", Type = AreaType.MobileDevelopment },
                new Category() { Name = "Swift", Description = "General-purpose, multi-paradigm, compiled programming language developed by Apple Inc. for iOS, iPadOS, macOS, watchOS, tvOS.", Logo = "cat-swift.png", Type = AreaType.MobileDevelopment },
                new Category() { Name = "Kotlin", Description = "Cross-platform, statically typed, general-purpose programming language with type inference.", Logo = "cat-kotlin.png", Type = AreaType.MobileDevelopment },
                //Web Development
                new Category() { Name = ".NET Core", Description = "Free and open-source, managed computer software framework for Windows, Linux, and macOS operating systems.", Logo = "cat-core.png", Type = AreaType.WebDevelopment  },
                new Category() { Name = "Angular JS", Description = "JavaScript-based open-source front-end web framework mainly maintained by Google.", Logo = "cat-angular.png", Type = AreaType.WebDevelopment  },
                new Category() { Name = "ASP.NET MVC", Description = "Web application framework developed by Microsoft, which implements the model–view–controller (MVC) pattern.", Logo = "cat-asp.png", Type = AreaType.WebDevelopment },
                new Category() { Name = "Entity Framework", Description = "Open source object-relational mapping (ORM) framework for ADO.NET.", Logo = "cat-ef.png", Type = AreaType.WebDevelopment},
                new Category() { Name = "Java Script", Description = "High-level, interpreted scripting language that conforms to the ECMAScript specification.", Logo = "cat-js.png", Type = AreaType.WebDevelopment },
                new Category() { Name = "Node JS", Description = "Open-source, cross-platform, JavaScript run-time environment that executes JavaScript code outside of a browser.", Logo = "cat-node.png", Type = AreaType.WebDevelopment },
                //Quality Assurance
                new Category() { Name = "Unit Testing", Description = "Software testing level where individual units or components of a software are tested.", Logo = "cat-unit.png", Type = AreaType.QualityAssurance },
                new Category() { Name = "Smoke Testing", Description = "Preliminary testing to reveal simple failures severe enough to, for example, reject a prospective software release.", Logo = "cat-smoke.png", Type = AreaType.QualityAssurance },
                new Category() { Name = "Stress Testing", Description = "Form of deliberately intense or thorough testing used to determine the stability of a given system or entity.", Logo = "cat-stress.png", Type = AreaType.QualityAssurance }
            };
        }

        static IEnumerable<Exam> GetInitialExams()
        {
            return new List<Exam>()
            {
                //Base Exams
                new Exam() { CategoryId = 1, Name = "Xamarin Base Exam", Description = "Base questions for Xamarin interview. Exam include such topics as Xamarin Forms, Xamarin Native Android, Xamarin Native iOS. Candidate not limited in time for this exam.", Logo = "cat-xamarin.png", Type = ExamType.Base },
                new Exam() { CategoryId = 2, Name = ".NET Core Base Exam", Description = "Base questions for .NET Core interview. Exam include questions for .NET platform and Core functionality. Candidate not limited in time for this exam.", Logo = "cat-core.png", Type = ExamType.Base },
                new Exam() { CategoryId = 3, Name = "Angular JS Base Exam", Description = "Base questions for Angular JS interview. Exam include questions for Angular JS functionality. Candidate not limited in time for this exam.", Logo = "cat-angular.png", Type = ExamType.Base },
                new Exam() { CategoryId = 4, Name = "ASP.NET MVC Base Exam", Description = "Base questions for ASP.NET MVC Core interview. Exam include such topics as ASP.NET Core, Controllers, Razor Views, View Models. Candidate not limited in time for this exam.", Logo = "cat-asp.png", Type = ExamType.Base },
                new Exam() { CategoryId = 5, Name = "Entity Framework Base Exam", Description = "Base questions for Entity Framework Core interview. Exam include such topics as EF Core, ORM, Database. Candidate not limited in time for this exam.", Logo = "cat-ef.png", Type = ExamType.Base },
                new Exam() { CategoryId = 6, Name = "Java Script Base Exam", Description = "Base questions for Java Script interview. Exam include questions for Java Script base functionality. Candidate not limited in time for this exam.", Logo = "cat-js.png", Type = ExamType.Base },
                new Exam() { CategoryId = 7, Name = "Node JS Base Exam", Description = "Base questions for Node JS interview. Exam include questions for Node JS base functionality. Candidate not limited in time for this exam.", Logo = "cat-node.png", Type = ExamType.Base },

                //Intermediate Exams
                new Exam() { CategoryId = 1, Name = "Xamarin Intermediate Exam", Description = "Intermediate questions for Xamarin interview. Exam include such topics as Xamarin Forms, Xamarin Native Android, Xamarin Native iOS. Candidate not limited in time for this exam.", Logo = "cat-xamarin.png", Type = ExamType.Intermediate },
                new Exam() { CategoryId = 2, Name = ".NET Core Intermediate Exam", Description = "Intermediate questions for .NET Core interview. Exam include questions for .NET platform and Core functionality. Candidate not limited in time for this exam.", Logo = "cat-core.png", Type = ExamType.Intermediate },
                new Exam() { CategoryId = 3, Name = "Angular JS Intermediate Exam", Description = "Intermediate questions for Angular JS interview. Exam include questions for Angular JS functionality. Candidate not limited in time for this exam.", Logo = "cat-angular.png", Type = ExamType.Intermediate },
                new Exam() { CategoryId = 4, Name = "ASP.NET MVC Intermediate Exam", Description = "Intermediate questions for ASP.NET MVC Core interview. Exam include such topics as ASP.NET Core, Controllers, Razor Views, View Models. Candidate not limited in time for this exam.", Logo = "cat-asp.png", Type = ExamType.Intermediate },
                new Exam() { CategoryId = 5, Name = "Entity Framework Intermediate Exam", Description = "Intermediate questions for Entity Framework Core interview. Exam include such topics as EF Core, ORM, Database. Candidate not limited in time for this exam.", Logo = "cat-ef.png", Type = ExamType.Intermediate },
                new Exam() { CategoryId = 6, Name = "Java Script Intermediate Exam", Description = "Intermediate questions for Java Script interview. Exam include questions for Java Script functionality. Candidate not limited in time for this exam.", Logo = "cat-js.png", Type = ExamType.Intermediate },
                new Exam() { CategoryId = 7, Name = "Node JS Intermediate Exam", Description = "Intermediate questions for Node JS interview. Exam include questions for Node JS functionality. Candidate not limited in time for this exam.", Logo = "cat-node.png", Type = ExamType.Intermediate },

                //Advanced Exams
                new Exam() { CategoryId = 1, Name = "Xamarin Advanced Exam", Description = "Advanced questions for Xamarin interview. Exam include such topics as Xamarin Forms, Xamarin Native Android, Xamarin Native iOS. Candidate will be limited in time for this exam.", Logo = "cat-xamarin.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 2, Name = ".NET Core Advanced Exam", Description = "Advanced questions for .NET Core interview. Exam include questions for .NET platform and Core functionality. Candidate will be limited in time for this exam.", Logo = "cat-core.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 3, Name = "Angular JS Advanced Exam", Description = "Advanced questions for Angular JS interview. Exam include questions for Angular JS functionality. Candidate will be limited in time for this exam.", Logo = "cat-angular.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 4, Name = "ASP.NET MVC Advanced Exam", Description = "Advanced questions for ASP.NET MVC Core interview. Exam include such topics as ASP.NET Core, Controllers, Razor Views, View Models. Candidate limited in time for this exam.", Logo = "cat-asp.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 5, Name = "Entity Framework Advanced Exam", Description = "Advanced questions for Entity Framework Core interview. Exam include such topics as EF Core, ORM, Database. Candidate will be limited in time for this exam.", Logo = "cat-ef.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 6, Name = "Java Script Advanced Exam", Description = "Advanced questions for Java Script interview. Exam include questions for Java Script functionality. Candidate will be limited in time for this exam.", Logo = "cat-js.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 7, Name = "Node JS Advanced Exam", Description = "Advanced questions for Node JS interview. Exam include questions for Node JS functionality. Candidate will be limited in time for this exam.", Logo = "cat-node.png", Type = ExamType.Advanced }
            };
        }

        static IEnumerable<Question> GetInitialQuestions()
        {
            return new List<Question>()
            {
                //Angular JS Advanced Exam
                new Question() { ExamId = 17, Title = "Is it a good or bad practice to use AngularJS together with jQuery?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "It is definitely a bad practice. We need to stay away from jQuery and try to realize the solution with an AngularJS approach. jQuery takes a traditional imperative approach to manipulating the DOM, and in an imperative approach, it is up to the programmer to express the individual steps leading up to the desired outcome. AngularJS, however, takes a declarative approach to DOM manipulation. Here, instead of worrying about all of the step by step details regarding how to do the desired outcome, we are just declaring what we want and AngularJS worries about the rest, taking care of everything for us." },
                new Question() { ExamId = 17, Title = "If you were to migrate from Angular 1.4 to Angular 1.5, what is the main thing that would need refactoring?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "Changing .directive to .component to adapt to the new Angular 1.5 components." },
                new Question() { ExamId = 17, Title = "How to share data between controllers?", Score = Constants.MEDIUM_QUESTION_SCORE, Type = AnswerType.Multiple, Notes = "Using events, $parent, nextSibling, controllerAs, also the $rootScope (not a good practice)" },
                new Question() { ExamId = 17, Title = "Where should we implement the DOM manipulation in AngularJS?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "In the directives. DOM Manipulations should not exist in controllers, services or anywhere else but in directives." },
                new Question() { ExamId = 17, Title = "How would you specify that a scope variable should have one-time binding only?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "By using “::” in front of it. This allows you to check if the candidate is aware of the available variable bindings in AngularJS." },
                new Question() { ExamId = 17, Title = "Explain how $scope.$apply() works?", Score = Constants.HARD_QUESTION_SCORE, Type = AnswerType.Text, Notes = "$scope.$apply re-evaluates all the declared ng-models and applies the change to any that have been altered (i.e. assigned to a new value) Explanation: scope.scope.apply() is one of the core angular functions that should never be used explicitly, it forces the angular engine to run on all the watched variables and all external variables and apply the changes on their values." },
                new Question() { ExamId = 17, Title = "What directive would you use to hide elements from the HTML DOM by removing them from that DOM not changing their styling?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "The ngIf Directive, when applied to an element, will remove that element from the DOM if it’s condition is false." },
                new Question() { ExamId = 17, Title = "What is a digest cycle in AngularJS?", Score = Constants.HARD_QUESTION_SCORE, Type = AnswerType.Text, Notes = "In each digest cycle Angular compares the old and the new version of the scope model values. The digest cycle is triggered automatically. We can also use $apply() if we want to trigger the digest cycle manually." },
                
                //.NET Core Intermediate Exam
                new Question() { ExamId = 9, Title = "What is Common Type System (CTS)?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "System that standardizes the data types of all programming languages using .NET under the umbrella of .NET to a common data type." },
                new Question() { ExamId = 9, Title = "What's the difference between SDK and Runtime in .NET Core?", Score = Constants.MEDIUM_QUESTION_SCORE, Type = AnswerType.Text, Notes = "The SDK is all of the stuff that is needed/makes developing a .NET Core application easier, such as the CLI and a compiler. The runtime is the 'virtual machine' that hosts/runs the application and abstracts all the interaction with the base operating system." },
                new Question() { ExamId = 9, Title = "What is included in .NET Core?", Score = Constants.MEDIUM_QUESTION_SCORE, Type = AnswerType.Multiple, Notes = "1) A .NET runtime, which provides a type system, assembly loading, a garbage collector, native interop and other basic services. 2) A set of framework libraries, which provide primitive data types, app composition types and fundamental utilities. 3) A set of SDK tools and language compilers that enable the base developer experience, available in the .NET Core SDK. 4) The 'dotnet' app host, which is used to launch .NET Core apps. It selects the runtime and hosts the runtime, provides an assembly loading policy and launches the app. The same host is also used to launch SDK tools in much the same way." },
                new Question() { ExamId = 9, Title = "What is CoreCLR?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Text, Notes = "CoreCLR is the .NET execution engine in .NET Core, performing functions such as garbage collection and compilation to machine code." },
                new Question() { ExamId = 9, Title = "What's the difference between Task and Thread in .NET?", Score = Constants.HARD_QUESTION_SCORE, Type = AnswerType.Text, Notes = "Thread represents an actual OS-level thread, with its own stack and kernel resources. Thread allows the highest degree of control; you can Abort() or Suspend() or Resume() a thread, you can observe its state, and you can set thread-level properties like the stack size, apartment state, or culture. ThreadPool is a wrapper around a pool of threads maintained by the CLR. The Task class from the Task Parallel Library offers the best of both worlds.Like the ThreadPool, a task does not create its own OS thread.Instead, tasks are executed by a TaskScheduler; the default scheduler simply runs on the ThreadPool.Unlike the ThreadPool, Task also allows you to find out when it finishes, and (via the generic Task) to return a result." },
                new Question() { ExamId = 9, Title = "What is Kestrel?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "Kestrel is a cross-platform web server built for ASP.NET Core based on libuv (a cross-platform asynchronous I/O library)." },
                new Question() { ExamId = 9, Title = "What is the difference betweeen Value Types and Reference Types?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Text, Notes = "Value Types stored directly on the stack or allocated inline in a structure. Reference Types store a reference to the value‘s memory address and are allocated on the heap. Reference types can be any of the pointer types, interface types or self-describing types (arrays and class types such as user-defined classes, boxed value types and delegates)." },
                new Question() { ExamId = 9, Title = "Dependency Injection in ASP.NET Core?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "Dependency Injection comes as a part of ASP.NET Core Framework and everything is built around it." },
                new Question() { ExamId = 9, Title = "What is .NET Standard?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Text, Notes = ".NET Standard is a set of APIs that all .NET platforms have to implement. This unifies the .NET platforms and prevents future fragmentation." },
                new Question() { ExamId = 9, Title = "What is Middleware in ASP.NET Core?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "Middleware is software that turns an application into a pipeline to process requests and responses. It controls how the application responds to HTTP requests." },
                new Question() { ExamId = 9, Title = "What is new in ASP.NET Core 2, compared to ASP.NET Core 1?", Score = Constants.MEDIUM_QUESTION_SCORE, Type = AnswerType.Multiple, Notes = "1) Razor Pages 2) NuGet packages auto restoring 3) Microsoft.AspNetCore.All, 4) DbContext Pooling 5) Configuration is a part of DI" },
                new Question() { ExamId = 9, Title = "Where are the static files in ASP.NET Core (MVC) located?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "All static files are now (by default) located inside of wwwroot folder." },
                new Question() { ExamId = 9, Title = "What are SignalR transports?", Score = Constants.HARD_QUESTION_SCORE, Type = AnswerType.Multiple, Notes = "1) WebSockets 2) Server Sent Events 3) Forever Frame 4) Long polling" },
                new Question() { ExamId = 9, Title = "What is the startup class in ASP.NET core?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "Startup class is the entry point of the ASP.NET Core application. Every .NET Core application must have this class." },
                new Question() { ExamId = 9, Title = "What is ASP.NET Core Module?", Score = Constants.HARD_QUESTION_SCORE, Type = AnswerType.Text, Notes = "ASP.NET Core Module lets you run ASP.NET Core apps behind IIS. It works only with kestrel. ASP.NET Core is a native IIS module that hooks into the IIS pipeline and redirects traffic to the backend ASP.NET Core application. ASP.NET Core application run in a process separate from the IIS worker process. It also does process management. ASP.NET Core module starts the process for the ASP.NET Core application when the first request comes in and restarts it when it crashes." }
            };
        }

        static IEnumerable<Answer> GetInitialAnswers()
        {
            return new List<Answer>()
            {
                //Angular JS Advanced Exam 
                new Answer() { QuestionId = 1, Value = "Good", IsCorrect = false },
                new Answer() { QuestionId = 1, Value = "Bad", IsCorrect = true },

                new Answer() { QuestionId = 2, Value = "$rootScope to $baseScope", IsCorrect = false },
                new Answer() { QuestionId = 2, Value = "controllerAs to nextSibling", IsCorrect = false },
                new Answer() { QuestionId = 2, Value = ".directive to .component", IsCorrect = true },
                new Answer() { QuestionId = 2, Value = "transclude to include", IsCorrect = false },

                new Answer() { QuestionId = 3, Value = "Using events", IsCorrect = true },
                new Answer() { QuestionId = 3, Value = "Using $share", IsCorrect = false },
                new Answer() { QuestionId = 3, Value = "Using $scope.$controller", IsCorrect = false },
                new Answer() { QuestionId = 3, Value = "Using angular.controller()", IsCorrect = false },
                new Answer() { QuestionId = 3, Value = "Using $parent", IsCorrect = true },
                new Answer() { QuestionId = 3, Value = "Using $anchorParent", IsCorrect = false },
                new Answer() { QuestionId = 3, Value = "Using nextSibling", IsCorrect = true },
                new Answer() { QuestionId = 3, Value = "Using controllerAs", IsCorrect = true },

                new Answer() { QuestionId = 4, Value = "Directives", IsCorrect = true },
                new Answer() { QuestionId = 4, Value = "Controllers", IsCorrect = false },
                new Answer() { QuestionId = 4, Value = "Services", IsCorrect = false },

                new Answer() { QuestionId = 5, Value = "'>>'", IsCorrect = false },
                new Answer() { QuestionId = 5, Value = "'::'", IsCorrect = true },
                new Answer() { QuestionId = 5, Value = "'->'", IsCorrect = false },
                new Answer() { QuestionId = 5, Value = "'<<'", IsCorrect = false },

                new Answer() { QuestionId = 7, Value = "ngIf", IsCorrect = true },
                new Answer() { QuestionId = 7, Value = "ng-show", IsCorrect = false },
                new Answer() { QuestionId = 7, Value = "ng-if", IsCorrect = false },

                //.NET Core Intermediate Exam
                new Answer() { QuestionId = 9, Value = "System that includes all the supported package by ASP.NET code with their dependencies into one package.", IsCorrect = false },
                new Answer() { QuestionId = 9, Value = "System that standardizes the data types of all programming languages using .NET under the umbrella of .NET to a common data type.", IsCorrect = true },
                new Answer() { QuestionId = 9, Value = "Cross-Site Request Forgery", IsCorrect = false },

                new Answer() { QuestionId = 11, Value = "web.config file", IsCorrect = false },
                new Answer() { QuestionId = 11, Value = "Global.asax file", IsCorrect = false },
                new Answer() { QuestionId = 11, Value = "Runtime (type system, assembly loading, garbage collector, native interop, basic services).", IsCorrect = true },
                new Answer() { QuestionId = 11, Value = "Built-in supports for the notification framework", IsCorrect = false },
                new Answer() { QuestionId = 11, Value = "Content-Generating Middleware", IsCorrect = false },
                new Answer() { QuestionId = 11, Value = "Set of framework libraries (primitive data types, app composition types, fundamental utilities).", IsCorrect = true },
                new Answer() { QuestionId = 11, Value = "Set of SDK tools and language compilers.", IsCorrect = true },
                new Answer() { QuestionId = 11, Value = "'dotnet' app host.", IsCorrect = true },

                new Answer() { QuestionId = 16, Value = "Own", IsCorrect = true },
                new Answer() { QuestionId = 16, Value = "Third-Party", IsCorrect = false },

                new Answer() { QuestionId = 14, Value = "Dependency Injection module.", IsCorrect = false },
                new Answer() { QuestionId = 14, Value = "Cross-platform solution to add real-time features to web apps.", IsCorrect = false },
                new Answer() { QuestionId = 14, Value = "Cross-platform web server built for ASP.NET Core based on libuv.", IsCorrect = true },

                new Answer() { QuestionId = 18, Value = "Application host.", IsCorrect = false },
                new Answer() { QuestionId = 18, Value = "Software that turns an application into a pipeline to process requests and responses.", IsCorrect = true },
                new Answer() { QuestionId = 18, Value = "Cross-platform web server environment.", IsCorrect = false },

                new Answer() { QuestionId = 19, Value = "Razor Pages", IsCorrect = true },
                new Answer() { QuestionId = 19, Value = "wwwroot folder", IsCorrect = false },
                new Answer() { QuestionId = 19, Value = "NuGet packages auto restoring", IsCorrect = true },
                new Answer() { QuestionId = 19, Value = "SignalR", IsCorrect = false },
                new Answer() { QuestionId = 19, Value = "Microsoft.AspNetCore.All", IsCorrect = true },
                new Answer() { QuestionId = 19, Value = "IHostingEnvironment", IsCorrect = false },
                new Answer() { QuestionId = 19, Value = "DbContext Pooling", IsCorrect = true },
                new Answer() { QuestionId = 19, Value = "Configuration is a part of DI", IsCorrect = true },

                new Answer() { QuestionId = 20, Value = "root folder", IsCorrect = false },
                new Answer() { QuestionId = 20, Value = "wwwroot folder", IsCorrect = true },
                new Answer() { QuestionId = 20, Value = "resources folder", IsCorrect = false },

                new Answer() { QuestionId = 21, Value = "Slow polling", IsCorrect = false },
                new Answer() { QuestionId = 21, Value = "Long polling", IsCorrect = true },
                new Answer() { QuestionId = 21, Value = "Conventional routes", IsCorrect = false },
                new Answer() { QuestionId = 21, Value = "Forever Frame", IsCorrect = true },
                new Answer() { QuestionId = 21, Value = "Server Sent Events", IsCorrect = true },
                new Answer() { QuestionId = 21, Value = "Server Log Events", IsCorrect = false },
                new Answer() { QuestionId = 21, Value = "Attribute routes", IsCorrect = false },
                new Answer() { QuestionId = 21, Value = "WebSockets", IsCorrect = true },

                new Answer() { QuestionId = 22, Value = "Configuration point", IsCorrect = false },
                new Answer() { QuestionId = 22, Value = "API initializer", IsCorrect = false },
                new Answer() { QuestionId = 22, Value = "Entry point of the application", IsCorrect = true }
            };
        }
    }
}
