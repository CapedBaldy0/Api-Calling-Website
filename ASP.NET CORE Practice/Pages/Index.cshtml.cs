using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_CORE_Practice.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string catFact { get; set; }
        public string bored { get; set; }
        public string dogImage { get; set; } = "Resources/dog.jpg";
        public string norisFact { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            catFact = await TestLibrary.ApiProcessor.LoadCatFact();
            bored = await TestLibrary.ApiProcessor.LoadActivity();
            norisFact = await TestLibrary.ApiProcessor.LoadNorisFact();
            Data.UpdateData(catFact, bored, dogImage, norisFact);
        }
        public async Task OnPostUpdateCatFact()
        {
            norisFact = Data.Noris;
            bored = Data.Act;
            catFact = await TestLibrary.ApiProcessor.LoadCatFact();
            dogImage = Data.Dog;
            Data.UpdateData(catFact, bored, dogImage, norisFact);
        }
        public async Task OnPostUpdateActivity()
        {
            norisFact = Data.Noris;
            catFact = Data.Cat;
            bored = await TestLibrary.ApiProcessor.LoadActivity();
            dogImage = Data.Dog;
            Data.UpdateData(catFact, bored, dogImage, norisFact);
        }
        public async Task OnPostUpdateDogImage()
        {
            norisFact = Data.Noris;
            catFact = Data.Cat;
            dogImage = await TestLibrary.ApiProcessor.LoadDogImage();
            bored = Data.Act;
            Data.UpdateData(catFact, bored, dogImage, norisFact);
        }
        public async Task OnPostUpdateNorisFact()
        {
            catFact = Data.Cat;
            dogImage = Data.Dog;
            bored = Data.Act;
            norisFact = await TestLibrary.ApiProcessor.LoadNorisFact();
            Data.UpdateData(catFact, bored, dogImage, norisFact);
        }
    }
}