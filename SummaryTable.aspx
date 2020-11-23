<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SummaryTable.aspx.cs" Inherits="project5.SummaryTable" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
    <style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
.tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
.tg .tg-yw4l{vertical-align:top}


table, th, td {
  border: 1px solid black;
  border-collapse: collapse;
}

</style>


<body bgcolor="#D3D3D3">
    
<center><h3>
    <br />
    CSE 445: Project 5<br />
</h3></center>
<table    cellspacing="0" cellpadding="0" border="1"> 
<tbody>
<tr>
 <td colspan="5"   valign="top" bgcolor="#bce6f5" style="text-align: center"><p><strong>Application and Components Summary Table</strong></p></td>
 </tr>

 <tr>
 <td colspan="5"   valign="top" bgcolor="#bce6f5"><p>This application is deployed at: <a href="http://webstrar74.fulton.asu.edu/Page0/Default.aspx">http://webstrar74.fulton.asu.edu/Page0/Default.aspx</a></p></td>
 </tr>

 <tr>
 <td colspan="5"   valign="top" bgcolor="#bce6f5"><p>Percentage of contribution: Suhas Khandiga Suresh name: 33.33%, Gnana Prakash Avvaru name: 33.33%, Anoop Reddy Vutukuri name: 33.33%</p></td>
 </tr>

 <tr>
 <td   valign="top" bgcolor="#bce6f5"><p>Provider Name</p></td>
 <td   valign="top" bgcolor="#bce6f5"><p>Page and component type</p></td>
 <td   valign="top" bgcolor="#bce6f5"><p>TryIt Link</p></td>
 <td   valign="top" bgcolor="#bce6f5"><p>Component description</p></td>
 <td   valign="top" bgcolor="#bce6f5"><p>Actual resources, method, where it is used</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Suhas Khandiga Suresh</p></td>
 <td   valign="top"><p>aspx page and server control </p>

  </td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Staff/Staff.aspx">http://webstrar74.fulton.asu.edu/Page0/Staff/Staff.aspx</a></p></td>
 <td   valign="top"><p>The staff page which can be used only staff members.</p></td>
 <td   valign="top"><p>GUI design and C# code behind GUI of the Staff page</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Suhas Khandiga Suresh</p></td>
 <td   valign="top"><p><br>
 Cookies</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/staffLogin.aspx">http://webstrar74.fulton.asu.edu/Page0/staffLogin.aspx</a></p></td>
 <td   valign="top"><p>Forms Authentication cookies and Role based Authentication for member and staff Login page.</p></td>
 <td   valign="top"><p>C# Code for member login and staff login page. It uses FormAuthenticationTicket along with encryption and decryption. It is linked to the staff login and member login page.</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Suhas Khandiga Suresh</p></td>
 <td   valign="top"><p>SVC service</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Staff/Staff.aspx">http://webstrar74.fulton.asu.edu/Page0/Staff/Staff.aspx</a></p></td>
 <td   valign="top"><p>Input: two strings store name and zip code </p>

<p>Output: string message which contains the address of the store</p></td>
 <td   valign="top"><p>Net built in libraries to create the REST/SOAP service and the data is obtained using google map API and google Place API.</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Suhas Khandiga Suresh</p></td>
 <td   valign="top"><p>SVC service</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Staff/Staff.aspx">http://webstrar74.fulton.asu.edu/Page0/Staff/Staff.aspx</a></p></td>
 <td   valign="top"><p>Minimum distance calculator Service.<br>
 Input: zip code of buyer and zip code of seller<br>
 Output: String which gives minimum distance in miles  </p></td>
 <td   valign="top"><p>We will use <a href="http://www.zipcodeapi.com/">http://www.zipcodeapi.com/</a> <br>
 <br>
 </p>

