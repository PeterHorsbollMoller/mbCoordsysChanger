using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapInfo.MiPro.Interop;

namespace CoordsysChanger
{
    public partial class CoordsysChangerDialog : Form
    {
        private string[] _tables;
        private static MapInfoApplication _miApp = null;
        private string _coordsys = "";
        private string _coordsysName = "";
        //private string _coordsysName = "";

        public CoordsysChangerDialog()
        {
            InitializeComponent();
        }

        private void CoordsysChangerDialog_Load(object sender, EventArgs e)
        {
            _miApp = InteropServices.MapInfoApplication;

            if (_coordsys == "")
                _buttonTransform.Enabled = false;
            else
                _buttonTransform.Enabled = true;
        }

        public string[] Tables
        {
            get { return _tables; }
            set 
            { 
                _tables = value;
                _listBoxTables.Items.AddRange(_tables);
            }
        }

        public string Coordsys
        {
            get { return _coordsys; }
            set 
            {   
                _coordsys = value;

                if (_coordsys == "")
                {
                    _buttonTransform.Enabled = false;
                    _coordsysName = "";
                }
                else
                {
                    _buttonTransform.Enabled = true;

                    _coordsysName = InteropHelper.Eval(string.Format(@"CoordsysName$(""""{0}"""")", _coordsys));
                }

                _textBoxProjection.Text = _coordsysName;
            }
        }


        private void _buttonProjection_Click(object sender, EventArgs e)
        {
            
            //string newCoordsys = _miApp.Eval(string.Format("ChooseProjection$({0}, 1)", _coordsys));
            string newCoordsys = _miApp.Eval("ChooseProjection$(\"\", 1)");
            //MessageBox.Show(string.Format("Error: {0}", _miApp.LastErrorMessage));

            if (newCoordsys != "")
                this.Coordsys = newCoordsys;

        }

    }
}
