using ConsoleApp_PredictCO;

Console.WriteLine("Прогнозирование Степени использования CO,%");
Console.WriteLine("Фактическое значение степени использования CO,%:");
Console.WriteLine("31.12.2022 0:00: 42,35294");
Console.WriteLine("31.12.2022 8:00: 44,49541");
Console.WriteLine("31.12.2022 16:00: 43,96135");


string[] dateArr = { "31.12.2022 0:00", "31.12.2022 8:00", "31.12.2022 16:00" };

foreach (string i in dateArr)
{
    //Load sample data
    MLModel_PredictCO.ModelInput sampleData = new MLModel_PredictCO.ModelInput()
    {
        Date = i,
    };
    var predictionResult = MLModel_PredictCO.Predict(sampleData);
    Console.WriteLine($"Прогнозируемая Степень использования CO,% на {i}: {predictionResult.Score}");
}

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

