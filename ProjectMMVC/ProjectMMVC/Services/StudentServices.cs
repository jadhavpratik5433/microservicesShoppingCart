using Microsoft.EntityFrameworkCore;
using ProjectMMVC.Models;

namespace ProjectMMVC.Services
{
    public class StudentServices :IStudent
    {
        private readonly ApplicationDbContext _context;
        public StudentServices(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<StudentsClass> GetByUserIdAsync(string userId)
        {
            return await _context.studentsClasses.FirstOrDefaultAsync(x => x.UserId == userId);
        }
        public async Task CreateAsync(StudentsClass student)
        {
            _context.studentsClasses.Add(student);
            await  _context.SaveChangesAsync();
        }






        public async Task<List<StudentsClass>> GetAllAsync()
       => await _context.studentsClasses.ToListAsync();

        public async Task<StudentsClass?> GetByIdAsync(int id)
            => await _context.studentsClasses.FirstOrDefaultAsync(x => x.Id == id);

        //public async Task CreateAsync(StudentsClass student)
        //{
        //    _context.studentsClasses.Add(student);
        //    await _context.SaveChangesAsync();
        //}

        public async Task UpdateAsync(StudentsClass student)
        {
            _context.studentsClasses.Update(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var student = await _context.studentsClasses.FindAsync(id);
            if (student != null)
            {
                _context.studentsClasses.Remove(student);
                await _context.SaveChangesAsync();
            }
        }

        public bool Exists(int id)
            => _context.studentsClasses.Any(e => e.Id == id);

        public Task CreateAscync(StudentsClass student)
        {
            throw new NotImplementedException();
        }
    }
}