<p>to calculate the distance between the two zip codes.</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Suhas Khandiga Suresh</p></td>
 <td   valign="top"><p>User control<br>
  +<br>
 Session state</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/MemberRegister.aspx">http://webstrar74.fulton.asu.edu/Page0/MemberRegister.aspx</a> </p></td>
 <td   valign="top"><p><br>
 Image Captcha to verify the login </p></td>
 <td   valign="top"><p>Built captcha.aspx page which shows random 5 letter code for the user to verify. We store this code in Session variable and later will be verified.</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Suhas Khandiga Suresh</p></td>
 <td   valign="top"><p>Global asax page </p></td>
 <td   valign="top">  </td>
 <td   valign="top"><p>Implemented <strong>AuthenticateRequest event handler</strong> of Global asax page</p></td>
 <td   valign="top"><p>In this event handler, I am creating principal object and assigning it to the current thread for every request. I am using C# HTTPCookie, GenericIdentity and GenericPrincipal classes </p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Gnana Prakash Avvaru</p></td>
 <td   valign="top"><p>Member aspx pages and server control</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/Member.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/Member.aspx</a></p>

  </td>
 <td   valign="top"><p>Member Login Page, Member Register Page and Member Page .Self-registration and login for accessing protected member page</p></td>
 <td   valign="top"><p>Used .Net Server Controls and Forms Security for login redirection if the member is not logged in and try to access member page</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Gnana Prakash Avvaru</p></td>
 <td   valign="top"><p>SVC service</p>

   </td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/WeatherTryIt.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/WeatherTryIt.aspx</a></p>

  </td>
 <td   valign="top"><p>This service returns a 5-day weather forecast data based on zip code location.</p>

<p>Input: String zip Code</p>

<p>Output: String [] forecast Data</p>

   </td>
 <td   valign="top"><p>Used .Net built in libraries to create this REST service and the data is obtained using</p>

<p>the below API’s.</p>

<p><a href="https://www.zippopotam.us/">https://www.zippopotam.us/</a></p>

<p><a href="https://openweathermap.org/">https://openweathermap.org/</a></p>

  </td>
 </tr>

 <tr>
 <td   valign="top"><p>Gnana Prakash Avvaru</p></td>
 <td   valign="top"><p>SVC service</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/ProductTryIt.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/ProductTryIt.aspx</a></p>

  </td>
 <td   valign="top"><p>This service provides product results based on the input keyword.</p>

<p>Input: string keyword Output: list of strings(describing product details)</p></td>
 <td   valign="top"><p>Used below eBay finding product api to list the products</p>

<p><a href="http://svcs.ebay.com/services/search/FindingService/v1">http://svcs.ebay.com/services/search/FindingService/v1</a></p>

  </td>
 </tr>

 <tr>
 <td   valign="top"><p>Gnana Prakash Avvaru</p></td>
 <td   valign="top"><p>Weather Service Try It aspx Page and server control</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/WeatherTryIt.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/WeatherTryIt.aspx</a></p>

  </td>
 <td   valign="top"><p>This is one of the protected page where members can only access and lets you to test the Weather Service</p></td>
 <td   valign="top"><p>Used .Net Server Controls and written C# code to access the service and parse the data.</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Gnana Prakash Avvaru</p></td>
 <td   valign="top"><p>Product Service Try It aspx Page and server control</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/Member.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/Member.aspx</a></p>

  </td>
 <td   valign="top"><p>This is one of the protected page where members can only access and lets you to test the Weather Service</p></td>
 <td   valign="top"><p>Used .Net Server Controls and written C# code to access the service and parse the data.</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Gnana Prakash Avvaru</p></td>
 <td   valign="top"><p>DLL</p></td>
 <td   valign="top">  </td>
 <td   valign="top"><p>Implemented DLL for encryption and decryption functions to store and retrieve passwords.</p></td>
 <td   valign="top"><p>Used .Net Class Library and Written C# code to implement</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Gnana Prakash Avvaru</p></td>
 <td   valign="top"><p>DLL Try It aspx page and server control</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/DLLTryIt.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/DLLTryIt.aspx</a></p>

  </td>
 <td   valign="top"><p>This is one of the protected page where members can only access and  lets you test DLL encryption and decryption functions</p></td>
 <td   valign="top"><p>Used .Net Server Controls and written C# code to access DLL functions and show the output</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Gnana Prakash Avvaru</p></td>
 <td   valign="top"><p>XML File</p></td>
 <td   valign="top">  </td>
 <td   valign="top"><p>Searching and Adding elements in to Member.xml while log in and register for member</p></td>
 <td   valign="top"><p>Used XML File and written C# code to implement the searching and storing data in XML file</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Anoop Reddy Vutukuri</p></td>
 <td   valign="top"><p>Global asax page </p></td>
 <td   valign="top">  </td>
 <td   valign="top"><p>Implemented <strong>Application_Error event handler</strong> of Global asax page</p></td>
 <td   valign="top"><p>In this event handler, I log the errors raised by the application in a xml file along with the timestamp.</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Anoop Reddy Vutukuri</p></td>
 <td   valign="top"><p>XML File</p></td>
 <td   valign="top">  </td>
 <td   valign="top"><p>Adding elements in to Errors.xml  during application crash.</p></td>
 <td   valign="top"><p>Used XML File and written C# code to implement the storing data in XML file</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Anoop Reddy Vutukuri</p></td>
 <td   valign="top"><p>Default aspx Page and server control</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Default.aspx">http://webstrar74.fulton.asu.edu/Page0/Default.aspx</a></p>

  </td>
 <td   valign="top"><p>It is Default page and can be accessed by anyone.</p></td>
 <td   valign="top"><p>Used .Net Server Controls and written C# code for all the buttons in the page to redirect to the respective pages.</p></td>
 </tr>
