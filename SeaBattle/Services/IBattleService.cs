namespace SeaBattle.Services
{
    public interface IBattleService
    {
        IBattle GetCurrentBattle();

        IBattle CreateBattle(int range);
    }
}