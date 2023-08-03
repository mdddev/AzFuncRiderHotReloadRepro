# Repro: `Hot Reload` not working for NET7 Azure Functions project

Rider does not update the code of Azure Functions project when `Hot Reload` is used. To reflect any changes the process must be stopped and started again. This defeats the purpose of the hot reload functionality.

According to the [**documentation**](https://www.jetbrains.com/help/rider/Hot_Reload.html) this should work.

## Steps to reproduce
1. Run the project in Rider
2. Edit message text in line 12 of timer-triggered function [EverySecond.cs](./EverySecond.cs)
3. Observe logs; function logs every second

## Expected behavior
Log message should be updated with new text.

## Actual behavior
Log message is not updated.

## Environment
```text
JetBrains Rider 2023.2
Build #RD-232.8660.212, built on July 31, 2023
Licensed to Mme
Subscription is active until some time
Runtime version: 17.0.7+7-b1000.6 amd64
VM: OpenJDK 64-Bit Server VM by JetBrains s.r.o.
Windows 10.0
.NET Core v7.0.7 x64 (Server GC)
GC: G1 Young Generation, G1 Old Generation
Memory: 4058M
Cores: 8
Registry:
ide.experimental.ui=true
vcs.empty.toolwindow.show=false
database.show.search.tab=false
ide.new.project.model.index.case.sensitivity=true

Non-Bundled Plugins:
com.github.copilot (1.2.16.2847)
me.seclerp.rider.plugins.efcore (232.0.0-rc1)
com.intellij.bigdatatools.core (232.8660.206)
com.intellij.bigdatatools.binary.files (232.8660.206)
com.intellij.bigdatatools.rfs (232.8660.206)
com.intellij.resharper.azure (3.50.0.1639-2023.2)
```
