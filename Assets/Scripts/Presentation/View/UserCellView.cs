using UniRx;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Presentation.View
{
    public class UserCellView : MonoBehaviour
    {
        [SerializeField] private Text nameText;
        [SerializeField] private Toggle isPaidToggle;

        public IObservable<bool> IsPaidToggleChangedAsObservable => isPaidToggle.OnValueChangedAsObservable();

        public void SetNameText(string userName)
        {
            nameText.text = userName;
        }
        
        public void SetIsPaidToggle(bool isPaid)
        {
            isPaidToggle.isOn = isPaid;
        }

        public void Delete()
        {
            Destroy(gameObject);
        }
    }
}