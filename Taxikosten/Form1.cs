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
        private TaxiCostCalc()
        {
            InitializeComponent();
        }

        public void txtGeredenKM_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtGeredenKM.Text, out var GeredenKM)); // €1,= per gereden KM
            double GeredenKMkosten = GeredenKM * 1.00;
        }

        private void txtMinDagTarief_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinDagTarief.Text, out var DagTarief)); // €0.25 per minuut
           double DagTariefkosten = DagTarief * 0.25;
        }

        private void txtMinNachtTarief_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinNachtTarief.Text, out var NachtTarief)); // €0.45 per minuut
            double NachtTariefKosten = NachtTarief * 0.45;
        }

        private void txtRitPrijs_TextChanged(object sender, EventArgs e)
        {
            txtRitPrijs.Text = ""; // ritprijs uitkomst
        }

        private void chkWeekendTarief_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWeekendTarief.Checked);
            var kostenTotaal = Kosten * 1.15; // hier tarief * 1.15

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            
            var Kosten = GeredenKMKosten+DagTariefKosten+NachtTariefKosten;

        }
    }
}