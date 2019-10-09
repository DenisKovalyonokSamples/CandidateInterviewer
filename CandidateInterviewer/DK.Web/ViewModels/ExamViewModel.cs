using DK.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DK.Web.ViewModels
{
    public class ExamViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int CandidateId { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

        public ExamType Type { get; set; }

        public string TypeLogo { get; set; }

        public string CandidateFullName { get; set; }
    }
}
