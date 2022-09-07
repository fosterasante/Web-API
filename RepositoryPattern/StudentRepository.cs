using Microsoft.EntityFrameworkCore;
using School.ClassLibrary.Models;

namespace School.School.API.RepositoryPattern
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly AppDbContext _appDbContext;

        public StudentRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<Student> CreateStudent(Student student)
        {
            if(student != null)
            {
                await _appDbContext.students.AddAsync(student);
                _appDbContext.SaveChanges();
                return student;
            }
            return null;
        }

        public async Task<Student> DeleteStudentAsync(int id)
        {
            var student = await _appDbContext.students.FindAsync();
            if(student != null)
            {
                _appDbContext.students.Remove(student);
               await _appDbContext.SaveChangesAsync();
                return student;
            }
            return null;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _appDbContext.students.ToListAsync();
        }

        public async Task<Student> GetSingleStudent(int id)
        {
            return await _appDbContext.students.FindAsync(id);
        }

        public async Task<Student> UpdateStudent(int id, Student student)
        {
            var newStudent = new Student();
            var result = await _appDbContext.students.FindAsync(id);
            if(result != null)
            {
                newStudent.FirstName = student.FirstName;
                newStudent.LastName = student.LastName;
                await _appDbContext.SaveChangesAsync();
                return student;
            }
            return null;
        }
    }
}
