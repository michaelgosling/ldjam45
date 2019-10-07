using MonoGame.Extended.Screens;
using MonoGame.Extended.BitmapFonts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Peak {
  public class Title : GameScreen {
    private Texture2D _bg;
    private SpriteBatch _batch;
    private BitmapFont _font;
    private Rectangle _logo;
    private MouseState prevMouseState;

    public Title(Game game) : base(game) {
      _batch = new SpriteBatch(game.GraphicsDevice);
      _logo = new Rectangle(
        (Game.GraphicsDevice.Viewport.Width / 2) - ((Game.GraphicsDevice.Viewport.Width / 3) / 2),
        Game.GraphicsDevice.Viewport.Height,
        Game.GraphicsDevice.Viewport.Width / 3,
        Game.GraphicsDevice.Viewport.Height / 8
      );
    }

    public override void Draw(GameTime dt) {
      _batch.Begin();
      _batch.Draw(null, _logo, Color.Red);
      _batch.End();
    }

    public override void Update(GameTime dt) {
    }
  }
}