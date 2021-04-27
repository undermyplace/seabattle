using System.Collections.Generic;

namespace SeaBattle.Services
{
    public interface ICoordParser
    {
        Coord ParseCoord(string coord);

        IEnumerable<Ship> ParseShips(string coords);
    }
}