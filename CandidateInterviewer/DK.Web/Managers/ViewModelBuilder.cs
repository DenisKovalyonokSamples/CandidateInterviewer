using DK.DataAccess.Entities;
using DK.DataAccess.Enums;
using DK.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace DK.Web.Managers
{
    public static class ViewModelBuilder
    {
        public static HomeViewModel GetHomeViewModel(List<Category> entities)
        {            
            var viewModel = new HomeViewModel();

            if (entities?.Any() == true)
            {
                viewModel.Categories = entities?
                  .Select(o => new CategoryViewModel()
                  {
                      Id = o.Id,
                      Name = o.Name,
                      Description = o.Description,
                      Logo = o.Logo
                  })?.ToList() ?? new List<CategoryViewModel>();
            }

            return viewModel;
        }

        public static InterviewsViewModel GetInterviewsViewModel(List<Category> entities)
        {
            var viewModel = new InterviewsViewModel();

            if (entities?.Any() == true)
            {
                viewModel.Categories = entities?
                  .Select(o => new CategoryViewModel()
                  {
                      Id = o.Id,
                      Name = o.Name,
                      Description = o.Description,
                      Logo = o.Logo,
                      Type = o.Type
                  })?.ToList() ?? new List<CategoryViewModel>();
            }

            return viewModel;
        }

        public static InterviewViewModel GetInterviewViewModel(Category entitiy)
        {
            var viewModel = new InterviewViewModel();

            viewModel.Candidate = new CandidateViewModel();
            viewModel.Category = GetCategoryViewModel(entitiy);
            viewModel.SelectedExamType = ExamType.Unknown;

            return viewModel;
        }

        public static CategoryViewModel GetCategoryViewModel(Category entity)
        {
            var viewModel = new CategoryViewModel();

            if (entity != null)
            {
                viewModel.Id = entity.Id;
                viewModel.Name = entity.Name;
                viewModel.Description = entity.Description;
                viewModel.Logo = entity.Logo;
                viewModel.Type = entity.Type;
            }

            return viewModel;
        }

        public static CandidateViewModel GetCandidateViewModel(Candidate entity)
        {
            var viewModel = new CandidateViewModel();

            if (entity != null)
            {
                viewModel.Id = entity.Id;
                viewModel.Name = entity.FirstName + " " + entity.LastName;
                viewModel.Description = entity.Description;
                viewModel.Email = entity.Email;
                viewModel.Phone = entity.Phone;
                viewModel.Skype = entity.Skype;
            }

            return viewModel;
        }

        public static Candidate ToCandidateEntity(this CandidateViewModel viewModel)
        {
            var entity = new Candidate();

            if (viewModel != null)
            {
                entity.Id = viewModel.Id;
                entity.FirstName = viewModel.Name;
                entity.Description = viewModel.Description;
                entity.Email = viewModel.Email;
                entity.Phone = viewModel.Phone;
                entity.Skype = viewModel.Skype;
            }

            return entity;
        }
    }
}
