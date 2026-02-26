using System;

class Person2
{
    private int _birthYear;

    public string Name { get; set; }
    public int BirthYear
    {
        set
        {
            if (value >= 1900)
            {
                _birthYear = value;
            }
        }
    }
    public int Age
    {
        get => DateTime.Now.Year - _birthYear;
    }
}