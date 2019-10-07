using MonoGame.Extended;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.ViewportAdapters;
using MonoGame.Extended.BitmapFonts;
using MonoGame.Extended.TextureAtlases;
using MonoGame.Extended.Screens;

namespace Peak
{
    public class Game1 : Game
    {
        public GraphicsDeviceManager _graphics;
        public SpriteBatch _batch;
        public OrthographicCamera _camera;
        public ViewportAdapter _viewport;
        public MouseState _prevMouseState;
        private ScreenManager screenMgr;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            screenMgr = new ScreenManager();
        }

        protected override void Initialize()
        {
            var scrn = new Title(this);
            var transition = new FadeTransition(_graphics.GraphicsDevice, Color.Black);
            screenMgr.LoadScreen(scrn, transition);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _batch = new SpriteBatch(GraphicsDevice);

            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _batch.Begin();
            _batch.FillRectangle(100, 100, 200, 200, Color.Red);
            _batch.End();

            base.Draw(gameTime);
        }
    }
}