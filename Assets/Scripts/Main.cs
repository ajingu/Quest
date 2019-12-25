using Presentation.Presenter;
using UnityEngine;
using Zenject;

public class Main : MonoBehaviour
{
    [Inject]
    private UserPresenter _userPresenter;
    
    void Start()
    {
        _userPresenter.LoadUsers();
    }
}
