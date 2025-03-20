using System.IO;

namespace ImageViewer
{
	public partial class Form1 : Form
	{
		private List<ImageInfo> fileInfos = new List<ImageInfo>();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// �摜�t�H���_��S���\������B
			IEnumerable<string> filePaths = Directory.EnumerateFiles("Z:/Pictrue/���C�ɓ���", "*", SearchOption.AllDirectories);

			foreach (string filePath in filePaths)
			{
				ImageInfo info = new ImageInfo(filePath);
				this.fileInfos.Add(info);

			}
			this.dgvImageList.DataSource = this.fileInfos;
			this.picImage.ImageLocation = "Z:/Pictrue/���C�ɓ���/32643199_p0.jpg";
		}

		private void dgvImageList_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			string path = (string)this.dgvImageList.Rows[e.RowIndex].Cells[0].Value;
			this.picImage.ImageLocation = path;

		}
	}
}
