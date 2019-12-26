using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using Presentation.Presenter;
using UniRx;
using UnityEngine;

namespace Presentation.View
{
    public class UserTableView : MonoBehaviour
    {
        [SerializeField] private Transform userCellsRoot;
        
        private List<IUserCellView> _userCells = new List<IUserCellView>();
        private GameObject _userCellPrefab;
        
        private void Awake()
        {
            _userCellPrefab = Resources.Load<GameObject>("Prefabs/UserCell");
            _userCells = userCellsRoot.GetComponentsInChildren<IUserCellView>().ToList();
        }

        public void LoadUsers(IEnumerable<User> users)
        {
            foreach (var userCell in _userCells)
            {
                userCell.Delete();
            }
            _userCells.Clear();
            
            foreach (var userModel in users)
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