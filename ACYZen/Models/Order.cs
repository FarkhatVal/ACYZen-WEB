namespace ACYZenWEBAPP.Models;

public class Order
{
    public int OrderId { get; set; }
    public string User { get; set; } // имя фамилия покупателя
    public string Address { get; set; } // адрес покупателя
    public string ContactPhone { get; set; } // контактный телефон покупателя
 
    public int ActionYaZenId { get; set; } // ссылка на связанную модель ActionYaZen
    public ActionYaZen ActionYaZen { get; set; } 
}