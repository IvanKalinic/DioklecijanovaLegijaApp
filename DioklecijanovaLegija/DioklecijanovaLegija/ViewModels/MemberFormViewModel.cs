using DioklecijanovaLegija.Models;
using System.Collections.Generic;

namespace DioklecijanovaLegija.ViewModels
{
    public class MemberFormViewModel
    {
        public IEnumerable<SoldierType> SoldierTypes { get; set; }
        public Member Member { get; set; }
        public string Title
        {
            get
            {
                if (Member != null && Member.Id != 0)
                    return "Edit member";
                return "New member";
            }
        }
    }
}
