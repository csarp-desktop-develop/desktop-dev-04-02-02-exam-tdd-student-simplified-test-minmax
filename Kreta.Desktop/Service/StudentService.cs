using Kreta.Desktop.Models;
using Kreta.Desktop.Repos;
using System;

namespace Kreta.Desktop.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo? _studentRepo;

        public StudentService(IStudentRepo? studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public int GetNumberOfMen()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfMen(int year, SchoolClassType type)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfWomen()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfWomen(int year, SchoolClassType type)
        {
            throw new NotImplementedException();
        }
    }
}
