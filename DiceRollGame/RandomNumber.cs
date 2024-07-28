class RandomNumber{
    private readonly Random _random;
    private const int _maxNumber = 6;

    public RandomNumber(Random random){
        _random = random;
    }
    public int newNumber() => _random.Next(1,_maxNumber + 1);
}
