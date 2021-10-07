using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxikosten

{

    public partial class TaxiCostCalc : Form
     {

        double geredenKMKosten;
        double dagTariefKosten;
        double nachtTariefKosten;


        public TaxiCostCalc()
        {
            InitializeComponent();

        }

        public void txtGeredenKM_TextChanged(object sender, EventArgs e)
        {
            string geredenKM = txtGeredenKM.Text;
            if (int.TryParse(txtGeredenKM.Text, out var GeredenKM)) // €1,= per gereden KM
            geredenKMKosten = GeredenKM * 1.00;
        }

        private void txtMinDagTarief_TextChanged(object sender, EventArgs e)
        {
            string minDagTarief = txtMinDagTarief.Text;
            if (int.TryParse(txtMinDagTarief.Text, out var DagTarief)) // €0.25 per minuut
           dagTariefKosten = DagTarief * 0.25;
        }

        private void txtMinNachtTarief_TextChanged(object sender, EventArgs e)
        {
            string minNachtTarief = txtMinNachtTarief.Text;
            if (int.TryParse(txtMinNachtTarief.Text, out var NachtTarief)) // €0.45 per minuut
                nachtTariefKosten = NachtTarief * 0.45;
        }

        private void txtRitPrijs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkWeekendTarief_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            txtRitPrijs.Text = "";
            double kosten = geredenKMKosten + dagTariefKosten + nachtTariefKosten;

            if (chkWeekendTarief.Checked)
            {
                var kostenTotaal = kosten * 1.15; // hier tarief * 1.15
                txtRitPrijs.Text =kostenTotaal.ToString("€" + "0.00"); // ritprijs uitkomst
            }

            else
            {
                txtRitPrijs.Text = kosten.ToString("€" + "0.00"); // ritprijs uitkomst
            }
            

        }
    }
}