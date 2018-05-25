using CompanyInfo.Models;
using System.Web.Http;

namespace CompanyInfo.Controllers
{

    public class HomepageUrlController : ApiController
    {
        private CompanyProperties _properties;


        public HomepageUrlController()
        {
            _properties = CompanyProperties.LoadFromConfigFile();
        }



        public HomepageUrlController(CompanyProperties props)
        {
            _properties = props;
        }



        /// <summary>
        /// Get the URL linking to our company's primary English website.
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetCorporateUrl()
        {
            return Ok(_properties.CorporateHomepageUrlEnglish);
        }



        /// <summary>
        /// Get the URL linking to our company's primary website in a specific language.
        /// </summary>
        /// <remarks>
        /// If we don't have a URL for that language, then the English site will be returned.
        /// </remarks>
        /// <param name="lang">The language of interest.  Only the first 2 characters are important.</param>
        /// <returns></returns>
        public IHttpActionResult GetCorporateUrl(string lang)
        {
            if (string.IsNullOrWhiteSpace(lang))
            {
                return Ok(_properties.CorporateHomepageUrlEnglish);
            }

            if (lang.ToLower().StartsWith("fr"))
            {
                return Ok(_properties.CorporateHomepageUrlFrench);
            }
            else
            {
                return Ok(_properties.CorporateHomepageUrlEnglish);
            }
        }


    }
}
