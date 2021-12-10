using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_ClassLibrary.Buttons.GlassButton
{
	[Serializable]
	public class GlassButton : DefaultButton.Button
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container? components;// = null;
		private bool IsPushed;

		///
		///Additional variables to handle pulsing
		///
		private Bitmap? buttonBitmap;
		private Rectangle buttonBitmapRectangle;

		#region Enum
		private enum MouseActionType
		{
			None,
			Hover,
			Click
		}

		#endregion

		#region Constructor
		public GlassButton()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			mouseAction = MouseActionType.None;

			this.SetStyle(ControlStyles.AllPaintingInWmPaint |
				ControlStyles.DoubleBuffer |
				ControlStyles.UserPaint, true);

			//The following defaults are better suited to draw the text outline
			this.Font = new Font("Arial Black", 12, FontStyle.Bold);
			this.BackColor = Color.CadetBlue;
			this.Size = new Size(112, 48);
			this.MouseClickColor = Color.Gold;
			this.MouseHoverColor = Color.Gold;
			this.PulseOnFocus = false;
			this.Cursor = Cursors.Hand;

			//Initialize variables to Pulse button
			_gamma = 1.0f;
			minGamma = 1.0f;
			maxGamma = 2.2f;
			gammaStep = .2f;
			pulseTimer.Interval = 90;
            pulseTimer.Tick += PulseTimer_Tick;
		}

        private void PulseTimer_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GlassButton Properties
        /// <summary>
        /// 
        /// </summary>
        private bool _pulseOnFocus;
		[System.ComponentModel.DefaultValue(false)]
		public bool PulseOnFocus
		{
			get
			{
				return (_pulseOnFocus);
			}
			set
			{
				_pulseOnFocus = value;
				Invalidate();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private Color _mouseClickColor;
		[DefaultValue(typeof(Color), "Gold")]
		public Color MouseClickColor
		{
			get
			{
				return (_mouseClickColor);
			}
			set
			{
				_mouseClickColor = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private Color _mouseHoverColor;
		[DefaultValue(typeof(Color), "Gold")]
		public Color MouseHoverColor
		{
			get
			{
				return (_mouseHoverColor);
			}
			set
			{
				_mouseHoverColor = value;
			}
		}

		[DefaultValue(typeof(Color), "CadetBlue")]
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
			}
		}

		[DefaultValue(typeof(Cursors), "Hand")]
		public override Cursor Cursor
		{
			get
			{
				return base.Cursor;
			}
			set
			{
				base.Cursor = value;
			}
		}

		#endregion

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion

		#region GlassButtonEvents
		private MouseActionType mouseAction;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics _graphic = e.Graphics;
			_graphic.Clear(Color.White);
			Color _color = this.BackColor;
			int shadowOffset = 8;
			int btnOffset = 0;
			switch (mouseAction)
			{
				case MouseActionType.Click:
					{
						shadowOffset = 4;
						_color = MouseClickColor;
						btnOffset = 2;
						break;
					}
				case MouseActionType.Hover:
					{
						_color = MouseHoverColor;
						break;
					}
			}

			_graphic.SmoothingMode = 
				System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			///
			/// Create main colored shape
			/// 
			Rectangle _rectangle = 
				new Rectangle(btnOffset, btnOffset, this.ClientSize.Width - 8 - btnOffset, this.ClientSize.Height - 8 - btnOffset);

            System.Drawing.Drawing2D.GraphicsPath graphicPath1 = this.GetPath(_rectangle, 20);

            System.Drawing.Drawing2D.LinearGradientBrush linearGradientBrush1 = 
				new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 0), new Point(0, _rectangle.Height + 6), _color, Color.White);

			///
			/// Create shadow
			/// 
			Rectangle _rectangle2 = _rectangle;

			_rectangle2.Offset(shadowOffset, shadowOffset);

            System.Drawing.Drawing2D.GraphicsPath graphicPath2 = this.GetPath(_rectangle2, 20);

            System.Drawing.Drawing2D.PathGradientBrush pathGradientBrush = 
				new System.Drawing.Drawing2D.PathGradientBrush(graphicPath2);

			pathGradientBrush.CenterColor = ControlPaint.DarkDark(Color.Silver);

			pathGradientBrush.SurroundColors = new Color[] { Color.White };

			///
			/// Create top water color to give "Glass" effect
			/// 
			Rectangle _rectangle3 = _rectangle;
			_rectangle3.Inflate(-5, -5);
			_rectangle3.Height = 15;
            System.Drawing.Drawing2D.GraphicsPath graphicPath3 = GetPath(_rectangle3, 20);

            System.Drawing.Drawing2D.LinearGradientBrush linearGradientBrush3 = 
				new LinearGradientBrush(_rectangle3, Color.FromArgb(255, Color.White), Color.FromArgb(0, Color.White), LinearGradientMode.Vertical);

			///
			///draw shapes
			///
			_graphic.FillPath(pathGradientBrush, graphicPath2); //draw shadow
			_graphic.FillPath(linearGradientBrush1, graphicPath1); //draw main
			_graphic.FillPath(linearGradientBrush3, graphicPath3); //draw top bubble

			///
			///Create a backup of the button image to a bitmap so we can manipulate it's pulsing action
			///
			buttonBitmapRectangle = new Rectangle(_rectangle.Location, _rectangle.Size);
			buttonBitmap = new Bitmap(buttonBitmapRectangle.Width, buttonBitmapRectangle.Height);
			Graphics graphicBitmap = Graphics.FromImage(buttonBitmap);
			graphicBitmap.SmoothingMode = SmoothingMode.AntiAlias;
			graphicBitmap.FillPath(linearGradientBrush1, graphicPath1);
			graphicBitmap.FillPath(linearGradientBrush3, graphicPath3);

			System.Drawing.Rectangle ButtonRect = this.ClientRectangle;
			ButtonRect.Inflate(-5, -5);
			if (IsPushed)
			{
				ButtonRect.X += 2;
				ButtonRect.Y += 2;
				ButtonRect.Width--;
				ButtonRect.Height--;
			}

			//buttonBitmapRectangle.Inflate(-5, -5);
			//if (IsPushed)
			//{
			//    buttonBitmapRectangle.X += 2;
			//    buttonBitmapRectangle.Y += 2;
			//    buttonBitmapRectangle.Width--;
			//    buttonBitmapRectangle.Height--;
			//}

			///
			///Set the region for the button
			Region _region = new Region(graphicPath1);
			_region.Union(graphicPath2);
			this.Region = _region;

			///
			/// Create a Path to draw the text to give the button a nice outline
			/// 
			GraphicsPath graphicPath4 = new GraphicsPath();

			RectangleF path1Bounds = graphicPath1.GetBounds();
			Rectangle rectangleText = new Rectangle((int)path1Bounds.X, (int)path1Bounds.Y, (int)path1Bounds.Width, (int)path1Bounds.Height);

			StringFormat strFormat = new StringFormat();
			strFormat.Alignment = StringAlignment.Center;
			strFormat.LineAlignment = StringAlignment.Center;
			graphicPath4.AddString(this.Text, this.Font.FontFamily, (int)this.Font.Style, this.Font.Size,
				rectangleText, strFormat);

			Pen txtPen = new Pen(this.ForeColor, 1);
			_graphic.DrawPath(txtPen, graphicPath4);
			if (this.Image != null)
				_graphic.DrawImage(this.Image, this.Width / 2 - 10, this.Height / 2 - 10);
			graphicBitmap.DrawPath(txtPen, graphicPath4);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				IsPushed = true;
				this.mouseAction = MouseActionType.Click;
				this.Invalidate();
			}
			base.OnMouseDown(e);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseUp(MouseEventArgs e)
		{
			if (this.Bounds.Contains(e.X, e.Y))
				this.mouseAction = MouseActionType.Hover;
			else
				this.mouseAction = MouseActionType.None;
			this.Invalidate();
			base.OnMouseUp(e);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseEnter(EventArgs e)
		{
			this.mouseAction = MouseActionType.Hover;
			this.Invalidate();
			base.OnMouseEnter(e);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseLeave(EventArgs e)
		{
			this.mouseAction = MouseActionType.None;
			this.Invalidate();
			base.OnMouseLeave(e);
		}

		//-----------------------------------------------------------------
		// METHODS TO HANDLE PULSING
		//-----------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			if (this._pulseOnFocus)
				pulseTimer.Start();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			pulseTimer.Stop();
			this.Invalidate();  //redraw to get back it's original picture
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private float _gamma;
		private float minGamma;
		private float maxGamma;
		private float gammaStep;
		private System.Windows.Forms.Timer pulseTimer = new System.Windows.Forms.Timer();
		private ImageAttributes imageAttribute = new ImageAttributes();

		private void pulseTimer_Tick(object sender, EventArgs e)
		{
			if (this.Focused && _pulseOnFocus && buttonBitmap != null)
			{
				_gamma += gammaStep;
				if (_gamma > this.maxGamma) gammaStep = -gammaStep;
				if (_gamma < this.minGamma) gammaStep = Math.Abs(gammaStep);

				imageAttribute.SetGamma(_gamma);
				this.CreateGraphics().DrawImage(buttonBitmap, buttonBitmapRectangle, 0, 0,
									  buttonBitmap.Width, buttonBitmap.Height, GraphicsUnit.Pixel, imageAttribute);
			}
		}
		#endregion

		#region GlassButton Method
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_rectangle"></param>
		/// <param name="r"></param>
		/// <returns></returns>
		private GraphicsPath GetPath(Rectangle _rectangle, int r)
		{
			int xCoordinate = _rectangle.X, yCoordinate = _rectangle.Y, _width = _rectangle.Width, _height = _rectangle.Height;
			GraphicsPath graphicPath = new GraphicsPath();
			graphicPath.AddArc(xCoordinate, yCoordinate, r, r, 180, 90);                //Upper left corner
			graphicPath.AddArc(xCoordinate + _width - r, yCoordinate, r, r, 270, 90);           //Upper right corner
			graphicPath.AddArc(xCoordinate + _width - r, yCoordinate + _height - r, r, r, 0, 90);       //Lower right corner
			graphicPath.AddArc(xCoordinate, yCoordinate + _height - r, r, r, 90, 90);           //Lower left corner
			graphicPath.CloseFigure();
			return graphicPath;
		}
		#endregion
	}
}
