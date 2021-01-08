﻿using baUHInia.MapLogic.Model;
using baUHInia.Playground.Model;
using System.Windows.Controls;

namespace baUHInia.MapLogic.Manager
{
    public interface IGameMapManager
    {
        Grid GetMapLoadGrid(int userID);
        Grid GetGameLoadGrid(int userID);
        Grid GetMapSaveGrid(int userID);
        Grid GetGameSaveGrid(int userID);
        Map LoadMap(string name);
        Game LoadGame(string name);
        bool SaveMap(ITileBinder tileBinder);
        bool SaveGame(ITileBinder tileBinder);
    }
}