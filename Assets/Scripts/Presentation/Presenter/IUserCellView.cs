using UnityEngine.UI;

namespace Presentation.Presenter
{
    public interface IUserCellView
    {
        Text NameText { get; }
        Toggle IsPaidToggle { get; }

        void Delete();
    }
}
