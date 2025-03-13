




class IsValid
{
    public static bool CheckIfInt(string input, out int result)
    {
        return int.TryParse(input, out result);

    }
}


