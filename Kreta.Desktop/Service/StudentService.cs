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

        public double GetAvgAge(int schoolClassSchoolGrade, SchoolClassType type)
        {
            throw new NotImplementedException();
        }

        public Guid GetOldestestStudent(bool gender)
        {
            throw new NotImplementedException();
        }

        public Guid GetOldestStudent()
        {
            throw new NotImplementedException();
        }

        public Guid GetYoungestStudent()
        {
            throw new NotImplementedException();
        }

        public Guid GetYoungestStudent(bool gender)
        {
            throw new NotImplementedException();
        }
    }
}
