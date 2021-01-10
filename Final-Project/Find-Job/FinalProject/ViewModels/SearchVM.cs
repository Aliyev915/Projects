using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class SearchVM
    {
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Candidate> Candidates { get; set; }
    }
}
