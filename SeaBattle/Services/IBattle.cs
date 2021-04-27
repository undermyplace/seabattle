using System.Collections.Generic;

namespace SeaBattle.Services
{
    public interface IBattle
    {
        int Range { get; }

        void SetShips(IEnumerable<Ship> ships);

        ShotResult Shot(Coord coord);

        BattleInfo GetInfo();
    }
}