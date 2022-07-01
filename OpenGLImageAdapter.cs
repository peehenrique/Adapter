namespace Adapter;

public class OpenGLImageAdapter : IImageTarget
{
    private readonly OpenGLImage _openGlImage;

    public OpenGLImageAdapter(OpenGLImage openGlImage)
    {
        _openGlImage = openGlImage;
    }
    
    public void LoadImage(string image)
    {
        _openGlImage.GLLoadImage(image);
    }

    public void DrawImage(int width, int height, int positionX, int positionY)
    {
        _openGlImage.GLDrawImage(positionX, positionY);
    }
}