/*
 * Name:    Kendrick Antwi
 * Date:    11/15/2026
 * Course:  SDC320 - Project Week 1
 * Purpose: Defines the IGradable interface, the contract for any item that can be scored.
 */

namespace StudentAssignmentTracker;

public interface IGradable
{
    double PointsPossible { get; }
    double? PointsEarned { get; }

    // Returns the score as a percentage, or null if not graded yet.
    double? GetPercent();
}
