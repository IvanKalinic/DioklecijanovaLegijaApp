using DioklecijanovaLegija.Models;

namespace DioklecijanovaLegija.ViewModels
{
    public class EventFormViewModel
    {
        public Event Event { get; set; }
        public string Title
        {
            get
            {
                if (Event != null && Event.Id != 0)
                    return "Edit event";

                return "New event";
            }
        }
    }
}
