class CarMuffler
{
    //Марка авто
    public string CarBrand { get; set; }

    //Год выпуска
    public int YearRelease { get; set; }

    //Стоимость глушителя
    public decimal Cost { get; set; }

    static IEnumerable<CarMuffler> GetMuffler(IEnumerable<CarMuffler> mufflers)
    {
        // реализовать логику
        return mufflers.Where(muffler => muffler.CarBrand == "Nissan Terrano 2" && muffler.YearRelease == 2007 && muffler.Cost <= 18000);
    }
}