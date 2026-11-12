namespace assigment1.route;

public class Book
{
    public string? title;
    public int pages;
    public override string ToString()//عملت اوفر رايد علي اساس ان الطباعه بتكون اصلا تو استرنج و التو استرنج من غير اوفر رايد بتطلع اسم الكلاس
    {
        return $"title:{title},page:{pages}";
    }
}