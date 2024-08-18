using Newtonsoft.Json;
using UserInterface.Integration.Models.TestData;

public class TestData
{
    [JsonProperty("check_timer_start_time_test")]
    public CheckTimerStartTimeTest CheckTimerStartTimeTest { get; set; }

    [JsonProperty("registration_profile_test")]
    public RegistrationProfileTest RegistrationProfileTest { get; set; }

    [JsonProperty("hidden_help_form_test")]
    public HiddenHelpFormTest HiddenHelpFormTest { get; set; }
}
