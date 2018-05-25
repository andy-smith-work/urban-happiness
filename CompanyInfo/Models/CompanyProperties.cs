using System.Configuration;

namespace CompanyInfo.Models
{
    public class CompanyProperties
    {
        public string LegalCompanyNameEnglish { get; set; }
        public string LegalCompanyNameFrench { get; set; }

        public string SimpleCompanyNameEnglish { get; set; }
        public string SimpleCompanyNameFrench { get; set; }

        public string StandardCompanyNameEnglish { get; set; }
        public string StandardCompanyNameFrench { get; set; }

        public string PrivacyPolicyUrlEnglish { get; set; }
        public string PrivacyPolicyUrlFrench { get; set; }

        public string CorporateHomepageUrlEnglish { get; set; }
        public string CorporateHomepageUrlFrench { get; set; }



        public static CompanyProperties LoadFromConfigFile() {
            CompanyProperties properties = new CompanyProperties();

            properties.LegalCompanyNameEnglish = ConfigurationManager.AppSettings["LegalCompanyNameEnglish"] ?? "";
            properties.LegalCompanyNameFrench = ConfigurationManager.AppSettings["LegalCompanyNameFrench"] ?? "";

            properties.StandardCompanyNameEnglish = ConfigurationManager.AppSettings["StandardCompanyNameEnglish"] ?? "";
            properties.StandardCompanyNameFrench = ConfigurationManager.AppSettings["StandardCompanyNameFrench"] ?? "";

            properties.SimpleCompanyNameEnglish = ConfigurationManager.AppSettings["SimpleCompanyNameEnglish"] ?? "";
            properties.SimpleCompanyNameFrench = ConfigurationManager.AppSettings["SimpleCompanyNameFrench"] ?? "";

            properties.PrivacyPolicyUrlEnglish = ConfigurationManager.AppSettings["PrivacyPolicyUrlEnglish"] ?? "";
            properties.PrivacyPolicyUrlFrench = ConfigurationManager.AppSettings["PrivacyPolicyUrlFrench"] ?? "";

            properties.CorporateHomepageUrlEnglish = ConfigurationManager.AppSettings["CorporateHomepageUrlEnglish"] ?? "";
            properties.CorporateHomepageUrlFrench = ConfigurationManager.AppSettings["CorporateHomepageUrlFrench"] ?? "";

            return properties;
        }
    }
}