using Objects;
using Objects.Geometry;
using Speckle.Automate.Sdk;
using Speckle.Core.Logging;
using Speckle.Core.Models.Extensions;

public static class AutomateFunction
{
  public static async Task Run(
    AutomationContext automationContext,
    FunctionInputs functionInputs
  )
  {
    new Objects.Geometry.Line();
    Speckle.Core.Models.Base latestVersion = await automationContext.ReceiveVersion();
    await automationContext.CreateNewVersionInProject(latestVersion, functionInputs.TargetModelName, "Automated push by CopyPaster");
  }
}
