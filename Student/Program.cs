using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Student[] students =
{
    new Student("김철수") {KoreanScore = 85, EnglishScore = 90, MathScore = 95},
    new Student("이영희") {KoreanScore = 75, EnglishScore = 80, MathScore = 70},
    new Student("박민수") {KoreanScore = 110, EnglishScore = 120, MathScore = -10}
};

foreach (Student student in students)
{
    Console.WriteLine($"=== 성적표: {student.Name} ===");
    Console.WriteLine($"국어: {student.KoreanScore}, 영어: {student.EnglishScore}, 수학: {student.MathScore}");
    Console.WriteLine($"총점: {student.TotalScore}");
    Console.WriteLine($"평균: {student.Average:F2}");
    Console.WriteLine($"학점: {student.Grade}");
    Console.WriteLine();
}
