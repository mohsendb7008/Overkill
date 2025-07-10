using Overkill.Validator;

var emailValidator = new EmailValidator();
Console.WriteLine(emailValidator.Validate("sample@school.edu"));
Console.WriteLine(emailValidator.Validate("invalid@invalid"));

var phoneValidator = new PhoneValidator();
Console.WriteLine(phoneValidator.Validate("09215546321"));
Console.WriteLine(phoneValidator.Validate("093311111111"));