using System;

class Student
{
    private int _koreanScore;
    private int _englishScore;
    private int _mathScore;

    public string Name { get; }
    public int KoreanScore
    {
        get => _koreanScore;
        set
        {
            if (value < 0)
            {
                _koreanScore = 0;
            }

            else if (value > 100)
            {
                _koreanScore = 100;
            }

            else
            {
                _koreanScore = value;
            }
        }
    }
    public int EnglishScore
    {
        get => _englishScore;
        set
        {
            if (value < 0)
            {
                _englishScore = 0;
            }

            else if (value > 100)
            {
                _englishScore = 100;
            }

            else
            {
                _englishScore = value;
            }
        }
    }
    public int MathScore
    {
        get => _mathScore;
        set
        {
            if (value < 0)
            {
                _mathScore = 0;
            }

            else if (value > 100)
            {
                _mathScore = 100;
            }

            else
            {
                _mathScore = value;
            }
        }
    }
    public int TotalScore => _koreanScore + _englishScore + _mathScore;
    public double Average => TotalScore / 3;
    public string Grade
    {
        get
        {
            if (Average >= 90)
            {
                return "A";
            }

            else if (Average >= 80)
            {
                return "B";
            }

            else if (Average >= 70)
            {
                return "C";
            }

            else if (Average >= 60)
            {
                return "D";
            }

            else
            {
                return "F";
            }
        }
    }

    public Student(string name)
    {
        Name = name;
    }
}