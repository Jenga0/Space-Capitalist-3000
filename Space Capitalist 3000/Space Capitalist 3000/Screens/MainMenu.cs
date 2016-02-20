using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Space_Capitalist_3000
{
    class MainMenu : Screen
    {
        ContentManager content;
        //The size of the screen
        Viewport viewport;

        //textures
        Texture2D backgroundTex;
        Texture2D playButtonTex;

        //Rectanggles
        Rectangle backgroundRec;
        Rectangle playButtonRec;
        public MainMenu()
        {

        }

        public override void LoadContent()
        {
            if (content == null)
                content = new ContentManager(ScreenManager.Game.Services, "Content");

            

            backgroundTex = content.Load<Texture2D>("Menu/MenuBG");
            playButtonTex = content.Load<Texture2D>("Menu/PlayButton");

            
            


        }

        public override void Update(GameTime gameTime, bool otherScreenHasFocus, bool coveredByOtherScreen)
        {
            
            

            base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        }

        public override void HandleInput(InputState input)
        {
            //m is abbreviated mouse
            bool mOverPlay = playButtonRec.Contains(input.CurrentMouseStates[0].X, input.CurrentMouseStates[0].Y);

            if(mOverPlay == true)
            {

            }

            base.HandleInput(input);
        }

        public override void Draw(GameTime gameTime)
        {
            SpriteBatch spriteBatch = ScreenManager.SpriteBatch;

            viewport = ScreenManager.GraphicsDevice.Viewport;
            backgroundRec = new Rectangle(0, 0, viewport.Width, viewport.Height);
            playButtonRec = new Rectangle(viewport.Width / 3, viewport.Height / 2, viewport.Width / 3, viewport.Height / 22);

            spriteBatch.Begin();

            spriteBatch.Draw(backgroundTex, backgroundRec, Color.White);
            spriteBatch.Draw(playButtonTex, playButtonRec, Color.White);
            spriteBatch.End();
        }
    }
}
