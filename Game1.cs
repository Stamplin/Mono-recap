using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Data;

namespace Mono_recap
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //add textures
        Texture2D bgtexture, glowTexture, wingTexture, gabeTexture, daBabyTexture, csskinTexture;

        //variables
        float spinRotation = 0;

        //spritefont
        SpriteFont font;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            //add title
            Window.Title = "The chosen one";

            //Set window size
            _graphics.PreferredBackBufferWidth = 1920/2;
            _graphics.PreferredBackBufferHeight = 1300/2;
            _graphics.ApplyChanges();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            //load textures
            bgtexture = Content.Load<Texture2D>("Images/bg");
            glowTexture = Content.Load<Texture2D>("Images/ray");
            wingTexture = Content.Load<Texture2D>("Images/wing");
            gabeTexture = Content.Load<Texture2D>("Images/gabe");
            daBabyTexture = Content.Load<Texture2D>("Images/dababy");
            csskinTexture = Content.Load<Texture2D>("Images/csskin");

            //font
            font = Content.Load<SpriteFont>("Fonts/TitleFont");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            //spin effect for the glow
            spinRotation += 0.05f;






            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(bgtexture, new Rectangle(0, 0, 1920/2, 1300/2), Color.White);
            //gabe
            _spriteBatch.Draw(gabeTexture, new Rectangle(100, 400, 890 / 4, 1211 / 4), Color.White);
            //spinning eyes thingy
            _spriteBatch.Draw(wingTexture, new Rectangle(400, 550 , 160 / 2, 160 / 2), null, Color.White, spinRotation*0.5f, Vector2.Zero, SpriteEffects.None, 0f);
            _spriteBatch.Draw(wingTexture, new Rectangle(800, 350, 160 / 2, 160 / 2), null, Color.White, -spinRotation, Vector2.Zero, SpriteEffects.None, 0f);
            _spriteBatch.Draw(wingTexture, new Rectangle(60, 100, 160 / 2, 160 / 2), null, Color.White, -spinRotation*2, Vector2.Zero, SpriteEffects.None, 0f);
            _spriteBatch.Draw(wingTexture, new Rectangle(900, 550, 160 / 2, 160 / 2), null, Color.White, spinRotation*0.8f, Vector2.Zero, SpriteEffects.None, 0f);
            _spriteBatch.Draw(wingTexture, new Rectangle(1200, 100, 160 / 2, 160 / 2), null, Color.White, spinRotation*0.5f, Vector2.Zero, SpriteEffects.None, 0f);
            
            //glow effect
            _spriteBatch.Draw(glowTexture, new Rectangle(170, 60, 1920/3, 1300/3), Color.White);
   
            //dababy
            _spriteBatch.Draw(daBabyTexture, new Rectangle(320, 120, 693 / 2, 459 / 2), Color.White);
            //csskin
            _spriteBatch.Draw(csskinTexture, new Rectangle(300, 230, 3890 / 12, 2160 / 12), Color.White);
            //font text
            _spriteBatch.DrawString(font, "The chosen one", new Vector2(0, 0), Color.White);
            _spriteBatch.End();



            base.Draw(gameTime);
        }
    }
}
