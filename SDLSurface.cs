namespace Adapter;

public class SDLSurface
{
    public void SDLLoadImage(string archive)
    {
        Console.WriteLine($"Image {archive} load.");
    }

    public void SDLDrawImage(int width, int height, int positionX, int positionY)
    {
        Console.WriteLine($"SDLSurface image print {width} - {height} - {positionX} - {positionY}");
    }
}