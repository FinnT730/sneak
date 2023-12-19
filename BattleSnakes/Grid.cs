namespace BattleSnakes;

public class Grid
{
    public Cell[,] cells;
    public int width, height;
    public int x, y;

    public LinkedList<Snake> snakes = new LinkedList<Snake>();

    public Grid(int width, int height, int x, int y)
    {
        cells = new Cell[,]{};
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        var cells1 = new Cell[width, height];
        for (int i = 0; i < width - 1; i++)
        {
            for (int j = 0; j < height - 1; j++)
            {
                var cell = new Cell();
                cell.x = 10 + (i * 9);
                cell.y = 10 + (j* 9);
                cells1[i, j] = cell;
            }
        }
        
        cells = cells1;
    }

    public void update()
    {
        foreach (var snake in snakes)
        {
            foreach (var cell in cells)
            {
                if (cell != null && snake != null)
                {
                    if (cell.x == snake.head.x && cell.y == snake.head.y)
                    {
                        cell.hasBody = true;
                    }
                    else
                    {
                        cell.hasBody = false;
                    }
                    foreach (var poss in snake.body)
                    {
                        if (cell.x == poss.x && cell.y == poss.y)
                        {
                            cell.hasBody = true;
                        }
                        else
                        {
                            cell.hasBody = false;
                        }
                    }

                    // if (cell.x == snake.x && cell.y == snake.y)
                    // {
                    //     cell.hasBody = true;
                    // }
                    // else
                    // {
                    //     cell.hasBody = false;
                    // }
                }
            }
            // if (cells != null && snake != null)
            // {
            //     foreach (var cell in cells)
            //     {
            //         if (cell != null)
            //         {
            //             if (cell.x != snake.x && cell.y != snake.y)
            //             {
            //                 cell.hasBody = false;
            //             }
            //             else
            //             {
            //                 cell.hasBody = true;
            //             }
            //         }
            //     }
            // }
        }
    }
}