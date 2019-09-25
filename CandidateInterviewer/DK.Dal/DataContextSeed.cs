using DK.DataAccess.Entities;
using DK.DataAccess.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                new Category() { Name = "Xamarin", Description = "Free and open source mobile app platform for building native and high-performance iOS, Android, tvOS, watchOS, macOS, and Windows apps.", Logo = "cat-xamarin.png" },
                new Category() { Name = ".NET Core", Description = "Free and open-source, managed computer software framework for Windows, Linux, and macOS operating systems.", Logo = "cat-core.png" },
                new Category() { Name = "Angular JS", Description = "JavaScript-based open-source front-end web framework mainly maintained by Google.", Logo = "cat-angular.png" },
                new Category() { Name = "ASP.NET MVC", Description = "Web application framework developed by Microsoft, which implements the model–view–controller (MVC) pattern.", Logo = "cat-asp.png" },
                new Category() { Name = "Entity Framework", Description = "Open source object-relational mapping (ORM) framework for ADO.NET.", Logo = "cat-ef.png" },
                new Category() { Name = "Java Script", Description = "High-level, interpreted scripting language that conforms to the ECMAScript specification.", Logo = "cat-js.png" },
                new Category() { Name = "Node JS", Description = "Open-source, cross-platform, JavaScript run-time environment that executes JavaScript code outside of a browser.", Logo = "cat-node.png" }
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
                new Exam() { CategoryId = 1, Name = "Xamarin Advanced Exam", Description = "Base questions for Xamarin interview. Exam include such topics as Xamarin Forms, Xamarin Native Android, Xamarin Native iOS. Candidate will be limited in time for this exam.", Logo = "cat-xamarin.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 2, Name = ".NET Core Advanced Exam", Description = "Base questions for .NET Core interview. Exam include questions for .NET platform and Core functionality. Candidate will be limited in time for this exam.", Logo = "cat-core.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 3, Name = "Angular JS Advanced Exam", Description = "Base questions for Angular JS interview. Exam include questions for Angular JS functionality. Candidate will be limited in time for this exam.", Logo = "cat-angular.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 4, Name = "ASP.NET MVC Advanced Exam", Description = "Base questions for ASP.NET MVC Core interview. Exam include such topics as ASP.NET Core, Controllers, Razor Views, View Models. Candidate limited in time for this exam.", Logo = "cat-asp.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 5, Name = "Entity Framework Advanced Exam", Description = "Base questions for Entity Framework Core interview. Exam include such topics as EF Core, ORM, Database. Candidate will be limited in time for this exam.", Logo = "cat-ef.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 6, Name = "Java Script Advanced Exam", Description = "Base questions for Java Script interview. Exam include questions for Java Script functionality. Candidate will be limited in time for this exam.", Logo = "cat-js.png", Type = ExamType.Advanced },
                new Exam() { CategoryId = 7, Name = "Node JS Advanced Exam", Description = "Base questions for Node JS interview. Exam include questions for Node JS functionality. Candidate will be limited in time for this exam.", Logo = "cat-node.png", Type = ExamType.Advanced }
            };
        }

        static IEnumerable<Question> GetInitialQuestions()
        {
            return new List<Question>()
            {
                new Question() { ExamId = 1, Title = "", Notes = "", Type = AnswerType.Text },
                new Question() { ExamId = 1, Title = "", Notes = "", Type = AnswerType.Text },
                new Question() { ExamId = 1, Title = "", Notes = "", Type = AnswerType.Text },
                new Question() { ExamId = 1, Title = "", Notes = "", Type = AnswerType.Text },
                new Question() { ExamId = 1, Title = "", Notes = "", Type = AnswerType.Text }
            };
        }
    }
}
