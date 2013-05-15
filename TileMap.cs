// Author: Sean Walsh, Harmanpreet Singh
// Date: May 14, 2013
// At PSU XNA group

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AWorldWithoutWalls
{
    public static class TileMap
    {
        public const int TileHeight = 32;
        public const int TileWidth = 32;
        public const int MapHeight = 20; // Each map have 20 tiles high
        public const int MapWidth = 25; // width of the map needs to be 25 tiles

        static private Texture2D texture; // so others can't change it
        static private int[,] mapSquares; // two dimensional array int[][] xy

        // create a list of rectangle
        static private List<Rectangle> tiles = new List<Rectangle>();

        static public void Initialize(Texture2D tileTexture)
        {
            texture = tileTexture;
            // to add a tile type, use the following line...
            // tiles.Add(x, y, tileWidth, tileHeight);

        }
        // two dim vector (returns the coordinate of the player to find out his boundries)
        static public Vector2 GetSquareCenter(Vector2 square)
        {
            int squareX, squareY;
            squareX = (int)square.X;
            squareY = (int)square.Y;

            return new Vector2(squareX * TileWidth + (TileWidth / 2), squareY * TileHeight + (TileHeight / 2));
        }
        static public Vector2 GetSquareAtPixel(Vector2 pixel)
        {
            return new Vector2((int)pixel.X / TileWidth, (int)pixel.Y / TileHeight);
        }
        // Retrieves a square from the world itself
        static public Rectangle SquareWorldRectangle(int x, int y)
        {
            return new Rectangle(x * TileWidth, y * TileHeight, TileWidth, TileHeight);
        }
        static public Rectangle SquareWorldRectangle(Vector2 square)
        {
            return SquareWorldRectangle((int)square.X, (int)square.Y);
        }
        static public Rectangle SquareScreenRectangle(int x, int y)
        {
            return SquareWorldRectangle(x, y);
        }
        // this returns the location at pixel level
        static public int GetTileAtSquare(int tileX, int tileY)
        {
            if ((tileX >= 0) && (tileY < MapWidth) && (tileY >= 0) && (tileY < MapHeight))
                return mapSquares[tileX, tileY];
            else
                return -1;
        }
        static public void SetTileAtSquare(int tileX, int tileY, int tile)
        {
            if ((tileX >= 0) && (tileX < MapWidth) && (tileY >= 0) && (tileY < MapHeight))
                mapSquares[tileX, tileY] = tile;
        }
        static public int GetTileAtPixel(Vector2 pixel)
        {
            return GetTileAtSquare((int)pixel.X / TileWidth, (int)pixel.Y / TileHeight);
        }

        static public void GenerateMap()
        {
            // Define a text file which looks like this for a 3x3 map
            // 0, 0, 0
            // 0, 1, 0
            // 0, 0, 0
            // Zero is a boundary
            // 1 is a rock in this theoretical case...
            mapSquares = new int[MapWidth, MapHeight];
        }

        static public void Draw(SpriteBatch spriteBatch)
        {
            // start tileX = 0
            int startX = 0 / TileWidth;
            int endX = 800 / TileWidth;

            int startY = 0 / TileHeight;
            int endY = 640 / TileHeight;

            for (int x = startX; x <= endX; x++)
            {
                for (int y = startY; y <= endY; y++)
                {
                    if ((x >= 0) && (y >= 0) && (x < MapWidth) && (y < MapHeight))
                        spriteBatch.Draw(texture, SquareScreenRectangle(x, y), tiles[GetTileAtSquare(x, y)], Color.White);
                }
            }
        }
    }
}
