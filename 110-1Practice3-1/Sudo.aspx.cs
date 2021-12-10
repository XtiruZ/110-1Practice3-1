using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice3_1
{
    public partial class Sudo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[,] ia_2DMap = new int[9, 9] { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },{ 6, 7, 2, 1, 9, 5, 3, 4, 8 },{ 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                                            { 8, 5, 9, 7, 6, 1, 4, 2, 3 },{4,2,6,8,5,3,7,9,1},{7,1,3,9,2,4,8,5,6},
                                            {9,6,1,5,3,7,2,8,4},{2,8,7,4,1,9,6,3,5},{3,4,5,2,8,6,1,7,9}};

            if (Mt_IsRowPass(ia_2DMap) == true & Mt_IsColPass(ia_2DMap) == true & Mt_Is9Pass(ia_2DMap) == true & Mt_IsNumPass(ia_2DMap) == 405)
            {
                Response.Write("True");
            }
            else
            {
                Response.Write("False");
            }
        }
        public bool Mt_IsRowPass(int[,] ia_2DMap)
        {
            bool b_ISSue = true;
            bool[] ba_Marked = new bool[9] { false, false, false, false, false, false, false, false, false };
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    ba_Marked[i] = false;
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    if (ia_2DMap[j, i].Equals(String.Empty) == false)
                    {
                        ba_Marked[i] = true;
                    }
                    else
                    {
                        b_ISSue = false;
                        break;
                    }
                }
                for (int a = 0; a < 9; a++)
                {
                    int x = ia_2DMap[j, a];
                    for (int b = a + 1; b < 9; b++)
                    {
                        if (x != ia_2DMap[j, b])
                        {
                            continue;
                        }
                        else
                        {
                            b_ISSue = false;
                            break;
                        }
                    }
                }
            }
            return b_ISSue;
        }
        public bool Mt_IsColPass(int[,] ia_2DMap)
        {
            bool b_ISSue = true;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    int x = ia_2DMap[i, j];
                    for (int a = i + 1; a < 9; a++)
                    {
                        if (x != ia_2DMap[a, j])
                        {
                            continue;
                        }
                        else
                        {
                            b_ISSue = false;
                            break;
                        }
                    }
                }
            }
            return b_ISSue;
        }
        public bool Mt_Is9Pass(int[,] ia_2DMap)
        {
            bool b_ISSue = true;
            for (int j = 0; j <= 6; j += 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    int x = ia_2DMap[j, i];
                    for (int a = i + 1; a < 3; a++)
                    {
                        if (x != ia_2DMap[j, a] && x != ia_2DMap[j + 1, a] && x != ia_2DMap[j + 2, a])
                        {
                            continue;
                        }
                        else
                        {
                            b_ISSue = false;
                            break;
                        }
                    }
                }
                for (int i = 3; i <= 6; i++)
                {
                    int y = ia_2DMap[j, i];
                    for (int a = i + 1; a < 6; a++)
                    {
                        if (y != ia_2DMap[j, a] && y != ia_2DMap[j + 1, a] && y != ia_2DMap[j + 2, a])
                        {
                            continue;
                        }
                        else
                        {
                            b_ISSue = false;
                            break;
                        }
                    }
                }
                for (int i = 6; i < 9; i++)
                {
                    int z = ia_2DMap[j, i];
                    for (int a = i + 1; a < 6; a++)
                    {
                        if (z != ia_2DMap[j, a] && z != ia_2DMap[j + 1, a] && z != ia_2DMap[j + 2, a])
                        {
                            continue;
                        }
                        else
                        {
                            b_ISSue = false;
                            break;
                        }
                    }
                }
            }
            return b_ISSue;
        }
        public int Mt_IsNumPass(int[,] ia_2DMap)
        {
            int num = 0;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    num += ia_2DMap[j, i];
                }
            }
            return num;
        }
    }
}