using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_ClassLibrary.Toolbar.Learning_Expandable_Property
{
    //public struct BorderAppearance
    public class BorderAppearance
    {

        private int _borderSizeValue = 1;

        [Browsable(true),
        DefaultValue(1),
            RefreshProperties(RefreshProperties.Repaint)]
        public int BorderSize
        {
            get
            {
                return _borderSizeValue;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "BorderSize",
                        value,
                        "must be >= 0");
                }

                if (_borderSizeValue != value)
                {
                    _borderSizeValue = value;
                }
            }
        }

        // [NotifyParentProperty(true)]
        // [EditorBrowsable(EditorBrowsableState.Never)]

        private Color _borderColorValue = Color.Empty;

        [Browsable(true)]
        [DefaultValue(typeof(Color), "")]
        [RefreshProperties(RefreshProperties.Repaint)]
        public Color BorderColor
        {
            get
            {
                return _borderColorValue;
            }
            set
            {
                if (value.Equals(Color.Transparent))
                {
                    throw new NotSupportedException("Transparent colors are not supported.");
                }

                if (_borderColorValue != value)
                {
                    _borderColorValue = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("{0},{1}", BorderSize, BorderColor.Name);
        }
    }
}
