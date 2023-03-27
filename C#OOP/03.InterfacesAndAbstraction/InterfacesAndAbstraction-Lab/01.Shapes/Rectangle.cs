﻿using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Height = height;
            Width = width;
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }


        public void Draw()
        {
            DrawLine(width, '*', '*');
            for (int i = 1; i < height-1; ++i)
            {
                DrawLine(width, '*', ' ');
            }
            DrawLine(width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width-1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }

}
