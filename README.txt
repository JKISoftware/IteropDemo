----------------------------------------------------
CONTENTS
----------------------------------------------------
This example includes 
1) LabVIEW demo code including project with an interop build spec
	../src/lv/Robot.Interface.Simulation.Example.lvproj
2) C# example code to exercise the interop 
	../src/c#/BB9C#.Controller/NET_RobotControl.sln
3) A working build of the demo code
	../build/JKIRobotDemo.exe

----------------------------------------------------
REQUIREMENTS
----------------------------------------------------
1) LabVIEW 2015 or later
2) Microsoft Visual Studio 2015 or later (older versions may be compatible)

----------------------------------------------------
SETUP
----------------------------------------------------
1) Apply the .vipc file to install any LabVIEW dependencies
	Package configuration location ..src/lv/InteropDemo.vipc 
2) Modify the interop build location in the Robot.Interface.Simulation.Example project 
   to point to the new c# build location.
   ..\Interop Demo Code\src\c#\BB9.C#.Controller\Controller Application\bin\Debug