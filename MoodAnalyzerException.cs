using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
          N0_SUCH_CLASS,
          NO_SUCH_METHOD
        }
        private readonly ExceptionType type;

        public MoodAnalyzerException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }

    }
}
