using Kreta.Desktop.Repos;
using Kreta.Desktop.SchoolCitizens;
using Moq;

namespace Kreta.Desktop.Service.Tests
{
    [TestClass()]
    public class StudentServiceTests
    {
        private readonly IStudentService? _studentService;
        private readonly Mock<IStudentRepo> moqStudeRepo = new Mock<IStudentRepo>();

        public StudentServiceTests()
        {
            _studentService = new StudentService(moqStudeRepo.Object);
        }

        [TestMethod()]
        public void EmptyDatabase()
        {
            moqStudeRepo
                .Setup(mock => mock.FindAll())
                .Returns(Enumerable.Empty<Student>().ToList());

            if (_studentService == null)
                Assert.Fail($"{nameof(IStudentService)} osztály nulla.");

            Assert.AreEqual(0, _studentService.GetNumberOfWomen(), $"{nameof(_studentService.GetNumberOfWomen)} üres adatbázis esetén hibát dobott.");
            Assert.AreEqual(0, _studentService.GetNumberOfWomen(9, Models.SchoolClassType.ClassA), $"{nameof(_studentService.GetNumberOfWomen)} 9.a osztály paraméterrel üres adatbázis esetén hibát dobott.");
            Assert.AreEqual(0, _studentService.GetNumberOfMen(), $"{nameof(_studentService.GetNumberOfMen)} üres adatbázis esetén hibát dobott.");
            Assert.AreEqual(0, _studentService.GetNumberOfMen(9, Models.SchoolClassType.ClassA), $"{nameof(_studentService.GetNumberOfMen)} 9.a osztály paraméterrel üres adatbázis esetén hibát dobott.");
        }

        [TestMethod()]
        public void NoEmptyDatabase()
        {
            // arrange
            List<Student> awardedStudents = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                },
            };
        }
    }
}