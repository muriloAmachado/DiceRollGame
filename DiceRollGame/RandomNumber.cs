class RandomNumber{
    private readonly Random _random;

    public RandomNumber(Random random){
        _random = random;
    }
    public int newNumber() => _random.Next(1,7);
}
