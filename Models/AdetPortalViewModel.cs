using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trylangsamidtermquiz2.Models
{
    public class AdetPortalViewModel
    {
        public List<AdetPortal> StudentPortal { get; set; }
        public SelectList Names { get; set; }
        public string PortalName{ get; set; }
        public string SearchString { get; set; }
    }
}