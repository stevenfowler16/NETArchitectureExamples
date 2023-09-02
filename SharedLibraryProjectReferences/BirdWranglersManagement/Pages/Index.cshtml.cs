using BirdWranglers;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BirdWranglerManagement.Pages
{
    public class IndexModel : PageModel
    {
        public readonly BirdWrangler birdWrangler;
        public IndexModel()
        {
            var birdCapacity = 10;
            birdWrangler = new BirdWrangler(birdCapacity);

            var blueBird = new Bird(14, "Blue", "Blue Jay") {ImagePath="BlueJay.jpg" };
            birdWrangler.AddBirdToCare(blueBird);

            var hummingBird = new Bird(4, "Orange", "Allen's Hummingbird") { ImagePath = "AllenHummingbird.jpg" };
            birdWrangler.AddBirdToCare(hummingBird);

            var owl = new Bird(45, "Gray-Brown", "Great Horned Owl") { ImagePath = "GreatHornedOwl.jpg" };
            birdWrangler.AddBirdToCare(owl);

            birdWrangler.FeedBirds();
        }

        public void OnGet()
        {

        }
    }
}