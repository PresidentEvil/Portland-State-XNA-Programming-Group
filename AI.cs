// Authors: Jesse Hibbs and Stephan Rhodes
// Date: May 14, 2013
// PSU XNA Programming Group        
protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            KeyboardState key = Keyboard.GetState();
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

            if (playerY < 468)
            {
                if (key.IsKeyDown(Keys.Down))
                {
                    playerY += 2;
                }
            }

            if (playerY > 0)
            {
                if (key.IsKeyDown(Keys.Up))
                {
                    playerY -= 2;
                }
            }

            if (playerX > 0)
            {
                if (key.IsKeyDown(Keys.Left))
                {
                    playerX -= 2;
                }
            }

            if (playerX < 468)
            {
                if (key.IsKeyDown(Keys.Right))
                {
                    playerX += 2;
                }

                if (key.IsKeyDown(Keys.Space))
                {
                    playerX += 5;
                }
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
}