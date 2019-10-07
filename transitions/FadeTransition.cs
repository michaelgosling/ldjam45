using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.Screens.Transitions;

public class FadeTransition : Transition {
  private readonly GraphicsDevice _gfxDevice;
  private readonly SpriteBatch _batch;

  public FadeTransition(GraphicsDevice gfxDevice, Color color, float duration = 1.0f) : base(duration) {
    _gfxDevice = gfxDevice;
    _batch = new SpriteBatch(gfxDevice);
  }

  public override void Dispose(){
    _batch.Dispose();
  }

  public Color Color { get; }
  public override void Draw(GameTime gameTime) {
    _batch.Begin(samplerState: SamplerState.PointClamp);
    _batch.FillRectangle(_gfxDevice.Viewport.Bounds, Color * Value);
    _batch.End();
  }
}