using System.Collections.Generic;

public class LightWorldBearCat : InteractableObject
{
    public override bool Use(List<ToolData> toolData = null)
    {
        if (!HasEquipped(toolData, ToolData.ToolType.Scissor))
            return false;
        
        //TODO OPEN cabinet
        
        return true;
    }
}