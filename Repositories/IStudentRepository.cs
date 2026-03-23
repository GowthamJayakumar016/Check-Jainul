using CheckGit.Models;

namespace CheckGit.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        void Add(Student student);
        void Delete(int id);
    }
}