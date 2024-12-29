// chiedo all'utente di inserire il numero del raggio
Console.WriteLine("Inserisci il raggio del cerchio:");
// leggo il raggio e lo converto in un float
float.TryParse(Console.ReadLine(), out float r);
// converto il raggio in double e decimal
double r2 = r;
decimal r3 = (decimal)r;

// calcolo l'area del cerchio con float, double e decimal
float areaFloat = r * r * (float)Math.PI;
double areaDouble = r2 * r2 * Math.PI;
decimal areaDecimal = r3 * r3 * (decimal)Math.PI;

// stampo l'area calcolata con float, double e decimal
Console.WriteLine($"Area calcolata con float: {areaFloat}");
Console.WriteLine($"Area calcolata con double: {areaDouble}");
Console.WriteLine($"Area calcolata con decimal: {areaDecimal}");
