# JoesLawn
Conestoga College - PROG8010 - Midterm Q2

Joe's Lawn Service wants you to build an application to output a receipt file for appointments. To do this, you will create an application that has the following features:
a series of input fields to collect the following information: customer name - text field
customer address - text fields for street, city and postal code, ListBox/ComboBox for province.
customer phone - text field (assume 10 digit – only allow digits)
customer lawn size in meters squared (m2) - numeric field
type of service - use a set of RadioButton (full - $9.99/m2, grass cutting - $4.99/m2, weed spraying - $7.99/m2) date of service - date field validated using DateTime
A pair of buttons: ‘Save’ and ‘Clear’.
The ‘Clear’ button should clear out all user entered text from the input fields and unselect all radio buttons.
When the ‘Save’ button is pressed, the following is to occur:
Display HST amount (assume 13%)
Display amount to be billed - calculated as lawn size * type of service cost + HST amount
Display a total billing amount and a total m2 amount for all appointments entered since the application started running (no between run storage required).
Write a text file with the name <customer name>-<date>.txt to the currently logged in user’s <AppData>\JoeLawnService directory. The text file should contain all the collected details plus a sequentially incrementing ‘receipt id’ formatted with 9 digits (fill with leading zeros). It should be formatted for 50 column monospaced font output and look like:
Appointment #: 000000001 <blank line>
<Customer name>
<Street Address>
<City> <Province> <Postal Code>
<Phone number – formatted (xxx) xxx-xxxx>
<blank line>
Date: <formatted as Weekday, Month day, year>
Service Type:
Lawn Size (m2):
<blank line>
Subtotal:
HST: Total:
<service type selected> <rounded to nearest .5>
<formatted as money> <calculated hst amount> ------------------------------- <calculated total cost>
Hint: use PadLeft/PadRight methods of the string object.
