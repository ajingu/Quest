using Presentation.Presenter;
using UnityEngine;
using UnityEngine.UI;

using UniRx;

namespace Presentation.View
{
    public class UserCellView : MonoBehaviour, IUserCellView
    {
        [SerializeField] private Text nameText;
        [SerializeField] private Toggle isPaidToggle;

        public Text NameText => nameText;
        public Toggle IsPaidToggle => isPaidToggle;

        public void Delete()
        {
            Destroy(gameObject);
        }
    }
}