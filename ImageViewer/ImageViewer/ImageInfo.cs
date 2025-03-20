using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer
{
	internal class ImageInfo
	{
		public string Path { get; set; }
		public string Name { get; protected set; }

		public ImageInfo(string path) {
			this.Path = path;
			this.Name = System.IO.Path.GetFileName(path);
		}
	}
}
