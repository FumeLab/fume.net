namespace FumeLab.Fume.Core
{
    public interface IQuery<TQuery>
    {
        TQuery Value { get; }
    }
}
