using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Back_end
{
    public partial class LabelText02 : UserControl
    {
        public enum TipoDato { texto, numero, fecha }
        public string _Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public bool _Validable {get; set; }
        public string _Nombre_campo { get; set; }
        public string _Nombre_tabla { get; set; }
        public string _Mensaje_error { get; set; }

        public int _Ancho { get; set; } = 10;
        public int _Decimales { get; set; } = 2;
        public TipoDato _TipoDato {
            get { return TipoD; }
            set {
                TipoD = value;
                string mascara = "";
                switch(TipoD)
                {
                    case TipoDato.texto:
                        TxtDato.Mask = mascara.PadLeft(_Ancho, 'C');
                        TxtDato.TextAlign = HorizontalAlignment.Left;
                        break;
                    case TipoDato.numero:
                        if (_Decimales >= 1)
                        {
                            mascara = mascara.PadLeft(_Ancho - _Decimales - 1, '9') + ".";
                            mascara = mascara.PadRight(_Ancho, '9');
                        }
                        else
                            mascara = mascara.PadLeft(_Ancho, '9');
                        TxtDato.Mask = mascara;
                        TxtDato.TextAlign = HorizontalAlignment.Right;
                        break;
                    case TipoDato.fecha:
                        TxtDato.Mask = "00/00/0000";
                        TxtDato.TextAlign = HorizontalAlignment.Left;
                        break;
                    default:
                        break;
                }
            }
        }
        public string _Text
        {
            get => TxtDato.Text;
            set
            {
                if (TipoD == TipoDato.numero)
                {
                    if (_Decimales == 0)
                        TxtDato.Text = string.Format("{0:" + TxtDato.Mask.Replace('9', '0') + "}", int.Parse(value));
                    else
                        TxtDato.Text = string.Format("{0:" + TxtDato.Mask.Replace('9', '0') + "}", double.Parse(value));
                }

            }
        }
        public bool _MaskFull => TxtDato.MaskFull;
        public bool _ReadOnly
        {
            get => TxtDato.ReadOnly;
            set => TxtDato.ReadOnly = value;
        }
        TipoDato TipoD = TipoDato.texto;
        public LabelText02()
        {
            InitializeComponent();
        }
        private void TxtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("."))
            {
                if (this._TipoDato == TipoDato.numero)
                {
                    TxtDato.Text = TxtDato.Text.Trim();
                    int blanco = TxtDato.Text.IndexOf(' ');
                    int entero = _Ancho - _Decimales - 1;
                    if (blanco <= entero && blanco != -1)
                    {
                        for (int i = 0; i < entero - blanco; i++)
                        {
                            TxtDato.Text = " " + TxtDato.Text;
                        }
                    }
                    TxtDato.SelectionStart = TxtDato.Text.Length;
                }
            }
        }
    }
}