<tr>
 <td   valign="top"><p>Anoop Reddy Vutukuri</p>

  </td>
 <td   valign="top"><p>SVC Service</p>

   </td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/SolarServiceTryIt.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/SolarServiceTryIt.aspx</a></p>

  </td>
 <td   valign="top"><p>This service returns the annual average sunshine index of a given position. This information can be used to decide if installing solar energy device is efficient at the location.</p>

  </td>
 <td   valign="top"><p>Net built in libraries to create the REST service and the data is obtained using NASA POWER Api’s.</p>

  </td>
 </tr>
     <tr>
 <td   valign="top"><p>Anoop Reddy Vutukuri</p></td>
 <td   valign="top"><p>User Control(Sign Out)</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/Member.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/Member.aspx</a></p>

  </td>
 <td   valign="top"><p>Lets the user to sign out of the application</p>

<td   valign="top"><p>Used C# Forms authentication from system.web.security library</p></td>
 </tr>
 <tr>
 <td   valign="top"><p>Anoop Reddy Vutukuri</p></td>
 <td   valign="top"><p>SVC service</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/AddToCartTryIt.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/AddToCartTryIt.aspx</a></p>

  </td>
 <td   valign="top"><p>Add to Cart service,</p>

<p>Input: List of Items </p>

<p>Output:String Confirmation</p>

<p>This Service will allow the buyer to add the items into the cart.</p></td>
 <td   valign="top"><p>Used C# built in classes and custom written classes to implement this service. XML Files to store cart details.</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Anoop Reddy Vutukuri</p></td>
 <td   valign="top"><p>SVC service</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/GetCartTotalTryIt.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/GetCartTotalTryIt.aspx</a></p>

  </td>
 <td   valign="top"><p>Get Cart Total service</p>

<p>Input: string userid</p>

<p>Output: Decimal Amount</p>

  </td>
 <td   valign="top"><p>Used C# built in classes and custom written classes to implement this service. XML Files to store and access the cart details.</p></td>
 </tr>

 <tr>
 <td   valign="top"><p>Anoop Reddy Vutukuri</p></td>
 <td   valign="top"><p>SVC service</p></td>
 <td   valign="top"><p><a href="http://webstrar74.fulton.asu.edu/Page0/Members/PlaceOrderTryIt.aspx">http://webstrar74.fulton.asu.edu/Page0/Members/PlaceOrderTryIt.aspx</a></p>

  </td>
 <td   valign="top"><p>Place Order service<br>
 Input: string userid, string delivery method.<br>
 output: Decimal Total Amount.</p>

<p>This Service will allow the buyer to enter the delivery method and buy the items in the cart. It returns the total charge including delivery fee.</p></td>
 <td   valign="top"><p>Used C# built in classes and custom written classes to implement this service. XML Files to store delivery details.</p></td>
 </tr>

    </tr>



 

 </tbody>
</table>
</body>

  
