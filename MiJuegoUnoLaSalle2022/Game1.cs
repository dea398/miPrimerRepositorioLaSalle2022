using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections;
using System.Collections.Generic;

namespace MiJuegoUnoLaSalle2022
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D spaceShip;

        List<Fireball> fireballs;

        Rectangle spaceShipRectangle;
        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            //_graphics.IsFullScreen = true;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            spaceShipRectangle = new Rectangle(300, 350, 250, 250);

            fireballs = new List<Fireball>();
            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            spaceShip = this.Content.Load<Texture2D>("Spaceship");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState keysState = Keyboard.GetState();

            // TODO: Add your update logic here
            //red++;
            //green++;
            //blue++; // blue = blue + 1

            if (keysState.IsKeyDown(Keys.Left))
            {
                spaceShipRectangle.X -= 3;
            }
            else if (keysState.IsKeyDown(Keys.Right))
            {
                spaceShipRectangle.X += 3;
            }
            else if (keysState.IsKeyDown(Keys.Space))
            {
                fireballs.Add(new Fireball());
            }

            


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(new Color(red,green,blue));
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

           

            
            _spriteBatch.Draw(spaceShip, spaceShipRectangle, Color.White);
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
