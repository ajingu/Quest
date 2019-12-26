using Application.Controller;
using UnityEngine;
using Zenject;

public class Main : MonoBehaviour
{
    [Inject] private UserLoadController _userLoadController;

    private void Start()
    {
        // var _userLoadController = new UserLoadController(); これではフィールドインジェクションされない
        // DIContainerはStart()呼ばれる前にInstallBindingsで登録してる. 動的な生成では自動的にinjectionされない
        _userLoadController.LoadUsers();
    }
}
