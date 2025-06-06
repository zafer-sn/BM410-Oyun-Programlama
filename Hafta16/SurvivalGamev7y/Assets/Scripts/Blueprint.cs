using UnityEngine;

public class Blueprint
{
    public string itemName;
    public string requirement1Name;
    public string requirement2Name;
    public int requirement1Amount;
    public int requirement2Amount;
    public int requirementAmount;
    public Blueprint
   (string itemName,
    string requirement1Name,
    string requirement2Name,
    int requirement1Amount,
    int requirement2Amount,
    int requirementAmount)
    {
        this.itemName = itemName;
        this.requirement1Name = requirement1Name;
        this.requirement2Name = requirement2Name;
        this.requirement1Amount = requirement1Amount;
        this.requirement2Amount = requirement2Amount;
        this.requirementAmount = requirementAmount;
    }
}
