namespace FumeLab.Fume.Core
{
    public interface IPageFactory
    {
        T CreatePage<T>() where T : class, new();
    }
}
