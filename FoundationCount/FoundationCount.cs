using UnityEngine;

public class FoundationCount : Mod
{
    public void Start()
    {
        Debug.Log("Mod FoundationCount has been loaded!");
    }

    [ConsoleCommand(name: "foundations", docs: "Shows the number of foundations.")]
    public static string MyCommand(string[] args)
    {
        var raftBounds = UnityEngine.Object.FindObjectOfType<RaftBounds>();
        return $"{raftBounds.FoundationCount} foundations.";
    }

    public void OnModUnload()
    {
        Debug.Log("Mod FoundationCount has been unloaded!");
    }
}