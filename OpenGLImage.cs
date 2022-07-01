namespace Adapter;

public class OpenGLImage
{
    public void GLLoadImage(string archive)
    {
        Console.WriteLine($"Image {archive} load.");
    }

    public void GLDrawImage(int positionX, int positionY)
    {
        Console.WriteLine($"OpenGL image print {positionX} - {positionY}");
    }
}