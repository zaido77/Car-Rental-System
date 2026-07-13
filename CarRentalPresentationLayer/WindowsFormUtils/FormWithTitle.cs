using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer
{
    public partial class FormWithTitle : BaseForm
    {
        protected string Title
        {
            get
            {
                return lblTitle.Text;
            }

            set
            {
                lblTitle.Text = value;
            }
        }

        public FormWithTitle()
        {
            InitializeComponent();

            lblTitle.ForeColor = clsColorsSettings.MainColor;
        }

    }
}
