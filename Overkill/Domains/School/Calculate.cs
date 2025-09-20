using Overkill.Domains.School.Models;

namespace Overkill.Domains.School;

public static class Calculate
{
    public static List<string> CountAllClasses(List<Enrollment> enrollments)
    {
        var classes = 
            from enrollment in enrollments
            group enrollment by enrollment.ClassId into grouping
            select (grouping.Key, grouping.Count());
        return (
            from class_ in classes
            orderby class_.Item2, class_.Item1
            select $"{class_.Item1}:{class_.Item2}"
        ).ToList();
    }

    public static int CountClassStudents(List<Enrollment> enrollments, int classId)
    {
        return (
            from enrollment in enrollments
            where enrollment.ClassId == classId
            select enrollment.StdNo    
        ).Count();
    }

    public static int CountStudentClasses(List<Enrollment> enrollments, int stdNo)
    {
        return (
            from enrollment in enrollments
            where enrollment.StdNo == stdNo
            select enrollment.ClassId
        ).Count();
    }

    public static string GetStudentFullName(List<Student> students, int stdNo)
    {
        return (
            from student in students
            where student.StdNo == stdNo
            select $"{student.FirstName} {student.LastName}"
        ).First();
    }
    
    public static List<string> GetStudentClassNames(List<Class> classes, List<Enrollment> enrollments, int stdNo)
    {
        return (
            from class_ in classes
            from enrollment in enrollments
            where class_.ClassId == enrollment.ClassId && enrollment.StdNo == stdNo
            orderby class_.ClassId
            select class_.ClassName
        ).ToList();
    }   
}