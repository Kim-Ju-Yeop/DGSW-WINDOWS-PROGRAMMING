using System;
using System.Drawing;
using System.Windows.Forms;

namespace fonts
{
    public partial class Form1 : Form
    {

        Boolean isBold = false;
        Boolean isItalic = false;

        String fontName = "굴림";
        int fontSize = 10;

        public Form1()
        {
            InitializeComponent();
            setFontComboBox();
            setSizeComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void setFontComboBox()
        {
            FontFamily[] fontFamilies = FontFamily.Families;

            foreach(FontFamily fontFamily in fontFamilies)
            {
                fontComboBox.Items.Add(fontFamily.Name);
            }
        }
        private void setSizeComboBox()
        {
            for(int i = 2; i < 100; i +=2)
            {
                sizeComboBox.Items.Add(i);
            }
        }


        private void changedFontComboBox(object sender, EventArgs e)
        {
            fontName = fontComboBox.SelectedItem.ToString();
            changeFont();
        }
        private void changedSizeComboBox(object sender, EventArgs e)
        {
            fontSize = (int) sizeComboBox.SelectedItem;
            changeFont();
        }


        private void clickBold(object sender, EventArgs  e)
        {
            isBold = !isBold;
            changeFont();
        }  
        private void clickItalic(object sender, EventArgs e)
        { 
            isItalic = !isItalic;
            changeFont();
        }


        private void changeFont()
        {
            FontStyle fontStyle = FontStyle.Regular;

            if (isBold) fontStyle |= FontStyle.Bold;
            if (isItalic) fontStyle |= FontStyle.Italic;

            textBox1.Font = new Font(new Font(fontName, fontSize), fontStyle);
        }
    }
}
