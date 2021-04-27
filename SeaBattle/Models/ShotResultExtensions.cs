using System;
using Microsoft.AspNetCore.Mvc;
using SeaBattle.Services;

namespace SeaBattle.Models
{
    public static class ShotResultExtensions
    {
        private static readonly ShotResponse _none = new ShotResponse(false, false, false);
        private static readonly ShotResponse _knock = new ShotResponse(true, false, false);
        private static readonly ShotResponse _destroy = new ShotResponse(true, true, false);
        private static readonly ShotResponse _end = new ShotResponse(true, true, true);
        public static ActionResult<ShotResponse> ToActionResult(this ShotResult result)
        {

            return result switch
            {
                ShotResult.None => _none,
                ShotResult.Knock => _knock,
                ShotResult.Destroy => _destroy,
                ShotResult.End => _end,
                _ => throw new NotImplementedException() //TODO
            };
        }
    }
}