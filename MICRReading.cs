using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GdPicture14;

namespace MICR
{
    public partial class frmMICRReading : Form
    {
        public frmMICRReading()
        {
            InitializeComponent();
        }

        private void MICRReading_Load(object sender, EventArgs e)
        {

            LicenseManager oLicenseManager = new LicenseManager();
            oLicenseManager.RegisterKEY("211883860501001421116010749430779");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetectMICR BankMICR = new DetectMICR();
            string VMicr = BankMICR.DetectMICRLine("D:\\MICRLine2.TIF");

         
            MessageBox.Show(VMicr.ToString());



        }
    }
}
