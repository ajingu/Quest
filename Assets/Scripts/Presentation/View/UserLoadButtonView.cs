using UniRx;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Presentation.View
{
    public class UserLoadButtonView : MonoBehaviour
    {
        [SerializeField] private Button userLoadButton;

        public IObservable<Unit> OnClickAsObservable => userLoadButton.OnClickAsObservable();
    }
}

