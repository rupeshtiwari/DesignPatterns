namespace DesignPatterns.Structural.Bridge
{
    public class XWindowImplentation:IWindowImpl
    {
        public void DevDrawText()
        {
            XDrawString();
        }

        public void DevDrawLine()
        {
            XDrawLine();
        }

        private void XDrawString()
        {
        }

        private void XDrawLine()
        {
        }
    }
}