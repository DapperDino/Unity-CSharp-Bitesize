namespace DapperDino.Tutorials.Cooldowns
{
    public interface IHasCooldown
    {
        int Id { get; }
        float CooldownDuration { get; }
    }
}
