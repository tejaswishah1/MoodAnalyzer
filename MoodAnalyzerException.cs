﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_METHOD_TYPE,
            EMPTY_STRING_TYPE
        }
        private readonly ExceptionType type;

        public MoodAnalyzerException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }

    }
}
