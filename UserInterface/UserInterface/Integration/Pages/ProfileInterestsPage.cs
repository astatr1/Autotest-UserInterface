using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using UserInterface.Integration.Utils;

namespace UserInterface.Integration.Pages
{
    public class ProfileInterestsPage : Form
    {
        private IButton NextRegistrationPageButton => ElementFactory.GetButton(By.XPath("//*[@type='button' and contains(text(),'Next')]"), "Next page login form");
        private ILink UploadAvatarProfileLink => ElementFactory.GetLink(By.XPath("//*[contains(@class,'avatar-and-interests__upload-button')]"), "Upload avatar");
        private ICheckBox UnselectAllCheckBox => ElementFactory.GetCheckBox(By.XPath("//*[contains(@for,'interest_unselectall')]"), "Unselect all");
        private ICheckBox GetInterestCheckBox(string interest) => ElementFactory.GetCheckBox(By.XPath($"//*[contains(@for,'interest_{interest}')]"), $"{interest}");

        public readonly Dictionary<string, string> Interests = new()
        {
            { "Ponies" ,"ponies" },
            { "Polo" ,"polo" },
            { "Dough" ,"dough" },
            { "Snails" ,"snails" },
            { "Balls" ,"balls" },
            { "Post-its" ,"postits" },
            { "Faucets" ,"faucets" },
            { "Enveloppes" ,"enveloppes" },
            { "Cables" ,"cables" },
            { "Questions" ,"questions" },
            { "Squares" ,"squares" },
            { "Purple" ,"purple" },
            { "Cotton" ,"cotton" },
            { "Dry-wall" ,"drywall" },
            { "Closets" ,"closets" },
            { "Tires" ,"tires" },
            { "Windows" ,"windows" },
            { "Mullets" ,"mullets" },
            { "Cinnamon" ,"cinnamon" }
        };

        public ProfileInterestsPage() : base(By.XPath("//*[contains(@class,'page-indicator') and contains(text(),'2')]"), "Profile interests page") { }

        public void UnselectAllCheckbox()
        {
            UnselectAllCheckBox.Check();
        }

        public void ClickUploadProfileImage()
        {
            UploadAvatarProfileLink.Click();
        }

        public void UploadProfileImage(string[] path)
        {
            var avatarPath = PathHelper.GetFullPath(path);
            FileDialogHelper.UploadFile(avatarPath);
        }

        public void ClickNextRegistrationPageButton()
        {
            NextRegistrationPageButton.State.WaitForClickable();
            NextRegistrationPageButton.WaitAndClick();
        }

        public void SelectInterestCheckBox(string interest)
        {
            GetInterestCheckBox(interest).WaitAndClick();
        }
    }
}
