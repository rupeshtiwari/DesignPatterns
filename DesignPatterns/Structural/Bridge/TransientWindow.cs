namespace DesignPatterns.Structural.Bridge
{
    public class TransientWindow:IWindow
    {
        public void DrawText()
        { 

        }

        public void DrawRect()
        {
            
        }

        public void DrawClosedBox()
        {
            DrawRect();
        }
    }
}