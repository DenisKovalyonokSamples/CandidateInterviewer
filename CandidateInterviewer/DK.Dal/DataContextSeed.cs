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
                //Angular JS Advanced Exam
                new Question() { ExamId = 17, Title = "Is it a good or bad practice to use AngularJS together with jQuery?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "It is definitely a bad practice. We need to stay away from jQuery and try to realize the solution with an AngularJS approach. jQuery takes a traditional imperative approach to manipulating the DOM, and in an imperative approach, it is up to the programmer to express the individual steps leading up to the desired outcome. AngularJS, however, takes a declarative approach to DOM manipulation. Here, instead of worrying about all of the step by step details regarding how to do the desired outcome, we are just declaring what we want and AngularJS worries about the rest, taking care of everything for us." },
                new Question() { ExamId = 17, Title = "If you were to migrate from Angular 1.4 to Angular 1.5, what is the main thing that would need refactoring?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "Changing .directive to .component to adapt to the new Angular 1.5 components." },
                new Question() { ExamId = 17, Title = "How to share data between controllers?", Score = Constants.MEDIUM_QUESTION_SCORE, Type = AnswerType.Multiple, Notes = "Using events, $parent, nextSibling, controllerAs, also the $rootScope (not a good practice)" },
                new Question() { ExamId = 17, Title = "Where should we implement the DOM manipulation in AngularJS?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "In the directives. DOM Manipulations should not exist in controllers, services or anywhere else but in directives." },
                new Question() { ExamId = 17, Title = "How would you specify that a scope variable should have one-time binding only?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "By using “::” in front of it. This allows you to check if the candidate is aware of the available variable bindings in AngularJS." },
                new Question() { ExamId = 17, Title = "Explain how $scope.$apply() works?", Score = Constants.HARD_QUESTION_SCORE, Type = AnswerType.Text, Notes = "$scope.$apply re-evaluates all the declared ng-models and applies the change to any that have been altered (i.e. assigned to a new value) Explanation: scope.scope.apply() is one of the core angular functions that should never be used explicitly, it forces the angular engine to run on all the watched variables and all external variables and apply the changes on their values." },
                new Question() { ExamId = 17, Title = "What directive would you use to hide elements from the HTML DOM by removing them from that DOM not changing their styling?", Score = Constants.SIMPLE_QUESTION_SCORE, Type = AnswerType.Single, Notes = "The ngIf Directive, when applied to an element, will remove that element from the DOM if it’s condition is false." },
                new Question() { ExamId = 17, Title = "What is a digest cycle in AngularJS?", Score = Constants.HARD_QUESTION_SCORE, Type = AnswerType.Text, Notes = "In each digest cycle Angular compares the old and the new version of the scope model values. The digest cycle is triggered automatically. We can also use $apply() if we want to trigger the digest cycle manually." }
            };
        }

        static IEnumerable<Answer> GetInitialAnswers()
        {
            return new List<Answer>()
            {
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
                new Answer() { QuestionId = 7, Value = "ng-if", IsCorrect = false }
            };
        }
    }
}
