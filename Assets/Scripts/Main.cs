using Presentation.Presenter;
using UnityEngine;
using Zenject;

public class Main : MonoBehaviour
{
    [Inject]
    private UserLoadPresenter _userLoadPresenter;
    
    void Start()
    {
        _userLoadPresenter.LoadUsers();
    }
}
