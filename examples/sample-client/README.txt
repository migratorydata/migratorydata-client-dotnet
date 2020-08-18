This is an example of a .NET client application which uses MigratoryData Client API for DotNet.

This .NET example application connects to the MigratoryData server running at 
"demo.migratorydata.com". It subscribes to the subject "/demo/oracle" and
displays the messages received from the MigratoryData server. 

You can edit the source code of this example application to connect to your instance 
of MigratoryData server and subscribe to your subjects. Then, use the build script 
"build.bat" to (re)compile the example application. 

REQUIREMENTS
------------

1. You need to have installed .NET Framework 2.0 or later

2. You need to configure the PATH environment variable so that the C# compiler "csc.exe" is available for use. 
   Alternatively, you can define the absolute path of the C# compiler in the "build.bat" script. 

STRUCTURE
---------

The delivery package of this example has the following structure:

    - "migratorydata-client-dotnet.dll"
        The MigratoryData Client API for DotNet library.

    - "sample-client.cs" :
        The source code of this example application.

    - "build.bat" :
        The build script which is used to compile this example application.
    	                 	                     
    - "README" :
        This file.
        	   
MODIFYING AND REBUILDING THE SOURCE CODE
----------------------------------------

	1. Edit the file "sample-client.cs"
	
	2. Run the "build.bat" script to rebuild the source code.
	
	3. Run the "sample-client.exe" executable produced at Step 2 above to start the example application.
