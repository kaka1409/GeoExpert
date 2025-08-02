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
        // Future work: Refactor this (correct name and methods)

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

        public static string FormatDate(DateTime date)
        {
            TimeSpan timePassed = DateTime.Now - date;
            string result;

            if (timePassed.Days >= 365 * 2)
            {
                result = ("Created " + timePassed.Days / 365 + " years ago");
            }
            else if (timePassed.Days < 365 * 2 && timePassed.Days > 365)
            {
                result = ("Created 1 year ago");
            }
            else if (timePassed.Days > 60)
            {
                result = ("Created " + timePassed.Days / 30 + " months ago");
            }
            else if (timePassed.Days < 60 && timePassed.Days > 30)
            {
                result = ("Created 1 month ago");
            }
            else if (timePassed.Days >= 1 && timePassed.Days <= 30)
            {
                result = ("Created " + timePassed.Days + " days ago");
            }
            else if (timePassed.Days == 0 && timePassed.Hours > 0)
            {
                result = ("Created " + timePassed.Hours + " hours ago");
            }
            else if (timePassed.Hours == 0 && timePassed.Minutes > 0)
            {
                result = ("Created " + timePassed.Minutes + " minutes ago");
            }
            else
            {
                result = ("Created Just Now");
            }

            return result;
        }
    }
}
