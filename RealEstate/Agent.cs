namespace RealEstate;

public class Agent : User
{
    public List<Ad> Ads { get; private set; }
    
    public Agent(string name, string contact) : base(name, contact)
    {
        Ads = new List<Ad>();
    }

    public void AddAd(Ad ad)
    {
        Ads.Add(ad);
    }

    public void PostAllAds()
    {
        foreach (var ad in Ads)
        {
            PostAd(ad);
        }
    }

    public void PostAd(Ad ad)
    {
        Console.WriteLine(ad.ToString());
    }
    
}