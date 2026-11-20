/*
 * Name:    Kendrick Antwi
 * Date:    11/20/2026
 * Course:  SDC320 - Project Week 2
 * Purpose: Entry point demonstrating interfaces (IGradable) and polymorphism for Student Assignment Tracker.
 */

using StudentAssignmentTracker;

MessageDisplay.ShowBanner("Project Week 2", "Software Design; Interfaces & Polymorphism", "Kendrick Antwi");
MessageDisplay.ShowWelcome();

var programming = new Course("Programming in C#", "SDC320", "Dr. Alvarez", 3);
// POLYMORPHISM: Quiz and Exam objects are stored as base Assignment references.
programming.AddAssignment(new Quiz("Quiz 1: Variables", new DateTime(2026, 11, 3), 20, 10) { PointsEarned = 18, IsCompleted = true });
programming.AddAssignment(new Quiz("Quiz 2: Classes", new DateTime(2026, 11, 17), 20, 12));
programming.AddAssignment(new Exam("Midterm Exam", new DateTime(2026, 11, 20), 100,
    new List<string> { "Loops", "Methods", "Classes" }));

var statistics = new Course("Intro to Statistics", "MAT210", "Prof. Chen", 4);
statistics.AddAssignment(new Quiz("Quiz 1: Averages", new DateTime(2026, 11, 5), 15, 8) { PointsEarned = 12, IsCompleted = true });
statistics.AddAssignment(new Exam("Exam 1", new DateTime(2026, 11, 24), 100,
    new List<string> { "Mean/Median", "Probability" }));

MessageDisplay.ShowCourse(programming);
MessageDisplay.ShowCourse(statistics);

// INTERFACE & POLYMORPHISM: Accessing assignments through the IGradable interface.
Console.WriteLine("IGradable Percentage Check:");
List<IGradable> gradables = new List<IGradable>(programming.Assignments);
foreach (IGradable item in gradables)
{
    double? pct = item.GetPercent();
    string pctText = pct.HasValue ? $"{pct:F1}%" : "Ungraded";
    Console.WriteLine($"  Max Points: {item.PointsPossible} | Score %: {pctText}");
}

Console.WriteLine("\nPress Enter to exit...");
Console.ReadLine();