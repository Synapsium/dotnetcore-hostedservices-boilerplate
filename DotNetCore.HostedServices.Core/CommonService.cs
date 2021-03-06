namespace DotNetCore.HostedServices.Core
{
    public abstract class CommonService : ICommonService
    {
        abstract public void OnStarted();  
        abstract public void OnStopping();
        abstract public void OnStopped();
    }
}