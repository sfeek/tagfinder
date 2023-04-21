using System.Text.RegularExpressions;

namespace Tag_Finder
{
    public partial class frmtagfinder : Form
    {
        public frmtagfinder()
        {
            InitializeComponent();

            string text = "Psychology is the study of mental process and behaviour of humans";
            string keywords = @"\b(study|mental|process|behaviour|humans)\b";
            rtbResults.AppendText(Regex.Match(text,keywords, RegexOptions.IgnoreCase).ToString());
        }

        private void btnChooseRoot_Click(object sender, EventArgs e)
        {

        }

        private void rtbResults_LinkClicked_1(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer",e.LinkText);
        }
    }
}