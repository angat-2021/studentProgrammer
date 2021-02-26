namespace SubString
{
    public class MethodCall
    {
        //ask for user input


        //make method that can be called in Main Method in Program class
        public string getFirstBetweenBraces(string userInput)
        {

            //check if the string contains both braces '{' and '}'

            if (userInput.Contains("{") == true && userInput.Contains("}") == true)
            {
                //find the index of first '{'

                int indexFirstLeftCurlyBrace = userInput.IndexOf("{");
                //find the index of first '}'
                int indexFirstRightCurlyBrace = userInput.IndexOf("}");

                //if there is nothing in between the braces.
                if ((indexFirstRightCurlyBrace - indexFirstLeftCurlyBrace) == 1)
                {

                    return "There is nothing in between the braces";
                }
                else
                {
                    string subStringBetweenBraces = userInput.Substring((indexFirstLeftCurlyBrace + 1), (indexFirstRightCurlyBrace - (indexFirstLeftCurlyBrace + 1)));

                    return subStringBetweenBraces;
                }

            }

            //if the string does not contain either one or both of the braces then return empty string
            else
            {

                return " ";

            }


        }

    }
}

