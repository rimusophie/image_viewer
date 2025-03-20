namespace ImageViewer
{
    partial class Form1
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
			picImage = new PictureBox();
			dgvImageList = new DataGridView();
			colName = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvImageList).BeginInit();
			SuspendLayout();
			// 
			// picImage
			// 
			picImage.Location = new Point(882, 12);
			picImage.Name = "picImage";
			picImage.Size = new Size(1018, 859);
			picImage.SizeMode = PictureBoxSizeMode.Zoom;
			picImage.TabIndex = 0;
			picImage.TabStop = false;
			// 
			// dgvImageList
			// 
			dgvImageList.AllowUserToAddRows = false;
			dgvImageList.AllowUserToDeleteRows = false;
			dgvImageList.AllowUserToOrderColumns = true;
			dgvImageList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvImageList.Columns.AddRange(new DataGridViewColumn[] { colName });
			dgvImageList.Location = new Point(12, 54);
			dgvImageList.Name = "dgvImageList";
			dgvImageList.ReadOnly = true;
			dgvImageList.Size = new Size(864, 928);
			dgvImageList.TabIndex = 1;
			dgvImageList.RowEnter += dgvImageList_RowEnter;
			// 
			// colName
			// 
			colName.DataPropertyName = "Name";
			colName.HeaderText = "ファイル名";
			colName.Name = "colName";
			colName.ReadOnly = true;
			colName.Width = 200;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1912, 1049);
			Controls.Add(dgvImageList);
			Controls.Add(picImage);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)picImage).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvImageList).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox picImage;
		private DataGridView dgvImageList;
		private DataGridViewTextBoxColumn colName;
	}
}
