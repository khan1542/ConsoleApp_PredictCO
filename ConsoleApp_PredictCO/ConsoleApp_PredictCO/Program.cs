using ConsoleApp_PredictCO;

Console.WriteLine("Прогнозирование Степени использования CO,%");
Console.WriteLine("Введите ID параметра");
string parameterid = Console.ReadLine();
Console.WriteLine("Введите дату в формате ДД.ММ.ГГГГ");
string data = Console.ReadLine();

//Load sample data
MLModel_PredictCO.ModelInput sampleData = new MLModel_PredictCO.ModelInput()
{
    ParameterId = Convert.ToInt32(parameterid),
    Date = data,
};

// Make a single prediction on the sample data and print results
var predictionResult = MLModel_PredictCO.Predict(sampleData);

Console.WriteLine($"\n\nПрогнозируемая Степень использования CO,%: {predictionResult.Score}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

