using Kreta.Desktop.Models;
using System;

namespace Kreta.Desktop.Service
{
    public interface IStudentService
    {
        public Guid GetYoungestStudent();
        public Guid GetYoungestStudent(bool gender);
        public Guid GetOldestStudent();
        public Guid GetOldestestStudent(bool gender);
        public double GetAvgAge(int schoolClassSchoolGrade, SchoolClassType type);
    }
}
