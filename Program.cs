static int SquareDigits(int n)
{
    string result = n.ToString();
    var intList = result.Select(d => int.Parse(d.ToString())).ToArray();
    for (int i = 0; i < intList.Length; i++)
    {
        double newNum = Math.Pow(intList[i], 2);
        intList[i] = (int)newNum;
    }
    string resultArray = String.Join("", intList);
    return int.Parse(resultArray);
}