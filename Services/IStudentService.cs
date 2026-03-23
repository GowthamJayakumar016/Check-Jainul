using CheckGit.Models;

namespace CheckGit.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        void AddStudent(Student student);
        void DeleteStudent(int id);
    }
}