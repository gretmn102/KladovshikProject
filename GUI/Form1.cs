using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ValidateChildren();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
        }

        private void rbUndefined_CheckedChanged(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
        }

        Core.TypeCont GetTypeCont()
        {
            if (rbBox.Checked)
                return Core.TypeCont.Box;
            else if (rbBag.Checked)
                return Core.TypeCont.Bag;
            else if (rbOther.Checked)
                return Core.TypeCont.Other;
            else
                return null;
        }

        Core.Size GetSize()
        {
            if (rbUndefined.Checked)
                return Core.Size.Undefined;
            else if (rbDef.Checked)
                return Core.Size.NewSize((int)numW.Value, (int)numL.Value, (int)numH.Value);
            else return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cor = new Core.Inter();
            if (txbNameGood.Text != "")
            {
                if (txbBarcode.Text != "")
                {
                    var typeCont = GetTypeCont();
                    if (typeCont != null)
                    { 
                        var size = GetSize();
                        if (size != null)
                        {
                            cor.AddGood(txbBarcode.Text, Int32.Parse(txbBarcode.Text), size, typeCont);
                            txbNameGood.ResetText();
                            txbBarcode.ResetText();
                        }
                            
                    }
                }
            }
        }

        private void txbNameGood_Validated(object sender, EventArgs e)
        {
            if (this.txbNameGood.Text == "")
                errorProvider1.SetError(this.txbNameGood, "name good is empty");
            else
                errorProvider1.SetError(this.txbNameGood, "");
        }

        private void rbDef_Validating(object sender, CancelEventArgs e)
        {
            //if (this.txbNameGood.Text == "")
            //    errorProvider1.SetError(this.txbNameGood, "name good is empty");
            //else
            //    errorProvider1.SetError(this.txbNameGood, "");
        }

        private void txbNameGood_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txbBarcode_KeyDown(object sender, KeyPressEventArgs e)
        {

        }

        private void txbBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            //Allow navigation keyboard arrows
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                case Keys.PageUp:
                case Keys.PageDown:
                case Keys.Delete:
                case Keys.End:
                case Keys.Home:
                    e.SuppressKeyPress = false;
                    return;
                default:
                    break;
            }

            //Block non-number characters
            char currentKey = (char)e.KeyCode;
            bool modifier = e.Control || e.Alt || e.Shift;
            bool nonNumber = char.IsLetter(currentKey) ||
                             char.IsSymbol(currentKey) ||
                             char.IsWhiteSpace(currentKey) ||
                             char.IsPunctuation(currentKey);

            if (!modifier && nonNumber)
                e.SuppressKeyPress = true;

            //Handle pasted Text
            if (e.Control && e.KeyCode == Keys.V)
            {
                //Preview paste data (removing non-number characters)
                string pasteText = Clipboard.GetText();
                string strippedText = "";
                for (int i = 0; i < pasteText.Length; i++)
                {
                    if (char.IsDigit(pasteText[i]))
                        strippedText += pasteText[i].ToString();
                }

                if (strippedText != pasteText)
                {
                    //There were non-numbers in the pasted text
                    e.SuppressKeyPress = true;

                    //OPTIONAL: Manually insert text stripped of non-numbers
                    TextBox me = (TextBox)sender;
                    int start = me.SelectionStart;
                    string newTxt = me.Text;
                    newTxt = newTxt.Remove(me.SelectionStart, me.SelectionLength); //remove highlighted text
                    newTxt = newTxt.Insert(me.SelectionStart, strippedText); //paste
                    me.Text = newTxt;
                    me.SelectionStart = start + strippedText.Length;
                }
                else
                    e.SuppressKeyPress = false;
            }
        }

        private void txbBarcode_Validated(object sender, EventArgs e)
        {
            if (this.txbBarcode.Text == "")
                this.errorProvider1.SetError(this.txbBarcode, "barcode is empty");
            else this.errorProvider1.SetError(this.txbBarcode, "");
        }
    }
}
