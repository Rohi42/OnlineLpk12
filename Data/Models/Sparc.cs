﻿using System;
using System.Collections.Generic;

namespace OnlineLpk12.Data.Models
{
    public partial class Sparc
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? LessonId { get; set; }
        public byte[]? Program { get; set; }
        public string? Query { get; set; }
        public byte[]? Results { get; set; }
        public int? QuizId { get; set; }
        public int? ProgrammingTaskId { get; set; }
        public DateTime? ActivityTimeStamp { get; set; }
    }
}
