// XNA Programming Group Work Session
// May 14, 2013

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace AWorldWithoutWalls
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D enemy, enemy2, enemy3, enemy4, enemy5;
        Texture2D player;
        bool enemy1dir, enemy2dir, enemy3dir, enemy4dir, enemy5dir;
        int enemy1X, enemy2X, enemy3X, enemy4X, enemy5X;
        int enemy1Y, enemy2Y, enemy3Y, enemy4Y, enemy5Y;
        int enemy1trav, enemy2trav, enemy3trav, enemy4trav, enemy5trav;

        #region
        // declarations //   
        int enemyX = 100, enemyY = 150;
        int playerX, playerY = 32;
        int screenWidth, screenHeight;
        #endregion


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = Content.Load<Texture2D>(@"images\player");
            enemy = Content.Load<Texture2D>(@"images\enemy");
            enemy2 = Content.Load<Texture2D>(@"images\enemy");
            enemy3 = Content.Load<Texture2D>(@"images\enemy");
            enemy4 = Content.Load<Texture2D>(@"images\enemy");
            enemy5 = Content.Load<Texture2D>(@"images\enemy");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>

        protected override void Update(GameTime gameTime)
        {
            // Authors: Jesse Hibbs and Stephan Rhodes
            // Enemy AI
            // Begin code
            if (!enemy1dir)
            {
                enemy1X += 2;
                ++enemy1trav;
                if (enemy1trav > 100)
                {
                    enemy1dir = true;
                    enemy1trav = 0;
                }
            }

            if (enemy1dir)
            {
                enemy1X -= 2;
                ++enemy1trav;
                if (enemy1trav > 100)
                {
                    enemy1dir = false;
                    enemy1trav = 0;
                }
            }
            if (!enemy2dir)
            {
                enemy2X += 2;
                ++enemy2trav;
                if (enemy2trav > 100)
                {
                    enemy2dir = true;
                    enemy2trav = 0;
                }
            }

            if (enemy2dir)
            {
                enemy2X -= 2;
                ++enemy2trav;
                if (enemy2trav > 100)
                {
                    enemy2dir = false;
                    enemy2trav = 0;
                }
            }
            if (!enemy3dir)
            {
                enemy3X += 2;
                ++enemy3trav;
                if (enemy3trav > 100)
                {
                    enemy3dir = true;
                    enemy3trav = 0;
                }
            }

            if (enemy3dir)
            {
                enemy3X -= 2;
                ++enemy3trav;
                if (enemy3trav > 100)
                {
                    enemy3dir = false;
                    enemy3trav = 0;
                }
            }
            if (!enemy4dir)
            {
                enemy4Y += 2;
                ++enemy4trav;
                if (enemy4trav > 100)
                {
                    enemy4dir = true;
                    enemy4trav = 0;
                }
            }

            if (enemy4dir)
            {
                enemy4Y -= 2;
                ++enemy4trav;
                if (enemy4trav > 100)
                {
                    enemy4dir = false;
                    enemy4trav = 0;
                }
            }
            if (!enemy5dir)
            {
                enemy5Y += 2;
                ++enemy5trav;
                if (enemy5trav > 100)
                {
                    enemy5dir = true;
                    enemy5trav = 0;
                }
            }

            if (enemy5dir)
            {
                enemy5Y -= 2;
                ++enemy5trav;
                if (enemy5trav > 100)
                {
                    enemy5dir = false;
                    enemy5trav = 0;
                }
            }
            // End code JH and SR

	    // Tyler R Saling
	    // Karmandeep S Bassi
	    // Keyboard input
	    // Begin Code
            KeyboardState key = Keyboard.GetState();

            /* TESTING //
            if (key.IsKeyDown(Keys.Up) && key.IsKeyDown(Keys.Left))
            {
                playerY -= 2;
                playerX -= 2;
                if (key.IsKeyDown(Keys.Space))
                {
                    playerY -= 4;
                    playerX -= 4;
                }
            }

            if (key.IsKeyDown(Keys.Down) && key.IsKeyDown(Keys.Right))
            {
                playerY += 2;
                playerX += 2;
                if (key.IsKeyDown(Keys.Space))
                {
                    playerY += 4;
                    playerX += 4;
                }
            }
            */

            // move up //
            if (key.IsKeyDown(Keys.Up))
            {
                playerY -= 2;
                if (key.IsKeyDown(Keys.Space))
                {
                    playerY -= 4;
                }
            }

            // move right //
            if (key.IsKeyDown(Keys.Right))
            {
                playerX += 2;
                if (key.IsKeyDown(Keys.Space))
                {
                    playerX += 4;
                }
            }


            // move left //
            if (key.IsKeyDown(Keys.Left))
            {
                playerX -= 2;
                if (key.IsKeyDown(Keys.Space))
                {
                    playerX -= 4;
                }
            }


            // move down //
            if (key.IsKeyDown(Keys.Down))
            {
                playerY += 2;
                if (key.IsKeyDown(Keys.Space))
                {
                    playerY += 4;
                }
            }
	    // End code KB and TS

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(player, new Rectangle(playerX, playerY, 32, 32), Color.White);
            spriteBatch.Draw(enemy, new Rectangle(enemyX, enemyY, 32, 32), Color.White);
            spriteBatch.Draw(enemy2, new Rectangle(enemy2X, enemy2Y, 32, 32), Color.White);
            spriteBatch.Draw(enemy3, new Rectangle(enemy3X, enemy3Y, 32, 32), Color.White);
            spriteBatch.Draw(enemy4, new Rectangle(enemy4X, enemy4Y, 32, 32), Color.White);
            spriteBatch.Draw(enemy5, new Rectangle(enemy5X, enemy5Y, 32, 32), Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}