/*
 * Name:    Kendrick Antwi
 * Date:    11/15/2026
 * Course:  SDC320 - Project Week 1
 * Purpose: Base class (abstract) for all schoolwork. INHERITANCE: Quiz and Exam derive from it.
 */

namespace StudentAssignmentTracker;

// INHERITANCE (base class): Quiz and Exam inherit from Assignment.
public abstract class Assignment : IGradable
{
    public string Title { get; set; }
    public DateTime DueDate { get; set; }
    public double PointsPossible { get; }
    public double? PointsEarned { get; set; }
    public bool IsCompleted { get; set; }

    protected Assignment(string title, DateTime dueDate, double pointsPossible)
    {
        Title = title;
        DueDate = dueDate;
        PointsPossible = pointsPossible;
    }

    // Each derived class supplies its own type name and extra details.
    public abstract string TypeName { get; }
    public abstract string GetExtraDetails();

    public double? GetPercent() =>
        PointsEarned.HasValue ? PointsEarned.Value / PointsPossible * 100 : null;

    // Virtual so derived classes may override (polymorphism).
    public virtual string GetSummary()
    {
        string score = PointsEarned.HasValue ? $"{PointsEarned}/{PointsPossible}" : $"--/{PointsPossible}";
        string status = IsCompleted ? "Done" : "Pending";
        return $"{Title,-22} {TypeName,-6} {DueDate:MM/dd/yyyy}  {score,-9} {status,-8} {GetExtraDetails()}";
    }
}
