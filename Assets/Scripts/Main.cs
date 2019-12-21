using Presentation.Presenter;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private UserPresenter userPresenter;
    
    void Start()
    {
        userPresenter.LoadUsers();
    }
}
