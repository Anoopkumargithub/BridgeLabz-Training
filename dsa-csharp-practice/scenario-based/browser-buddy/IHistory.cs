using System;

interface IHistory
{
    void NewTab();
    void NextTab();
    void PrevTab();
    void CloseTab();
    void ReopenTab();
}