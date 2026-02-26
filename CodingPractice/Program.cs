using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Player player = new Player();
player.Health = 100;
player.Health = -999;

Player2 player2 = new Player2();
player2.SetHealth(100);
Console.WriteLine(player2.GetHealth());
Console.WriteLine();

Person person = new Person();
person.Name = "홍길동";
Console.WriteLine(person.Name);
Console.WriteLine();

Developer developer = new Developer();
developer.Name = "김개발";
developer.Age = 25;
Console.WriteLine($"{developer.Name}, {developer.Age}세");
Console.WriteLine();

Player3 player3 = new Player3();
Console.WriteLine($"이름: {player3.Name}");
Console.WriteLine($"레벨: {player3.Level}");
Console.WriteLine($"최대 체력: {player3.MaxHealth}");
Console.WriteLine();

Car car = new Car();
car.Name = "소나타";
car.Color = "검정";
Console.WriteLine($"{car.Name}, {car.Color}");
Console.WriteLine();

Product product = new Product();
Console.WriteLine(product.Manufacturer);
Console.WriteLine();

Page page = new Page();
Console.WriteLine(page.Message);
page.UpdateMessage("업데이트된 메시지");
Console.WriteLine(page.Message);
Console.WriteLine();

SecureData SC  = new SecureData();
SC.Password = "SC123";
Console.WriteLine(SC.Validate("SC123"));
Console.WriteLine();

Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"반지름: {circle.Radius}");
Console.WriteLine($"넓이: {circle.Area}");
Console.WriteLine($"둘레: {circle.Circumference}");
Console.WriteLine();

Counter counter = new Counter();
counter.Count = 10;
counter.Increase();
Console.WriteLine($"카운트: {counter.Count}");
Console.WriteLine();

Player4 player4 = new Player4();

player4.Health = 150;
Console.WriteLine($"체력: {player4.Health}");

player4.Health = -50;
Console.WriteLine($"체력: {player4.Health}");
Console.WriteLine();

Person2 person2 = new Person2();
person2.Name = "홍길동";
person2.BirthYear = 2000;
Console.WriteLine($"{person2.Name}님의 나이: {person2.Age}세");
Console.WriteLine();

Course course =  new Course();
course.Id = 1;
course.Title = "C# 기초";
Console.WriteLine($"{course.Id} - {course.Title}");
Console.WriteLine();

Course course2 = new Course { Id = 2, Title = "Unity 게임 개발" };
Console.WriteLine($"{course2.Id} - {course2.Title}");

Course[] courses =
{
    new Course { Id = 1, Title = "C# 기초" },
    new Course { Id = 2, Title = "C# 중급" },
    new Course { Id = 3, Title = "Unity 입문" }
};

foreach (Course c in courses)
{
    Console.WriteLine($"{c.Id} - {c.Title}");
}
Console.WriteLine();

Customer customer = new Customer { Id = 1, Name = "김철수", Email = "kim@example.com", City = "서울" };
Console.WriteLine($"고객: #{customer.Id}");
Console.WriteLine($"이름: {customer.Name}");
Console.WriteLine($"이메일: {customer.Email}");
Console.WriteLine($"도시: {customer.City}");
Console.WriteLine();

Console.WriteLine($"게임: {GameSettings.GameTitle}");
Console.WriteLine($"최대 플레이어: {GameSettings.MaxPlayers}");
Console.WriteLine($"사운드: {GameSettings.IsSountEnabled}");

GameSettings.MaxPlayers = 8;
Console.WriteLine($"변경된 최대 플레이어: {GameSettings.MaxPlayers}");
Console.WriteLine();

Monster monster = new Monster("고블린");
monster.Level = 5;
monster.Attack = 15;

Console.WriteLine($"이름: {monster.Name}");
Console.WriteLine($"레벨: {monster.Level}");
Console.WriteLine($"체력: {monster.Health}");
Console.WriteLine($"공격력: {monster.Attack}");
Console.WriteLine($"방어력: {monster.Defence}");
Console.WriteLine($"생존: {monster.IsAlive}");

monster.TakeDamage(50);
Console.WriteLine($"50 대미지 후 체력: {monster.Health}");