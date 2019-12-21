using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using Presentation.Presenter;
using UniRx;
using UnityEngine;

namespace Presentation.View
{
    public class UsersTableView : MonoBehaviour, IUsersTableView
    {
        [SerializeField] private Transform userCellsRoot;
        [SerializeField] private string userCellPrefabPath = "Prefabs/UserCell";
        
        private IUserCellView[] _userCellViews;
        private List<IUserCellView> _userCells = new List<IUserCellView>();
        private GameObject _userCellPrefab;
        
        private void Awake()
        {
            _userCellPrefab = Resources.Load<GameObject>(userCellPrefabPath);
            
            _userCells = userCellsRoot.GetComponentsInChildren<IUserCellView>().ToList();
        }
        
        public void UpdateUsers(UserModel[] userModels)
        {
            foreach (var userCell in _userCells)
            {
                userCell.Delete();
            }
            _userCells.Clear();
            
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