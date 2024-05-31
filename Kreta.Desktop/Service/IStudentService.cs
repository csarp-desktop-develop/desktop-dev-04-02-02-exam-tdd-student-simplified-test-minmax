using Kreta.Desktop.Models;

namespace Kreta.Desktop.Service
{
    public interface IStudentService
    {
        public int GetNumberOfWomen();
        public int GetNumberOfWomen(int year, SchoolClassType type);
        public int GetNumberOfMen();
        public int GetNumberOfMen(int year, SchoolClassType type);
    }
}
