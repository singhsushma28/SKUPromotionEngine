public class Service: IService
{
public void GetPriceById(SKUUnits units)
{
    units.Price = units.UnitId switch
  {
    "A" => 50m,
    "B" => 30m,
    "C" => 20m,
    "D" => 2015m
  };
}

    int priceOfB = 30;
    int counterOfC = 0;
    int priceOfC = 20;
    int counterOfD = 0;
    int priceOfD = 15;

    foreach (var unit in units)
    {
        switch (unit.UnitId)
        {
            case "A":
                counterOfA += 1;
                break;
            case "B":
                counterOfB += 1;
                break;
            case "C":
                counterOfC += 1;
                break;
            case "D":
                counterOfD += 1;
                break;
        }
    }
    int totalPriceOfA = (counterOfA / 3) * 130 + (counterOfA % 3 * priceOfA);
    int totalPriceOfB = (counterOfB / 2) * 45 + (counterOfB % 2 * priceOfB);
    int totalPriceOfC = (counterOfC * priceOfC);
    int totalPriceOfD = (counterOfD * priceOfD);
    return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD;
}

}
