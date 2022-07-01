using Adapter;

var image = new SDLImagemAdapter(new SDLSurface());
image.LoadImage("test.png");
image.DrawImage(20, 30, 10, 10);

var image2 = new OpenGLImageAdapter(new OpenGLImage());
image2.LoadImage("test2.png");
image2.DrawImage(0, 0, 30, 20);