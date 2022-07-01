namespace Adapter;

public interface IImageTarget
{
    void LoadImage(string image);
    void DrawImage(int width, int height, int positionX, int positionY);
}