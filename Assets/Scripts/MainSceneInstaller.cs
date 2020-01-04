using Infrastructure.Data;
using Application.Interactor;
using Infrastructure.Repository;
using Application.UseCase;
using Zenject;

public class MainSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IData>().To<ScriptableObjectData>().AsSingle();
        //Container.Bind<IData>().To<HerokuData>().AsSingle();
        Container.Bind<IUserRepository>().To<UserRepository>().AsSingle();
        Container.Bind<IUserLoadUseCase>().To<UserLoadInteractor>().AsSingle();
    }
}