using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyse
    {
        public string message;

        public MoodAnalyse() { }

        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
            
        {
            try
            {

                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_STRING_TYPE, "Mood cannot be empty");
                    
                }
               else if (this.message.Contains("sad".ToLower()))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }

            catch(NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_METHOD_TYPE, "Mood cannot be null value");
                
                
            }
                }

        public static object CreateMoodAnalyser(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
        }
    

