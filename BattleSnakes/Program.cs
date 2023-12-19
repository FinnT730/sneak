using BattleSnakes;
using Raylib_cs;
using static Raylib_cs.Raylib;

class Program
{
    static void Main(String[] args)
    {
        Grid grid = new Grid(9, 9, 150, 150);
        const int cellSize = 32;

        // grid.cells[0, 0].hasBody = true;
        // grid.cells[1, 0].hasBody = true;
        // grid.cells[2, 0].hasBody = true;
        // grid.cells[3, 0].hasBody = true;

        var snake = new Snake();
        snake.head = new Pos(1,1);
        snake.body.Add(new Pos(1,2));
        grid.snakes.AddFirst(new Snake());

        InitWindow(600, 600, "BattleSnake");
        grid.update();

        while (!WindowShouldClose())
        {
            BeginDrawing();
            ClearBackground(Color.RAYWHITE);
            DrawText("Sneak 1.0", 10, 10, 60, Color.RED);
            // Draw the grid
            for (int i = 0; i <= grid.width; i++)
            {
                DrawLine(grid.x, grid.y + i * cellSize, grid.x + grid.height * cellSize, grid.y + i * cellSize,
                    Color.BLACK);
                for (int j = 0; j <= grid.height; j++)
                {
                    DrawLine(grid.x + j * cellSize, grid.y, grid.x + j * cellSize, grid.y + grid.width * cellSize,
                        Color.BLACK);
                }
            }

            for (int i = 0; i < grid.width; i++)
            {
                for (int j = 0; j < grid.height; j++)
                {
                    if (grid.cells[i, j] != null && grid.cells[i, j].hasBody)
                    {
                        DrawRectangle((i * cellSize) + grid.x, (j * cellSize) + grid.y, cellSize - 1, cellSize - 1,
                            Color.RED);
                    }
                }
            }

            EndDrawing();
        }

        CloseWindow();
    }
}