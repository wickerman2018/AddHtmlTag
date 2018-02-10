using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddHtmlTag
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void AddTag(string tag)
        {
            int spos = tbSourse.SelectionStart;
            tbSourse.Text = tbSourse.Text.Insert(spos, "<" + tag + ">");
        }
        void AddTagD(string tag)
        {
            int spos = tbSourse.SelectionStart;
            int epos = spos + tbSourse.SelectionLength + 2 + tag.Length;
            tbSourse.Text = tbSourse.Text.Insert(spos, "<" + tag + ">");
            tbSourse.Text = tbSourse.Text.Insert(epos, "</" + tag + ">");
        }
        void AddTagDbr(string tag)
        {
            int spos = tbSourse.SelectionStart;
            int epos = spos + tbSourse.SelectionLength + 4 + tag.Length;
            tbSourse.Text = tbSourse.Text.Insert(spos, "<" + tag + ">" + Environment.NewLine);
            tbSourse.Text = tbSourse.Text.Insert(epos, Environment.NewLine + "</" + tag + ">");
        }

        private void btnPaste_Click(object sender, RoutedEventArgs e)
        {
            tbSourse.Text = Clipboard.GetText();
        }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            AddTagD("b");
        }

        private void btnI_Click(object sender, RoutedEventArgs e)
        {
            AddTagD("i");
        }

        private void btnStrike_Click(object sender, RoutedEventArgs e)
        {
            AddTagD("strike");
        }

        private void btnQuote_Click(object sender, RoutedEventArgs e)
        {
            AddTagD("blockquote");
        }

        private void btnMore_Click(object sender, RoutedEventArgs e)
        {
            AddTag("!--more--");
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            AddTagDbr("table");
        }

        private void btnTR_Click(object sender, RoutedEventArgs e)
        {
            AddTagDbr("tr");
        }

        private void btnTD_Click(object sender, RoutedEventArgs e)
        {
            AddTagD("td");
        }

        private void btnUL_Click(object sender, RoutedEventArgs e)
        {
            AddTagDbr("ul");
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(tbSourse.Text);
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            tbSourse.Text = tbSourse.Text.Replace(Environment.NewLine, "</br>" + Environment.NewLine);
        }

        private void btnAddAuthor_Click(object sender, RoutedEventArgs e)
        {
            tbSourse.AppendText(Environment.NewLine + "<br />Автор: <a href=\"mailto:" + tbEmail.Text + "\">" + tbAuthor.Text + "</a>");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbSourse.Clear();
        }
    }
}
