using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Learning_ClassLibrary.Toolbar.Learning_Expandable_Property
{
    public class BorderAppearanceConverter : ExpandableObjectConverter
    {
        // This override prevents the PropertyGrid from 
        // displaying the full type name in the value cell.
        //public override object ConvertTo(
        //    ITypeDescriptorContext context,
        //    CultureInfo culture,
        //    object value,
        //    Type destinationType)
        //{
        //    if (destinationType == typeof(string))
        //    {
        //        return "";
        //    }

        //    return base.ConvertTo(
        //        context,
        //        culture,
        //        value,
        //        destinationType);
        //}

        //public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        //{
        //    return base.CanConvertTo(context, destinationType);
        //}

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return true;
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            BorderAppearance borderAppearance =
                new BorderAppearance();

            const string pattern = "";

            Match match = Regex.Match(value.ToString(), pattern);

            if (!match.Success)
            {
                borderAppearance.BorderSize =
                    int.Parse(match.Groups["BorderSize"].Value);

                borderAppearance.BorderColor =
                    Color.FromName(match.Groups["BorderColor"].Value);

                return borderAppearance;
            }

            return base.ConvertFrom(context, culture, value);
        }
    }
}
