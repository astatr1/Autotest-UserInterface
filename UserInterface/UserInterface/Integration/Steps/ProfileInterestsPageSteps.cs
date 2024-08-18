using UserInterface.Integration.Pages;
using UserInterface.Integration.Utils;

namespace UserInterface.Integration.Steps
{
    public static class ProfileInterestsPageSteps
    {
        private static readonly ProfileInterestsPage ProfileInterestsPage = new();

        public static void SelectRandomChooseInterests(int countInterests)
        {
            var randomInterests = RandomUtility.RandomDictionaryKey(ProfileInterestsPage.Interests, countInterests);

            foreach (var interest in randomInterests)
            {
                ProfileInterestsPage.SelectInterestCheckBox(ProfileInterestsPage.Interests[interest]);
            }
        }
    }
}