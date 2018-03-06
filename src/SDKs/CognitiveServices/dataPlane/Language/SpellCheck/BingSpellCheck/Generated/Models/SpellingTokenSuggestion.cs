// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.SpellCheck.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SpellingTokenSuggestion
    {
        /// <summary>
        /// Initializes a new instance of the SpellingTokenSuggestion class.
        /// </summary>
        public SpellingTokenSuggestion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SpellingTokenSuggestion class.
        /// </summary>
        public SpellingTokenSuggestion(string suggestion, double? score = default(double?), string pingUrlSuffix = default(string))
        {
            Suggestion = suggestion;
            Score = score;
            PingUrlSuffix = pingUrlSuffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "suggestion")]
        public string Suggestion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pingUrlSuffix")]
        public string PingUrlSuffix { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Suggestion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Suggestion");
            }
        }
    }
}
