using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExpert.models
{
    class TFQuestion : Question
    {
        private QuestionType type = QuestionType.TrueFalse;
        public QuestionType Type
        {
            get { return type; }
            set { type = value; }
        }
        public TFQuestion()
        {

        }

        public override bool CheckAnswer()
        {
            return true;
        }
    }
}
