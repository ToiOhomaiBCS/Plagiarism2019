using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomerManagementApplication
{
  public partial class CustomerManagementApplication : Form
  {
    //Declaringa List<T> of Customer Type named CustomerDB 
    List<Customer> CustomerDB;

    public CustomerManagementApplication()
    {
      InitializeComponent();

      //LoadDB method, which adds 4 new customer objects to CustomerDB List
      LoadDB();
    }

    #region Methods

    private void LoadDB()
    {
      //Initializing CustomerDB with 4 customer objects
      CustomerDB = new List<Customer>
      {
          new Customer("Jim", "Smith", "346-2514"),
          new Customer("Jo", "Baker", "346-1263"),
          new Customer("Aimee", "Ellery", "346-3658"),
          new Customer("Sam", "Herewani", "346-9898"),
      };
    }

    private void ClearTextBoxes()
    {
      //This method clears the First Name, Last Name & Phone TextBoxe's value
      FirstNameTextBox.Text = string.Empty;
      LastNameTextBox.Text = string.Empty;
      PhoneTextBox.Text = string.Empty;
    }

    private void ClearDisplay()
    {
      //This method clears the CustomerDetailsListBox
      CustomerDetailsListBox.DataSource = null;
      CustomerDetailsListBox.Items.Clear();
    }

    private void DisplayCustomers()
    {
      //Declaring & Initializing an object of type List<string> type
      var customerDetails = new List<string>();

      //Using foreach loop to cycle the elements of CustomerDB List 
      foreach (var customer in CustomerDB)
      {
        //Fetching customer details by calling the GetCustomer method
        //Then, adding it to the customerDetails list
        customerDetails.Add(customer.GetCustomer());
      }

      //Setting the DataSource of ListBox
      CustomerDetailsListBox.DataSource = customerDetails;

      //Setting the SelectedIndex of ListBox to -1, so that when it displays the
      //value, a default value is not selected in the ListBox
      CustomerDetailsListBox.SelectedIndex = -1;
    }

    #endregion

    #region Buttons

    private void SearchButton_Click(object sender, System.EventArgs e)
    {
      //Storing the value of SearchTextBox
      var searchText = SearchTextBox.Text;

      //Validating SearchTextBox value
      if (string.IsNullOrEmpty(searchText))
      {
        //Displaying MessageBox, as the input in SearchTextBox is not valid
        ShowMessageBox("You must enter a customer name", MessageBoxType.Error);
        //Setting focus back to SearchTextBox
        SearchTextBox.Focus();
      }
      else
      {
        //Clearing SearchTextBox
        SearchTextBox.Text = string.Empty;

        //Calling ClearDisplay method to clear all items from ListBox
        ClearDisplay();

        //Finding the users based on the SearchTextBox input
        //Using LINQ's WHERE method to find the customers
        //While comparing Names, setting the values to Uppercase for ignoring cases
        var searchedCustomers = CustomerDB
          .Where(x => x.FName.ToUpper().Contains(searchText.ToUpper()) || x.LName.ToUpper().Contains(searchText.ToUpper()));

        //Checking if there is any customers or not based on the SearchTextBox Input
        if (searchedCustomers == null || searchedCustomers.Count() <= 0)
        {
          //Showing MessageBox as no customer was found
          ShowMessageBox("Customer not found, please try again", MessageBoxType.Error);
          //Setting focus back to SearchTextBox
          SearchTextBox.Focus();
          //Breaking the execution by using return, so that code doesn't execute any further
          return;
        }
        //If the execution reaches here, that means some customers was found
        //Declaring & Initializing an object of type List<string> type
        var customerDetails = new List<string>();

        //Using foreach loop to cycle the elements of searchedCustomers List 
        foreach (var customer in searchedCustomers)
        {
          //Fetching customer details by calling the GetCustomer method
          //Then, adding it to the customerDetails list
          customerDetails.Add(customer.GetCustomer());
        }

        //Setting the DataSource of ListBox
        CustomerDetailsListBox.DataSource = customerDetails;

        //Setting the SelectedIndex of ListBox to -1, so that when it displays the
        //value, a default value is not selected in the ListBox
        CustomerDetailsListBox.SelectedIndex = -1;
      }
    }

    private void ListCustomersButton_Click(object sender, System.EventArgs e)
    {
      //Calling ClearBoxes method to clear textboxes
      ClearTextBoxes();
      //Calling DisplayCustomers method to display Customer Details in ListBox
      DisplayCustomers();
    }

    private void ClearListButton_Click(object sender, System.EventArgs e)
    {
      //Calling ClearBoxes method to clear textboxes
      ClearDisplay();
      //Setting focus back to SearchTextBox
      SearchTextBox.Focus();
      //Enabling the ADD Button
      AddButton.Enabled = true;
    }

    private void UpdateButton_Click(object sender, System.EventArgs e)
    {
      //Finding the selected Index of the ListBox
      var selectedIndex = CustomerDetailsListBox.SelectedIndex;

      //Validating if any item of ListBox is selected or not
      if (selectedIndex < 0)
      {
        //Showing MessageBox, as user hasn't selected any item from ListBox
        ShowMessageBox("Please select a customer to update", MessageBoxType.Error);
        //Calling ClearDisplay method to clear all items from ListBox
        ClearDisplay();
        //Displaying Customers in the ListBox
        DisplayCustomers();
        //Breaking the execution by using return, so that code doesn't execute any further
        return;
      }

      //Fetching the First Name, Last Name & Phone values from TextBoxes
      var firstName = FirstNameTextBox.Text;
      var lastName = LastNameTextBox.Text;
      var phone = PhoneTextBox.Text;

      //Validating if All TextBoxes are filled or not by Calling a Custom Method that validates the data
      var isValuesFilled = CheckIfAllTextBoxesAreFilled(firstName, lastName, phone);
      if (!isValuesFilled)
      {
        //Showing Message Box, as the data user entered is not valid
        ShowMessageBox("All textboxes must be filled to continue", MessageBoxType.Error);
        //Breaking the execution by using return, so that code doesn't execute any further
        return;
      }

      //Fetching FirstName of the Customer by the SelectedIndex in the ListBox
      //This Custom method receives SelectedIndex as input, and returns FirstName, LastName & Phone values
      //Here, we are only interested with FirstName so using decontruct of tuple to get that value and
      //discarding other values by using _ operator
      var (firstNameOfCustomertoBeUpdated, _, _) = GetCustomerBySelectedIndex(selectedIndex);

      //Finding the Customer from the CustomerDB list to be updated
      var customerToBeUpdated = CustomerDB.First(x => x.FName.ToUpper().Equals(firstNameOfCustomertoBeUpdated.ToUpper()));
      //Setting respective values for update
      customerToBeUpdated.FName = firstName;
      customerToBeUpdated.LName = lastName;
      customerToBeUpdated.Phone = phone;

      //Calling ClearBoxes method to clear textboxes
      ClearTextBoxes();
      //Calling ClearDisplay method to clear all items from ListBox
      ClearDisplay();
      //Displaying Customers in the ListBox
      DisplayCustomers();
      //Showing Message Box for displaying updated message
      ShowMessageBox("Customer details updated", MessageBoxType.Information);
      //Setting ADD button to enabled
      AddButton.Enabled = true;
    }

    private void AddButton_Click(object sender, System.EventArgs e)
    {
      //Fetching the First Name, Last Name & Phone values from TextBoxes
      var firstName = FirstNameTextBox.Text;
      var lastName = LastNameTextBox.Text;
      var phone = PhoneTextBox.Text;

      //Validating if All TextBoxes are filled or not by Calling a Custom Method that validates the data
      var isValuesFilled = CheckIfAllTextBoxesAreFilled(firstName, lastName, phone);
      if (!isValuesFilled)
      {
        //Showing Message Box, as the data user entered is not valid
        ShowMessageBox("All textboxes must be filled to continue", MessageBoxType.Error);
        //Breaking the execution by using return, so that code doesn't execute any further
        return;
      }
      //Adding the Customer to CustomerDB list
      CustomerDB.Add(new Customer(firstName, lastName, phone));

      //Calling ClearBoxes method to clear textboxes
      ClearTextBoxes();
      //Calling ClearDisplay method to clear all items from ListBox
      ClearDisplay();
      //Displaying Customers in the ListBox
      DisplayCustomers();
      //Showing Message Box for displaying saved message
      ShowMessageBox("New customer has been added", MessageBoxType.Information);
    }

    private void DeleteButton_Click(object sender, System.EventArgs e)
    {
      //Finding the selected Index of the ListBox
      var selectedIndex = CustomerDetailsListBox.SelectedIndex;
      //Validating if any item of ListBox is selected or not
      if (selectedIndex < 0)
      {
        //Showing MessageBox, as user hasn't selected any item from ListBox
        ShowMessageBox("Please select a customer to delete", MessageBoxType.Error);
        //Calling ClearDisplay method to clear all items from ListBox
        ClearDisplay();
        //Displaying Customers in the ListBox
        DisplayCustomers();
        //Breaking the execution by using return, so that code doesn't execute any further
        return;
      }
      //Showing a MessageBox to confirm that User really wants to remove data
      var dialogResult = MessageBox.Show("Are you sure?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
      //Validating User Choice
      if (dialogResult == DialogResult.Yes)
      {
        //Fetching FirstName of the Customer by the SelectedIndex in the ListBox
        //This Custom method receives SelectedIndex as input, and returns FirstName, LastName & Phone values
        //Here, we are only interested with FirstName so using decontruct of tuple to get that value and
        //discarding other values by using _ operator
        var (firstNameOfCustomertoBeUpdated, _, _) = GetCustomerBySelectedIndex(selectedIndex);

        //Finding the Customer from the CustomerDB list to be deleted
        var customerToBeDeleted = CustomerDB.First(x => x.FName.ToUpper().Equals(firstNameOfCustomertoBeUpdated.ToUpper()));
        //Remove the element from CustomerDB list
        CustomerDB.Remove(customerToBeDeleted);

        //Calling ClearBoxes method to clear textboxes
        ClearTextBoxes();
        //Calling ClearDisplay method to clear all items from ListBox
        ClearDisplay();
        //Displaying Customers in the ListBox
        DisplayCustomers();
        //Showing Message Box for displaying updated message
        ShowMessageBox("This customer has been deleted", MessageBoxType.Information);
        //Setting ADD button to enabled
        AddButton.Enabled = true;
      }
      else
      {
        //Showing Message Box for cancellation of Operations as User chose not to delete data
        ShowMessageBox("Operation cancelled", MessageBoxType.Information);
      }
    }

    private void ClearButton_Click(object sender, System.EventArgs e)
    {
      //Calling ClearBoxes method to clear textboxes
      ClearTextBoxes();
      //Setting focus back to SearchTextBox
      FirstNameTextBox.Focus();
      //Setting ADD button to enabled
      AddButton.Enabled = true;
    }

    #endregion

    #region Other Events

    private void CustomerDetailsListBox_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      //Disabling the ADD Button if the SelectedIndex of ListBox is Greater than -1
      //This is because while displaying the values in ListBox, we have set the SelectedIndex to be -1

      //Finding Selected Index
      var selectedIndex = CustomerDetailsListBox.SelectedIndex;
      //Validating the Selected Index
      if (selectedIndex > -1)
      {
        //If code execution reaches here, that means some index is selected in the ListBox
        //So, disabling the ADD button
        AddButton.Enabled = false;

        //Fetching FirstName, LastName & Phone of the Customer by the SelectedIndex in the ListBox
        //This Custom method receives SelectedIndex as input, and returns FirstName, LastName & Phone values
        //Here, we are interested in all values of Customer i.e. FirstName, LastName & Phone
        //so using decontruct of tuple to get those values
        var (firstName, lastName, phone) = GetCustomerBySelectedIndex(selectedIndex);

        //Setting values to TextBoxes
        FirstNameTextBox.Text = firstName;
        LastNameTextBox.Text = lastName;
        PhoneTextBox.Text = phone;
      }
    }

    #endregion

    #region Custom Utility Methods

    //Instead repating Message.Show everwhere, created a custom method that takes what message to display and,
    //the type of MessageBox to show. Here, I have declared an enum of MessageBoxType with two values i.e, Error and Information
    private void ShowMessageBox(string message, MessageBoxType type)
    {
      //Using switch case to determine the type
      switch (type)
      {
        case MessageBoxType.Error:
          //Showing Message Box by setting the Message Box Header to "Error" & assigning message that came in parameter
          //Showing only one button i.e. OK
          MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
          break;
        case MessageBoxType.Information:
          //Showing Message Box by setting the Message Box Header to "Information" & assigning message that came in parameter
          //Showing only one button i.e. OK
          MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
          break;
      }
    }

    //The functionality of this method was required multiple times, so created a custom method
    //that can be called my methods so that the code is clean & not repeated
    //This returns a boolean value, true if data is valid else false
    private bool CheckIfAllTextBoxesAreFilled(string firstName, string lastName, string phone)
    {
      //Validating data
      if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone))
      {
        //Returning false as data is not valid
        return false;
      }
      //Data valid so returning true
      return true;
    }

    //The functionality of this method was also required multiple times, so created a custom method to get rid of
    //code repetition. This method uses returns a Tuple of 3 string values
    private (string firstName, string lastName, string phone) GetCustomerBySelectedIndex(int selectedIndex)
    {
      //Fetching selected item form the selected index
      var selectedItem = CustomerDetailsListBox.Items[selectedIndex].ToString();
      //Splitting the selected item by tab space
      var splittedItems = selectedItem.Split('\t');
      //Returning the the splitted values
      return (splittedItems[0], splittedItems[1], splittedItems[2]);
    }


        #endregion

        private void CustomerManagementApplication_Load(object sender, System.EventArgs e)
        {

        }
    }
}
