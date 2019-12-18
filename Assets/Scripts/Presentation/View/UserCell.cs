using UnityEngine;
using UnityEngine.UI;

using Domain.Model;

namespace Presentation.View
{
    public class UserCell : MonoBehaviour
    {
        [SerializeField] private Text nameText;
        [SerializeField] private Text moneyText;

        public void UpdateCell(UserModel userModel)
        {
            nameText.text = userModel.Name;
            moneyText.text = userModel.Money.ToString();
        }
    }
}