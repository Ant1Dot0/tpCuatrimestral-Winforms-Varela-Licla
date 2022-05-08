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
            this.DGVAllArticles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVAllArticles.Location = new System.Drawing.Point(12, 43);
            this.DGVAllArticles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVAllArticles.MultiSelect = false;
            this.DGVAllArticles.Name = "DGVAllArticles";
            this.DGVAllArticles.RowHeadersWidth = 51;
            this.DGVAllArticles.RowTemplate.Height = 24;
            this.DGVAllArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAllArticles.Size = new System.Drawing.Size(920, 465);
            this.DGVAllArticles.TabIndex = 0;
            this.DGVAllArticles.SelectionChanged += new System.EventHandler(this.DGVAllArticles_SelectionChanged);
            // 
            // PBXAllArticles
            // 
            this.PBXAllArticles.Location = new System.Drawing.Point(1070, 43);
            this.PBXAllArticles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBXAllArticles.Name = "PBXAllArticles";
            this.PBXAllArticles.Size = new System.Drawing.Size(382, 455);
            this.PBXAllArticles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXAllArticles.TabIndex = 1;
            this.PBXAllArticles.TabStop = false;
            // 
            // FormTestAllArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 549);
            this.Controls.Add(this.PBXAllArticles);
            this.Controls.Add(this.DGVAllArticles);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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