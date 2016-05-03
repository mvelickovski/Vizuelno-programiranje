using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    class Cell
    {
        public bool IsAlive { get; set; }
        public bool ShouldLive { get; set; }
        public Cell()
        {
            IsAlive = false;
            ShouldLive = false;
        }

        public override string ToString()
        {
            if (IsAlive)
                return " X ";
            return " _ ";
        }
    }

    class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[][] Cells { get; set; }

        public Grid(int rows,int columns)
        {
            Rows = rows;
            Columns = columns;
            Cells = new Cell[rows][];
            for(int i = 0; i < rows; i++)
            {
                Cells[i] = new Cell[columns];
                for(int j = 0; j < columns; j++)
                {
                    Cells[i][j] = new Cell();
                }
            }
        }

        public void ToggleCell(int x,int y,bool isAlive)
        {
            Cells[x][y].IsAlive = isAlive;
        }
        
        public void Evolve()
        {
            int sumNeighbours;
            int i = 0, j = 0;
            for(i=0;i<Rows;i++)
            {
                sumNeighbours = 0;
                for (j = 0; j < Columns; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (Cells[i + 1][j].IsAlive)
                                sumNeighbours++;
                            if (Cells[i + 1][j + 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i][j + 1].IsAlive)
                                sumNeighbours++;
                        }
                        else if (j == Columns - 1)
                        {
                            if (Cells[i + 1][j].IsAlive)
                                sumNeighbours++;
                            if (Cells[i + 1][j - 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i][j - 1].IsAlive)
                                sumNeighbours++;
                        }
                        else
                        {
                            if (Cells[i + 1][j - 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i + 1][j].IsAlive)
                                sumNeighbours++;
                            if (Cells[i + 1][j + 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i][j - 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i][j + 1].IsAlive)
                                sumNeighbours++;
                        }
                    }
                    else if (i == Rows - 1)
                    {
                        if (j == 0)
                        {
                            if (Cells[i - 1][j].IsAlive)
                                sumNeighbours++;
                            if (Cells[i - 1][j + 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i][j + 1].IsAlive)
                                sumNeighbours++;
                        }
                        else if (j == Columns - 1)
                        {
                            if (Cells[i - 1][j].IsAlive)
                                sumNeighbours++;
                            if (Cells[i - 1][j - 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i][j - 1].IsAlive)
                                sumNeighbours++;
                        }
                        else
                        {
                            if (Cells[i - 1][j - 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i - 1][j].IsAlive)
                                sumNeighbours++;
                            if (Cells[i - 1][j + 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i][j - 1].IsAlive)
                                sumNeighbours++;
                            if (Cells[i][j + 1].IsAlive)
                                sumNeighbours++;
                        }
                    }
                    else if (j == 0)
                    {
                        if (Cells[i-1][j].IsAlive)
                            sumNeighbours++;
                        if (Cells[i + 1][j].IsAlive)
                            sumNeighbours++;
                        if (Cells[i - 1][j + 1].IsAlive)
                            sumNeighbours++;
                        if (Cells[i][j + 1].IsAlive)
                            sumNeighbours++;
                        if (Cells[i + 1][j + 1].IsAlive)
                            sumNeighbours++;
                    }
                    else if (j == Columns - 1)
                    {
                        if (Cells[i - 1][j].IsAlive)
                            sumNeighbours++;
                        if (Cells[i + 1][j].IsAlive)
                            sumNeighbours++;
                        if (Cells[i - 1][j - 1].IsAlive)
                            sumNeighbours++;
                        if (Cells[i][j - 1].IsAlive)
                            sumNeighbours++;
                        if (Cells[i + 1][j - 1].IsAlive)
                            sumNeighbours++;
                    }

                }

                if (Cells[i][j].IsAlive)
                {
                    if (sumNeighbours < 2)
                        Cells[i][j].ShouldLive = false;
                    else if(sumNeighbours==2 || sumNeighbours == 3)
                        Cells[i][j].ShouldLive = true;
                    else if(sumNeighbours>3)
                        Cells[i][j].ShouldLive = false;
                }
                else
                {
                    if(sumNeighbours==3)
                        Cells[i][j].ShouldLive = true;
                }
            }

            for (i = 0; i < Rows; i++)
            {
                for (j = 0; j < Columns; j++)
                {
                    //ToggleCell(i, j, Cells[i][j].ShouldLive);
                    Cells[i][j].IsAlive = Cells[i][j].ShouldLive;
                }
            }
        }
    }

    abstract class Game
    {
        protected Grid grid;
        public int CurrentGeneration { get; set; }
        public int MaxGenerations { get; set; }
        public Game(int maxGenerations)
        {
            MaxGenerations = maxGenerations;
            CurrentGeneration = 0;
        }
        public void Evolve()
        {
            CurrentGeneration++;
            Evolve();
        }

        virtual public void Show()
        {
            Console.Clear();
            Console.WriteLine("Current Generation: {0}", CurrentGeneration);
            for(int i=0;i<grid.Rows;i++)
            {
                for(int j = 0; j < grid.Columns; j++)
                {
                    Console.Write("{0} ", grid.Cells[i][j]);
                }
                Console.WriteLine();
            }
        }

    }

    /// <summary>
    /// Implementacija na igrata so pochetna sostojba so statichki raspored na zhivi kletki koi ne se menuvaat pri evolucija.
    /// </summary>
    class StillLifeGame : Game
    {
        public enum GameType
        {
            Block,
            Beehive,
            Loaf,
            Boat
        }

        public GameType Type { get; set; }

        public StillLifeGame(GameType gameType, int maxGenerations) : base(maxGenerations)
        {
            Type = gameType;
            if (Type == GameType.Block)
            {
                grid = new Grid(4, 4);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
            }

            if (Type == GameType.Beehive)
            {
                grid = new Grid(5, 6);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(3, 2, true);
                grid.ToggleCell(3, 3, true);
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("Still Game of Life: {0}", Type);
            base.Show();
        }
    }

    /// <summary>
    /// Implementacija na igrata so pochetna sostojba so raspored na zhivi kletki koi osciliraat pri evolucija.
    /// </summary>
    class OscilatorGame : Game
    {
        public enum GameType
        {
            Blinker,
            Toad,
            Beacon,
            Pulsar
        }

        public GameType Type { get; set; }

        public OscilatorGame(GameType gameType, int maxGenerations) : base(maxGenerations)
        {
            Type = gameType;
            if (gameType == GameType.Blinker)
            {
                grid = new Grid(5, 5);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(2, 3, true);
            }

            if (gameType == GameType.Toad)
            {
                grid = new Grid(6, 6);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(3, 1, true);
                grid.ToggleCell(4, 2, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(3, 4, true);
            }
            if (gameType == GameType.Beacon)
            {
                grid = new Grid(6, 6);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(3, 3, true);
                grid.ToggleCell(3, 4, true);
                grid.ToggleCell(4, 3, true);
                grid.ToggleCell(4, 4, true);
            }
            if (gameType == GameType.Pulsar)
            {
                grid = new Grid(17, 17);
                for (int i = 0; i < 17; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        if (i == 2 || i == 7 || i == 9 || i == 14)
                        {
                            if (j == 4 || j == 5 || j == 6 || j == 10 || j == 11 || j == 12)
                            {
                                grid.ToggleCell(i, j, true);
                            }
                        }
                        if ((i >= 4 && i <= 6) || (i >= 10 && i <= 12))
                        {
                            if (j == 2 || j == 7 || j == 9 || j == 14)
                            {
                                grid.ToggleCell(i, j, true);
                            }

                        }
                    }
                }
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("Oscilator Game of Life: {0}", Type);
            base.Show();
        }
    }

    class Program
    {
        static readonly int MAX_GENERATIONS = 10;

        static void Main(string[] args)
        {
            // Instanciranje na objekt od igrata
            Game game = new OscilatorGame(OscilatorGame.GameType.Beacon, MAX_GENERATIONS);
            while (game.CurrentGeneration <= game.MaxGenerations)
            {
                game.Show();
                game.Evolve();
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Evaluation ended!\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
