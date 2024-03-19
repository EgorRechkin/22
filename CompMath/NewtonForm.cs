namespace ComputationalMathConsole;

static class NewtonForm
{
    public static float findDividedDifference(float[] xValues, float[] functionValues)
    {
        if (xValues.Length > 2)
        {
            float[] xFirstArray = new float[xValues.Length - 1];
            float[] xSecondArray = new float[xValues.Length - 1];
            float[] yFirstArray = new float[xValues.Length - 1];
            float[] ySecondArray = new float[xValues.Length - 1];
            for (int i = 0; i < xValues.Length - 1; i++)
            {
                xFirstArray[i] = xValues[i];
                yFirstArray[i] = functionValues[i];
            }

            for (int i = 1; i < xValues.Length; i++)
            {
                xSecondArray[i - 1] = xValues[i];
                ySecondArray[i-1] = functionValues[i];
            }
            float ans = (findDividedDifference(xFirstArray, yFirstArray) -
                         findDividedDifference(xSecondArray, ySecondArray)) /
                        (xValues[0] - xValues.Last());
            return ans;
        }
            
        float ans1 = (functionValues[0] - functionValues[1]) / (xValues[0] - xValues[1]);
        return ans1;
    }

    public static float MainFunction(float x, float[] xValues, float[] functionValues)
    {
        float answer = functionValues[0];
        float mult = 1;

        for (int i = 1; i < xValues.Length; i++)
        {
            mult *= x - xValues[i - 1];
            float[] newArrX = new float[i + 1];
            float[] newArrY = new float[i + 1];
            for (int j = 0; j <= i; j++)
            {
                newArrX[j] = xValues[j];
                newArrY[j] = functionValues[j];
            }

            answer += mult * findDividedDifference(newArrX, newArrY);
        }

        return answer;
    }
}