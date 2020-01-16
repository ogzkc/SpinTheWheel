using System;
using System.Drawing;
using System.Drawing.Text;

namespace SpinTheWheel.Utility
{
    public static class FontHelper
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection privateFonts;

        private static FontFamily fontFamily = null;

        public static Font GetFont(float size)
        {
            if (fontFamily == null)
                InitializeFont();

            return new Font(fontFamily, size);
        }

        private static void InitializeFont()
        {
            privateFonts = new PrivateFontCollection();
            byte[] fontData = Properties.Resources.Alfabe;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint writingByte = 0;
            privateFonts.AddMemoryFont(fontPtr, Properties.Resources.Alfabe.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Alfabe.Length, IntPtr.Zero, ref writingByte);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontFamily = privateFonts.Families[0];
        }
    }
}
