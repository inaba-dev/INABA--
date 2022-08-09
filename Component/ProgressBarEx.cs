using System;
using System.Drawing;

namespace APP
{
    public class ProgressBarEx : System.Windows.Forms.PictureBox
    {
        public Color Color { get; set; }
        private int Maximum;
        private int Value;

        public ProgressBarEx()
        {
            Maximum = 100;
            Value = 0;
            Color = Color.Blue;
        }

        public void setup(int maximum)
        {
            Maximum = maximum;
        }

        public void update(int _value)
        {
            Value = _value;
        
            try
            {
                //// 描画クリア
                this.Image = null;

                //// 描画先とするImageオブジェクトを作成する
                Bitmap canvas = new Bitmap(this.Width, this.Height);

                //// ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);

                ////
                int point = (int)((double)this.Width * ((double)Value / (double)Maximum));

                //// 四角を描く
                g.FillRectangle(new SolidBrush(Color), new Rectangle(0, 0, point, this.Height));

                //// リソースを解放する
                g.Dispose();

                //// 表示する
                this.Image = canvas;
            }
            catch
            {
                Console.WriteLine("[catch] progress error");
            }
        }
    }
}
