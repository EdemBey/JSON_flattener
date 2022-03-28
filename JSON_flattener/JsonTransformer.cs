using Newtonsoft.Json.Linq;

namespace JSON_flattener
{
    public static class JsonTransformer
    {
        public static Dictionary<string, string> GetPropertiesFromJson(string jsonFile)
        {
            JObject jobject;
            string jsonMessage;

            try
            {
                jsonMessage = File.ReadAllText(jsonFile);
            }
            catch
            {
                throw new FileNotFoundException("File not found. Check the filename");
            }

            if (jsonMessage.Length == 0)
                throw new ArgumentOutOfRangeException("jsonFile", jsonMessage, "Json file is empty");

            try
            {
                jobject = JObject.Parse(jsonMessage); //parse to JObject the JSON string
            }
            catch 
            {
                throw new Exception("Couldn't parse object, format of JSON is wrong");
            }


            return jobject.Descendants() //get the children
                                        //check if it has or not elements
                                        //using Any instead of Count to save on performance
                .Where(j => !j.Children().Any())
                .Aggregate(
                    new Dictionary<string, string>(),
                    (props, jtoken) =>   //(result,item) where jtoken is the value in the dictionary (type JToken, basically can be any type)
                    {
                        props.Add(jtoken.Path, jtoken.ToString()); //jtoken.Path() - the key
                        return props;
                    });
        }
    }
}
