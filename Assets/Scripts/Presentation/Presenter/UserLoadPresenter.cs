using System.Threading.Tasks;
using Application.UseCase;
using Presentation.View;
using UniRx;
using UnityEngine;
using Zenject;

namespace Presentation.Presenter
{
    public class UserLoadPresenter : MonoBehaviour, IUserLoadPresenter
    {
        [Inject] private IUserLoadUseCase _userLoadUseCase;
        
        [SerializeField] private Transform userCellsRoot;
        private GameObject _userCellPrefab;

        [SerializeField] private UserLoadButtonView userLoadButtonView;
        
        [Inject]
        public void Construct(IUserLoadUseCase userLoadUseCase)
        {
            _userLoadUseCase = userLoadUseCase;
        }
        
        private void Awake()
        {
            _userCellPrefab = Resources.Load<GameObject>("Prefabs/UserCell");
            
            
            userLoadButtonView.OnClickAsObservable
                .Subscribe(_ =>
                {
                    LoadUsers();
                })
                .AddTo(userLoadButtonView.gameObject);
        }

        public async void LoadUsers()
        {
            var userCells = userCellsRoot.GetComponentsInChildren<UserCellView>();
            foreach (var userCell in userCells)
            {
                userCell.Delete();
            }

            var users = await _userLoadUseCase.LoadUsers();
            
            foreach (var user in users)
            {
                var userCellObject = Instantiate(_userCellPrefab, userCellsRoot);
                var userCell = userCellObject.GetComponent<UserCellView>();

                userCell.SetNameText(user.Name.Value);

                // Model -> View
                user.IsPaid
                    .Subscribe(isPaid => userCell.SetIsPaidToggle(isPaid))
                    .AddTo(userCellObject);
                
                // View -> Model
                userCell.IsPaidToggleChangedAsObservable
                    .Subscribe(isPaid => user.IsPaid.Value = isPaid)
                    .AddTo(userCellObject);
            }
        }
    }
}