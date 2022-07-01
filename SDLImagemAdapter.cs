namespace Adapter;

public class SDLImagemAdapter : IImageTarget
{
    private readonly SDLSurface _sdlSurface;

    public SDLImagemAdapter(SDLSurface sdlSurface)
    {
        _sdlSurface = sdlSurface;
    }
    
    public void LoadImage(string image)
    {
        _sdlSurface.SDLLoadImage(image);
    }

    public void DrawImage(int width, int height, int positionX, int positionY)
    {
        _sdlSurface.SDLDrawImage(width, height, positionX, positionY);
    }
}