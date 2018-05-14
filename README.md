# Data Protection By Design | DPBD Framework
Enabling "In Code" Attribute Declaration To Ensure Data Protection Compliance


GDPR, China Cyber Security law etc. are ensuring companies have to take better care of customer data. The purpose of for example the GDPR is to provide a set of standardized data protection laws across all the member countries. This should make it easier for EU citizens to understand how their data is being used, and also raise any complaints, even if they are not in the country where its located.
It can be a real challenge to identify within the code where and which entities should be taken care of and in which way. Different regions, countries and even states have their own legislation. Even authorities a can have a different request. For example, the tax office in the EU wants you to store data for a much longer time then GDPR is requesting.  The last thing you want is to manage this complexity in your code with a long written CASE statement that you need to change an maintain every month.
The idea is to be able to easily extend your C# or VB .NET coding with a special attribute that enables easy identification of entities within your code that store sensitive customer data. See it as a reusable attribute that like Swagger can create a dashboard or report based on market entities within your project to target concerning entities and ensure compliance by design. After identification for each of the elements, you can connect the related policies or even let the software determine which policies should be in place


For example:

[DPBD]
public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string IdCardNumber{ get; set; }
        [Required]
[DPBD (dataItemMapping=”IdentificationNumber”, EnableStoragePolicy=True, EnableEncryptionPolicy=True)]
       Public string country {get; set;}
[DPBD (dataItemMapping=”countryRegion”)]
    }

The attribute knows there is a class that contains customer data. By adding the attribute on each of the possible sensitive properties the software can identify exactly which properties need to be validated so compliance is ensured. Due to the fact that there is a country used within the class, the tool now knows that customers from multiple countries might be added.

Roadmap:
V0.1 Proof Of Concept
Developing basic attribute model
V0.2. Getting Insights
Creating the dashboard/report
V0.3.  Basic Compliance check
Connecting legislation to the elements
V0.4. Content Validation
Adding a testing solution that can traverse through the software to determine how the data is stored. For example. If Microsoft EF in combination with a SQL database is used it knows that data storage is involved. If API endpoints are involved it knows 3th party can acces the software etc.
V0.5. The Right To Retrieve
Adding Basics to Enable Data Retrieval by Default
V0.6. The Right To Be Forgotten
Adding Basics to Enable Deletes by Request or Data Storage Policies
