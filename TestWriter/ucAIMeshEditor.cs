﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCO.Managed;

namespace SCO.TestWriter
{
	public partial class ucAIMeshEditor : UserControl
	{
		private SCOFile scoFile;
		public ucAIMeshEditor(SCOFile scoFile)
		{
			InitializeComponent();
			this.scoFile = scoFile;
		}
	}
}