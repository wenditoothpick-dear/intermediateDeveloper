namespace banking;
public class Bank : MediumClass
{
    public string FirstName{get; set; } = default!;
     public string LastName {get; set;} = default!;
    //  public decimal Balance {get; set;}
     public string MiddleName {get; set;} = default!;
    public string Password {get; set;} = default!;
    public string Year {get; set;} = default!;
    public string Gender {get; set;} = default!;
    public string Occupation {get; set;} = default!;
    public int Id {get; set;}
    public DateTime DueDate {get; set;}
}