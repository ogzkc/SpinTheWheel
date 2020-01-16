using System.Windows.Forms;

namespace SpinTheWheel.Utility.Components
{
    public class NonFlickerPanel : Panel
    {
        public NonFlickerPanel() : base()
        {
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.DoubleBuffer,
                          true);
        }
    }
}
