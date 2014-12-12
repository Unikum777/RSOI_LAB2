using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailsApp.Models
{
	public class SkyDriveFile
	{
		public string Id { get; set; }
		public string FileName { get; set; }
		public string FileId { get; set; }
		public string ParentId { get; set; }
		public int Size { get; set; }
		public string Link { get; set; }
		public string Access { get; set; }
	}
}