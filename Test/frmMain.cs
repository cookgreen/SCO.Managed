﻿using SCO.Managed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCO.Test
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnChoose_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "SCO File|*.sco";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				txtSCOFile.Text = dialog.FileName;
				ReaderSCO(txtSCOFile.Text);
			}
		}

		private void ReaderSCO(string fileName)
		{
			SCOLoader loader = new SCOLoader();
			SCOFile sco = loader.Read(fileName);
			txtAIMeshCount.Text = sco.AIMeshes.Count.ToString();
			txtGroundPaintLayerCount.Text = sco.GroundPaints.Count.ToString();
			txtMissionObjectCount.Text = sco.MissionObjects.Count.ToString();

			missionObject.Items.Clear();
			foreach (var missObj in sco.MissionObjects)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = missObj.ID;
				lvi.SubItems.Add(missObj.MetaType.ToString());
				lvi.SubItems.Add(missObj.SubKindNo.ToString());
				lvi.SubItems.Add(missObj.VariationId.ToString());
				lvi.SubItems.Add(missObj.VariationId2.ToString());
				missionObject.Items.Add(lvi);
			}
		}
	}
}
