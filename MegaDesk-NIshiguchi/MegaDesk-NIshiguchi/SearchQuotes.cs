﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Nishiguchi {
    public partial class SearchQuotes : Form {
        public SearchQuotes() {
            InitializeComponent();
        }

        private void backToMain_Click(object sender, EventArgs e) {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Tag = this;
            mainMenuForm.Show(this);
            Hide();
        }
    }
}
