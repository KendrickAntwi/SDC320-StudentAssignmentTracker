/*
 * Name:    Kendrick Antwi
 * Date:    11/15/2026
 * Course:  SDC320 - Project Week 1
 * Purpose: Entry point. Creates sample Courses, Quizzes and Exams and displays them (inheritance + composition demo).
 */

using StudentAssignmentTracker;

MessageDisplay.ShowBanner("Project Week 1", "Inheritance, Composition, and User Interactions", "Kendrick Antwi");
MessageDisplay.ShowWelcome();

// Instantiate classes with realistic information.
var programming = new Course("Programming in C#", "SDC320", "Dr. Alvarez", 3);
// INHERITANCE in use: Quiz and Exam objects are stored as their base type, Assignment.
programming.AddAssignment(new Quiz("Quiz 1: Variables", new DateTime(2026, 11, 3), 20, 10) { PointsEarned = 18, IsCompleted = true });
programming.AddAssignment(new Quiz("Quiz 2: Classes", new DateTime(2026, 11, 17), 20, 12));
programming.AddAssignment(new Exam("Midterm Exam", new DateTime(2026, 11, 20), 100,
    new List<string> { "Loops", "Methods", "Classes" }));

var statistics = new Course("Intro to Statistics", "MAT210", "Prof. Chen", 4);
statistics.AddAssignment(new Quiz("Quiz 1: Averages", new DateTime(2026, 11, 5), 15, 8) { PointsEarned = 12, IsCompleted = true });
statistics.AddAssignment(new Exam("Exam 1", new DateTime(2026, 11, 24), 100,
    new List<string> { "Mean/Median", "Probability" }));

// Display the information stored in the classes.
MessageDisplay.ShowCourse(programming);
MessageDisplay.ShowCourse(statistics);

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();
