namespace CoffeeSoft.App.General
{
    public class ReportConfig
    {
        private string reportName;

        private string reportId;

        public string ReportName
        {
            get
            {
                return this.reportName;
            }
            set
            {
                this.reportName = value;
            }
        }

        public string ReportId
        {
            get
            {
                return this.reportId;
            }
            set
            {
                this.reportId = value;
            }
        }
    }
}
