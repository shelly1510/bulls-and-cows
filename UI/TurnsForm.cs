using System;
using System.Windows.Forms;

namespace UI
{
    public partial class TurnsForm : Form
    {
        private int m_NumOfTurns = 4;
        private bool m_ClosedByStart = false;

        public int NumberChosen
        {
            get
            {
                return m_NumOfTurns;
            }
        }

        public bool ClosedByStart
        {
            get
            {
                return m_ClosedByStart;
            }
        }

        public TurnsForm()
        {
            InitializeComponent();
        }

        private void buttonNumberOfTurns_Click(object i_Sender, EventArgs i_)
        {
            m_NumOfTurns = (m_NumOfTurns + 1) % 11;
            if(m_NumOfTurns < 4)
            {
                m_NumOfTurns = 4;
            }

            (i_Sender as Button).Text = string.Format("Number of Chances: {0}", m_NumOfTurns);
        }

        private void buttonStart_Click(object i_Sender, EventArgs i_)
        {
            m_ClosedByStart = i_Sender == buttonStart;
            this.Close();
        }
    }
}
