using Infrastructure.Database;
using Application.Interactor;
using Infrastructure.Repository;
using Application.UseCase;
using Zenject;

public class MainSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IDatabase>().To<ScriptableObjectDatabase>().AsSingle();
        Container.Bind<IUserRepository>().To<UserRepository>().AsSingle();
        Container.Bind<IUserLoadUseCase>().To<UserLoadInteractor>().AsSingle();
    }
}