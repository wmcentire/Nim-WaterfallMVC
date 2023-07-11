namespace Nim_WaterfallMVC.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; } // Property to hold the request ID

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); // Property that determines if the request ID should be shown

        // The ErrorViewModel class represents the model for the error view. It contains the following:

        // RequestId: A nullable string property that holds the request ID for the error.
        // This property is used to track and display the unique identifier of the error.

        // ShowRequestId: A boolean property that determines if the request ID should be shown.
        // It returns true if the RequestId is not null or empty, indicating that the request ID should be displayed.
        // Otherwise, it returns false, indicating that the request ID should not be shown.

        // This class is typically used in conjunction with the Error action method in a controller to pass error information to the error view.
    }
}
