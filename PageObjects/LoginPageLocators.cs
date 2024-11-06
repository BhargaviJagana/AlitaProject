using OpenQA.Selenium;

namespace PageObjects
{
    public partial class LoginPage
    {
        private By by1 = By.Id("user-name");
        private By by2 = By.Id("password");
        private By by3 = By.Id("login-button");
        private By productLabel = By.XPath("//*[@class='header_secondary_container']");
        private By errorButton = By.XPath("//button[@class='error-button']");
    }
}
