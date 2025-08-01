using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeoExpert.models;

namespace GeoExpert.Utils
{
    public static class ViewHelper
    {
        public static string FormatQuestionType(QuestionType questionType)
        {
            switch (questionType)
            {
                case QuestionType.MultipleChoice: 
                    return "Multi-choices";

                case QuestionType.TrueFalse:
                    return "True/False";

                case QuestionType.OpenEnded:
                    return "Open-ended";

                default:
                    return "No question type";
            }
        }
    }
}
