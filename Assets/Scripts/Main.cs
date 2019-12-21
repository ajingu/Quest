using Data.DataStore;
using Domain.Repository;
using Domain.UseCase;
using Presentation.Presenter;
using Presentation.View;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private UsersTableView _usersTableView;
    
    void Start()
    {
        var userPresenter = new UserPresenter(new UserUseCase(new UserRepository(new UserDataStore())), _usersTableView);
        userPresenter.LoadUsers();
    }
}
