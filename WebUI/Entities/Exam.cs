﻿namespace WebUI.Entities
{
    public class Exam
    {
		public int Id { get; set; }
		public int CourseId { get; set; }
		public int ExamId { get; set; }
		public int SemesterId { get; set; }
		public DateTime ExamDate { get; set; }
		public int Duration { get; set; }
	}
}
