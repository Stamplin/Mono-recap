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
        Texture2D bgtexture, glowTexture, wingTexture;

        //variables
        float spinRotation = 0;

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
            //spinning eyes thingy
            _spriteBatch.Draw(wingTexture, new Rectangle(400, 550 , 160 / 2, 160 / 2), null, Color.White, spinRotation*0.5f, Vector2.Zero, SpriteEffects.None, 0f);
            _spriteBatch.Draw(wingTexture, new Rectangle(800, 350, 160 / 2, 160 / 2), null, Color.White, -spinRotation, Vector2.Zero, SpriteEffects.None, 0f);
            _spriteBatch.Draw(wingTexture, new Rectangle(60, 100, 160 / 2, 160 / 2), null, Color.White, -spinRotation*2, Vector2.Zero, SpriteEffects.None, 0f);
            _spriteBatch.Draw(wingTexture, new Rectangle(900, 550, 160 / 2, 160 / 2), null, Color.White, spinRotation*0.8f, Vector2.Zero, SpriteEffects.None, 0f);
            //glow effect
            _spriteBatch.Draw(glowTexture, new Rectangle(170, 60, 1920/3, 1300/3), Color.White);

            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
