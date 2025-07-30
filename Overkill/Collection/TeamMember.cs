namespace Overkill.Collection;

public class TeamMember(string name, int tasksCompleted, int yearsOfExperience)
{
    public string Name { get; set; } = name;
    public int TasksCompleted { get; set; } = tasksCompleted;
    public int YearsOfExperience { get; set; } = yearsOfExperience;
}
