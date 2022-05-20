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
        public string guess { get; set; } = "the guess will show here";
        public string number { get; set; }

        [BindProperty]
        public string option { get; set; }

        public string[] options = new[] { "Gender", "Age", "Nationality" };

        [BindProperty]
        public string guessName { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            catFact = await TestLibrary.ApiProcessor.LoadCatFact();
            bored = await TestLibrary.ApiProcessor.LoadActivity();
            norisFact = await TestLibrary.ApiProcessor.LoadNorisFact();
            number = await TestLibrary.ApiProcessor.LoadNumbersFact();
            Data.UpdateData(catFact, bored, dogImage, norisFact, guess, number);
        }
        public void getData()
        {
            guess = Data.Guess;
            catFact = Data.Cat;
            dogImage = Data.Dog;
            bored = Data.Act;
            norisFact = Data.Noris;
            number = Data.Number;
        }

        public async Task OnPostUpdateCatFact()
        {
            getData();
            catFact = await TestLibrary.ApiProcessor.LoadCatFact();
            Data.UpdateData(catFact, bored, dogImage, norisFact, guess, number);
        }
        public async Task OnPostUpdateActivity()
        {
            getData();
            bored = await TestLibrary.ApiProcessor.LoadActivity();
            Data.UpdateData(catFact, bored, dogImage, norisFact, guess, number);
        }
        public async Task OnPostUpdateDogImage()
        {
            getData();
            dogImage = await TestLibrary.ApiProcessor.LoadDogImage();
            Data.UpdateData(catFact, bored, dogImage, norisFact, guess, number);
        }
        public async Task OnPostUpdateNorisFact()
        {
            getData();
            norisFact = await TestLibrary.ApiProcessor.LoadNorisFact();
            Data.UpdateData(catFact, bored, dogImage, norisFact, guess, number);
        }
        public async Task OnPostUpdateGuessName()
        {
            getData();
            if (option == "Gender")
            {
                guess = await TestLibrary.ApiProcessor.LoadGuessGender(guessName);
            }
            if (option == "Age")
            {
                guess = await TestLibrary.ApiProcessor.LoadGuessAge(guessName);
            }
            if (option == "Nationality")
            {
                guess = await TestLibrary.ApiProcessor.LoadGuessNationality(guessName);
            }
            Data.UpdateData(catFact, bored, dogImage, norisFact, guess, number);
        }
        public async Task OnPostUpdateNumbersFact()
        {
            getData();
            number = await TestLibrary.ApiProcessor.LoadNumbersFact();
            Data.UpdateData(catFact, bored, dogImage, norisFact, guess, number);
        }
    }
}