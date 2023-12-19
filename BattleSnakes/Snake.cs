using System.Collections;

namespace BattleSnakes;

public class Snake
{
    public int x, y;
    public Pos head = new Pos(0,0);
    public List<Pos> body = new List<Pos>();
    public bool isPlayer = false;
    public Snake()
    {
        
    }

    public void moveForward()
    {
        body.Insert(0, head);
        body.RemoveAt(body.Count);
    }
}