
namespace Taxikosten
{
    partial class TaxiCostCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkWeekendTarief = new System.Windows.Forms.CheckBox();
            this.txtMinDagTarief = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinNachtTarief = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRitPrijs = new System.Windows.Forms.TextBox();
            this.txtGeredenKM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkWeekendTarief
            // 
            this.chkWeekendTarief.AutoSize = true;
            this.chkWeekendTarief.Location = new System.Drawing.Point(10, 172);
            this.chkWeekendTarief.Name = "chkWeekendTarief";
            this.chkWeekendTarief.Size = new System.Drawing.Size(216, 19);
            this.chkWeekendTarief.TabIndex = 0;
            this.chkWeekendTarief.Text = "Weekend tarief vrij 22.00 tot ma 7.00";
            this.chkWeekendTarief.UseVisualStyleBackColor = true;
            this.chkWeekendTarief.CheckedChanged += new System.EventHandler(this.chkWeekendTarief_CheckedChanged);
            // 
            // txtMinDagTarief
            // 
            this.txtMinDagTarief.Location = new System.Drawing.Point(10, 80);
            this.txtMinDagTarief.Name = "txtMinDagTarief";
            this.txtMinDagTarief.Size = new System.Drawing.Size(100, 23);
            this.txtMinDagTarief.TabIndex = 1;
            this.txtMinDagTarief.TextChanged += new System.EventHandler(this.txtMinDagTarief_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minuten tussen 8.00-18.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minuten tussen 18.01 en 7.59";
            // 
            // txtMinNachtTarief
            // 
            this.txtMinNachtTarief.Location = new System.Drawing.Point(10, 134);
            this.txtMinNachtTarief.Name = "txtMinNachtTarief";
            this.txtMinNachtTarief.Size = new System.Drawing.Size(100, 23);
            this.txtMinNachtTarief.TabIndex = 4;
            this.txtMinNachtTarief.TextChanged += new System.EventHandler(this.txtMinNachtTarief_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rit prijs";
            // 
            // txtRitPrijs
            // 
            this.txtRitPrijs.Location = new System.Drawing.Point(61, 255);
            this.txtRitPrijs.Name = "txtRitPrijs";
            this.txtRitPrijs.Size = new System.Drawing.Size(100, 23);
            this.txtRitPrijs.TabIndex = 6;
            this.txtRitPrijs.TextChanged += new System.EventHandler(this.txtRitPrijs_TextChanged);
            // 
            // txtGeredenKM
            // 
            this.txtGeredenKM.Location = new System.Drawing.Point(10, 27);
            this.txtGeredenKM.Name = "txtGeredenKM";
            this.txtGeredenKM.Size = new System.Drawing.Size(100, 23);
            this.txtGeredenKM.TabIndex = 7;
            this.txtGeredenKM.TextChanged += new System.EventHandler(this.txtGeredenKM_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gereden KM";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(72, 211);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 9;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // TaxiCostCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 310);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGeredenKM);
            this.Controls.Add(this.txtRitPrijs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinNachtTarief);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinDagTarief);
            this.Controls.Add(this.chkWeekendTarief);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaxiCostCalc";
            this.Text = "Taxikosten calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkWeekendTarief;
        private System.Windows.Forms.TextBox txtMinDagTarief;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinNachtTarief;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRitPrijs;
        private System.Windows.Forms.TextBox txtGeredenKM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBereken;
    }
}

