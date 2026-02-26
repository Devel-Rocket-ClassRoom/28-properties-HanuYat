using System;

class Monster
{
    private int _health;
    private const int k_MaxHealth = 200;

    public int Health
    {
        get => _health;
        set
        {
            if (value < 0)
            {
                _health = 0;
            }

            else if (value > k_MaxHealth)
            {
                _health -= k_MaxHealth;
            }

            else
            {
                _health = value;
            }
        }
    }
    public int Level { get; set; }
    public int Attack { get; set; }
    public string Name { get; private set; }
    public bool IsAlive => _health > 0;
    public int Defence => Level * 2;

    public Monster(string name)
    {
        Name = name;
        _health = 100;
    }

    public void TakeDamage(int damage)
    {
        int NextDamage = damage - Defence;
        if (NextDamage > 0)
        {
            _health -= NextDamage;
        }
    }
}