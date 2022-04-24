using System;
using System.Drawing;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class ColorPallet : Form
    {
        private Color? m_Color;

        public Color? GetColor
        {
            get
            {
                return getAndResetColor();
            }
        }

        public ColorPallet()
        {
            InitializeComponent();
        }

        private Color? getAndResetColor()
        {
            Color? toReturn = m_Color;
            m_Color = null;
            return toReturn;
        }

        private void pinkButton_Click(object i_Sender, EventArgs i_)
        {
            m_Color = Color.MediumVioletRed;
            this.Close();
        }

        private void redButton_Click(object i_Sender, EventArgs i_)
        {
            m_Color = Color.Red;
            this.Close();
        }

        private void greenButton_Click(object i_Sender, EventArgs i_)
        {
            m_Color = Color.LawnGreen;
            this.Close();
        }

        private void cyanButton_Click(object i_Sender, EventArgs i_)
        {
            m_Color = Color.Cyan;
            this.Close();
        }

        private void blueButton_Click(object i_Sender, EventArgs i_)
        {
            m_Color = Color.Blue;
            this.Close();
        }

        private void yellowButton_Click(object i_Sender, EventArgs i_)
        {
            m_Color = Color.Yellow;
            this.Close();
        }

        private void brownButton_Click(object i_Sender, EventArgs i_)
        {
            m_Color = Color.SaddleBrown;
            this.Close();
        }

        private void whiteButton_Click(object i_Sender, EventArgs i_)
        {
            m_Color = Color.White;
            this.Close();
        }
    }
}
