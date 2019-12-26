using Application.Controller;
using Infrastructure.Database;
using Application.Interactor;
using Infrastructure.Repository;
using Application.UseCase;
using Presentation.Presenter;
using Zenject;

public class MainSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IDatabase>().To<ScriptableObjectDatabase>().AsSingle();
        Container.Bind<IUserRepository>().To<UserRepository>().AsSingle();
        Container.Bind<IUserLoadPresenter>().To<UserLoadPresenter>().AsSingle();
        Container.Bind<IUserLoadUseCase>().To<UserLoadInteractor>().AsSingle();
        Container.Bind<UserLoadController>().AsSingle();
    }
}