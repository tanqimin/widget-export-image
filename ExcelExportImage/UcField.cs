using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work.MyFavs.Tools
{
    public partial class UcField : UserControl
    {
        private readonly ICollection<string> _fields;
        public event EventHandler DeleteField;

        public string Value { get
            {
                return cbCol1.Text; 
            }
        }
        public UcField(ICollection<string> fields)
        {
            InitializeComponent();
            _fields = fields;
        }

        private void lldel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DeleteField != null)
            {
                DeleteField.Invoke(this, e);
            }
        }

        private void UcField_Load(object sender, EventArgs e)
        {
            if(_fields != null)
            {
                foreach (var field in _fields)
                {
                    cbCol1.Items.Add(field);
                }
            }
        }
    }
}
