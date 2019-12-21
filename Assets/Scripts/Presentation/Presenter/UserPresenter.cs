using System.Collections.Generic;
using System.Linq;
using Data.DataStore;
using Domain.Repository;
using Domain.UseCase;
using UniRx;
using UnityEngine;

namespace Presentation.Presenter
{
    public class UserPresenter : MonoBehaviour, IUserPresenter
    {
        [SerializeField] private Transform userCellsRoot;
        [SerializeField] private string userCellPrefabPath = "Prefabs/UserCell";
        
        private UserUseCase _userUseCase;
        
        private List<IUserCellView> _userCells = new List<IUserCellView>();
        private GameObject _userCellPrefab;
        
        private void Awake()
        {
            _userUseCase = new UserUseCase(new UserRepository(new UserDataStore()));
            
            _userCellPrefab = Resources.Load<GameObject>(userCellPrefabPath);
            _userCells = userCellsRoot.GetComponentsInChildren<IUserCellView>().ToList();
        }
        
        public void LoadUsers()
        {
            foreach (var userCell in _userCells)
            {
                userCell.Delete();
            }
            _userCells.Clear();
            
            var userModels = _userUseCase.LoadUsers();
            foreach (var userModel in userModels)
            {
                var userCellObject = Instantiate(_userCellPrefab, userCellsRoot);
                var userCell = userCellObject.GetComponent<IUserCellView>();

                userCell.NameText.text = userModel.Name.Value;

                // Model -> View
                userModel.IsPaid
                    .Subscribe(isPaid => userCell.IsPaidToggle.isOn = isPaid)
                    .AddTo(userCellObject);
                
                // View -> Model
                userCell.IsPaidToggle
                    .OnValueChangedAsObservable()
                    .Subscribe(isPaid => userModel.IsPaid.Value = isPaid)
                    .AddTo(userCellObject);
            }
        }
    }
}