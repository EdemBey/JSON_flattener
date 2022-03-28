# JSON_flattener
The program is made to flatten JSON objects 
(Read the [Problem Description](https://gist.github.com/doug-ol/0c018e82c095cd3addcb1275999c966f))

### How to run the program
Run code with command: 
```sh-session
dotnet run -- test.json
```

OR

1. Download the code from GitHub 

1. Open in IDE 

1. Run the program (program.cs)

The command line will print out the flattened version of the JSON object

### Test
```sh-session
dotnet test
```

## Setup Notes
-The project is targeting .NET 6.0

-The JSON string is situated inside test.json . File is placed in `"...\JSON_flattener\JSON_flattener\bin\Debug\net6.0\test.json"`

-For Linux users, [install .NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/linux?WT.mc_id=dotnet-35129-website)
