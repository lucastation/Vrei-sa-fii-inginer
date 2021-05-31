﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace InterfataQuestions
{
    public partial class FormBeginning : Form
    {
        public FormBeginning()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            FormQuestions formQuestions = new FormQuestions();
            formQuestions.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            FormRecords formRecords = new FormRecords();
            formRecords.Show();
            this.Close();
        }

        private void FormBeginning_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("P:\\Facultate\\Proict IP Final\\Vrei-sa-fii-inginer\\Fonts\\OriginTech personal use.tff");
            buttonPlay.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
            buttonRecords.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
            buttonHelp.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
            buttonExit.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
        }
    }
}
