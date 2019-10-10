using DK.Core;
using DK.DataAccess.Enums;
using DK.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace DK.Web.Managers
{
    public static class CalculationManager
    {
        public static int CalculateFinalInterviewScore(List<QuestionViewModel> questions, ExamType type)
        {
            int totalScore = 0;

            foreach (var question in questions)
            {
                if (question.Type == AnswerType.Single)
                {
                    if (question.Answers.Any(e => e.Value == question.CandidateAnswer && e.IsCorrect))
                    {
                        totalScore += question.Score;
                    }
                }

                if (question.Type == AnswerType.Multiple)
                {
                    if (question.Answers.All(e => e.IsCorrect == e.CandidateAnswer))
                    {
                        totalScore += question.Score;
                    }
                }
            }

            totalScore = ApplyDifficaltyLevelCoefficient(totalScore, type);

            return totalScore;
        }

        private static int ApplyDifficaltyLevelCoefficient(int score, ExamType type)
        {
            if (type == ExamType.Intermediate)
            {
                score = score * Constants.INTERMEDIATE_EXAM_COEFFICIENT;
            }

            if (type == ExamType.Advanced)
            {
                score = score * Constants.ADVANCED_EXAM_COEFFICIENT;
            }

            return score;
        }
    }
}
