using System.Drawing;
using System.Windows.Forms;

namespace LawFirmAutomationSystem
{
    public sealed class CheckedListBox : System.Windows.Forms.CheckedListBox
    {
        public CheckedListBox()
        {
            ItemHeight = 25;
            BackColor = Color.FromArgb(55, 71, 79);
            ForeColor = Color.White;
            Font = new Font("Arial", 14);

            UncheckedColor = Color.FromArgb(181, 191, 196);
            CheckedColor = Color.White;
        }
        public override int ItemHeight { get; set; }
        public override Color BackColor { get; set; }
        public override Color ForeColor { get; set; }
        public override Font Font { get; set; }
        public Color UncheckedColor { get; set; }
        public Color CheckedColor { get; set; }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Color textColor = this.GetItemCheckState(e.Index) == CheckState.Unchecked ? UncheckedColor : (this.GetItemCheckState(e.Index) == CheckState.Checked ? CheckedColor : Color.White);
            DrawItemEventArgs e2 = new DrawItemEventArgs(e.Graphics, e.Font, new Rectangle(e.Bounds.Location, e.Bounds.Size), e.Index, (e.State & DrawItemState.Focus) == DrawItemState.Focus ? DrawItemState.Focus : DrawItemState.None, textColor, this.BackColor);
            base.OnDrawItem(e2);
        }
    }
}
