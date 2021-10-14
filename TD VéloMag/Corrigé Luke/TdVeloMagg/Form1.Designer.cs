namespace TdVeloMagg
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStations_CellContentClick = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations_CellContentClick)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStations_CellContentClick
            // 
            this.dgvStations_CellContentClick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStations_CellContentClick.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvStations_CellContentClick.Location = new System.Drawing.Point(12, 12);
            this.dgvStations_CellContentClick.Name = "dgvStations_CellContentClick";
            this.dgvStations_CellContentClick.RowHeadersWidth = 5;
            this.dgvStations_CellContentClick.Size = new System.Drawing.Size(268, 426);
            this.dgvStations_CellContentClick.TabIndex = 0;
            this.dgvStations_CellContentClick.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom des stations";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.dgvStations_CellContentClick);
            this.Name = "Form1";
            this.Text = "Velo Magg";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations_CellContentClick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStations_CellContentClick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

