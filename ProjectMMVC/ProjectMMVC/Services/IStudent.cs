using ProjectMMVC.Models;

namespace ProjectMMVC.Services
{
    public interface IStudent
    {
        Task<StudentsClass> GetByUserIdAsync(string userId);
        Task CreateAscync(StudentsClass student);
        Task CreateAsync(StudentsClass student);
        Task UpdateAsync(StudentsClass student);
        Task DeleteAsync(int id);
        bool Exists(int id);
        Task<List<StudentsClass>> GetAllAsync();
        Task<StudentsClass?> GetByIdAsync(int id);
    }
}
