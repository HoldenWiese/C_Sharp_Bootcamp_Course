namespace Step164OutputParamsAndMore
{
    static class AddAndSubtract
    {
        static public void SumAndDiff (out int sum, out int diff, int input)
        {
            sum = input + 5;
            diff = input - 5;
        }
    }
}
