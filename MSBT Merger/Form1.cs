using MsbtEditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Label = MsbtEditor.Label;

// portions of this code are from IcySon55

namespace MSBT_Merger
{
    public partial class Form1 : Form
    {
        private MSBT msbt1, msbt2, msbtRes;
        private string tempFolder = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tempFolder.Length > 0)
            {
                Directory.Delete(tempFolder, true);
            }
        }

        private void selectMSBT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msbt1 = AskAndLoadMSBT();
            PopulateSide(1, msbt1);
        }

        private void selectMSBT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msbt2 = AskAndLoadMSBT();
            PopulateSide(2, msbt2);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple program to merge MSBT entries. Program by pineapples721. MSBT logic by IcySon55.", "MSBT Merger");
        }

        private void msbt1CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            msbt1RTB.Text = IEntryToString(msbt1, (IEntry)msbt1CLB.SelectedItem);
        }

        private void msbt2CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            msbt2RTB.Text = IEntryToString(msbt2, (IEntry)msbt2CLB.SelectedItem);
        }

        private void msbtResultCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            msbtResultRTB.Text = IEntryToString(msbtRes, (IEntry)msbtResultCLB.SelectedItem);
        }

        private void oneOnTwoBtn_Click(object sender, EventArgs e)
        {
            Merge(1);
        }

        private void twoOnOneBtn_Click(object sender, EventArgs e)
        {
            Merge(2);
        }

        private MSBT AskAndLoadMSBT()
        {
            using (OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "MSBT Files|*.msbt"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return new MSBT(ofd.FileName);
                }
                else
                {
                    return null;
                }
            }
        }

        private string IEntryToString(MSBT msbt, IEntry entry)
        {
            return msbt.FileEncoding.GetString(msbt.TXT2.OriginalStrings[(int)entry.Index].Value).Replace("\n", "\r\n").TrimEnd('\0').Replace("\0", @"\0") + "\0";
        }
        private void Merge(int source)
        {
            if (msbt1 == null || msbt2 == null) return;

            msbtResultCLB.Items.Clear();
            msbtRes = null;
            msbtResultRTB.Text = "";

            bool anyInCommon = msbt1.LBL1.Labels.Select(x => ((Label)x).Name).Any(x => msbt2.LBL1.Labels.Select(y => ((Label)y).Name).Contains(x));
            if (!anyInCommon)
            {
                MessageBox.Show("Both MSBTs do not have any entry in common.", "MSBT Merger");
                return;
            }

            if (tempFolder.Length == 0)
            {
                tempFolder = Path.Combine(Path.GetTempPath(), "msbtmerger");
                if (!Directory.Exists(tempFolder))
                {
                    Directory.CreateDirectory(tempFolder);
                }

                msbt1.ExportXMSBT(Path.Combine(tempFolder, "m1.xmsbt"));
                msbt2.ExportXMSBT(Path.Combine(tempFolder, "m2.xmsbt"));
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                FileName = "result.msbt",
                Filter = "MSBT Files|*.msbt",
                Title = "Save Resulting MSBT"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy((source == 1 ? msbt2 : msbt1).File.FullName, sfd.FileName, true);
                    msbtRes = new MSBT(sfd.FileName);

                    IEnumerable<string> sel1 = msbt1CLB.SelectedItems.Cast<IEntry>().Select(x => x.ToString());
                    IEnumerable<string> sel2 = msbt2CLB.SelectedItems.Cast<IEntry>().Select(x => x.ToString());

                    Dictionary<string, Label> labels = new Dictionary<string, Label>();
                    foreach (Label lbl in msbtRes.LBL1.Labels)
                    {
                        labels.Add(lbl.Name, lbl);
                    }

                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(Path.Combine(tempFolder, "m" + source + ".xmsbt"));
                    XmlNode xmlRoot = xmlDocument.SelectSingleNode("/xmsbt");
                    foreach (XmlNode entry in xmlRoot.SelectNodes("entry"))
                    {
                        string label = entry.Attributes["label"].Value;
                        byte[] str = msbtRes.FileEncoding.GetBytes(entry.SelectSingleNode("text").InnerText.Replace("\r\n", "\n").Replace(@"\0", "\0") + "\0");

                        if (labels.ContainsKey(label))
                        {
                            bool b = !mergeSelectedCB.Checked;
                            b |= mergeSelectedCB.Checked && source == 1 && sel1.Contains(label);
                            b |= mergeSelectedCB.Checked && source == 2 && sel2.Contains(label);
                            if (b)
                            {
                                labels[label].String.Value = str;
                            }
                        }
                        else
                        {
                            if (createEntriesCB.Checked)
                            {
                                if (label.Trim().Length <= MSBT.LabelMaxLength && Regex.IsMatch(label.Trim(), MSBT.LabelFilter))
                                {
                                    Label lbl = msbtRes.AddLabel(label);
                                    lbl.String.Value = str;
                                }
                            }
                        }
                    }

                    msbtRes.Save();

                    foreach (Label lbl in msbtRes.LBL1.Labels)
                    {
                        msbtResultCLB.Items.Add(lbl);
                    }

                    MessageBox.Show("Done", "MSBT Merger");
                }
            }
        }

        private void PopulateSide(int side, MSBT msbt)
        {
            if (side == 1)
            {
                msbt1CLB.Items.Clear();
                msbt1CLB.Items.AddRange(GetMSBTEntryPairs(msbt1).Keys.ToArray());
            }
            else if (side == 2)
            {
                msbt2CLB.Items.Clear();
                msbt2CLB.Items.AddRange(GetMSBTEntryPairs(msbt2).Keys.ToArray());
            }
        }

        private Dictionary<IEntry, string> GetMSBTEntryPairs(MSBT msbt)
        {
            Dictionary<IEntry, string> dict = new Dictionary<IEntry, string>();
            
            /*Encoding encoding = Encoding.UTF8;
            if (msbt.Header.EncodingByte == EncodingByte.Unicode)
            {
                if (BitConverter.ToUInt16(msbt.Header.ByteOrderMark, 0) == 0xFEFF)
                {
                    encoding = Encoding.Unicode;
                }
                else
                {
                    encoding = Encoding.BigEndianUnicode;
                }
            }*/

            for (int i = 0; i < msbt.TXT2.NumberOfStrings; i++)
            {
                IEntry label = null;
                if (msbt.HasLabels)
                {
                    //label = ((MsbtEditor.Label)msbt.LBL1.Labels[i]).Name;
                    label = msbt.LBL1.Labels[i];
                }
                else
                {
                    //label = new string(encoding.GetChars(((MsbtEditor.String)msbt.TXT2.Strings[i]).Value));
                    label = msbt.TXT2.Strings[i];
                }

                if (!dict.ContainsKey(label))
                {
                    dict.Add(label, IEntryToString(msbt, label));
                }
            }

            return dict;
        }
    }
}
