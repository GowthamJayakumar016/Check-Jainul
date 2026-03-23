using CheckGit.Models;
using CheckGit.Repositories;

namespace CheckGit.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetStudents()
        {
            return _repo.GetAll();
        }

        public void AddStudent(Student student)
        {
            _repo.Add(student);
        }

        public void DeleteStudent(int id)
        {
            _repo.Delete(id);
        }
    }
}