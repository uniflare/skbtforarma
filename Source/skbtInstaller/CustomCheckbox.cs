using System;
using System.Drawing;
using System.Windows.Forms;

namespace skbtInstaller
{

    class CustomCheckbox : CheckBox {
        public CustomCheckbox()
        {
            this.TextAlign = ContentAlignment.MiddleRight;
        }
        public override bool AutoSize 
        {
            get { return base.AutoSize; }
            set { base.AutoSize = false; }
        }
        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);
            int h = 20;
            ControlPaint.DrawCheckBox(
                e.Graphics, 
                0, 7, h, h,
                this.Checked ? ButtonState.Checked : ButtonState.Normal
            );
        }
    }
}
