using System.Text.RegularExpressions;

namespace BackEndPart3;

public delegate bool RequiredFieldValidation(string fieldValidation);

public delegate bool StringLengthValidation(string fieldValidation, int min, int max);

public delegate bool DateValidation(string fieldValidation, out DateTime dateTime);

public delegate bool PatternMatchValidation(string fieldValidation, string pattern);

public delegate bool CompareFieldsValidation(string fieldValidation, string fieldValidationComparison);

public class ValidationFunctions
{
    private static RequiredFieldValidation _requiredFieldValidation = null;

    private static StringLengthValidation _stringLengthValidation = null;

    private static DateValidation _dateValidation = null;

    private static PatternMatchValidation _patternMatchValidation = null;

    private static CompareFieldsValidation _compareFieldsValidation = null;


    public static RequiredFieldValidation RequiredFieldValidation
    {
        get
        {
            if (_requiredFieldValidation == null)
                _requiredFieldValidation = new RequiredFieldValidation(RequiredFieldValidationProperty);

            return _requiredFieldValidation;
        }
    }

    private static bool RequiredFieldValidationProperty(string fieldvalidation)
    {
        if (!string.IsNullOrEmpty(fieldvalidation))
            return true;
        return false;
    }


    public static StringLengthValidation StringLengthValidation
    {
        get
        {
            if (_stringLengthValidation == null)
                _stringLengthValidation = new StringLengthValidation(StringLengthValidationProperty);

            return _stringLengthValidation;
        }
    }

    private static bool StringLengthValidationProperty(string fieldvalidation, int min, int max)
    {
        if (fieldvalidation.Length >= min && fieldvalidation.Length <= max)
            return true;
        return false;
    }


    public static DateValidation DateValidation
    {
        get
        {
            if (_dateValidation == null)
                _dateValidation = new DateValidation(DateValidationProperty);

            return _dateValidation;
        }
    }

    private static bool DateValidationProperty(string fieldvalidation, out DateTime datetime)
    {
        if (DateTime.TryParse(fieldvalidation, out datetime))
            return true;
        return false;
    }


    public static PatternMatchValidation PatternMatchValidation
    {
        get
        {
            if (_patternMatchValidation == null)
                _patternMatchValidation = new PatternMatchValidation(PatternMatchValidationProperty);

            return _patternMatchValidation;
        }
    }

    private static bool PatternMatchValidationProperty(string fieldvalidation, string pattern)
    {
        var regValidation = new Regex(pattern);
        if (regValidation.IsMatch(fieldvalidation))
            return true;
        return false;
    }


    public static CompareFieldsValidation CompareFieldsValidation
    {
        get
        {
            if (_compareFieldsValidation == null)
                _compareFieldsValidation = new CompareFieldsValidation(CompareFieldsValidationProperty);

            return _compareFieldsValidation;
        }
    }

    private static bool CompareFieldsValidationProperty(string fieldvalidation, string fieldvalidationcomparison)
    {
        if (fieldvalidation.Equals(fieldvalidationcomparison))
            return true;
        return false;
    }
}