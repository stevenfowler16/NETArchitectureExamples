using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BirdWranglers
{
    public class BirdWrangler
    {
        public BirdWrangler(int BirdWranglingAmount)
        {
            this.BirdWranglingAmount = BirdWranglingAmount;
        }

        public ReadOnlyCollection<Bird> Birds => new ReadOnlyCollection<Bird>(BirdsWrangled);
        public int BirdWranglingAmount { get; }
        private IList<Bird> BirdsWrangled { get; set; } = new List<Bird>();

        public void FeedBirds()
        {
            foreach (var bird in BirdsWrangled)
            {
                bird.Feed();
            }
        }

        public void AddBirdToCare(Bird bird)
        {
            if (BirdsWrangled.Count > BirdWranglingAmount)
            {
                throw new Exception("Unable to wrangle any more birds");
            }

            BirdsWrangled.Add(bird);
        }
    }
}
