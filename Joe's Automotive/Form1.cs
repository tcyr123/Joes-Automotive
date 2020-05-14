using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////  value-returning methods  ////////////////////////////////////////////////////////////////////////
        private double OilLubeCharges()
        {
            double OilLubeTotal = 0;
            if (OilChangeCB.Checked == true)
            {
                OilLubeTotal = OilLubeTotal + 26;
            }
            if (LubeJobCB.Checked == true)
            {
                OilLubeTotal = OilLubeTotal + 18;
            }
            return OilLubeTotal;
        }

        private double FlushCharges()
        {
            double FlushTotal = 0;
            if (RadiatorFlushCB.Checked == true)
            {
                FlushTotal = FlushTotal + 30;
            }
            if (TransmissionFlushCB.Checked == true)
            {
                FlushTotal = FlushTotal + 80;
            }
            return FlushTotal;
        }

        private double MiscCharges()
        {
            double MiscTotal = 0;
            if (InspectionCB.Checked == true)
            {
                MiscTotal = MiscTotal + 15;
            }
            if (ReplaceMufflerCB.Checked == true)
            {
                MiscTotal = MiscTotal + 100;
            }
            if (TireRotationCB.Checked == true)
            {
                MiscTotal = MiscTotal + 20;
            }
            return MiscTotal;
        }

        private double OtherCharges()
        {
            double LaborTotal = 0;
            if (LaborIn.Text != "") 
                LaborTotal = double.Parse(LaborIn.Text);
            return LaborTotal; 

        }

        private double TaxCharges()
        {
            double TaxTotal = 0;
            if (PartsIn.Text.Length > 0)
                TaxTotal = double.Parse(PartsIn.Text) * 0.06 ;
            return TaxTotal;
        }

        private double TotalCharges()
        {
            double TotalTotal = 0;
            TotalTotal = TaxCharges() + OtherCharges() + MiscCharges() + FlushCharges() + OilLubeCharges();
            return TotalTotal;
        }

        ////////////////////////////////////////////////////////////  clear void methods  ///////////////////////////////////////////////////////////////////////////////
        private void ClearOilLube()
        {
            OilChangeCB.Checked = false;
            LubeJobCB.Checked = false;
        }

        private void ClearFlushes()
        {
            RadiatorFlushCB.Checked = false;
            TransmissionFlushCB.Checked = false;
        }

        private void ClearMisc()
        {
            InspectionCB.Checked = false;
            ReplaceMufflerCB.Checked = false;
            TireRotationCB.Checked = false;
        }

        private void ClearOther()
        {
            PartsIn.Text = "";
            LaborIn.Text = "";
        }

        private void ClearFees()
        {
            TotalFeesOut.Text = "";
            PartsOut.Text = "";
            TaxOnPartsOut.Text = "";
            ServLaborOut.Text = "";
        }

        /////////////////////////////////////////////////////////////////////  CLEAR  ///////////////////////////////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
            OilChangeCB.Focus();
        }


        ////////////////////////////////////////////////////////////////////  CALCULATE  ////////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            double a = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges();
            ServLaborOut.Text = a.ToString("c");
            if (PartsIn.Text != "")
            PartsOut.Text = double.Parse(PartsIn.Text).ToString("c");
            else
                PartsOut.Text = 0.ToString("c");
            TaxOnPartsOut.Text = TaxCharges().ToString("c");
            TotalFeesOut.Text = TotalCharges().ToString("c");
        }


        //////////////////////////////////////////////////////////////////////  EXIT  ///////////////////////////////////////////////////////////////////////////////////
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
