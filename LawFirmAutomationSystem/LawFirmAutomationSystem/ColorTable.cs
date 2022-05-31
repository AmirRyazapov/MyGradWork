using System.Drawing;
using System.Windows.Forms;

namespace LawFirmAutomationSystem
{
    public class ColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(38, 50, 56); }
        }

        public override Color MenuBorder
        {
            get { return Color.FromArgb(38, 50, 56); }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(38, 50, 56); }
        }
        
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(38, 50, 56); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(38, 50, 56); }
        }

    }
}
