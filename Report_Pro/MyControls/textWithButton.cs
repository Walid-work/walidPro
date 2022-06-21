using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public class textWithButton : Panel
    {
        Button _button;
        TextBox _text;
        Label _label;

       

        public string TextS
        {
            get
            {
                return _text.Text;
            }
            set
            {
                _text.Text = value.ToString();
            }
        }

        public string LabelText
        {
            get
            {
                return _label.Text;
            }
            set
            {
                _label.Text = value.ToString();
            }
        }

        public Color LabelBackColor
        {
            get
            {
                return _label.BackColor;
            }
            set
            {
                _label.BackColor = value;
            }
        }

        public Color TextBackColor
        {
            get
            {
                return _text.BackColor;
            }
            set
            {
                _text.BackColor = value;
            }
        }

        public Color LabelColor
        {
            get
            {
                return _label.ForeColor;
            }
            set
            {
                _label.ForeColor = value;
            }
        }




        public Color TextColor
        {
            get
            {
                return _text.ForeColor;
            }
            set
            {
                _text.ForeColor = value;
            }
        }

        public ContentAlignment LabelAlignment
        {
            get
            {
                return _label.TextAlign;
            }
            set
            {
                _label.TextAlign = value;
            }
        }

        public HorizontalAlignment TextAlignment
        {
            get
            {
                return _text.TextAlign;
            }
            set
            {
                _text.TextAlign = value;
            }
        }

        public Size LabelSize
        {
            get
            {
                return _label.Size;
            }
            set
            {
                _label.Size = value;
            }
        }

        public Size TextSize
        {
            get
            {
                return _text.Size;
            }
            set
            {
                _text.Size = value;
            }
        }



        public Font LabelFont
        {
            get
            {
                return _label.Font;
            }
            set
            {
                _label.Font = value;
            }
        }

        public Font TextlFont
        {
            get
            {
                return _text.Font;
            }
            set
            {
                _text.Font = value;
            }
        }


        public Boolean labelVisable
        {
            get { return _label.Visible; }
            set
            {
                _label.Visible = value;
            }
        }


        public Boolean buttonVisable
        {
            get
            {
                return _button.Visible;
            }
            set
            {
                _button.Visible = value;
            }
        }





        public Image buttonImage
        {
            get
            {
                return _button.Image;
            }
            set
            {
                _button.Image = value;
            }
        }




        //public Label Label
        //{
        //    get
        //    {
        //        return _label;
        //    }


        //}

        //public TextBox TextBox 
        //{
        //    get
        //    {
        //        return _text;
        //    }

        //}






        public textWithButton()
        {

            _button = new Button();
            _label = new Label();
            _text = new TextBox();
            _button.Width = 30;
            _text.Width = 50;
            _label.Width = 50;
            _label.Text = "Label";
            _text.BorderStyle = BorderStyle.FixedSingle;
            _label.BorderStyle = BorderStyle.FixedSingle;
            _label.TextAlign = ContentAlignment.MiddleCenter;
            _text.TextAlign = HorizontalAlignment.Center;
            Height = _text.Height;
            Width = 130;

            _text.Dock = DockStyle.Fill;
            Controls.Add(this._text);
            //_label.BringToFront();
            Controls.Add(this._label);
            Controls.Add(this._button);

            //this.text.BorderStyle = BorderStyle.FixedSingle;

            //  SendMessage(TextBox.Handle, &HD3, CType(2, IntPtr), CType((btn.Width << 16), IntPtr))


            _button.Click += Button_Click;
            _text.KeyDown += _text_KeyDown;
            _text.KeyUp += _text_KeyUp;
            Paint += TextWithButton_Paint;
            _text.SizeChanged += _text_SizeChanged;
            SizeChanged += TextWithButton_SizeChanged;



        }

        private void _text_KeyUp(object sender, KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        private void _text_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        private void TextWithButton_SizeChanged(object sender, EventArgs e)
        {
            this.Height = _text.Height;
        }

        private void _text_SizeChanged(object sender, EventArgs e)
        {
            this.Height = _text.Height;
        }




        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            if (e.Control != _button && e.Control != _text && e.Control != _label)
            {
                Controls.Remove(e.Control);
            }

        }




        private void TextWithButton_Paint(object sender, PaintEventArgs e)
        {
            if (this.RightToLeft == RightToLeft.Yes)
            {
                this._button.Dock = DockStyle.Left;
                this._label.Dock = DockStyle.Right;
            }
            else
            {
                this._button.Dock = DockStyle.Right;
                this._label.Dock = DockStyle.Left;
            }





        }

        private void Button_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }




    }
}
