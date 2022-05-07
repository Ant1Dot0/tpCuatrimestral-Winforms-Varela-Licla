namespace Vista
{
    partial class FormTestAllArticles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVAllArticles = new System.Windows.Forms.DataGridView();
            this.PBXAllArticles = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXAllArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAllArticles
            // 
            this.DGVAllArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAllArticles.Location = new System.Drawing.Point(9, 35);
            this.DGVAllArticles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVAllArticles.Name = "DGVAllArticles";
            this.DGVAllArticles.RowHeadersWidth = 51;
            this.DGVAllArticles.RowTemplate.Height = 24;
            this.DGVAllArticles.Size = new System.Drawing.Size(412, 244);
            this.DGVAllArticles.TabIndex = 0;
            // 
            // PBXAllArticles
            // 
            this.PBXAllArticles.Location = new System.Drawing.Point(436, 56);
            this.PBXAllArticles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBXAllArticles.Name = "PBXAllArticles";
            this.PBXAllArticles.Size = new System.Drawing.Size(146, 168);
            this.PBXAllArticles.TabIndex = 1;
            this.PBXAllArticles.TabStop = false;
            // 
            // FormTestAllArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.PBXAllArticles);
            this.Controls.Add(this.DGVAllArticles);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTestAllArticles";
            this.Text = "FormTestAllArticles";
            this.Load += new System.EventHandler(this.FormTestAllArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXAllArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAllArticles;
        private System.Windows.Forms.PictureBox PBXAllArticles;
    }
}