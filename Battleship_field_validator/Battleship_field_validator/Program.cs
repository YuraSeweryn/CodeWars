using System;

namespace Battleship_field_validator
{
    public class BattleshipField
    {
        static int[] must_have = { 0, 4, 3, 2, 1 };
        static int[,] field;
        static void minus_ships(int i, int j)
        {
            try
            {
                if (field[i - 1, j] == 1 && field[i - 2, j] == 1 && field[i - 3, j] == 1)
                {
                    must_have[4]--;
                    field[i, j] = 0;
                    field[i - 1, j] = 0;
                    field[i - 2, j] = 0;
                    field[i - 3, j] = 0;
                }
            }
            catch { }


            try
            {
                if (field[i + 1, j] == 1 && field[i + 2, j] == 1 && field[i + 3, j] == 1)
                {
                    must_have[4]--;
                    field[i, j] = 0;
                    field[i + 1, j] = 0;
                    field[i + 2, j] = 0;
                    field[i + 3, j] = 0;
                }
            }
            catch { }
            try
            {
                if (field[i, j + 1] == 1 && field[i, j + 2] == 1 && field[i, j + 3] == 1)
                {
                    must_have[4]--;
                    field[i, j] = 0;
                    field[i, j + 1] = 0;
                    field[i, j + 2] = 0;
                    field[i, j + 3] = 0;
                }
            }
            catch { }
            try
            {
                if (field[i, j - 1] == 1 && field[i, j - 2] == 1 && field[i, j - 3] == 1)
                {
                    must_have[4]--;
                    field[i, j] = 0;
                    field[i, j - 1] = 0;
                    field[i, j - 2] = 0;
                    field[i, j - 3] = 0;
                }
            }
            catch { }
            try
            {
                if (field[i - 1, j] == 1 && field[i - 2, j] == 1)
                {
                    must_have[3]--;
                    field[i, j] = 0;
                    field[i - 1, j] = 0;
                    field[i - 2, j] = 0;
                }
            }
            catch { }
            try
            {
                if (field[i + 1, j] == 1 && field[i + 2, j] == 1)
                {
                    must_have[3]--;
                    field[i, j] = 0;
                    field[i + 1, j] = 0;
                    field[i + 2, j] = 0;
                }
            }
            catch { }
            try
            {
                if (field[i, j + 1] == 1 && field[i, j + 2] == 1)
                {
                    must_have[3]--;
                    field[i, j] = 0;
                    field[i, j + 1] = 0;
                    field[i, j + 2] = 0;
                }
            }
            catch { }
            try
            {
                if (field[i, j - 1] == 1 && field[i, j - 2] == 1)
                {
                    must_have[3]--;
                    field[i, j] = 0;
                    field[i, j - 1] = 0;
                    field[i, j - 2] = 0;
                }
            }
            catch { }
            try
            {
                if (field[i - 1, j] == 1)
                {
                    must_have[2]--;
                    field[i, j] = 0;
                    field[i - 1, j] = 0;
                }
            }
            catch { }
            try
            {
                if (field[i + 1, j] == 1)
                {
                    must_have[2]--;
                    field[i, j] = 0;
                    field[i + 1, j] = 0;
                }
            }
            catch { }
            try
            {
                if (field[i, j + 1] == 1)
                {
                    must_have[2]--;
                    field[i, j] = 0;
                    field[i, j + 1] = 0;
                }
            }
            catch
            { }
            try
            {
                if (field[i, j - 1] == 1)
                {
                    must_have[2]--;
                    field[i, j] = 0;
                    field[i, j - 1] = 0;
                }
            }
            catch { }
            if (field[i, j] == 1)
            {
                must_have[1]--;
                field[i, j] = 0;
            }

        }
        public static bool ValidateBattlefield(int[,] field)
        {
            BattleshipField.field = field;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (field[i, j] == 1)
                    {
                        minus_ships(i, j);
                    }
                }
            }
            if(must_have[1] != 0 || must_have[2] != 0 || must_have[3] != 0 || must_have[4] != 0)
            {
                return false;
            }
            return true;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int[,] field = new int[10, 10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            BattleshipField.ValidateBattlefield(field);
        }
    }
}
