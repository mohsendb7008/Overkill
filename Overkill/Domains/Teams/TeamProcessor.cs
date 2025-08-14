namespace Overkill.Domains.Teams;

public class TeamProcessor
{
    private readonly List<TeamMember> _members = [];

    private class TeamMemberComparer(System.Func<TeamMember, TeamMember, int> comparer) : IComparer<TeamMember>
    {
        public int Compare(TeamMember? x, TeamMember? y)
        {
            if (x == null || y == null)
                return 0;
            return comparer.Invoke(x, y);
        }
    }
    
    public void SortMembers(System.Func<TeamMember, TeamMember, int> comparison)
    {
        _members.Sort(new TeamMemberComparer(comparison));
    }

    public List<TeamMember> FilterMembers(System.Func<TeamMember, bool> condition)
    {
        return _members.Where(condition).ToList();
    }

    public void AddMember(TeamMember member)
    {
        _members.Add(member);
    }
}
