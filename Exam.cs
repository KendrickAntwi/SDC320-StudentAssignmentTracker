/*
 * Name:    Kendrick Antwi
 * Date:    11/15/2026
 * Course:  SDC320 - Project Week 1
 * Purpose: Derived class: an Exam is a kind of Assignment that also tracks its topics covered.
 */

namespace StudentAssignmentTracker;

// INHERITANCE (derived class): Exam IS-A Assignment.
public class Exam : Assignment
{
    public List<string> Topics { get; }

    public Exam(string title, DateTime dueDate, double pointsPossible, List<string> topics)
        : base(title, dueDate, pointsPossible)
    {
        Topics = topics;
    }

    public override string TypeName => "Exam";
    public override string GetExtraDetails() => "Topics: " + string.Join(", ", Topics);
}
