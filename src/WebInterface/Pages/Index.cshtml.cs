using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Models.DataModels;

namespace WebInterface.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRepository _repository;

        public Owner PageOwner;

        public IndexModel(ILogger<IndexModel> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task OnGet()
        {
            var owners = await _repository.GetAllAsync<Owner>();
            PageOwner = owners.FirstOrDefault();
        }
    }
}