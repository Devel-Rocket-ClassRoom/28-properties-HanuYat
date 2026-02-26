class Player4
{
    private int _health;

    public int Health
    {
        get => _health;
        set
        {
            if (value > 100)
            {
                _health = 100;
            }

            else if (value < 0)
            {
                _health = 0;
            }

            else
            {
                _health = value;
            }
        }
    }
}