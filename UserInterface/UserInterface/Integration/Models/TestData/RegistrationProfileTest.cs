using Newtonsoft.Json;

namespace UserInterface.Integration.Models.TestData
{
    public class RegistrationProfileTest
    {
        [JsonProperty("password_length")]
        public int PasswordLength { get; set; }

        [JsonProperty("name_email_length")]
        public int NameEmailLength { get; set; }

        [JsonProperty("domain_name_length")]
        public int DomainNameLength { get; set; }

        [JsonProperty("count_selected_interests")]
        public int CountSelectedInterests { get; set; }

        [JsonProperty("path_avatar_file")]
        public string[] PathAvatarFile { get; set; }
    }
}
