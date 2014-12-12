using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MailsApp.Models;

namespace MailsApp.Controllers
{
    public class FilesController : ApiController
    {
	    private SkyDriveFile[] files = new SkyDriveFile[]
	    {
		    new SkyDriveFile
		    {
			    Access = "Just Me",
			    FileId = "01",
			    FileName = "Vasya",
			    Id = "01",
			    Link = "http\01",
			    ParentId = "0",
			    Size = 995
		    },
		    new SkyDriveFile
		    {
			    Access = "Just Me",
			    FileId = "02",
			    FileName = "Petya",
			    Id = "01",
			    Link = "http\02",
			    ParentId = "1",
			    Size = 995
		    },
		    new SkyDriveFile
		    {
			    Access = "Just Me",
			    FileId = "03",
			    FileName = "Masha",
			    Id = "01",
			    Link = "http\03",
			    ParentId = "1",
			    Size = 995
		    }
	    };

	    public IEnumerable<SkyDriveFile> GetAllFiles()
	    {
		    return files;
	    }

		public IHttpActionResult GetProduct(string id)
		{
			var product = files.FirstOrDefault((p) => p.Id == id);
			if (product == null)
			{
				return NotFound();
			}
			return Ok(product);
		}
    }
}
