using CompanyInfo.Models;
using System.Web.Http;


namespace CompanyInfo.Controllers
{
    [RoutePrefix("api/CompanyName")]
    public class CompanyNameController : ApiController
    {

        private CompanyProperties _properties;


        /// <summary>
        /// Information relating to our company name.
        /// </summary>
        public CompanyNameController()
        {
            _properties = CompanyProperties.LoadFromConfigFile();
        }



        /// <summary>
        /// Information relating to our company name.
        /// </summary>
        public CompanyNameController(CompanyProperties props)
        {
            _properties = props;
        }



        /// <summary>
        /// Get our current English company name.
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetName()
        {
            return Ok(_properties.StandardCompanyNameEnglish);
        }


        /// <summary>
        /// Get our company name in a specified language.
        /// </summary>
        /// <remarks>
        /// If we don't have a name in the requested language, the English version is used.
        /// </remarks>
        /// <param name="lang">The desired language.  Only the first 2 characters are important.</param>
        /// <returns></returns>
        public IHttpActionResult GetName(string lang)
        {
            if (string.IsNullOrWhiteSpace(lang))
            {
                return Ok(_properties.StandardCompanyNameEnglish);
            }

            if (lang.ToLower().StartsWith("fr")) {
                return Ok(_properties.StandardCompanyNameFrench);
            } else
            {
                return Ok(_properties.StandardCompanyNameEnglish);
                // new comment.
            }
        }



        /// <summary>
        /// Get the English version of our company's full legal name.
        /// </summary>
        /// <returns></returns>
        [Route("legal")]
        public IHttpActionResult GetLegalName()
        {
            return Ok(_properties.LegalCompanyNameEnglish);
        }



        /// <summary>
        /// Get our company's full legal name in the language specified.
        /// </summary>
        /// <remarks>
        /// If we don't have a legal name in the requested language, the English version is used.
        /// </remarks>
        /// <param name="lang">The language of interest.  Only the first 2 characters are important.</param>
        [Route("legal/{lang}")]
        public IHttpActionResult GetLegalName(string lang) 
        {
            if (string.IsNullOrWhiteSpace(lang))
            {
                return Ok(_properties.LegalCompanyNameEnglish);
            }

            if (lang.ToLower().StartsWith("fr"))
            {
                return Ok(_properties.LegalCompanyNameFrench);
            }
            else
            {
                return Ok(_properties.LegalCompanyNameEnglish);
            }
        }



        /// <summary>
        /// Get the shorter, simpler English version of our company name.
        /// </summary>
        /// <returns></returns>
        [Route("simple")]
        public IHttpActionResult GetSimpleName()
        {
            return Ok(_properties.SimpleCompanyNameEnglish);
        }



        /// <summary>
        /// Get the shorter, simpler version of our company name in the language specified.  
        /// </summary>
        /// <remarks>
        /// If we don't have a simple name in the requested language, the English version is used.
        /// </remarks>
        /// <param name="lang">The language of interest.  Only the first 2 characters are important.</param>
        /// <returns></returns>
        [Route("simple/{lang}")]
        public IHttpActionResult GetSimpleName(string lang)
        {
            if (string.IsNullOrWhiteSpace(lang))
            {
                return Ok(_properties.SimpleCompanyNameEnglish);
            }

            if (lang.ToLower().StartsWith("fr"))
            {
                return Ok(_properties.SimpleCompanyNameFrench);
            }
            else
            {
                return Ok(_properties.SimpleCompanyNameEnglish);
            }
        }
    }
}
