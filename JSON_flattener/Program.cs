// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using JSON_flattener;

var json = args[0] != "" ? args[0] : "test.json";
var d = JsonTransformer.GetPropertiesFromJson(json);

Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(d, new JsonSerializerOptions { WriteIndented = true }));
