using System.Collections.Generic;
using System.Linq;
using Application.UseCase;
using UniRx;
using UnityEngine;
using Zenject;

namespace Presentation.Presenter
{
    public class UserLoadPresenter : MonoBehaviour, IUserLoadPresenter
    {
        [SerializeField] private Transform userCellsRoot;
        [SerializeField] private string userCellPrefabPath = "Prefabs/UserCell";
        
        private IUserLoadUseCase _userLoadUseCase;
        
        private List<IUserCellView> _userCells = new List<IUserCellView>();
        private GameObject _userCellPrefab;
        
        private void Awake()
        {
            _userCellPrefab = Resources.Load<GameObject>(userCellPrefabPath);
            _userCells = userCellsRoot.GetComponentsInChildren<IUserCellView>().ToList();
        }
        
        [Inject]
        public void Construct(IUserLoadUseCase userLoadUseCase)
        {
            _userLoadUseCase = userLoadUseCase;
        }
        
        public void LoadUsers()
        {
            foreach (var userCell in _userCells)
            {
                userCell.Delete();
            }
            _userCells.Clear();
            
            var userModels = _userLoadUseCase.Load();
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