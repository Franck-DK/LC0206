using System.ComponentModel.DataAnnotations;

namespace a
{
    public class Student
    {
        [Key]
        public string Id { get; set; } = "";

        public string Name { get; set; } = "";

        public int Age { get; set; } = 0;

        public double Grade { get; set; } = 0;

        public char LetterGrade { get; set; } = 'H'; //ABCDF
    }
}