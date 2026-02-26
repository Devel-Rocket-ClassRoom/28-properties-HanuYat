using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 사각형 1 ===");
Rectangle r1 = new Rectangle { Width = 10, Height = 5 };
Console.WriteLine($"가로: {r1.Width}, 세로: {r1.Height}");
Console.WriteLine($"넓이: {r1.Area}");
Console.WriteLine($"둘레: {r1.Perimeter}");
Console.WriteLine($"정사각형: {r1.IsSquare}");
Console.WriteLine();

Console.WriteLine("=== 사각형 2 ===");
Rectangle r2 = new Rectangle { Width = 7, Height = 7 };
Console.WriteLine($"가로: {r2.Width}, 세로: {r2.Height}");
Console.WriteLine($"넓이: {r2.Area}");
Console.WriteLine($"둘레: {r2.Perimeter}");
Console.WriteLine($"정사각형: {r2.IsSquare}");
Console.WriteLine();

Console.WriteLine("=== 기본 사각형 ===");
Rectangle r3 = new Rectangle();
Console.WriteLine($"가로: {r3.Width}, 세로: {r3.Height}");
Console.WriteLine($"넓이: {r3.Area}");
Console.WriteLine($"둘레: {r3.Perimeter}");
Console.WriteLine($"정사각형: {r3.IsSquare}");