﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
	public partial class FrmName : Form
	{
		public FrmName()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Settings.Name = txtName.Text;
			new FrmGame().ShowDialog();
			DialogResult = DialogResult.OK;
		}
	}
}
