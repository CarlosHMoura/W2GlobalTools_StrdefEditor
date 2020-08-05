using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W2___Strdef_Editor.Funções;

namespace W2___Strdef_Editor
{
    public partial class Window : Form
    {
        public string FilePatch = "";
        public Window()
        {
            this.InitializeComponent();
            this.StrList.Items.Clear();
            this.linkLabel1.Links.Add(new LinkLabel.Link()
            {
                LinkData = (object)"http://www.webcheats.com.br/members/seitbnao.4781487/"
            });
            this.linkLabel1.Text = "Copyright @ 2020 - SeiTbNao";
            this.linkLabel1.TextAlign = ContentAlignment.TopCenter;

            salvarStrDefbinToolStripMenuItem.Enabled = false;
            salvarStrDefcsvToolStripMenuItem.Enabled = false;
            Substituir.Enabled = false;
            Pesquisar.Enabled = false;
            Alterar.Enabled = false;
        }


        public void _Update()
        {
            this.StrList.Items.Clear();

            for (int index = 0; index < 2000; ++index)
                this.StrList.Items.Add((object)("(" + (object)index + ") " + External.g_pStrdef.Strdef[index].Value.Replace('_', ' ')));
        }
        public void GetValue()
        {
            int index = External.Index;
            if (index == -1)
                return;
            External.g_pStrdef.Strdef[index].Value = this.strDefText.Text;
        }

        private void Substituir_Click(object sender, EventArgs e)
        {
            if (this.StrList.Items.Count < 1)
                return;
            string oldValue = this.search.Text.Replace(' ', '_').ToString();
            if (string.IsNullOrEmpty(oldValue))
                return;
            string newValue = this.replace.Text.Replace(' ', '_').ToString();
            for (int index = 0; index < 2000; ++index)
            {
                External.g_pStrdef.Strdef[index].Value = External.g_pStrdef.Strdef[index].Value.Replace(oldValue, newValue);
                External.g_pStrdef.Strdef[index].Value.Replace(' ', '_');
            }
            this._Update();
            MessageBox.Show("Ocorrências trocadas com sucesso", "W2 - Strdef Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < StrList.Items.Count; i++)
            {
                if (StrList.Items[i].ToString().ToLower().Contains(Pesquisar.Text.ToLower()))
                {
                    StrList.SetSelected(i, true);
                    break;
                }
            }
        }
        public void LoadStrDefBin()
        {
            try
            {

                using (OpenFileDialog find = new OpenFileDialog())
                {
                    find.Filter = "*.bin|*.bin";
                    find.Title = "Selecione sua strdef.bin";

                    find.ShowDialog();

                    if (find.CheckFileExists)
                    {
                        this.FilePatch = find.FileName;

                        if (File.Exists(this.FilePatch))
                        {
                            byte[] temp = File.ReadAllBytes(this.FilePatch);

                            if (temp.Length != 256004 && temp.Length != 256000)
                            {
                                MessageBox.Show("strdef inválido", "strdef.bin inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.LoadStrDefBin();
                            }
                            else
                            {
                               
                                if (Functions.ReadStrdef(this.FilePatch))
                                {
                                    salvarStrDefbinToolStripMenuItem.Enabled = true;
                                    salvarStrDefcsvToolStripMenuItem.Enabled = true;
                                    Substituir.Enabled = true;
                                    Pesquisar.Enabled = true;
                                    Alterar.Enabled = true;
                                    this._Update();
                                }

                            }
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)
            {
                salvarStrDefbinToolStripMenuItem.Enabled = false;
                salvarStrDefcsvToolStripMenuItem.Enabled = false;
                Substituir.Enabled = false;
                Pesquisar.Enabled = false;
                Alterar.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }
        private void abrirStrDefbinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadStrDefBin();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            this.GetValue();
            this._Update();

            StrList.SelectedIndex = External.Index;
        }

        private void StrList_SelectedIndexChanged(object sender, EventArgs e)
        {
            External.Index = this.StrList.SelectedIndex;
            
            if (External.Index == -1)
                return;
            this.strDefText.Text = External.g_pStrdef.Strdef[External.Index].Value;
        }

        private void salvarStrDefbinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Filter = "*.bin|*.bin";
                    save.Title = "Selecione onde deseja salvar sua strdef.bin";
                    save.ShowDialog();

                    if (save.FileName != "")
                    {
                        External.g_pStrdef.Checksum = 26115295;

                    
                        byte[] toSave = Pak.ToByteArray(External.g_pStrdef);

                        for (int i = 0; i < toSave.Length - 4; i++)
                            toSave[i] ^= 0x5A;

                        File.Create(save.FileName).Close();
                        File.WriteAllBytes(save.FileName, toSave);

                        MessageBox.Show($"Arquivo {save.FileName} salvo com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salvarStrDefcsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Filter = "*.csv|*.csv";
                    save.Title = "Selecione onde deseja salvar sua strdef.csv";
                    save.ShowDialog();

                    if (save.FileName != "")
                    {
                        StreamWriter streamWriter = new StreamWriter(save.FileName);
                        streamWriter.WriteLine("#by Seitbnao ");
                        streamWriter.WriteLine("#Index,Strdef\n");
                        for (int index = 0; index < 2000; ++index)
                        {
                            if (string.IsNullOrEmpty(External.g_pStrdef.Strdef[index].Value))
                                continue;

                            streamWriter.WriteLine(index.ToString() + "," + External.g_pStrdef.Strdef[index].Value.Replace(' ', '_'));
                        }
                        streamWriter.Close();
                        int num = (int)MessageBox.Show("" + save.FileName + " gerado com sucesso", "W2 - Strdef Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
