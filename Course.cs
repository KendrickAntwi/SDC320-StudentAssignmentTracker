/*
 * Name:    Kendrick Antwi
 * Date:    11/15/2026
 * Course:  SDC320 - Project Week 1
 * Purpose: Represents a college course. COMPOSITION: a Course is made up of (owns) its Assignments.
 */

namespace StudentAssignmentTracker;

public class Course
{
    public string Name { get; }
    public string Code { get; }
    public string Instructor { get; }
    public int Credits { get; }

    // COMPOSITION (HAS-A): a Course is composed of Assignment objects.
    // The list is private and created inside Course, so the assignments
    // belong to the course and are managed only through its methods.
    private readonly List<Assignment> _assignments = new();

    public Course(string name, string code, string instructor, int credits)
    {
        Name = name;
        Code = code;
        Instructor = instructor;
        Credits = credits;
    }

    public IReadOnlyList<Assignment> Assignments => _assignments;

    public void AddAssignment(Assignment assignment) => _assignments.Add(assignment);

    public double TotalEarned() => _assignments.Where(a => a.PointsEarned.HasValue).Sum(a => a.PointsEarned!.Value);
    public double TotalPossibleGraded() => _assignments.Where(a => a.PointsEarned.HasValue).Sum(a => a.PointsPossible);

    public double? CurrentPercent() =>
        TotalPossibleGraded() > 0 ? TotalEarned() / TotalPossibleGraded() * 100 : null;
}
