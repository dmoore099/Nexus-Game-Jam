public class LightWorldCabinet : InteractableObject
{
    public override bool Use(ToolData toolData = null)
    {
        if (toolData == null || toolData.type != ToolData.ToolType.LightCabinetKey)
            return false;
        
        //TODO OPEN cabinet
        
        return true;
    }
}