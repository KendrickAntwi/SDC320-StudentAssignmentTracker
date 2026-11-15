/*
 * Name:    Kendrick Antwi
 * Date:    11/15/2026
 * Course:  SDC320 - Project Week 1
 * Purpose: Derived class: a Quiz is a kind of Assignment that also tracks its number of questions.
 */

namespace StudentAssignmentTracker;

// INHERITANCE (derived class): Quiz IS-A Assignment.
public class Quiz : Assignment
{
    public int NumberOfQuestions { get; }

    public Quiz(string title, DateTime dueDate, double pointsPossible, int numberOfQuestions)
        : base(title, dueDate, pointsPossible)
    {
        NumberOfQuestions = numberOfQuestions;
    }

    public override string TypeName => "Quiz";
    public override string GetExtraDetails() => $"{NumberOfQuestions} questions";
}
