using SpinTheWheel.Controls.Events;
using SpinTheWheel.Data;
using SpinTheWheel.Properties;
using SpinTheWheel.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpinTheWheel.Controls
{
    public partial class SpinnerWheel : UserControl
    {
        #region Events

        public event EventHandler<StudentSelectedEventArgs> OnStudentSelected;

        #endregion

        #region

        private const int TIMER_INTERVAL = 5;

        #endregion

        #region Private Variables

        private Timer rotationTimer;
        private Bitmap spinnerBitmap;

        private float wheelRotationAngle = 0;
        private float targetRotationAngle = 0;
        private float step;

        private int selectedIndex = -2;

        private Font textFont;

        #endregion

        #region Properties

        public List<Student> Students { get; set; }
        public bool AnimationEnabled { get; set; } = true;
        public int AnimationEndWaitDuration { get; set; } = 2500;
        public int AnimationDuration { get; set; } = 1800;
        public int FontSize { get; set; } = 9;

        #endregion

        public SpinnerWheel()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void SpinnerWheel_Load(object sender, EventArgs e)
        {
            textFont = FontHelper.GetFont(FontSize);

            rotationTimer = new Timer()
            {
                Interval = TIMER_INTERVAL
            };
            rotationTimer.Tick += RotationTimer_Tick;
        }

        public void RefreshSpinner()
        {
            spinnerBitmap = null;
            textFont = FontHelper.GetFont(FontSize);

            nonFlickerPanel.Invalidate();
        }

        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            var increasingAngle = MathHelper.Map(-wheelRotationAngle, 0, targetRotationAngle, 0, 5);

            wheelRotationAngle -= (5 - increasingAngle);

            nonFlickerPanel.Refresh();

            var index = (int)(-wheelRotationAngle / step);
            if (index >= Students.Count)
                index = index - Students.Count;

            OnStudentSelected?.Invoke(this, new StudentSelectedEventArgs()
            {
                Student = Students[index]
            });

            if (wheelRotationAngle.ToInt() <= -targetRotationAngle.ToInt()
                || (int)wheelRotationAngle <= (int)-targetRotationAngle)
            {
                rotationTimer.Stop();

                OnStudentSelected?.Invoke(this, new StudentSelectedEventArgs()
                {
                    Student = Students[selectedIndex]
                });

                Application.DoEvents();

                System.Threading.Thread.Sleep(AnimationEndWaitDuration);

                buttonSpinWheel.Enabled = true;
                Application.DoEvents();

                wheelRotationAngle = 0;
                nonFlickerPanel.Invalidate();
            }
        }

        private void buttonSpinWheel_Click(object sender, EventArgs e)
        {
            buttonSpinWheel.Enabled = false;
            Application.DoEvents();

            var random = new Random();
            selectedIndex = random.Next(0, Students.Count);

            step = (float)360 / (float)Students.Count;
            targetRotationAngle = (float)selectedIndex * step;

            var totalMs = targetRotationAngle / TIMER_INTERVAL;

            if (totalMs < AnimationDuration)
            {
                var increasingAngle = (float)(AnimationDuration - totalMs) / (float)TIMER_INTERVAL;
                targetRotationAngle += 360 + ((int)(increasingAngle / 360) * 360);
            }

            var randomizedStopAngle = random.Next(10, 90);
            targetRotationAngle += (((float)randomizedStopAngle / (float)100) * step);

            rotationTimer.Start();
        }

        private void nonFlickerPanel_Paint(object sender, PaintEventArgs e)
        {
            if (Students != null)
            {
                var random = new Random();
                float studentNumber = Students.Count;
                float step = 360 / studentNumber;

                if (wheelRotationAngle != 0)
                {
                    e.Graphics.TranslateTransform((float)nonFlickerPanel.Width / 2, (float)nonFlickerPanel.Height / 2);
                    e.Graphics.RotateTransform(wheelRotationAngle);
                    e.Graphics.TranslateTransform(-(float)nonFlickerPanel.Width / 2, -(float)nonFlickerPanel.Height / 2);
                }

                if (spinnerBitmap == null)
                {
                    spinnerBitmap = new Bitmap(nonFlickerPanel.Width, nonFlickerPanel.Height);

                    var bitmapGraphics = Graphics.FromImage(spinnerBitmap);
                    bitmapGraphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    bitmapGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    bitmapGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                    bitmapGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                    for (int i = 0; i < studentNumber; i++)
                    {
                        var color = Color.White;

                        if (i % 5 == 0)
                            color = ColorTranslator.FromHtml("#4281A4");
                        else if (i % 5 == 1)
                            color = ColorTranslator.FromHtml("#48A9A6");
                        else if (i % 5 == 2)
                            color = ColorTranslator.FromHtml("#E4DFDA");
                        else if (i % 5 == 3)
                            color = ColorTranslator.FromHtml("#D4B483");
                        else if (i % 5 == 4)
                            color = ColorTranslator.FromHtml("#C1666B");

                        var randomColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));

                        var brush = new SolidBrush(color);
                        bitmapGraphics.FillPie(brush, 0, 0, (float)nonFlickerPanel.Width, (float)nonFlickerPanel.Height, (float)i * step, step);

                        bitmapGraphics.TranslateTransform((float)nonFlickerPanel.Width / 2, (float)nonFlickerPanel.Height / 2);
                        bitmapGraphics.RotateTransform((float)i * step + step / 3);
                        bitmapGraphics.TranslateTransform(-(float)nonFlickerPanel.Width / 2, -(float)nonFlickerPanel.Height / 2);

                        var studentDisplayName = string.Empty;
                        studentDisplayName += $"{Students[i].FirstName} {Students[i].LastName.ToCharArray()[0]}. {Students[i].Number}";

                        var textSize = bitmapGraphics.MeasureString(studentDisplayName, textFont);

                        bitmapGraphics.DrawString(studentDisplayName, textFont, Brushes.Black, new PointF((float)nonFlickerPanel.Width - textSize.Width, (float)nonFlickerPanel.Height / (float)2));

                        bitmapGraphics.ResetTransform();
                    }
                }

                e.Graphics.DrawImage(spinnerBitmap, Point.Empty);

                e.Graphics.ResetTransform();

                var size = new SizeF(24, 24);
                var point = new PointF((float)(nonFlickerPanel.Width - size.Width) + 2, (float)nonFlickerPanel.Height / 2 - size.Height / 2);

                e.Graphics.DrawImage(Resources.play_button, new RectangleF(point, size));
            }
        }

        private void SpinnerWheel_Resize(object sender, EventArgs e)
        {
            spinnerBitmap = null;

            nonFlickerPanel.Width = Size.Width;
            nonFlickerPanel.Height = Size.Height - 50;

            var panelSize = nonFlickerPanel.Height;
            if (nonFlickerPanel.Width < nonFlickerPanel.Height)
                panelSize = nonFlickerPanel.Width;

            nonFlickerPanel.Size = new Size(panelSize, panelSize);
            nonFlickerPanel.Invalidate();
        }
    }
}
