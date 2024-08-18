using AutoIt;

namespace UserInterface.Integration.Utils
{
    public static class FileDialogHelper
    {
        private const string DialogWindowName = "Открытие";
        private const string EditField = "Edit1";
        private const string OpenButtonName = "Button1";
        private const int TimeSleep = 1000;

        public static void UploadFile(string filePath)
        {
            // Ждем, пока появится окно "Открытие"
            AutoItX.WinWait(DialogWindowName);

            // Устанавливаем фокус на окно
            AutoItX.WinActivate(DialogWindowName);

            // Вводим путь к файлу
            AutoItX.ControlSetText(DialogWindowName, string.Empty, EditField, filePath);

            // Нажимаем кнопку "Открыть"
            AutoItX.ControlClick(DialogWindowName, string.Empty, OpenButtonName);
            AutoItX.Sleep(TimeSleep);
        }
    }
}
