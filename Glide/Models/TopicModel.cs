using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using SQLite.Net.Attributes;
using System.Text;
using System.Threading.Tasks;

// Program Title: Glide
// Class File: TopicModel.cs
// Author: Herbert Smith
// Purpose: This is for the courses that Glide teaches. 

namespace Glide.Models
{
    public class TopicModel
    {
        [PrimaryKey]
        public int Top_ID { get; set; }
        public int Course_ID { get; set; } // If more than one course, then it may be best to not start the TopicID at ZERO for the first topic, so that less of the program needs modifying to allow multiple courses.
        public string Top_Name { get; set; } // This is only used to make things easier for building a course. I can't think of why this would be needed, other than for that purpose.
        public bool Top_Studied { get; set; }

        public string Next_Date { get; set; }
        public string First_Date { get; set; }  // I might have a feature that displays the progress of topics since their first study dates.

        // The number of correct problems, out of the total problems for a topic, 
        // is in the databse, just in case the range for the calculation of difficulty 
        // needs to be adjusted a little. The range for difficulty is not mentioned in
        // any research I could find. But, there definitely is a range. 1.3 for hardest, 
        // and 2.5 for easiest, appears to me to be correct. I will need to analyze the
        // results of research better, to see if the values need to be changed. Close is
        // good enough to me, until the program is fully functional.
        public double Num_Problems { get; set; }
        public double Num_Correct { get; set; }

        public double Top_Difficulty { get; set; }
        public double Top_Repetition { get; set; }
        public double Interval_Remaining { get; set; }

        public double Interval_Length { get; set; }
        public double Engram_Stability { get; set; }
        public double Engram_Retrievability { get; set; }
    }


    // There can be any number of topics. I have three here just to have something at the moment.
    public class TopicManager
    {
        // The database needs some initial topic data to save into it, so that is what this is for.
        /* topic data initial values */
        public static List<TopicModel> GetTopics()
        {
            var Topics = new List<TopicModel>();

            Topics.Add(new TopicModel
            {
                Top_ID = 0,
                Course_ID = 0,
                Top_Name = "Sets",
                Top_Studied = false,

                Next_Date = "none",
                First_Date = "none",

                Num_Problems = 5,
                Num_Correct = 0,

                Top_Difficulty = 0,
                Top_Repetition = 0,
                Interval_Remaining = 0,

                Interval_Length = 0,
                Engram_Stability = 0,
                Engram_Retrievability = 0,
            }
            );
            Topics.Add(new TopicModel
            {
                Top_ID = 1,
                Course_ID = 0,
                Top_Name = "Sub Sets",
                Top_Studied = false,

                Next_Date = "none",
                First_Date = "none",

                Num_Problems = 4,
                Num_Correct = 0,

                Top_Difficulty = 0,
                Top_Repetition = 0,
                Interval_Remaining = 0,

                Interval_Length = 0,
                Engram_Stability = 0,
                Engram_Retrievability = 0,
            }
            );
            Topics.Add(new TopicModel
            {
                Top_ID = 2,
                Course_ID = 0,
                Top_Name = "Union and Intersection",
                Top_Studied = false,

                Next_Date = "none",
                First_Date = "none",

                Num_Problems = 2,
                Num_Correct = 0,

                Top_Difficulty = 0,
                Top_Repetition = 0,
                Interval_Remaining = 0,

                Interval_Length = 0,
                Engram_Stability = 0,
                Engram_Retrievability = 0,
            }
            );

            return Topics;
        }
    }
}

