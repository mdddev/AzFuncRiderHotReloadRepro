using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzFuncHotReloadRepro;

public static class EverySecond
{
    [Function(nameof(EverySecond))]
    public static void Run([TimerTrigger("*/1 * * * * *")] TimerInfo timer, FunctionContext ctx)
    {
        // make changes to this when debugging to show in the logs that changes are not applied
        const string message = "Say this or that";
        
        var logger = ctx.GetLogger(nameof(EverySecond));
        logger.LogWarning("Triggered at= {now}; message= {msg}", DateTime.UtcNow, message);
    }
}
