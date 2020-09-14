# How to do custom Validation using Validationattribute of ASP.NET MVC

ValidationAttribute class is included in DataAnnotations namespace. It helps you to validate model data received from user. It gives you many in built validation attributes like StringLength, Required, DataType for validating model.

## Files

1. **[Customer Details View](https://github.com/geeksarray/how-to-do-custom-validation-using-validationattribute-of-aspnet-mvc/blob/master/FirstMVC/FirstMVC/Views/Home/CustomerDetails.cshtml)** - html view having Customer details.
1. **[Model Class with Custom Validation](https://github.com/geeksarray/how-to-do-custom-validation-using-validationattribute-of-aspnet-mvc/blob/master/FirstMVC/FirstMVC/Models/ValidJoinDate.cs)** - has implemented ValidationAttribute class to achieve custom validation of Join Date of Customer.
1. **[Customer Model](https://github.com/geeksarray/how-to-do-custom-validation-using-validationattribute-of-aspnet-mvc/blob/master/FirstMVC/FirstMVC/Models/Customer.cs)** - with custom validation attribute used for JoinDate property.

Below picture show implementation of Custom Validation attribute 

![Custom Validation attribute in ASP.NET MVC](https://geeksarray.com/images/blog/asp-net-mvc-custom-validation.png)

For more details visit - [Custom Validation Attribute in ASP.NET MVC](https://geeksarray.com/blog/how-to-do-custom-validation-using-validationattribute-of-aspnet-mvc)

