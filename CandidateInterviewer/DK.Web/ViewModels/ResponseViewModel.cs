using DK.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DK.Web.ViewModels
{
    public class ResponseViewModel
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public int InterviewId { get; set; }

        public string Value { get; set; }

        public bool IsApproved { get; set; }

        public ApprovalType Type { get; set; }
    }
}
