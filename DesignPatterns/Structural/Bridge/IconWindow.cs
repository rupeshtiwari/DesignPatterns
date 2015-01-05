namespace DesignPatterns.Structural.Bridge
{
    public class IconWindow : IWindow
    {
        private readonly IWindowImpl _windowImplentation;

        public IconWindow(IWindowImpl windowImplentation)
        {
            _windowImplentation = windowImplentation;
        }

        public void DrawText()
        {
            _windowImplentation.DevDrawText();
        }

        public void DrawRect()
        {
            _windowImplentation.DevDrawLine();
            _windowImplentation.DevDrawLine();
            _windowImplentation.DevDrawLine();
            _windowImplentation.DevDrawLine();
        }

        public void DrawBorder()
        {
            DrawRect();
            DrawText();
        }
    }
}