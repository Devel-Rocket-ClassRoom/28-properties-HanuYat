class Player2
{
    private int _health;

    public void SetHealth(int health)
    {
        if (health >= 0 && health <= 100)
        {
           _health = health;
        }
    }

    public int GetHealth()
    {
        return _health;
    }
}