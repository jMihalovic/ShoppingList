
namespace ShoppingList
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButPlus = new System.Windows.Forms.Button();
            this.NakupLabel = new System.Windows.Forms.Label();
            this.HotovoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButPlus
            // 
            this.ButPlus.Location = new System.Drawing.Point(12, 100);
            this.ButPlus.Name = "ButPlus";
            this.ButPlus.Size = new System.Drawing.Size(23, 23);
            this.ButPlus.TabIndex = 0;
            this.ButPlus.Text = "+";
            this.ButPlus.UseVisualStyleBackColor = true;
            this.ButPlus.Click += new System.EventHandler(this.ButPlus_Click);
            // 
            // NakupLabel
            // 
            this.NakupLabel.AutoSize = true;
            this.NakupLabel.Location = new System.Drawing.Point(53, 73);
            this.NakupLabel.Name = "NakupLabel";
            this.NakupLabel.Size = new System.Drawing.Size(52, 13);
            this.NakupLabel.TabIndex = 1;
            this.NakupLabel.Text = "Nakup si:";
            // 
            // HotovoLabel
            // 
            this.HotovoLabel.AutoSize = true;
            this.HotovoLabel.Location = new System.Drawing.Point(484, 73);
            this.HotovoLabel.Name = "HotovoLabel";
            this.HotovoLabel.Size = new System.Drawing.Size(42, 13);
            this.HotovoLabel.TabIndex = 2;
            this.HotovoLabel.Text = "Hotovo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.HotovoLabel);
            this.Controls.Add(this.NakupLabel);
            this.Controls.Add(this.ButPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButPlus;
        private System.Windows.Forms.Label NakupLabel;
        private System.Windows.Forms.Label HotovoLabel;
    }
}

