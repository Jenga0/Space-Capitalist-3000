using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Space_Capitalist_3000
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        public GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ScreenManager screenManager;

        public Game1()
        {


            
            

            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            screenManager = new ScreenManager(this);
            

            graphics.PreferredBackBufferHeight = 540;
            graphics.PreferredBackBufferWidth = 910;
            graphics.IsFullScreen = true;

            

            Components.Add(screenManager);

            screenManager.AddScreen(new TestScreen(), null);

            GameServices.Initialize(graphics); 
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.Black);
            
            // The real drawing happens inside the screen manager component.
            base.Draw(gameTime);
        }
        

    }
}
