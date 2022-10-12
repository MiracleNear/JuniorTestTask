public class ParserUserInputStringToFloatNumber
{
   public bool TryParse(string value, out float result)
   {
      result = default;

      if (value.Contains("."))
      {
         value = value.Replace('.', ',');
      }
      
      float parseResult = float.Parse(value);

      if (parseResult >= 0)
      {
         result = parseResult;
         return true;
      }

      return false;
   }
   
}
