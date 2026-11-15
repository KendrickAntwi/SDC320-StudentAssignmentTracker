/*
 * Name:    Kendrick Antwi
 * Date:    11/15/2026
 * Course:  SDC320 - Project Week 1
 * Purpose: Reusable display helpers (banner, welcome message, formatted course output) for use in later project weeks.
 */

namespace StudentAssignmentTracker;

public static class MessageDisplay
{
    public static void ShowBanner(string week, string title, string author)
    {
        string line = new string('=', 70);
        Console.WriteLine(line);
        Console.WriteLine($"  {week} | {title}");
        Console.WriteLine($"  By: {author}");
        Console.WriteLine(line);
    }

    public static void ShowWelcome()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Student Assignment Tracker!");
        Console.WriteLine("Track your courses, quizzes and exams in one place.");
        Console.WriteLine("This week's demo creates sample data and displays it.");
        Console.WriteLine("Next weeks will add a menu so you can add, update and delete items.");
        Console.WriteLine("\"Procrastination is the art of keeping up with yesterday.\" - Don Marquis");
        Console.WriteLine();
    }

    public static void ShowCourse(Course course)
    {
        Console.WriteLine($"{course.Code} - {course.Name}  (Instructor: {course.Instructor}, {course.Credits} credits)");
        Console.WriteLine(new string('-', 70));
        foreach (Assignment a in course.Assignments)
        {
            // POLYMORPHISM: each assignment type formats its own details.
            Console.WriteLine(a.GetSummary());
        }
        double? pct = course.CurrentPercent();
        string grade = pct.HasValue ? $"{pct:F1}%" : "N/A";
        Console.WriteLine($"Graded so far: {course.TotalEarned()}/{course.TotalPossibleGraded()} points = {grade}");
        Console.WriteLine();
    }
}
