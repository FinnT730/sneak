namespace BattleSnakes;

public class Cell
{
    private int id;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public bool food = false;
    public int x = 0;
    public int y = 0;
    public bool hasBody = false;
}