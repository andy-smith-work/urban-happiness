using CompanyInfo.Models;
using System.Web.Http;

namespace CompanyInfo.Controllers
{

    public class PrivacyPolicyController : ApiController
    {
        private CompanyProperties _properties;


        public PrivacyPolicyController()
        {
            _properties = CompanyProperties.LoadFromConfigFile();
        }



        public PrivacyPolicyController(CompanyProperties props)
        {
            _properties = props;
        }



        /// <summary>
        /// Get the URL to our English privacy policy.
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetPrivacyPolicyUrl()
        {
            return Ok(_properties.PrivacyPolicyUrlEnglish);
        }



        /// <summary>
        /// Get the URL to our privacy policy written in a specified language.
        /// </summary>
        /// <remarks>
        /// We may have an alternate version of our privacy policy in a different language. 
        /// If we don't have a privacy policy in the desired language, the URL for the English
        /// one is returned.
        /// </remarks>
        /// <param name="lang">The desired language.  Only the first 2 characters are important.</param>
        /// <returns></returns>
        public IHttpActionResult GetPrivacyPolicyUrl(string lang)
        {
            if (string.IsNullOrWhiteSpace(lang))
            {
                return Ok(_properties.PrivacyPolicyUrlEnglish);
            }

            if (lang.ToLower().StartsWith("fr"))
            {
                return Ok(_properties.PrivacyPolicyUrlFrench);
            }
            else
            {
                return Ok(_properties.PrivacyPolicyUrlEnglish);
            }
        }


    }
}
