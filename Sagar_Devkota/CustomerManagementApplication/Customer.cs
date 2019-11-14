namespace CustomerManagementApplication
{
  class Customer
  {
    //Auto-implemented properties
    public string FName { get; set; }
    public string LName { get; set; }
    public string Phone { get; set; }

    //Parameterised Constructor to Initialize Auto-Implemented Properties
    //i.e, FirstName, LastName & Phone
    public Customer(string fn, string ln, string ph)
    {
      FName = fn;
      LName = ln;
      Phone = ph;
    }

    // returns Customer Detail i.e, FirstName, LastName & Phone with tab spaces
    public string GetCustomer()
    {
      return $"{FName}\t{LName}\t{Phone}";
    }
  }
}
