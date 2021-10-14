using Aquilent.Navy.Web.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Aquilent.Navy.WebApp.Models
{
    public class WorkflowModel
    {
        public WorkflowModel()
        {
            // Empty Constructor
        }

        public string PackageStatus { get; set; }

        public string PurchaseRequestLine1 { get; set; }
        public string PrError { get; set; }

        public string DraftSdLine1 { get; set; }
        public string DraftSdLine2 { get; set; }
        public string DraftSdError { get; set; }

        public string ReleasedSdLine1 { get; set; }
        public string ReleasedSdLine2 { get; set; }
        public string ReleasedSdLine3 { get; set; }
        public string ReleasedSdError { get; set; }

        public string DraftToLine1 { get; set; }
        public string DraftToLine2 { get; set; }
        public string DraftToLine3 { get; set; }
        public string DraftToLine4 { get; set; }
        public string DraftToLine5 { get; set; }
        public string DraftToError { get; set; }

        public string ExecutedToLine1 { get; set; }
        public string ExecutedToLine2 { get; set; }
        public string ExecutedToLine3 { get; set; }
        public string ExecutedToLine4 { get; set; }
        public string ExecutedToError { get; set; }

    }
}