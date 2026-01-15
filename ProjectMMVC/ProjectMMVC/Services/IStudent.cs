using ProjectMMVC.Models;

namespace ProjectMMVC.Services
{
    public interface IStudent
    {
        Task<List<StudentsClass>> GetAllAsync();
        Task<StudentsClass?> GetByIdAsync(int id);
        Task CreateAsync(StudentsClass student);
        Task UpdateAsync(StudentsClass student);
        Task DeleteAsync(int id);
        bool Exists(int id);
    }
}
