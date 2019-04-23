using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab_11_version_2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_11_version_2.Pages
{
    public class ProfessorModel : PageModel
    {
        private readonly ProfessorDbContext _context;
        public List<Lab_11_version_2.Models.Professor> Professors {get; set;}
        public SelectList ProfessorDropDown { get; set; }
        private readonly ILogger _logger;
        public ProfessorModel(ProfessorDbContext context)
        {
            //_logger = logger;
            _context = context;
        }
        public void OnGet()
        {
        Professors = _context.Professor.ToList();
        ProfessorDropDown = new SelectList(Professors, "ProfessorId", "FirstName");
            //_logger.LogWarning($"OnPost() Called. FirstName = {FirstName}");
        }
    }
}